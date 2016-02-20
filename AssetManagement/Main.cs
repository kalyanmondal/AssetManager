
//To Do List
//    1) AutoComplete Other Data Entry Stop
//    2) Webcam Problem
//    3) Database Password

using AssetManagement.HelperClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Transactions;
using System.Windows.Forms;

namespace AssetManagement
{
    public partial class frm_Main : Form
    {
        #region Private Variable

        private WebCam webcam;
        private OleDbConnection con;
        private OleDbCommand cmd;
        private OleDbDataAdapter adapter;
        private DataSet ds;
        private byte[] photo_aray;
        private string reportSaveLocation;
        private string backUpDatabaseLocation;
        private bool backupSuccessful = false;
        private bool restoreSuccessful = false;

        public static string serialNumber { get; set; }
        public static string employeeId { get; set; }
        public static string medicineName { get; set; }
        public static DateTime? InTime { get; set; }
        public static DateTime? OutTime { get; set; }
        public static int toDo { get; set; }
        public static string sheetName { get; set; }
        public static string restoreFrom { get; set; }
        public static bool medValidationPassed { get; set; }
        public static bool addminLoginAllowed { get; set; }
        public static int validRows { get; set; }
        public static bool errorInEmployeeeImport { get; set; }

        public Dictionary<string, string> employeeData = new Dictionary<string, string>();
        public Dictionary<string, string> employeeUpdatedData = new Dictionary<string, string>();

        public Dictionary<string, string> medicineData = new Dictionary<string, string>();
        public Dictionary<string, string> medicineUpdatedData = new Dictionary<string, string>();

        public Dictionary<string, string> pedistalData = new Dictionary<string, string>();
        public Dictionary<string, string> pedistalUpdatedData = new Dictionary<string, string>();

        public static int maxValProgressBar { get; set; }

        #endregion Private Variable

        #region Construction

        public frm_Main()
        {
            InitializeComponent();
            lbl_LoggedinUser.Text = string.Format("Login User : {0}", System.Security.Principal.WindowsIdentity.GetCurrent().Name);
            lbl_Date.Text = string.Format("Date : {0}", DateTime.Now.ToString("dd MMMM yyyy"));
            tmr_Asset_Timer.Start();
            cBox_Floor_Number.SelectedIndex = 0;

        }

        #endregion Construction

        #region Events

        #region generalEvents

        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                RegManager.createKey();
                if (RegManager.getKey("data source") == string.Empty)
                {
                    DialogResult dr = MessageBox.Show("Database configuration is not done! \nWould you like to do it now?", "Asset Manager", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr != DialogResult.Cancel)
                    {
                        frm_DatabaseSelector fmds = new frm_DatabaseSelector(0);
                        fmds.ShowDialog();
                    }
                    else
                    {
                        RegManager.deleteAllKey();
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing went wrong. Please contact service provider. " +ex, "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegManager.deleteAllKey();
                Application.Exit();
            }
        }

        private void tmr_Ops_Timer_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = string.Format("Time Now : {0}", DateTime.Now.ToLongTimeString());
            tbox_In_Time.Text = DateTime.Now.ToString("dd MMMM yyyy") + " " + DateTime.Now.ToLongTimeString();
            tbox_Out_Time.Text = DateTime.Now.ToString("dd MMMM yyyy") + " " + DateTime.Now.ToLongTimeString();
            if (tbox_InterOffice_Serial_Number.Text == string.Empty)
            {
                tbox_InterOffce_Date.Text = DateTime.Now.ToString("dd MMMM yyyy");
                tbox_InterOffce_Issuing_Time.Text = DateTime.Now.ToLongTimeString();
            }
            tbox_InterOffce_Return_Return_Date.Text = DateTime.Now.ToString("dd MMMM yyyy");
            tbox_InterOffce_Return_Return_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void svFlDlg_SaveReport_FileOk(object sender, CancelEventArgs e)
        {
            reportSaveLocation = svFlDlg_SaveReport.FileName;
        }

        #endregion generalEvents

        #region btnEvents

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            webcam.Stop();
            pBox_Image.Image = null;
        }

        private void btn_TakeImage_Click(object sender, EventArgs e)
        {
            pBox_Image.Image = pBox_Image.Image;
            webcam.Stop();
        }

        private void btn_Webcam_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            webcam.Continue();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            resetVisitorFrom(1);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (inFormValidate() == 0)
                {
                    insertVisitorDetails();
                }
                else
                {
                    MessageBox.Show("Please enter all the mandetory field", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Failed due to : " + ex.Message, "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Out_Reset_Click(object sender, EventArgs e)
        {
            resetVisitorFrom(2);
            controlDisabler(true);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
            adapter = new OleDbDataAdapter(queryGenerator(0), con);
            ds = new DataSet();
            adapter.Fill(ds, "tbl_Visitor_details");
            if (ds.Tables[0].Rows.Count > 1)
            {
                frm_Selector fm = new frm_Selector(ds);
                fm.ShowDialog();
                if (serialNumber != null)
                {
                    fetchDataBySerialNumber(serialNumber);
                }
            }
            else
            {
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No Visitor Found", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (tbox_Out_Serial_Number.Text == string.Empty)
                    {
                        fetchDataBySerialNumber(ds.Tables[0].Rows[0][0].ToString());
                    }
                }
            }
        }

        private void btn_Out_Update_Click(object sender, EventArgs e)
        {
            if (DatabaseOperation.updateData("UPDATE tbl_Visitor_details SET OUT_TIME  = '" + tbox_Out_Time.Text + "' WHERE Serial_Number =" + tbox_Out_Serial_Number.Text + "") > 0)
            {
                MessageBox.Show("Record Updated", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetVisitorFrom(2);
            }
            else
            {
                MessageBox.Show("Updation Failed", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Report_Extract_Click(object sender, EventArgs e)
        {
            adapter = new OleDbDataAdapter(queryGenerator(1), con);
            ds = new DataSet();
            adapter.Fill(ds, "tbl_Visitor_details");
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("There is no data to extract", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int rowcount = 0;
                DataTable withoutImage = ds.Tables[0].Copy();
                withoutImage.Columns.Remove("Photo");
                withoutImage.Columns.Remove("Signeture_Image");
                svFlDlg_SaveReport.Title = "Save the report";
                svFlDlg_SaveReport.Filter = "Excel File-2007|*.xlsx|Excel File-2003|*.xls|All Files|*.*";
                svFlDlg_SaveReport.ShowDialog();
                if (reportSaveLocation != null)
                {
                    if (ExcelUtlity.WriteDataTableToExcel(withoutImage, "Visitor Report", reportSaveLocation, "Visitor Details", 0))
                    {
                        if (cbox_dload_Images.Checked)
                        {
                            Directory.CreateDirectory(reportSaveLocation.Substring(0, reportSaveLocation.LastIndexOf(@"\")) + @"\Images");
                            foreach (DataRow datarow in ds.Tables[0].Rows)
                            {
                                if (ds.Tables[0].Rows[rowcount][14] != System.DBNull.Value)
                                {
                                    photo_aray = (byte[])ds.Tables[0].Rows[rowcount][14];
                                    MemoryStream ms = new MemoryStream(photo_aray);
                                    Image.FromStream(ms).Save(reportSaveLocation.Substring(0, reportSaveLocation.LastIndexOf(@"\")) + @"\Images\" + ds.Tables[0].Rows[rowcount][1].ToString() + ".jpeg");
                                }
                                if (ds.Tables[0].Rows[rowcount][15] != System.DBNull.Value)
                                {
                                    photo_aray = (byte[])ds.Tables[0].Rows[rowcount][15];
                                    MemoryStream ms = new MemoryStream(photo_aray);
                                    Image.FromStream(ms).Save(reportSaveLocation.Substring(0, reportSaveLocation.LastIndexOf(@"\")) + @"\Images\" + ds.Tables[0].Rows[rowcount][1].ToString() + "_Signetrue" + ".jpeg");
                                }
                                rowcount += 1;
                            }
                        }
                        MessageBox.Show("Data Extracted...", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please provide the file name...", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_Reset_Extract_Click(object sender, EventArgs e)
        {
            resetVisitorFrom(4);
        }

        private void btn_Report_Today_Click(object sender, EventArgs e)
        {
            quickReportGenerator(0);
        }

        private void btn_Report_Last_7_Days_Click(object sender, EventArgs e)
        {
            quickReportGenerator(1);
        }

        private void btn_Report_Interview_1_Month_Click(object sender, EventArgs e)
        {
            quickReportGenerator(2);
        }

        private void btn_Inter_Office_Reset_Click(object sender, EventArgs e)
        {
            resetVisitorFrom(3);
        }

        private void btn_Inter_Office_Webcam_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void btn_Inter_Office_Continue_Click(object sender, EventArgs e)
        {
            webcam.Continue();
        }

        private void btn_Inter_Office_Take_Picture_Click(object sender, EventArgs e)
        {
            pBox_Inter_Office_Image.Image = pBox_Inter_Office_Image.Image;
            webcam.Stop();
        }

        private void btn_Inter_Office_Stop_Click(object sender, EventArgs e)
        {
            webcam.Stop();
            pBox_Inter_Office_Image.Image = null;
        }

        private void btn_Assign_Click(object sender, EventArgs e)
        {
            if (inFormInterOfficeVisitorValidate() == 0)
            {
                insertInterOfficeVisitorDetails();
                resetVisitorFrom(3);
            }
            else
            {
                MessageBox.Show("Please enter all the mandetory field", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Inter_Office_Search_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
            string query = string.Empty;
            query = "SELECT Serial_No_Inter_Office,Employee_Id,Employee_Name,Comming_From,Contact_Number,Assign_Date,Remarks,Badge_Number,Access_Card_Number,Issueing_Time,No_Of_Days,Employee_Image,Employee_Signeture FROM tbl_Inter_Office_Visitor WHERE Employee_Id = '" + tbox_InterOffce_Return_Employee_Id.Text + "' AND Return_Date IS NULL AND Return_Time IS NULL";
            adapter = new OleDbDataAdapter(query, con);
            ds = new DataSet();
            adapter.Fill(ds, "tbl_Inter_Office_Visitor");
            if (ds.Tables[0].Rows.Count > 0)
            {
                tbox_InterOffice_Serial_Number.Text = ds.Tables[0].Rows[0][0].ToString();
                tbox_InterOffce_Employee_Id.Text = ds.Tables[0].Rows[0][1].ToString();
                tbox_InterOffce_Employee_Name.Text = ds.Tables[0].Rows[0][2].ToString();
                tbox_InterOffce_Comming_From.Text = ds.Tables[0].Rows[0][3].ToString();
                tbox_InterOffce_Contact_Number.Text = ds.Tables[0].Rows[0][4].ToString();
                tbox_InterOffce_Date.Text = Convert.ToDateTime(ds.Tables[0].Rows[0][5].ToString()).ToString("dd MMMM yyyy");
                tbox_InterOffce_Remarks.Text = ds.Tables[0].Rows[0][6].ToString();
                tbox_InterOffce_Badge_Number.Text = ds.Tables[0].Rows[0][7].ToString();
                tbox_InterOffce_Access_Card_Number.Text = ds.Tables[0].Rows[0][8].ToString();
                tbox_InterOffce_Issuing_Time.Text = ds.Tables[0].Rows[0][9].ToString().Substring(ds.Tables[0].Rows[0][9].ToString().IndexOf(" ") + 1);
                tbox_InterOffce_No_Of_Days.Text = ds.Tables[0].Rows[0][10].ToString();

                pBox_Inter_Office_Image.Image = null;
                if (ds.Tables[0].Rows[0][11] != System.DBNull.Value)
                {
                    photo_aray = (byte[])ds.Tables[0].Rows[0][11];
                    MemoryStream ms = new MemoryStream(photo_aray);
                    pBox_Inter_Office_Image.Image = Image.FromStream(ms);
                }
                pBox_Inter_Office_Signeture.Image = null;
                if (ds.Tables[0].Rows[0][12] != System.DBNull.Value)
                {
                    photo_aray = (byte[])ds.Tables[0].Rows[0][12];
                    MemoryStream ms = new MemoryStream(photo_aray);
                    pBox_Inter_Office_Signeture.Image = Image.FromStream(ms);
                }
            }
            else
            {
                MessageBox.Show("No Visitor Found", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Inter_Office_Return_Click(object sender, EventArgs e)
        {
            if (DatabaseOperation.updateData("UPDATE tbl_Inter_Office_Visitor SET Return_Date  = '" + tbox_InterOffce_Return_Return_Date.Text + "', Return_Time = '" + tbox_InterOffce_Return_Return_Time.Text + "' WHERE Serial_No_Inter_Office =" + tbox_InterOffice_Serial_Number.Text + "") > 0)
            {
                MessageBox.Show("Record Updated", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetVisitorFrom(3);
            }
            else
                MessageBox.Show("Updation Failed", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Report_Inter_Office_Today_Click(object sender, EventArgs e)
        {
            quickReportGenerator(3);
        }

        private void btn_Report_Inter_Office_Last_7_Days_Click(object sender, EventArgs e)
        {
            quickReportGenerator(4);
        }

        private void btn_Report_Inter_Office_1_Month_Click(object sender, EventArgs e)
        {
            quickReportGenerator(5);
        }

        private void btn_Report_Inter_Office_Specified_Employee_Click(object sender, EventArgs e)
        {
            frm_ReportDataCollector rdc = new frm_ReportDataCollector(0);
            rdc.ShowDialog();
            quickReportGenerator(6);
        }

        private void btn_Report_Inter_Office_Specific_Employee_Click(object sender, EventArgs e)
        {
            frm_ReportDataCollector rdc = new frm_ReportDataCollector(1);
            rdc.ShowDialog();
            quickReportGenerator(7);
        }

        private void btn_Med_Emp_Search_Click(object sender, EventArgs e)
        {
            searchEmployee(1, ref tbox_Med_Emp_Id, ref tbox_Med_Emp_Name, ref tbox_Med_Emp_Email, ref tbox_Med_Emp_Desk_Phone, ref lbl_Med_Emp_Id, ref lbl_Med_Emp_Name, ref lbl_Med_Emp_Email, ref lbl_Med_Emp_Desk_Phone, ref lbl_Med_Error);
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            opFlDlg_SelectFile.Title = "Select the file to import";
            opFlDlg_SelectFile.ShowDialog();
            tbox_Browse.Text = opFlDlg_SelectFile.FileName.ToString();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            btn_Start.Enabled = false;
            try
            {
                pgBar_Import_Progress.Value = 0;
                bg_Worker_ImportEmployee.ProgressChanged -= new ProgressChangedEventHandler(bg_Worker_ImportEmployee_ProgressChanged);
                bg_Worker_ImportEmployee.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(bg_Worker_ImportEmployee_RunWorkerCompleted);
                if (tbox_Browse.Text == string.Empty)
                {
                    MessageBox.Show("No File Seleted.", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btn_Start.Enabled = true;
                    return;
                }
                if (!tbox_Browse.Text.Substring(tbox_Browse.Text.LastIndexOf('.') + 1, (tbox_Browse.Text.Length - tbox_Browse.Text.LastIndexOf('.')) - 1).Equals("xlsx") && !tbox_Browse.Text.Substring(tbox_Browse.Text.LastIndexOf('.') + 1, (tbox_Browse.Text.Length - tbox_Browse.Text.LastIndexOf('.')) - 1).Equals("xls"))
                {
                    MessageBox.Show("Kindly provide an Excel File!", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btn_Start.Enabled = true;
                    return;
                }
                bg_Worker_ImportEmployee.ProgressChanged += new ProgressChangedEventHandler(bg_Worker_ImportEmployee_ProgressChanged);
                bg_Worker_ImportEmployee.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_Worker_ImportEmployee_RunWorkerCompleted);
                bg_Worker_ImportEmployee.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Failed due to : " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Employee_Search_Click(object sender, EventArgs e)
        {
            searchEmployee(0, ref tbox_ManageEmployee_EmployeeId, ref tbox_ManageEmployee_EmployeeName, ref tbox_ManageEmployee_EmployeeEmail, ref tbox_ManageEmployee_EmployeeExtection, ref lbl_ManageEmployee_EmployeeId, ref lbl_ManageEmployee_EmployeeName, ref lbl_ManageEmployee_EmployeeEmail, ref lbl_ManageEmployee_EmployeeExtection, ref lbl_Error);
        }

        private void btn_Employee_Reset_Click(object sender, EventArgs e)
        {
            resetEmployeeForm();
        }

        private void btn_Employee_Update_Click(object sender, EventArgs e)
        {
            if (tbox_Id.Text != string.Empty)
            {
                employeeUpdatedData.Add("Id", tbox_Id.Text.Trim());
                employeeUpdatedData.Add("Employee_Id", tbox_ManageEmployee_EmployeeId.Text.Trim());
                employeeUpdatedData.Add("Employee_Name", tbox_ManageEmployee_EmployeeName.Text.Trim());
                employeeUpdatedData.Add("Employee_Email", tbox_ManageEmployee_EmployeeEmail.Text.Trim());
                employeeUpdatedData.Add("Extension", tbox_ManageEmployee_EmployeeExtection.Text.Trim());
                employeeUpdatedData.Add("Personal_Mobile", tbox_ManageEmployee_EmployeePersonalMobile.Text.Trim());
                employeeUpdatedData.Add("Personal_Email", tbox_ManageEmployee_EmployeePersonalEmail.Text.Trim());
                employeeUpdatedData.Add("Official_Mobile", tbox_ManageEmployee_EmployeeOfficialMobile.Text.Trim());
                employeeUpdatedData.Add("Department", tbox_ManageEmployee_EmployeeDepartment.Text.Trim());
                employeeUpdatedData.Add("Company", tbox_ManageEmployee_EmployeeCompany.Text.Trim());
                employeeUpdatedData.Add("Current_Manager_Name", tbox_ManageEmployee_EmployeeManager.Text.Trim());
                employeeUpdatedData.Add("Current_Manager_Employee_Id", tbox_ManageEmployee_EmployeeManagerId.Text.Trim());
                employeeUpdatedData.Add("Location", tbox_ManageEmployee_EmployeeLocation.Text.Trim());
                if (rdBtn_EmployeeActive.Checked == true)
                {
                    employeeUpdatedData.Add("Active", "True");
                }
                else
                {
                    employeeUpdatedData.Add("Active", "False");
                }

                bool equal = compareData(employeeData, employeeUpdatedData);

                employeeUpdatedData.Clear();
                if (equal == true)
                {
                    MessageBox.Show("There is no changes in data to update", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool active;
                    if (rdBtn_EmployeeActive.Checked == true)
                    {
                        active = true;
                    }
                    else
                    {
                        active = false;
                    }

                    if (DatabaseOperation.updateData("UPDATE tbl_Employee_Details SET Employee_Id  = '" + tbox_ManageEmployee_EmployeeId.Text.Trim() + "',Employee_Name='" + tbox_ManageEmployee_EmployeeName.Text.Trim() + "',Employee_Email='" + tbox_ManageEmployee_EmployeeEmail.Text.Trim() + "',Extension='" + tbox_ManageEmployee_EmployeeExtection.Text.Trim() + "',Personal_Mobile='" + tbox_ManageEmployee_EmployeePersonalMobile.Text.Trim() + "',Personal_Email='" + tbox_ManageEmployee_EmployeePersonalEmail.Text.Trim() + "',Official_Mobile='" + tbox_ManageEmployee_EmployeeOfficialMobile.Text.Trim() + "',Department='" + tbox_ManageEmployee_EmployeeDepartment.Text.Trim() + "',Company='" + tbox_ManageEmployee_EmployeeCompany.Text.Trim() + "',Current_Manager_Name='" + tbox_ManageEmployee_EmployeeManager.Text.Trim() + "',Current_Manager_Employee_Id='" + tbox_ManageEmployee_EmployeeManagerId.Text.Trim() + "',Location='" + tbox_ManageEmployee_EmployeeLocation.Text.Trim() + "',Active=" + active + " WHERE Id =" + tbox_Id.Text + "") > 0)
                    {
                        MessageBox.Show("Record Updated", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetVisitorFrom(2);
                    }
                    else
                        MessageBox.Show("Updation Failed", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populateEmployeeData("SELECT * FROM tbl_Employee_Details WHERE Id=" + tbox_Id.Text, 0, ref tbox_ManageEmployee_EmployeeId, ref tbox_ManageEmployee_EmployeeName, ref tbox_ManageEmployee_EmployeeEmail, ref tbox_ManageEmployee_EmployeeExtection);
                }
            }
        }

        private void btn_Med_Emp_Reset_Click(object sender, EventArgs e)
        {
            resetEmpData(1, ref tbox_Med_Emp_Id, ref tbox_Med_Emp_Name, ref tbox_Med_Emp_Email, ref tbox_Med_Emp_Desk_Phone, ref lbl_Med_Emp_Id, ref lbl_Med_Emp_Name, ref lbl_Med_Emp_Email, ref lbl_Med_Emp_Desk_Phone, ref lbl_Med_Error, ref btn_Med_Emp_Search);
        }

        private void btn_ManageMedicine_Add_Click(object sender, EventArgs e)
        {
            if (tbox_ManageMedicine_InsertMedicineName.Text.Length == 0)
            {
                lbl_ExistingMedicine.Text = "Please provide the name of the medicine!!!";
            }
            else if (getExistingData("SELECT Medicine_Name FROM tbl_Medicine_Details").Contains(tbox_ManageMedicine_InsertMedicineName.Text))
            {
                lbl_ExistingMedicine.Text = "Existing Medicine!!!";
            }
            else
            {
                lbl_ExistingMedicine.Text = string.Empty;
                if (DatabaseOperation.insertDetails("INSERT INTO tbl_Medicine_Details (Medicine_Name,Stock_Quantity,Warning_Quantity,Active) VALUES ('" + tbox_ManageMedicine_InsertMedicineName.Text.Trim() + "'," + nemUD_ManageMedicine_InsertMedicineStock.Value + "," + nemUD_ManageMedicine_InsertWarning.Value + ",True)") > 0)
                {
                    resetAddMedicine();
                    plotGraph("True");
                    MessageBox.Show("Record Added", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operation Failed", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_ManageMedicine_Insert_Reset_Click(object sender, EventArgs e)
        {
            resetAddMedicine();
        }

        private void btn_ManageMedicine_Update_Click(object sender, EventArgs e)
        {
            updateMedicineDetails();
            resetUpdateMedicine();
            if (rd_ManageMedicine_PlotActiveMedicine.Checked == true)
            {
                plotGraph("True");
            }
            else
            {
                rd_ManageMedicine_PlotActiveMedicine.Checked = true;
            }
        }

        private void btn_ManageMedicine_Search_Click(object sender, EventArgs e)
        {
            getMedicineDetails();
        }

        private void btn_Med_Details_Reset_Click(object sender, EventArgs e)
        {
            resetMedMedcineData();
        }

        private void btn_Med_Assign_Click(object sender, EventArgs e)
        {
            if (!autoCompleteTextbox.autocompletedataValidator(ref tbox_Med_Medcine_Name, "Medicine_Name", "tbl_Medicine_Details", "Active", "=", "True"))
            {
                lbl_medNameChecker.Text = "You have entered an invalid medicine name!";
            }
            else
            {
                lbl_medNameChecker.Text = string.Empty;
                insertMedAssinment(cbox_Non_Employee_Medicine_Distribution.Checked);
            }
        }

        private void btn_ManageMedicine_Update_Reset_Click(object sender, EventArgs e)
        {
            resetUpdateMedicine();
        }

        private void btn_Repoint_Database_Click(object sender, EventArgs e)
        {
            frm_DatabaseSelector fmds = new frm_DatabaseSelector(1);
            fmds.ShowDialog();
            databaseSizeCalculator();
            pgBarColorChanger();
            pgBar_Database_Size.Update();
            lbl_ConnectedDatabase.Text = string.Empty;
            lbl_ConnectedDatabase.Text = "Connected Database Location : " + Encrypter.Decrypt(RegManager.getKey("data source"), true);
        }

        private void btn_Backup_Database_Click(object sender, EventArgs e)
        {
            btn_Backup_Database.Enabled = false;
            try
            {
                pgBar_Backup_Progress.Value = 0;
                bg_Worker_BackupDatabase.ProgressChanged -= new ProgressChangedEventHandler(bg_Worker_BackupDatabase_ProgressChanged);
                bg_Worker_BackupDatabase.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(bg_Worker_BackupDatabase_RunWorkerCompleted);
                bg_Worker_BackupDatabase.ProgressChanged += new ProgressChangedEventHandler(bg_Worker_BackupDatabase_ProgressChanged);
                bg_Worker_BackupDatabase.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_Worker_BackupDatabase_RunWorkerCompleted);
                bg_Worker_BackupDatabase.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Failed due to : " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Restore_Database_Click(object sender, EventArgs e)
        {
            btn_Restore_Database.Enabled = false;
            try
            {
                pgBar_Backup_Progress.Value = 0;
                bg_Worker_RestoreDatabase.ProgressChanged -= new ProgressChangedEventHandler(bg_Worker_RestoreDatabase_ProgressChanged);
                bg_Worker_RestoreDatabase.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(bg_Worker_RestoreDatabase_RunWorkerCompleted);
                bg_Worker_RestoreDatabase.ProgressChanged += new ProgressChangedEventHandler(bg_Worker_RestoreDatabase_ProgressChanged);
                bg_Worker_RestoreDatabase.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_Worker_RestoreDatabase_RunWorkerCompleted);
                bg_Worker_RestoreDatabase.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Failed due to : " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Change_Admin_Password_Click(object sender, EventArgs e)
        {
            frm_AdminLoginDetailsChanger fraldc = new frm_AdminLoginDetailsChanger();
            fraldc.ShowDialog();
        }

        private void btn_MedReport_Today_Click(object sender, EventArgs e)
        {
            quickReportGenerator(8);
        }

        private void btn_MedReport_LastOneMonth_Click(object sender, EventArgs e)
        {
            quickReportGenerator(9);
        }

        private void btn_MedReport_Specified_Medicine_Click(object sender, EventArgs e)
        {
            frm_ReportDataCollector rdc = new frm_ReportDataCollector(2);
            rdc.ShowDialog();
            quickReportGenerator(10);
        }

        private void btn_MedReport_Specified_Date_Range_Click(object sender, EventArgs e)
        {
            frm_ReportDataCollector rdc = new frm_ReportDataCollector(3);
            rdc.ShowDialog();
            quickReportGenerator(11);
        }

        private void btn_MedReport_Specified_Employee_Click(object sender, EventArgs e)
        {
            frm_ReportDataCollector rdc = new frm_ReportDataCollector(4);
            rdc.ShowDialog();
            quickReportGenerator(12);
        }

        private void btn_MedReport_Non_Employee_Click(object sender, EventArgs e)
        {
            quickReportGenerator(13);
        }

        private void btn_Key_Emp_Search_Click(object sender, EventArgs e)
        {
            searchEmployee(2, ref tbox_Key_Emp_Id, ref tbox_Key_Emp_Name, ref tbox_Key_Emp_Email, ref tbox_Key_Emp_Desk_Phone, ref lbl_Key_Emp_Id, ref lbl_Key_Emp_Name, ref lbl_Key_Emp_Email, ref lbl_Key_Emp_Desk_Phone, ref lbl_Key_Error);
        }

        private void btn_Key_Emp_Reset_Click(object sender, EventArgs e)
        {
            resetEmpData(0, ref tbox_Key_Emp_Id, ref tbox_Key_Emp_Name, ref tbox_Key_Emp_Email, ref tbox_Key_Emp_Desk_Phone, ref lbl_Key_Emp_Id, ref lbl_Key_Emp_Name, ref lbl_Key_Emp_Email, ref lbl_Key_Emp_Desk_Phone, ref lbl_Key_Error, ref btn_Key_Emp_Search);
        }

        private void btn_ManageKeys_Add_Click(object sender, EventArgs e)
        {
            bool validatPedistalNo = false;
            bool validateKeyNo = false;
            bool validateFloor = false;
            if (tbox_ManageKeys_InsertKeysPedistalNo.Text.Length == 0)
            {
                lbl_ExistingPedistal.Text = "Please provide the number of the pedistal!!!";
                validatPedistalNo = false;
            }
            else
            {
                if (getExistingData("SELECT Pedistal_No FROM tbl_Pedistal_Details").Contains(tbox_ManageKeys_InsertKeysPedistalNo.Text))
                {
                    lbl_ExistingPedistal.Text = "Existing Pedistal!!!";
                    validatPedistalNo = false;
                }
                else
                {
                    lbl_ExistingPedistal.Text = string.Empty;
                    validatPedistalNo = true;
                }
            }
            if (tbox_ManageKeys_InsertKeysKeyNo.Text.Length == 0)
            {
                lbl_ManageKeys_InsertKeys_InsertKeysKeyNo.Text = "Provide the key number!!!";
                validateKeyNo = false;
            }
            else
            {
                lbl_ManageKeys_InsertKeys_InsertKeysKeyNo.Text = string.Empty;
                validateKeyNo = true;
            }
            if (cbox_ManageKeys_InsertKeysWhichFloor.SelectedItem.ToString().Equals("--------------------Select--------------------"))
            {
                lbl_ManageKeys_InsertKeys_Select_Floor.Text = "Select a floor";
                validateFloor = false;
            }
            else
            {
                lbl_ManageKeys_InsertKeys_Select_Floor.Text = string.Empty;
                validateFloor = true;
            }
            if (validatPedistalNo && validateKeyNo && validateFloor)
            {
                if (DatabaseOperation.insertDetails("INSERT INTO tbl_Pedistal_Details (Pedistal_No,Key_No,No_Of_Keys,Location,Active) VALUES ('" + tbox_ManageKeys_InsertKeysPedistalNo.Text.Trim() + "','" + tbox_ManageKeys_InsertKeysKeyNo.Text.Trim() + "','" + nemUD_ManageKeys_InsertKeys.Value + "','" + cbox_ManageKeys_InsertKeysWhichFloor.SelectedItem + "',True)") > 0)
                {
                    MessageBox.Show("Record Added", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetAddPedistal();
                }
                else
                {
                    MessageBox.Show("Operation Failed", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_ManageKeys_Insert_Reset_Click(object sender, EventArgs e)
        {
            resetAddPedistal();
        }

        private void btn_ManageKeys_Update_Reset_Click(object sender, EventArgs e)
        {
            resetUpdatePedstal();
        }

        private void btn_ManageKeys_Search_By_PedistalNo_Click(object sender, EventArgs e)
        {
            getPedistalDetails();
        }
        
        private void btn_ManageKeys_Update_Click(object sender, EventArgs e)
        {
            updatePedistalDetails();
        }

        #endregion btnEvents

        #region tbPageEvents

        private void tb_Page_VisitorDetails_OutDetails_Enter(object sender, EventArgs e)
        {
            resetVisitorFrom(2);
            controlDisabler(true);
        }

        private void tb_Page_VisitorDetails_InDetails_Enter(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref pBox_Image);
            resetVisitorFrom(1);
        }

        private void tb_Page_VisitorDetails_Report_Enter(object sender, EventArgs e)
        {
            dtPk_Report_InTime.Checked = false;
            dtPk_Report_OutTime.Checked = false;
            dtPk_Report_InTime.Format = DateTimePickerFormat.Custom;
            dtPk_Report_InTime.CustomFormat = "dd MMMM yyyy";
            dtPk_Report_OutTime.Format = DateTimePickerFormat.Custom;
            dtPk_Report_OutTime.CustomFormat = "dd MMMM yyyy";
        }

        private void tb_Page_InterOffice_Visitor_Enter(object sender, EventArgs e)
        {
            cbox_Inter_Update_Return_Details.Checked = false;
            cbox_Inter_Update_Return_Details_CheckedChanged(sender, e);
            webcam = new WebCam();
            webcam.InitializeWebCam(ref pBox_Inter_Office_Image);
            resetVisitorFrom(3);
        }

        private void tb_Page_Settings_Enter(object sender, EventArgs e)
        {
            frm_AdminLogin fmal = new frm_AdminLogin();
            fmal.ShowDialog();
            if (frm_Main.addminLoginAllowed != true)
            {
                tbCtrl_Asset_Manager.SelectedTab = tb_Page_VisitorDetails;
            }
            else
            {
                tb_Page_Settings.Enter -= tb_Page_Settings_Enter;
                tbCtrl_Asset_Manager.SelectedTab = tb_Page_Settings;
                tbCtrl_Settings.SelectedTab = tb_Page_Settings_Manage_Employee;
                tb_Page_Settings.Enter += tb_Page_Settings_Enter;
                resetEmployeeForm();
            }
        }

        private void tb_Page_Settings_Manage_Database_Enter(object sender, EventArgs e)
        {
            lbl_ConnectedDatabase.Text = string.Empty;
            lbl_ConnectedDatabase.Text = "Connected Database Location : " + Encrypter.Decrypt(RegManager.getKey("data source"), true);
            databaseSizeCalculator();
            pgBarColorChanger();
            if (RegManager.getKey("backupdatetime") != "")
            {
                lbl_Database_Last_BackedUp_On.Text = lbl_Database_Last_BackedUp_On.Text.Substring(0, 19) + Encrypter.Decrypt(RegManager.getKey("backupdatetime"), true);
            }
            else
            {
                lbl_Database_Last_BackedUp_On.Text = lbl_Database_Last_BackedUp_On.Text.Substring(0, 19) + "Not backed-up yet";
            }
        }

        private void tb_Page_Settings_Manage_Medicine_Enter(object sender, EventArgs e)
        {
            if (rd_ManageMedicine_PlotActiveMedicine.Checked == true)
            {
                plotGraph("True");
            }
            else
            {
                rd_ManageMedicine_PlotActiveMedicine.Checked = true;
            }
            resetAddMedicine();
            resetUpdateMedicine();
        }

        private void tb_Page_Settings_Manage_Medicine_Leave(object sender, EventArgs e)
        {
            if (chrt_Medicine_Stock.ChartAreas.Count > 0)
            {
                chrt_Medicine_Stock.ChartAreas.Remove(chrt_Medicine_Stock.ChartAreas[0]);
                chrt_Medicine_Stock.Legends.Remove(chrt_Medicine_Stock.Legends["MedicineStock"]);
                chrt_Medicine_Stock.Series.Remove(chrt_Medicine_Stock.Series["Medicine Stock"]);
                chrt_Medicine_Stock.Series.Remove(chrt_Medicine_Stock.Series["Warning Limit"]);
            }
        }

        private void tb_Page_Settings_Manage_Keys_Enter(object sender, EventArgs e)
        {
            resetAddPedistal();
            resetUpdatePedstal();
        }
        #endregion tbPageEvents

        #region cboxEvents

        private void cbox_Interview_Purpose_CheckedChanged(object sender, EventArgs e)
        {
            interviewCheckboxStatusChange(0);
        }

        private void cbox_Interview_Out_Purpose_CheckedChanged(object sender, EventArgs e)
        {
            interviewCheckboxStatusChange(1);
        }

        private void cbox_Inter_Update_Return_Details_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_Inter_Update_Return_Details.Checked == true)
            {
                grpBx_Inter_Office_Emp_Details.Enabled = false;
                grpBx_Inter_Office_Access_Card_Details.Enabled = false;
                grpBx_Inter_Office_Emp_Image_Details.Enabled = false;
                grpBx_Inter_Office_Emp_Signeture_Details.Enabled = false;
                btn_Assign.Enabled = false;
                grpBx_Inter_Office_Return_Details.Enabled = true;
            }
            else
            {
                grpBx_Inter_Office_Emp_Details.Enabled = true;
                grpBx_Inter_Office_Access_Card_Details.Enabled = true;
                grpBx_Inter_Office_Emp_Image_Details.Enabled = true;
                grpBx_Inter_Office_Emp_Signeture_Details.Enabled = true;
                btn_Assign.Enabled = true;
                grpBx_Inter_Office_Return_Details.Enabled = false;
            }
        }

        private void cbox_Interview_Report_Purpose_CheckedChanged(object sender, EventArgs e)
        {
            interviewCheckboxStatusChange(2);
        }

        private void cbox_Non_Employee_Medicine_Distribution_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_Non_Employee_Medicine_Distribution.Checked == true)
            {
                changeLabel(false);
                btn_Med_Emp_Search.Enabled = false;
            }
            else
            {
                changeLabel(true);
                btn_Med_Emp_Search.Enabled = true;
            }
        }



        #endregion cboxEvents

        #region bgPgrsEvents

        private void bg_Worker_ImportEmployee_DoWork(object sender, DoWorkEventArgs e)
        {
            importEmployee();
        }

        private void bg_Worker_ImportEmployee_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgBar_Import_Progress.Maximum = maxValProgressBar;
            lblStateStatus.Text = e.UserState as string;
            pgBar_Import_Progress.Value = pgBar_Import_Progress.Value + e.ProgressPercentage > maxValProgressBar ? maxValProgressBar : pgBar_Import_Progress.Value + e.ProgressPercentage;
        }

        private void bg_Worker_ImportEmployee_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult dresult = new DialogResult();
            lblStateStatus.Text = "Completed...";
            if (errorInEmployeeeImport == true)
            {
                MessageBox.Show( validRows +"/" + maxValProgressBar + " Data inserted into database \n There are some employee information which is not valid.", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dresult = MessageBox.Show("Kidnly review " + tbox_Browse.Text.Substring(0, tbox_Browse.Text.LastIndexOf('.')) + "_Incorrect.xlsx File");
            }
            if (dresult == DialogResult.OK)
            {
                pgBar_Import_Progress.Value = 0;
                lblStateStatus.Text = string.Empty;
                tbox_Browse.Text = string.Empty;
            }
            btn_Start.Enabled = true;
        }

        private void bg_Worker_BackupDatabase_DoWork(object sender, DoWorkEventArgs e)
        {
            backupDatabase();
        }

        private void bg_Worker_BackupDatabase_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lbl_BackupStatus.Text = e.UserState as string;
            pgBar_Backup_Progress.Value = pgBar_Backup_Progress.Value + e.ProgressPercentage > 100 ? 100 : pgBar_Backup_Progress.Value + e.ProgressPercentage;
        }

        private void bg_Worker_BackupDatabase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (backupSuccessful)
            {
                lbl_Database_Last_BackedUp_On.Text = lbl_Database_Last_BackedUp_On.Text.Substring(0, 19) + Encrypter.Decrypt(RegManager.getKey("backupdatetime"), true);
                lbl_BackupStatus.Text = "Completed...";
                DialogResult dresult = MessageBox.Show("Data Backup Completed", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dresult == DialogResult.OK)
                {
                    pgBar_Backup_Progress.Value = 0;
                    lbl_BackupStatus.Text = string.Empty;
                }
                btn_Backup_Database.Enabled = true;
            }
            else
            {
                lbl_BackupStatus.Text = "Cancelled...";
                DialogResult dresult = MessageBox.Show("Data backup aborted by user", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dresult == DialogResult.OK)
                {
                    pgBar_Backup_Progress.Value = 0;
                    lbl_BackupStatus.Text = string.Empty;
                }
                btn_Backup_Database.Enabled = true;
            }
        }

        private void bg_Worker_RestoreDatabase_DoWork(object sender, DoWorkEventArgs e)
        {
            RestoreDatabase();
        }

        private void bg_Worker_RestoreDatabase_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void bg_Worker_RestoreDatabase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (restoreSuccessful)
            {
                lbl_BackupStatus.Text = "Completed...";
                DialogResult dresult = MessageBox.Show("Data Restore Completed", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dresult == DialogResult.OK)
                {
                    pgBar_Backup_Progress.Value = 0;
                    lbl_BackupStatus.Text = string.Empty;
                }
                btn_Restore_Database.Enabled = true;
            }
            else
            {
                lbl_BackupStatus.Text = "Cancelled...";
                DialogResult dresult = MessageBox.Show("Data restore aborted by user", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dresult == DialogResult.OK)
                {
                    pgBar_Backup_Progress.Value = 0;
                    lbl_BackupStatus.Text = string.Empty;
                }
                btn_Restore_Database.Enabled = true;
            }
        }

        #endregion bgPgrsEvents

        #region tboxEvents

        private void tbox_ManageEmployee_EmployeeId_TextChanged(object sender, EventArgs e)
        {
            autoCompleteTextbox.autoCompleteData(ref tbox_ManageEmployee_EmployeeId, "Employee_Id", "tbl_Employee_Details");
        }

        private void tbox_ManageEmployee_EmployeeName_TextChanged(object sender, EventArgs e)
        {
            autoCompleteTextbox.autoCompleteData(ref tbox_ManageEmployee_EmployeeName, "Employee_Name", "tbl_Employee_Details");
        }

        private void tbox_ManageEmployee_EmployeeEmail_TextChanged(object sender, EventArgs e)
        {
            autoCompleteTextbox.autoCompleteData(ref tbox_ManageEmployee_EmployeeEmail, "Employee_Email", "tbl_Employee_Details");
        }

        private void tbox_ManageEmployee_EmployeeExtection_TextChanged(object sender, EventArgs e)
        {
            autoCompleteTextbox.autoCompleteData(ref tbox_ManageEmployee_EmployeeExtection, "Extension", "tbl_Employee_Details");
        }

        private void tbox_Med_Emp_Id_TextChanged(object sender, EventArgs e)
        {
            if (cbox_Non_Employee_Medicine_Distribution.Checked == false)
            {
                autoCompleteTextbox.autoCompleteData(ref tbox_Med_Emp_Id, "Employee_Id", "tbl_Employee_Details", "Active", " = ", "True");
            }
        }

        private void tbox_Med_Emp_Name_TextChanged(object sender, EventArgs e)
        {
            if (cbox_Non_Employee_Medicine_Distribution.Checked == false)
            {
                autoCompleteTextbox.autoCompleteData(ref tbox_Med_Emp_Name, "Employee_Name", "tbl_Employee_Details", "Active", " = ", "True");
            }
        }

        private void tbox_Med_Medcine_Name_TextChanged(object sender, EventArgs e)
        {
            autoCompleteTextbox.autoCompleteData(ref tbox_Med_Medcine_Name, "Medicine_Name", "tbl_Medicine_Details", "Active", "=", "True");
            if (tbox_Med_Medcine_Name.Text.Length > 0)
            {
                tbox_Med_Medcine_Quantity.Enabled = true;
            }
            else
            {
                tbox_Med_Medcine_Quantity.Enabled = false;
            }
        }

        private void tbox_Med_Medcine_Quantity_KeyUp(object sender, KeyEventArgs e)
        {
            medStockValidator();
        }

        private void tbox_ManageMedicine_UpdateMedicineName_TextChanged(object sender, EventArgs e)
        {
            if (tbox_ManageMedicine_UpdateMedicineName.Text.Length > 0)
            {
                btn_ManageMedicine_Search.Enabled = true;
                autoCompleteTextbox.autoCompleteData(ref tbox_ManageMedicine_UpdateMedicineName, "Medicine_Name", "tbl_Medicine_Details");
            }
            else
            {
                btn_ManageMedicine_Search.Enabled = false;
            }
        }

        private void tbox_ManageMedicine_UpdateMedicineName_EnabledChanged(object sender, EventArgs e)
        {
            if (tbox_ManageMedicine_UpdateMedicineName.Enabled == true)
            {
                nemUD_ManageMedicine_UpdateMedicineStock.Enabled = false;
                nemUD_ManageMedicine_UpdateWarning.Enabled = false;
                lbl_ManageMedicine_UpdateMedicineStock.Enabled = false;
                lbl_ManageMedicine_UpdateWarning.Enabled = false;
                rdBtn_MedicineActive.Enabled = false;
                rdBtn_MedicineInActive.Enabled = false;
                btn_ManageMedicine_Update.Enabled = false;
            }
            else
            {
                nemUD_ManageMedicine_UpdateMedicineStock.Enabled = true;
                nemUD_ManageMedicine_UpdateWarning.Enabled = true;
                lbl_ManageMedicine_UpdateMedicineStock.Enabled = true;
                lbl_ManageMedicine_UpdateWarning.Enabled = true;
                rdBtn_MedicineActive.Enabled = true;
                rdBtn_MedicineInActive.Enabled = true;
                btn_ManageMedicine_Update.Enabled = true;
            }
        }

        private void tbox_Med_Emp_Email_TextChanged(object sender, EventArgs e)
        {
            if (cbox_Non_Employee_Medicine_Distribution.Checked == false)
            {
                autoCompleteTextbox.autoCompleteData(ref tbox_Med_Emp_Email, "Employee_Email", "tbl_Employee_Details", "Active", " = ", "True");
            }
        }

        private void tbox_Med_Emp_Desk_Phone_TextChanged(object sender, EventArgs e)
        {
            if (cbox_Non_Employee_Medicine_Distribution.Checked == false)
            {
                autoCompleteTextbox.autoCompleteData(ref tbox_Med_Emp_Desk_Phone, "Extension", "tbl_Employee_Details", "Active", " = ", "True");
            }
        }

        private void tbox_InterOffce_Return_Employee_Id_TextChanged(object sender, EventArgs e)
        {
            autoCompleteTextbox.autoCompleteData(ref tbox_InterOffce_Return_Employee_Id, "Employee_Id", "tbl_Inter_Office_Visitor", "Return_Date", " IS ", "NULL");
        }

        private void tbox_Med_Medcine_Updated_Stock_TextChanged(object sender, EventArgs e)
        {
            if(tbox_Med_Medcine_Updated_Stock.Text.Length > 0 )
            {
                btn_Med_Assign.Enabled = true;
            }
            else
            {
                btn_Med_Assign.Enabled = false;
            }
        }

        private void tbox_Key_Emp_Id_TextChanged(object sender, EventArgs e)
        {
            autoCompleteTextbox.autoCompleteData(ref tbox_Key_Emp_Id, "Employee_Id", "tbl_Employee_Details", "Active", " = ", "True");
        }

        private void tbox_Key_Emp_Name_TextChanged(object sender, EventArgs e)
        {
            autoCompleteTextbox.autoCompleteData(ref tbox_Key_Emp_Name, "Employee_Name", "tbl_Employee_Details", "Active", " = ", "True");
        }

        private void tbox_Key_Emp_Email_TextChanged(object sender, EventArgs e)
        {
            autoCompleteTextbox.autoCompleteData(ref tbox_Key_Emp_Email, "Employee_Email", "tbl_Employee_Details", "Active", " = ", "True");
        }

        private void tbox_Key_Emp_Desk_Phone_TextChanged(object sender, EventArgs e)
        {
            autoCompleteTextbox.autoCompleteData(ref tbox_Key_Emp_Desk_Phone, "Extension", "tbl_Employee_Details", "Active", " = ", "True");
        }

        private void tbox_Out_Serial_Number_TextChanged(object sender, EventArgs e)
        {
            if (tbox_Out_Serial_Number.Text != string.Empty)
            {
                btn_Out_Update.Enabled = true;
            }
            else
            {
                btn_Out_Update.Enabled = false;
            }
        }

        private void tbox_ManageKeys_UpdateKeysPedistalNo_TextChanged(object sender, EventArgs e)
        {
            if (tbox_ManageKeys_UpdateKeysPedistalNo.Text.Length > 0)
            {
                btn_ManageKeys_Search_By_PedistalNo.Enabled = true;
                autoCompleteTextbox.autoCompleteData(ref tbox_ManageKeys_UpdateKeysPedistalNo, "Pedistal_No", "tbl_Pedistal_Details");
            }
            else
            {
                btn_ManageKeys_Search_By_PedistalNo.Enabled = false;
            }
        }

        private void tbox_ManageKeys_UpdateKeysPedistalNo_EnabledChanged(object sender, EventArgs e)
        {
            if (tbox_ManageKeys_UpdateKeysPedistalNo.Enabled == true)
            {
                lbl_ManageKeys_UpdateKeysKeyNo.Enabled = false;
                lbl_ManageKeys_UpdateKeysNoOfKeys.Enabled = false;
                lbl_ManageKeys_UpdateKeysWhichFloor.Enabled = false;
                tbox_ManageKeys_UpdateKeysKeyNo.Enabled = false;
                nemUD_ManageKeys_UpdateKeys.Enabled = false;
                cbox_ManageKeys_UpdateKeysWhichFloor.Enabled = false;
                rdBtn_PedistalActive.Enabled = false;
                rdBtn_PedistalInActive.Enabled = false;
                btn_ManageKeys_Update.Enabled = false;
            }
            else
            {

                lbl_ManageKeys_UpdateKeysKeyNo.Enabled = true;
                lbl_ManageKeys_UpdateKeysNoOfKeys.Enabled = true;
                lbl_ManageKeys_UpdateKeysWhichFloor.Enabled = true;
                tbox_ManageKeys_UpdateKeysKeyNo.Enabled = true;
                nemUD_ManageKeys_UpdateKeys.Enabled = true;
                cbox_ManageKeys_UpdateKeysWhichFloor.Enabled = true;
                rdBtn_PedistalActive.Enabled = true;
                rdBtn_PedistalInActive.Enabled = true;
                btn_ManageKeys_Update.Enabled = true;
            }
        }

        #endregion tboxEvents

        #region rdBtnEvents

        private void rd_ManageMedicine_PlotActiveMedicine_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_ManageMedicine_PlotActiveMedicine.Checked == true)
            {
                plotGraph("True");
            }
        }

        private void rd_ManageMedicine_PlotInActiveMedicine_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_ManageMedicine_PlotInActiveMedicine.Checked == true)
            {
                plotGraph("False");
            }
        }

        #endregion rdBtnEvents

        #endregion Events

        #region Function

        /// <summary>
        /// Resets the visitor from.
        /// </summary>
        /// <param name="from">From.</param>
        private void resetVisitorFrom(int from)
        {
            if (from == 1)
            {
                tbox_In_Name.Text = string.Empty;
                tbox_In_Address.Text = string.Empty;
                tbox_In_ContactNumber.Text = string.Empty;
                cbox_Interview_Purpose.Checked = false;
                tbox_In_Purpose.Text = string.Empty;
                tbox_In_Whom_To_Meet.Text = string.Empty;
                tbox_In_Badge_Number.Text = string.Empty;
                tbox_In_Escort_Name.Text = string.Empty;
                cBox_Floor_Number.SelectedIndex = 0;
                tbox_In_Remarks.Text = string.Empty;
                tbox_In_Carrying_Laptop.Text = string.Empty;
                tbox_In_Id_Proof.Text = string.Empty;
                pBox_Image.Image = null;
                //pBox_Signeture.Image = null;
                lbl_Visitor_In_Name.ForeColor = System.Drawing.Color.Black;
                lbl_Visitor_In_Address.ForeColor = System.Drawing.Color.Black;
                lbl_Visitor_In_Contact_Number.ForeColor = System.Drawing.Color.Black;
                lbl_Visitor_In_Purpose.ForeColor = System.Drawing.Color.Black;
                lbl_Visitor_In_Whom_To_Meet.ForeColor = System.Drawing.Color.Black;
                lbl_Visitor_In_Badge_Number.ForeColor = System.Drawing.Color.Black;
                lbl_Visitor_In_Escort_Name.ForeColor = System.Drawing.Color.Black;
                lbl_Visitor_In_Identity_Card_Number.ForeColor = System.Drawing.Color.Black;
                lbl_Visitor_Floor_Number.ForeColor = System.Drawing.Color.Black;
            }
            if (from == 2)
            {
                tbox_Out_Serial_Number.Text = string.Empty;
                tbox_Out_Name.Text = string.Empty;
                tbox_Out_Address.Text = string.Empty;
                tbox_Out_ContactNumber.Text = string.Empty;
                cbox_Interview_Out_Purpose.Checked = false;
                tbox_Out_Purpose.Text = string.Empty;
                tbox_Out_Whom_To_Meet.Text = string.Empty;
                tbox_Out_Badge_Number.Text = string.Empty;
                tbox_Out_Escort_Name.Text = string.Empty;
                cBox_Out_Floor_Number.SelectedIndex = 0;
                cBox_Out_Floor_Number.Text = string.Empty;
                tbox_Out_Remarks.Text = string.Empty;
                tbox_Out_Carrying_Laptop.Text = string.Empty;
                tbox_Out_Id_Proof.Text = string.Empty;
                pBox_Out_Image.Image = null;
                pBox_Out_Signeture.Image = null;
            }
            if (from == 3)
            {
                tbox_InterOffce_Employee_Id.Text = string.Empty;
                tbox_InterOffce_Employee_Name.Text = string.Empty;
                tbox_InterOffce_Comming_From.Text = string.Empty;
                tbox_InterOffce_Contact_Number.Text = string.Empty;
                tbox_InterOffce_Date.Text = string.Empty;
                tbox_InterOffce_Remarks.Text = string.Empty;
                tbox_InterOffice_Serial_Number.Text = string.Empty;
                tbox_InterOffce_Badge_Number.Text = string.Empty;
                tbox_InterOffce_Access_Card_Number.Text = string.Empty;
                tbox_InterOffce_Issuing_Time.Text = string.Empty;
                tbox_InterOffce_No_Of_Days.Text = string.Empty;
                pBox_Inter_Office_Image.Image = null;
                tbox_InterOffce_Return_Employee_Id.Text = string.Empty;
                //pBox_Inter_Office_Signeture.Image = null;

                lbl_InterOffce_Employee_Id.ForeColor = System.Drawing.Color.Black;
                lbl_InterOffce_Employee_Name.ForeColor = System.Drawing.Color.Black;
                lbl_InterOffce_Comming_From.ForeColor = System.Drawing.Color.Black;
                lbl_InterOffce_Contact_Number.ForeColor = System.Drawing.Color.Black;
                lbl_InterOffce_Badge_Number.ForeColor = System.Drawing.Color.Black;
                lbl_InterOffce_Access_Card_Number.ForeColor = System.Drawing.Color.Black;
                lbl_InterOffce_No_Of_Days.ForeColor = System.Drawing.Color.Black;
            }
            if (from == 4)
            {
                tbox_Report_Name.Text = string.Empty;
                tbox_Report_Address.Text = string.Empty;
                tbox_Report_ContactNumber.Text = string.Empty;
                tbox_Report_Purpose.Text = string.Empty;
                tbox_Report_Whom_To_Meet.Text = string.Empty;
                tbox_Report_Badge_Number.Text = string.Empty;
                tbox_Report_Escort_Name.Text = string.Empty;
                cbox_Interview_Report_Purpose.Checked = false;
                dtPk_Report_InTime.Checked = false;
                dtPk_Report_OutTime.Checked = false;
                cBox_Report_Floor_Number.SelectedIndex = 0;
                tbox_Report_Remarks.Text = string.Empty;
                tbox_Report_Carrying_Laptop.Text = string.Empty;
                tbox_Report_Id_Proof.Text = string.Empty;
            }
        }
        /// <summary>
        /// Ins the form validate.
        /// </summary>
        /// <returns></returns>
        private int inFormValidate()
        {
            int result = 0;
            if (tbox_In_Name.Text == string.Empty)
            {
                lbl_Visitor_In_Name.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_Visitor_In_Name.ForeColor = System.Drawing.Color.Black;
            }
            if (tbox_In_Address.Text == string.Empty)
            {
                lbl_Visitor_In_Address.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_Visitor_In_Address.ForeColor = System.Drawing.Color.Black;
            }
            if (tbox_In_ContactNumber.Text == string.Empty)
            {
                lbl_Visitor_In_Contact_Number.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_Visitor_In_Contact_Number.ForeColor = System.Drawing.Color.Black;
            }
            if (tbox_In_Purpose.Text == string.Empty)
            {
                lbl_Visitor_In_Purpose.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_Visitor_In_Purpose.ForeColor = System.Drawing.Color.Black;
            }
            if (tbox_In_Whom_To_Meet.Text == string.Empty)
            {
                lbl_Visitor_In_Whom_To_Meet.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_Visitor_In_Whom_To_Meet.ForeColor = System.Drawing.Color.Black;
            }
            if (tbox_In_Badge_Number.Text == string.Empty)
            {
                lbl_Visitor_In_Badge_Number.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_Visitor_In_Badge_Number.ForeColor = System.Drawing.Color.Black;
            }
            if (tbox_In_Escort_Name.Text == string.Empty)
            {
                lbl_Visitor_In_Escort_Name.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_Visitor_In_Escort_Name.ForeColor = System.Drawing.Color.Black;
            }
            if (tbox_In_Id_Proof.Text == string.Empty)
            {
                lbl_Visitor_In_Identity_Card_Number.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_Visitor_In_Identity_Card_Number.ForeColor = System.Drawing.Color.Black;
            }
            if (cBox_Floor_Number.SelectedIndex == 0)
            {
                lbl_Visitor_Floor_Number.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_Visitor_Floor_Number.ForeColor = System.Drawing.Color.Black;
            }
            return result;
        }
        /// <summary>
        /// Inserts the visitor details.
        /// </summary>
        private void insertVisitorDetails()
        {
            if (DatabaseOperation.insertDetailsWithDoublePicture("INSERT INTO tbl_Visitor_details ( Visitor_Name,From_Address,Contact_Number,Purpose,Whom_To_Meet,Badge_Number,In_Time,Escort_Name,Which_Floor,Remarks,Carrying_Laptop,ID_Proof,Photo,Signeture_Image) VALUES ('" + tbox_In_Name.Text + "','" + tbox_In_Address.Text + "','" + tbox_In_ContactNumber.Text + "','" + tbox_In_Purpose.Text + "','" + tbox_In_Whom_To_Meet.Text + "','" + tbox_In_Badge_Number.Text + "','" + tbox_In_Time.Text + "','" + tbox_In_Escort_Name.Text + "','" + cBox_Floor_Number.SelectedItem + "','" + tbox_In_Remarks.Text + "','" + tbox_In_Carrying_Laptop.Text + "','" + tbox_In_Id_Proof.Text + "',@Photo,@Signeture_Image)", ref pBox_Image, "@Photo", ref pBox_Signeture, "@Signeture_Image") > 0)
            {
                MessageBox.Show("Details Captured", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetVisitorFrom(1);
            }
            else
            {
                MessageBox.Show("Details Not Captured", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Queries the generator.
        /// </summary>
        /// <param name="from">From.</param>
        /// <returns></returns>
        private string queryGenerator(int from)
        {
            bool whereFlag = false;
            string resultQuery = string.Empty;
            if (from == 0)
            {
                resultQuery = "SELECT Serial_Number,Visitor_Name, From_Address, Contact_Number, Purpose, Whom_To_Meet, Badge_Number,In_Time,Out_Time, Escort_Name, Which_Floor, Remarks, Carrying_Laptop, ID_Proof FROM tbl_Visitor_details";
            }
            else
            {
                resultQuery = "SELECT Serial_Number,Visitor_Name, From_Address, Contact_Number, Purpose, Whom_To_Meet, Badge_Number,In_Time,Out_Time, Escort_Name, Which_Floor, Remarks, Carrying_Laptop, ID_Proof,Photo,Signeture_Image FROM tbl_Visitor_details";
            }

            if (from == 0)
            {
                if (tbox_Out_Name.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Visitor_Name LIKE '%" + tbox_Out_Name.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Visitor_Name LIKE '%" + tbox_Out_Name.Text + "%'";
                    }
                }
            }
            else
            {
                if (tbox_Report_Name.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Visitor_Name LIKE '%" + tbox_Report_Name.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Visitor_Name LIKE '%" + tbox_Report_Name.Text + "%'";
                    }
                }
            }
            if (from == 0)
            {
                if (tbox_Out_Address.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE From_Address LIKE '%" + tbox_Out_Address.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND From_Address LIKE '%" + tbox_Out_Address.Text + "%'";
                    }
                }
            }
            else
            {
                if (tbox_Report_Address.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE From_Address LIKE '%" + tbox_Report_Address.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND From_Address LIKE '%" + tbox_Report_Address.Text + "%'";
                    }
                }
            }
            if (from == 0)
            {
                if (tbox_Out_ContactNumber.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Contact_Number LIKE '%" + tbox_Out_ContactNumber.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Contact_Number LIKE '%" + tbox_Out_ContactNumber.Text + "%'";
                    }
                }
            }
            else
            {
                if (tbox_Report_ContactNumber.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Contact_Number LIKE '%" + tbox_Report_ContactNumber.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Contact_Number LIKE '%" + tbox_Report_ContactNumber.Text + "%'";
                    }
                }
            }
            if (from == 0)
            {
                if (tbox_Out_Purpose.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Purpose LIKE '%" + tbox_Out_Purpose.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Purpose LIKE '%" + tbox_Out_Purpose.Text + "%'";
                    }
                }
            }
            else
            {
                if (tbox_Report_Purpose.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Purpose LIKE '%" + tbox_Report_Purpose.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Purpose LIKE '%" + tbox_Report_Purpose.Text + "%'";
                    }
                }
            }
            if (from == 0)
            {
                if (tbox_Out_Whom_To_Meet.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Whom_To_Meet LIKE '%" + tbox_Out_Whom_To_Meet.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Whom_To_Meet LIKE '%" + tbox_Out_Whom_To_Meet.Text + "%'";
                    }
                }
            }
            else
            {
                if (tbox_Report_Whom_To_Meet.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Whom_To_Meet LIKE '%" + tbox_Report_Whom_To_Meet.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Whom_To_Meet LIKE '%" + tbox_Report_Whom_To_Meet.Text + "%'";
                    }
                }
            }
            if (from == 0)
            {
                if (tbox_Out_Badge_Number.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Badge_Number LIKE '%" + tbox_Out_Badge_Number.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Badge_Number LIKE '%" + tbox_Out_Badge_Number.Text + "%'";
                    }
                }
            }
            else
            {
                if (tbox_Report_Badge_Number.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Badge_Number LIKE '%" + tbox_Report_Badge_Number.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Badge_Number LIKE '%" + tbox_Report_Badge_Number.Text + "%'";
                    }
                }
            }
            if (from == 0)
            {
                if (tbox_Out_Escort_Name.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Escort_Name LIKE '%" + tbox_Out_Escort_Name.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Escort_Name LIKE '%" + tbox_Out_Escort_Name.Text + "%'";
                    }
                }
            }
            else
            {
                if (tbox_Report_Escort_Name.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Escort_Name LIKE '%" + tbox_Report_Escort_Name.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Escort_Name LIKE '%" + tbox_Report_Escort_Name.Text + "%'";
                    }
                }
            }
            if (from == 0)
            {
                if (cBox_Out_Floor_Number.SelectedIndex > 0)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Which_Floor = '" + cBox_Out_Floor_Number.Text + "'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Which_Floor = '" + cBox_Out_Floor_Number.Text + "'";
                    }
                }
            }
            else
            {
                if (cBox_Report_Floor_Number.SelectedIndex > 0)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Which_Floor = '" + cBox_Report_Floor_Number.Text + "'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Which_Floor = '" + cBox_Report_Floor_Number.Text + "'";
                    }
                }
            }
            if (from == 0)
            {
                if (tbox_Out_Carrying_Laptop.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Carrying_Laptop LIKE '*" + tbox_Out_Carrying_Laptop.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Carrying_Laptop LIKE '%" + tbox_Out_Carrying_Laptop.Text + "%'";
                    }
                }
            }
            else
            {
                if (tbox_Report_Carrying_Laptop.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Carrying_Laptop LIKE '*" + tbox_Report_Carrying_Laptop.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Carrying_Laptop LIKE '%" + tbox_Report_Carrying_Laptop.Text + "%'";
                    }
                }
            }
            if (from == 0)
            {
                if (tbox_Out_Id_Proof.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Carrying_Laptop LIKE '" + tbox_Out_Id_Proof.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Carrying_Laptop LIKE '%" + tbox_Out_Id_Proof.Text + "%'";
                    }
                }
            }
            else
            {
                if (tbox_Report_Id_Proof.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Carrying_Laptop LIKE '" + tbox_Report_Id_Proof.Text + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Carrying_Laptop LIKE '%" + tbox_Report_Id_Proof.Text + "%'";
                    }
                }
            }
            if (from == 1)
            {
                if (dtPk_Report_InTime.Checked == true)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE In_Time LIKE '" + dtPk_Report_InTime.Value.Date.ToShortDateString() + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND In_Time LIKE '" + dtPk_Report_InTime.Value.ToString("MM/dd/yyyy") + "%'";
                    }
                }
            }
            if (from == 0)
            {
                if (whereFlag == false)
                {
                    resultQuery = resultQuery + " WHERE Out_Time Is Null";
                    whereFlag = true;
                }
                else
                {
                    resultQuery = resultQuery + " AND Out_Time Is Null";
                }
            }
            else
            {
                if (dtPk_Report_OutTime.Checked == true)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Out_Time LIKE '" + dtPk_Report_OutTime.Value.Date.ToShortDateString() + "%'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Out_Time LIKE '" + dtPk_Report_OutTime.Value.Date.ToShortDateString() + "%'";
                    }
                }
            }
            return resultQuery;
        }
        /// <summary>
        /// Fetches the data by serial number.
        /// </summary>
        /// <param name="serialNumber">The serial number.</param>
        private void fetchDataBySerialNumber(string serialNumber)
        {
            con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
            string query = "SELECT Serial_Number,Visitor_Name, From_Address, Contact_Number, Purpose, Whom_To_Meet, Badge_Number, Escort_Name, Which_Floor, Remarks, Carrying_Laptop, ID_Proof,Photo,Signeture_Image FROM tbl_Visitor_details WHERE Serial_Number = " + serialNumber + "";
            adapter = new OleDbDataAdapter(query, con);
            ds = new DataSet();
            adapter.Fill(ds, "tbl_Visitor_details");
            serialNumber = null;
            poupulateData();
        }
        /// <summary>
        /// Poupulates the data.
        /// </summary>
        private void poupulateData()
        {
            tbox_Out_Serial_Number.Text = ds.Tables[0].Rows[0][0].ToString();
            tbox_Out_Name.Text = ds.Tables[0].Rows[0][1].ToString();
            tbox_Out_Address.Text = ds.Tables[0].Rows[0][2].ToString();
            tbox_Out_ContactNumber.Text = ds.Tables[0].Rows[0][3].ToString();
            tbox_Out_Purpose.Text = ds.Tables[0].Rows[0][4].ToString();
            tbox_Out_Whom_To_Meet.Text = ds.Tables[0].Rows[0][5].ToString();
            tbox_Out_Badge_Number.Text = ds.Tables[0].Rows[0][6].ToString();
            tbox_Out_Escort_Name.Text = ds.Tables[0].Rows[0][7].ToString();
            cBox_Out_Floor_Number.Text = ds.Tables[0].Rows[0][8].ToString();
            tbox_Out_Remarks.Text = ds.Tables[0].Rows[0][9].ToString();
            tbox_Out_Carrying_Laptop.Text = ds.Tables[0].Rows[0][10].ToString();
            tbox_Out_Id_Proof.Text = ds.Tables[0].Rows[0][11].ToString();
            pBox_Out_Image.Image = null;
            if (ds.Tables[0].Rows[0][12] != System.DBNull.Value)
            {
                photo_aray = (byte[])ds.Tables[0].Rows[0][12];
                MemoryStream ms = new MemoryStream(photo_aray);
                pBox_Out_Image.Image = Image.FromStream(ms);
            }
            pBox_Out_Signeture.Image = null;
            if (ds.Tables[0].Rows[0][13] != System.DBNull.Value)
            {
                photo_aray = (byte[])ds.Tables[0].Rows[0][13];
                MemoryStream ms = new MemoryStream(photo_aray);
                pBox_Out_Signeture.Image = Image.FromStream(ms);
            }
            controlDisabler(false);
        }
        /// <summary>
        /// Controls the disabler.
        /// </summary>
        /// <param name="type">if set to <c>true</c> [type].</param>
        private void controlDisabler(bool type)
        {
            tbox_Out_Serial_Number.Enabled = type;
            tbox_Out_Name.Enabled = type;
            tbox_Out_Address.Enabled = type;
            tbox_Out_ContactNumber.Enabled = type;
            cbox_Interview_Out_Purpose.Enabled = type;
            tbox_Out_Purpose.Enabled = type;
            tbox_Out_Whom_To_Meet.Enabled = type;
            tbox_Out_Badge_Number.Enabled = type;
            tbox_Out_Escort_Name.Enabled = type;
            cBox_Out_Floor_Number.Enabled = type;
            tbox_Out_Remarks.Enabled = type;
            tbox_Out_Carrying_Laptop.Enabled = type;
            tbox_Out_Id_Proof.Enabled = type;
        }
        /// <summary>
        /// Quicks the report generator.
        /// </summary>
        /// <param name="type">The type.</param>
        private void quickReportGenerator(int type)
        {
            string query = string.Empty;
            DateTime time = DateTime.Now;
            string format = "dd MMMM yyyy";
            string reportName = string.Empty;
            con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
            if (type == 0)
            {
                query = "SELECT Serial_Number,Visitor_Name, From_Address, Contact_Number, Purpose, Whom_To_Meet, Badge_Number,In_Time,Out_Time, Escort_Name, Which_Floor, Remarks, Carrying_Laptop, ID_Proof FROM tbl_Visitor_details WHERE In_Time BETWEEN #" + time.ToShortDateString() + " 12:00:00 AM# AND #" + time.ToShortDateString() + " 11:59:59 PM#";
                reportName = "Today's Visitor Details";
            }
            if (type == 1)
            {
                query = "SELECT Serial_Number,Visitor_Name, From_Address, Contact_Number, Purpose, Whom_To_Meet, Badge_Number,In_Time,Out_Time, Escort_Name, Which_Floor, Remarks, Carrying_Laptop, ID_Proof FROM tbl_Visitor_details WHERE In_Time BETWEEN #" + DateTime.Now.AddDays(-7).ToShortDateString() + " 12:00:00 AM# AND #" + DateTime.Now.ToShortDateString() + " 11:59:59 PM#";
                reportName = "Last 7 Days Visitor Details";
            }
            if (type == 2)
            {
                query = "SELECT Serial_Number,Visitor_Name, From_Address, Contact_Number, Purpose, Whom_To_Meet, Badge_Number,In_Time,Out_Time, Escort_Name, Which_Floor, Remarks, Carrying_Laptop, ID_Proof FROM tbl_Visitor_details WHERE Purpose='Interview' AND In_Time BETWEEN #" + DateTime.Now.AddDays(-30).ToShortDateString() + " 12:00:00 AM# AND #" + DateTime.Now.ToShortDateString() + " 11:59:59 PM#";
                reportName = "Last 30 Days Interview Candidate";
            }
            if (type == 3)
            {
                query = "SELECT Serial_No_Inter_Office,Employee_Id,Employee_Name,Comming_From,Contact_Number,Assign_Date,Remarks,Badge_Number,Access_Card_Number,Issueing_Time,No_Of_Days,Return_Date,Return_Time FROM tbl_Inter_Office_Visitor WHERE Assign_Date = #" + DateTime.Now.ToShortDateString() + "#";
                reportName = "Today's Inter Office Employee Details";
            }
            if (type == 4)
            {
                query = "SELECT Serial_No_Inter_Office,Employee_Id,Employee_Name,Comming_From,Contact_Number,Assign_Date,Remarks,Badge_Number,Access_Card_Number,Issueing_Time,No_Of_Days,Return_Date,Return_Time FROM tbl_Inter_Office_Visitor WHERE Assign_Date BETWEEN #" + DateTime.Now.AddDays(-7).ToShortDateString() + "# AND #" + DateTime.Now.ToShortDateString() + "#";
                reportName = "Last 7 Days Inter Office Employee Details";
            }
            if (type == 5)
            {
                query = "SELECT Serial_No_Inter_Office,Employee_Id,Employee_Name,Comming_From,Contact_Number,Assign_Date,Remarks,Badge_Number,Access_Card_Number,Issueing_Time,No_Of_Days,Return_Date,Return_Time FROM tbl_Inter_Office_Visitor WHERE Assign_Date BETWEEN #" + DateTime.Now.AddDays(-30).ToShortDateString() + "# AND #" + DateTime.Now.ToShortDateString() + "#";
                reportName = "Last 30 Days Inter Office Employee Details";
            }
            if (type == 6)
            {
                if (toDo == 1)
                {
                    query = "SELECT Serial_No_Inter_Office,Employee_Id,Employee_Name,Comming_From,Contact_Number,Assign_Date,Remarks,Badge_Number,Access_Card_Number,Issueing_Time,No_Of_Days,Return_Date,Return_Time FROM tbl_Inter_Office_Visitor WHERE Employee_Id LIKE '%" + employeeId + "%'";
                    reportName = "Inter Office Report for employee-" + employeeId;
                }
            }
            if (type == 7)
            {
                if (toDo == 1)
                {
                    if (InTime != null)
                    {
                        query = "SELECT Serial_No_Inter_Office,Employee_Id,Employee_Name,Comming_From,Contact_Number,Assign_Date,Remarks,Badge_Number,Access_Card_Number,Issueing_Time,No_Of_Days,Return_Date,Return_Time FROM tbl_Inter_Office_Visitor WHERE Assign_Date = #" + InTime.Value.ToShortDateString() + "#";
                        reportName = "Inter Office Report for " + InTime.Value.ToString(format);
                    }
                    if (OutTime != null)
                    {
                        query = "SELECT Serial_No_Inter_Office,Employee_Id,Employee_Name,Comming_From,Contact_Number,Assign_Date,Remarks,Badge_Number,Access_Card_Number,Issueing_Time,No_Of_Days,Return_Date,Return_Time FROM tbl_Inter_Office_Visitor WHERE Return_Date = #" + OutTime.Value.ToShortDateString() + "#";
                        reportName = "Inter Office Report for return date-" + OutTime.Value.ToString(format);
                    }
                    if (InTime != null && OutTime != null)
                    {
                        query = "SELECT Serial_No_Inter_Office,Employee_Id,Employee_Name,Comming_From,Contact_Number,Assign_Date,Remarks,Badge_Number,Access_Card_Number,Issueing_Time,No_Of_Days,Return_Date,Return_Time FROM tbl_Inter_Office_Visitor WHERE Assign_Date >= #" + InTime.Value.ToShortDateString() + "# AND Return_Date <= #" + OutTime.Value.ToShortDateString() + "#";
                        reportName = "Inter Office between" + InTime.Value.ToString(format) + " and " + OutTime.Value.ToString(format);
                    }
                    if (InTime == null && OutTime == null)
                    {
                        query = "SELECT Serial_No_Inter_Office,Employee_Id,Employee_Name,Comming_From,Contact_Number,Assign_Date,Remarks,Badge_Number,Access_Card_Number,Issueing_Time,No_Of_Days,Return_Date,Return_Time FROM tbl_Inter_Office_Visitor";
                        reportName = "Inter Office report for alltime";
                    }
                }
            }
            if (type == 8)
            {
                query = "SELECT Employee_Id,Employee_Name,Employee_Email,Desk_Phone,Medcine_Name,Quantity,Date_Assign FROM tbl_Medicine_Distrubution WHERE Date_Assign = #" + DateTime.Now.ToShortDateString() + "#";
                reportName = "Today's Medicine Distribution Details";
            }
            if (type == 9)
            {
                query = "SELECT Employee_Id,Employee_Name,Employee_Email,Desk_Phone,Medcine_Name,Quantity,Date_Assign FROM tbl_Medicine_Distrubution WHERE Date_Assign BETWEEN #" + DateTime.Now.AddDays(-30).ToShortDateString() + "# AND #" + DateTime.Now.ToShortDateString() + "#";
                reportName = "Last 30 Days Medicine Distribution Details";
            }
            if (type == 10)
            {
                if (toDo == 1)
                {
                    query = "SELECT Employee_Id,Employee_Name,Employee_Email,Desk_Phone,Medcine_Name,Quantity,Date_Assign FROM tbl_Medicine_Distrubution WHERE Medcine_Name = '" + medicineName + "'";
                    reportName = "Medicine Distribution Details for " + medicineName;
                }
            }
            if (type == 11)
            {
                if (toDo == 1)
                {
                    if (InTime != null && OutTime != null)
                    {
                        query = "SELECT Employee_Id,Employee_Name,Employee_Email,Desk_Phone,Medcine_Name,Quantity,Date_Assign FROM tbl_Medicine_Distrubution WHERE Date_Assign BETWEEN  #" + InTime.Value.ToShortDateString() + "# AND #" + OutTime.Value.ToShortDateString() + "#";
                        reportName = "Medicine Distribution between " + InTime.Value.ToString(format) + " and " + OutTime.Value.ToString(format);
                    }
                    if (InTime == null && OutTime == null)
                    {
                        query = "SELECT Employee_Id,Employee_Name,Employee_Email,Desk_Phone,Medcine_Name,Quantity,Date_Assign FROM tbl_Medicine_Distrubution";
                        reportName = "Medicine Distribution report for alltime";
                    }
                }
            }
            if (type == 12)
            {
                if (toDo == 1)
                {
                    query = "SELECT Employee_Id,Employee_Name,Employee_Email,Desk_Phone,Medcine_Name,Quantity,Date_Assign FROM tbl_Medicine_Distrubution WHERE Employee_Id = " + employeeId + "";
                    reportName = "Medicine Distribution Details for employee-" + employeeId;
                }
            }
            if (type == 13)
            {
                query = "SELECT Employee_Id,Employee_Name,Employee_Email,Desk_Phone,Medcine_Name,Quantity,Date_Assign FROM tbl_Medicine_Distrubution WHERE Employee_Id = 0";
                reportName = "Medicine Distribution Details for non-employee";
            }
            if (query != "")
            {
                adapter = new OleDbDataAdapter(query, con);
                ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("There is no data to extract", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    svFlDlg_SaveReport.Title = "Save the report";
                    svFlDlg_SaveReport.Filter = "Excel File-2007|*.xlsx|Excel File-2003|*.xls|All Files|*.*";
                    svFlDlg_SaveReport.ShowDialog();
                    if (reportSaveLocation != null)
                    {
                        if (ExcelUtlity.WriteDataTableToExcel(ds.Tables[0], "Report", reportSaveLocation, reportName, type))
                        {
                            MessageBox.Show("Data Extracted...", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please provide the file name...", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                InTime = null;
                OutTime = null;
                toDo = 0;
            }
            else
            {
                MessageBox.Show("No criteria specified...", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                toDo = 0;
            }
        }
        /// <summary>
        /// Interviews the checkbox status change.
        /// </summary>
        /// <param name="from">From.</param>
        private void interviewCheckboxStatusChange(int from)
        {
            if (from == 0)
            {
                if (cbox_Interview_Purpose.Checked == true)
                {
                    tbox_In_Purpose.Text = "Interview";
                    tbox_In_Purpose.Enabled = false;
                }
                else
                {
                    tbox_In_Purpose.Text = string.Empty;
                    tbox_In_Purpose.Enabled = true;
                }
            }
            else if (from == 1)
            {
                if (cbox_Interview_Out_Purpose.Checked == true)
                {
                    tbox_Out_Purpose.Text = "Interview";
                    tbox_Out_Purpose.Enabled = false;
                }
                else
                {
                    tbox_Out_Purpose.Text = string.Empty;
                    tbox_Out_Purpose.Enabled = true;
                }
            }
            else if (from == 2)
            {
                if (cbox_Interview_Report_Purpose.Checked == true)
                {
                    tbox_Report_Purpose.Text = "Interview";
                    tbox_Report_Purpose.Enabled = false;
                }
                else
                {
                    tbox_Report_Purpose.Text = string.Empty;
                    tbox_Report_Purpose.Enabled = true;
                }
            }
        }
        /// <summary>
        /// Ins the form inter office visitor validate.
        /// </summary>
        /// <returns></returns>
        private int inFormInterOfficeVisitorValidate()
        {
            int result = 0;

            if (tbox_InterOffce_Employee_Id.Text == string.Empty)
            {
                lbl_InterOffce_Employee_Id.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_InterOffce_Employee_Id.ForeColor = System.Drawing.Color.Black;
            }

            if (tbox_InterOffce_Employee_Name.Text == string.Empty)
            {
                lbl_InterOffce_Employee_Name.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_InterOffce_Employee_Name.ForeColor = System.Drawing.Color.Black;
            }

            if (tbox_InterOffce_Comming_From.Text == string.Empty)
            {
                lbl_InterOffce_Comming_From.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_InterOffce_Comming_From.ForeColor = System.Drawing.Color.Black;
            }

            if (tbox_InterOffce_Contact_Number.Text == string.Empty)
            {
                lbl_InterOffce_Contact_Number.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_InterOffce_Contact_Number.ForeColor = System.Drawing.Color.Black;
            }

            if (tbox_InterOffce_Badge_Number.Text == string.Empty)
            {
                lbl_InterOffce_Badge_Number.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_InterOffce_Badge_Number.ForeColor = System.Drawing.Color.Black;
            }

            if (tbox_InterOffce_Access_Card_Number.Text == string.Empty)
            {
                lbl_InterOffce_Access_Card_Number.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_InterOffce_Access_Card_Number.ForeColor = System.Drawing.Color.Black;
            }

            if (tbox_InterOffce_No_Of_Days.Text == string.Empty)
            {
                lbl_InterOffce_No_Of_Days.ForeColor = System.Drawing.Color.Red;
                result++;
            }
            else
            {
                lbl_InterOffce_No_Of_Days.ForeColor = System.Drawing.Color.Black;
            }
            return result;
        }
        /// <summary>
        /// Inserts the inter office visitor details.
        /// </summary>
        private void insertInterOfficeVisitorDetails()
        {
            if (DatabaseOperation.insertDetailsWithDoublePicture("INSERT INTO tbl_Inter_Office_Visitor (Employee_Id,Employee_Name,Comming_From,Contact_Number,Assign_Date,Remarks,Badge_Number,Access_Card_Number,Issueing_Time,No_Of_Days,Employee_Image,Employee_Signeture) VALUES ('" + tbox_InterOffce_Employee_Id.Text + "','" + tbox_InterOffce_Employee_Name.Text + "','" + tbox_InterOffce_Comming_From.Text + "','" + tbox_InterOffce_Contact_Number.Text + "','" + tbox_InterOffce_Date.Text + "','" + tbox_InterOffce_Remarks.Text + "','" + tbox_InterOffce_Badge_Number.Text + "','" + tbox_InterOffce_Access_Card_Number.Text + "','" + tbox_InterOffce_Issuing_Time.Text + "','" + tbox_InterOffce_No_Of_Days.Text + "',@Employee_Image,@Employee_Signeture)", ref pBox_Inter_Office_Image, "@Employee_Image", ref pBox_Inter_Office_Signeture, "@Employee_Signeture") > 0)
            {
                MessageBox.Show("Details Captured", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Details Not Captured", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }
        /// <summary>
        /// Imports the employee.
        /// </summary>
        private void importEmployee()
        {
            if (tbox_Browse.Text == string.Empty)
            {
                bg_Worker_ImportEmployee.ReportProgress(0, string.Format("No file selected."));
                bg_Worker_ImportEmployee.ReportProgress(0, string.Format("Complete with no Data Upload"));
                btn_Start.Enabled = true;
                return;
            }

            bg_Worker_ImportEmployee.ReportProgress(0, string.Format("Opening the file."));
            if (ExcelUtlity.noOfSheetCounter(tbox_Browse.Text) > 1)
            {
                bg_Worker_ImportEmployee.ReportProgress(0, string.Format("Checking the number of sheets in the selected file."));
                frm_SheetSelector ss = new frm_SheetSelector(ExcelUtlity.sheetNames(tbox_Browse.Text));
                ss.ShowDialog();
            }
            else
            {
                sheetName = ExcelUtlity.sheetNames(tbox_Browse.Text)[0].ToString();
            }

            int rowcount = ExcelUtlity.noOfRowsCounter(tbox_Browse.Text, sheetName);
            maxValProgressBar = rowcount;
            string connectionString = "";
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=Yes'";
            connectionString = String.Format(connectionString, tbox_Browse.Text);
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            DataTable allData = new DataTable();
            cmd.Connection = conn;
            conn.Open();
            DataTable dtSchema;
            dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string ExcelSheetName = dtSchema.Rows[0]["TABLE_NAME"].ToString();
            conn.Close();
            conn.Open();
            cmd.CommandText = "SELECT * From [" + ExcelSheetName + "]";
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(allData);
            allData.Columns.Add("IsCorrect", typeof(System.Int32));
            int rows = 0;
            bg_Worker_ImportEmployee.ReportProgress(0, string.Format("Validating the data."));
            foreach (DataRow r in allData.Rows)
            {
                if (allData.Rows[rows][0].ToString().Equals("") || allData.Rows[rows][1].ToString().Equals("") || allData.Rows[rows][2].ToString().Equals("") || allData.Rows[rows][3].ToString().Equals(""))
                {
                    r["IsCorrect"] = 0;
                }
                if (!allData.Rows[rows][0].ToString().Equals("") && !allData.Rows[rows][1].ToString().Equals("") && !allData.Rows[rows][2].ToString().Equals("") && !allData.Rows[rows][3].ToString().Equals(""))
                {
                    r["IsCorrect"] = 1;
                }
                rows++;
            }
            bg_Worker_ImportEmployee.ReportProgress(0, string.Format("Prepareing data to write to database."));
            WriteToAccess(allData.AsEnumerable().Where(row => row.Field<int>("IsCorrect") == 1).CopyToDataTable(), rowcount, tbox_Browse.Text);
            validRows = rowcount - allData.AsEnumerable().Where(row => row.Field<int>("IsCorrect") == 0).CopyToDataTable().Rows.Count;
            ExcelUtlity.WriteDataTableToExcelForFixedData(allData.AsEnumerable().Where(row => row.Field<int>("IsCorrect") == 0).CopyToDataTable(), "Employee Details", tbox_Browse.Text.Substring(0, tbox_Browse.Text.LastIndexOf('.')) + "_Incorrect.xlsx", ref bg_Worker_ImportEmployee, pgBar_Import_Progress.Value, rowcount - 1);
            conn.Close();
        }
        /// <summary>
        /// Backups the database.
        /// </summary>
        private void backupDatabase()
        {
            ////string xmlTags = "";
            var t = new Thread((ThreadStart)(() =>
            {
                fbDlg_Backup_Database.ShowNewFolderButton = false;
                DialogResult dr = fbDlg_Backup_Database.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    backupSuccessful = false;
                    return;
                }

                if (dr == DialogResult.OK)
                {
                    backUpDatabaseLocation = fbDlg_Backup_Database.SelectedPath;
                    bg_Worker_BackupDatabase.ReportProgress(5, string.Format("Getting the source database"));
                    string src = Encrypter.Decrypt(RegManager.getKey("data source"), true);
                    bg_Worker_BackupDatabase.ReportProgress(5, string.Format("Creating the destination database"));
                    string dst = backUpDatabaseLocation + "/Backup_" + DateTime.Now.ToString("dd MMMM yyyy hh-mm-ss");
                    bg_Worker_BackupDatabase.ReportProgress(5, string.Format("Copying database started"));
                    System.IO.File.Copy(src, dst, true);
                    bg_Worker_BackupDatabase.ReportProgress(5, string.Format("Copying database finished"));
                    RegManager.updateKey("backupdatetime", DateTime.Now.ToString("dd MMM yyyy hh:mm:ss tt"));
                    processBackupAndOriginalDatabase(src, dst);
                }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            #region comment

                ////con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
                ////con.Open();
                ////DataTable userTables = con.GetSchema("Tables");
                ////con.Close();
                ////xmlTags = xmlTags + "<Backups>";
                ////foreach (DataRow dt in userTables.Rows)
                ////{
                ////    if (dt["TABLE_NAME"].ToString().StartsWith("tbl_"))
                ////    {
                ////        cmd = new OleDbCommand("SELECT * FROM " + dt["TABLE_NAME"].ToString(), con);
                ////        con.Open();
                ////        OleDbDataReader data = cmd.ExecuteReader();
                ////        DataTable schemaTable = data.GetSchemaTable();
                ////        while (data.Read())
                ////        {
                ////            xmlTags = xmlTags + "<" + dt["TABLE_NAME"].ToString() + ">";
                ////            for (int i = 0; i < schemaTable.Rows.Count; i++)
                ////            {
                ////                xmlTags = xmlTags + "<" + schemaTable.Rows[i][0] + ">" + data[i].ToString() + "</" + schemaTable.Rows[i][0] + ">";
                ////            }
                ////            xmlTags = xmlTags + "</" + dt["TABLE_NAME"].ToString() + ">";
                ////        }
                ////        con.Close();
                ////    }
                ////}
                ////xmlTags = xmlTags + "</Backups>";

                #endregion comment
        }
        /// <summary>
        /// Restores the database.
        /// </summary>
        private void RestoreDatabase()
        {
            var t = new Thread((ThreadStart)(() =>
            {
                opFlDlg_SelectFile.Title = "Select the backup file";
                DialogResult dr = opFlDlg_SelectFile.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    backupSuccessful = false;
                    return;
                }
                if (dr == DialogResult.OK)
                {
                    restoreFrom = opFlDlg_SelectFile.FileName;
                    OleDbConnection srcCon = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + ";OLE DB Services=-4; data source=" + restoreFrom);
                    try
                    {
                        using (TransactionScope scope = new TransactionScope())
                        {
                            srcCon.Open();
                            DataTable userTables = srcCon.GetSchema("Tables");
                            foreach (DataRow dt in userTables.Rows)
                            {
                                if (dt["TABLE_NAME"].ToString().StartsWith("tbl_"))
                                {
                                    var cmd = new OleDbCommand();
                                    cmd.Connection = srcCon;
                                    cmd.CommandType = System.Data.CommandType.Text;
                                    cmd.CommandText = "INSERT INTO " + dt["TABLE_NAME"].ToString() + " IN '" + Encrypter.Decrypt(RegManager.getKey("data source"), true) + "' SELECT * FROM " + dt["TABLE_NAME"].ToString();
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            scope.Complete();
                        }
                        restoreSuccessful = true;
                    }
                    catch (Exception ex)
                    {
                        restoreSuccessful = false;
                        MessageBox.Show("Operation Failed due to : " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        srcCon.Close();
                    }
                }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }
        /// <summary>
        /// Writes to access.
        /// </summary>
        /// <param name="dt">The dt.</param>
        /// <param name="rowcount">The rowcount.</param>
        private void WriteToAccess(DataTable dt, int rowcount, string fileName)
        {
            int j = 1;
            con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
            string cmdText = "Insert into tbl_Employee_Details (Employee_Id,Employee_Name,Employee_Email,Extension,Personal_Mobile,Personal_Email,Official_Mobile,Department,Company,Current_Manager_Name,Current_Manager_Employee_Id,Location,Active) Values (?,?,?,?,?,?,?,?,?,?,?,?,?)";
            con.Open();
            OleDbTransaction transaction = con.BeginTransaction();
            OleDbCommand cmd = new OleDbCommand(cmdText, con, transaction);
            using (con)
            {
                try
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        int i = 0;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("?", r[i++].ToString().Trim());
                        cmd.Parameters.AddWithValue("?", r[i++].ToString().Trim());
                        cmd.Parameters.AddWithValue("?", r[i++].ToString().Trim());
                        cmd.Parameters.AddWithValue("?", r[i++].ToString().Trim());
                        cmd.Parameters.AddWithValue("?", r[i++].ToString().Trim());
                        cmd.Parameters.AddWithValue("?", r[i++].ToString().Trim());
                        cmd.Parameters.AddWithValue("?", r[i++].ToString().Trim());
                        cmd.Parameters.AddWithValue("?", r[i++].ToString().Trim());
                        cmd.Parameters.AddWithValue("?", r[i++].ToString().Trim());
                        cmd.Parameters.AddWithValue("?", r[i++].ToString().Trim());
                        cmd.Parameters.AddWithValue("?", r[i++].ToString().Trim());
                        cmd.Parameters.AddWithValue("?", r[i++].ToString().Trim());
                        cmd.Parameters.AddWithValue("?", 1);
                        cmd.ExecuteNonQuery();
                        j++;
                        bg_Worker_ImportEmployee.ReportProgress((int)Math.Ceiling((float)j / rowcount), string.Format("Completed -" + (j - 1).ToString() + "/" + (rowcount - 1).ToString()));
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Operation Failed due to : " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Validates the search critaria.
        /// </summary>
        /// <param name="from">From.</param>
        /// <returns></returns>
        private bool validateSearchCritaria(int from, ref TextBox EmployeeId, ref TextBox EmployeeName, ref TextBox EmployeeEmail, ref TextBox EmployeeDeskPhone, ref Label EmployeeIdLabel, ref Label EmployeeNameLabel, ref Label EmployeeEmailLabel, ref Label EmployeeDeskPhoneLabel, ref Label ErrorLabel)
        {
            if (EmployeeId.Text == string.Empty && EmployeeName.Text == string.Empty && EmployeeEmail.Text == string.Empty && EmployeeDeskPhone.Text == string.Empty)
            {
                ErrorLabel.Text = "Kindly provide atleast one search criteria";
                EmployeeIdLabel.ForeColor = System.Drawing.Color.Red;
                EmployeeNameLabel.ForeColor = System.Drawing.Color.Red;
                EmployeeEmailLabel.ForeColor = System.Drawing.Color.Red;
                EmployeeDeskPhoneLabel.ForeColor = System.Drawing.Color.Red;
                return true;
            }
            else
            {
                ErrorLabel.Text = string.Empty;
                EmployeeIdLabel.ForeColor = System.Drawing.Color.Black;
                EmployeeNameLabel.ForeColor = System.Drawing.Color.Black;
                EmployeeEmailLabel.ForeColor = System.Drawing.Color.Black;
                EmployeeDeskPhoneLabel.ForeColor = System.Drawing.Color.Black;
                return false;
            }
        }
        /// <summary>
        /// Resets the employee form.
        /// </summary>
        private void resetEmployeeForm()
        {
            tbox_Browse.Text = string.Empty;
            tbox_Id.Text = string.Empty;
            tbox_ManageEmployee_EmployeeId.Text = string.Empty;
            tbox_ManageEmployee_EmployeeName.Text = string.Empty;
            tbox_ManageEmployee_EmployeeEmail.Text = string.Empty;
            tbox_ManageEmployee_EmployeeExtection.Text = string.Empty;
            tbox_ManageEmployee_EmployeeId.Enabled = true;
            tbox_ManageEmployee_EmployeeName.Enabled = true;
            tbox_ManageEmployee_EmployeeEmail.Enabled = true;
            tbox_ManageEmployee_EmployeeExtection.Enabled = true;
            tbox_ManageEmployee_EmployeePersonalMobile.Text = string.Empty;
            tbox_ManageEmployee_EmployeePersonalEmail.Text = string.Empty;
            tbox_ManageEmployee_EmployeeOfficialMobile.Text = string.Empty;
            tbox_ManageEmployee_EmployeeDepartment.Text = string.Empty;
            tbox_ManageEmployee_EmployeeCompany.Text = string.Empty;
            tbox_ManageEmployee_EmployeeManager.Text = string.Empty;
            tbox_ManageEmployee_EmployeeManagerId.Text = string.Empty;
            tbox_ManageEmployee_EmployeeLocation.Text = string.Empty;
            rdBtn_EmployeeActive.Checked = false;
            rdBtn_EmployeeInActive.Checked = false;
            lbl_Error.Text = string.Empty;
            lbl_ManageEmployee_EmployeeId.ForeColor = System.Drawing.Color.Black;
            lbl_ManageEmployee_EmployeeName.ForeColor = System.Drawing.Color.Black;
            lbl_ManageEmployee_EmployeeEmail.ForeColor = System.Drawing.Color.Black;
            lbl_ManageEmployee_EmployeeExtection.ForeColor = System.Drawing.Color.Black;
        }
        /// <summary>
        /// Makes the inactive.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="EmployeeId">The employee identifier.</param>
        /// <param name="EmployeeName">Name of the employee.</param>
        /// <param name="EmployeeEmail">The employee email.</param>
        /// <param name="EmployeeDeskPhone">The employee desk phone.</param>
        private void makeInactive(int from, ref TextBox EmployeeId, ref TextBox EmployeeName, ref TextBox EmployeeEmail, ref TextBox EmployeeDeskPhone)
        {
            if (from == 0)
            {
                if (EmployeeId.Text != string.Empty && EmployeeName.Text != string.Empty && EmployeeEmail.Text != string.Empty && EmployeeDeskPhone.Text != string.Empty)
                {
                    EmployeeId.Enabled = false;
                    EmployeeName.Enabled = false;
                    EmployeeEmail.Enabled = false;
                    EmployeeDeskPhone.Enabled = false;
                }
                else
                {
                    EmployeeId.Enabled = true;
                    EmployeeName.Enabled = true;
                    EmployeeEmail.Enabled = true;
                    EmployeeDeskPhone.Enabled = true;
                }
            }
            if (from == 1 || from == 2)
            {

                if (EmployeeId.Text != string.Empty || EmployeeName.Text != string.Empty || EmployeeEmail.Text != string.Empty || EmployeeDeskPhone.Text != string.Empty)
                {
                    EmployeeId.Enabled = false;
                    EmployeeName.Enabled = false;
                    EmployeeEmail.Enabled = false;
                    EmployeeDeskPhone.Enabled = false;
                    if (from == 1)
                    {
                        btn_Med_Emp_Search.Enabled = false;
                    }
                    else if(from == 2)
                    {
                        btn_Key_Emp_Search.Enabled = false;
                    }
                }
            }
        }
        /// <summary>
        /// Resets the emp data.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="EmployeeId">The employee identifier.</param>
        /// <param name="EmployeeName">Name of the employee.</param>
        /// <param name="EmployeeEmail">The employee email.</param>
        /// <param name="EmployeeDeskPhone">The employee desk phone.</param>
        /// <param name="EmployeeIdLabel">The employee identifier label.</param>
        /// <param name="EmployeeNameLabel">The employee name label.</param>
        /// <param name="EmployeeEmailLabel">The employee email label.</param>
        /// <param name="EmployeeDeskPhoneLabel">The employee desk phone label.</param>
        /// <param name="ErrorLabel">The error label.</param>
        /// <param name="SearchButton">The search button.</param>
        private void resetEmpData(int from, ref TextBox EmployeeId, ref TextBox EmployeeName, ref TextBox EmployeeEmail, ref TextBox EmployeeDeskPhone, ref Label EmployeeIdLabel, ref Label EmployeeNameLabel, ref Label EmployeeEmailLabel, ref Label EmployeeDeskPhoneLabel, ref Label ErrorLabel, ref Button SearchButton)
        {
            EmployeeId.Text = string.Empty;
            EmployeeName.Text = string.Empty;
            EmployeeEmail.Text = string.Empty;
            EmployeeDeskPhone.Text = string.Empty;
            EmployeeId.Enabled = true;
            EmployeeName.Enabled = true;
            EmployeeEmail.Enabled = true;
            EmployeeDeskPhone.Enabled = true;
            SearchButton.Enabled = true;
            ErrorLabel.Text = string.Empty;
            EmployeeIdLabel.ForeColor = System.Drawing.Color.Black;
            EmployeeNameLabel.ForeColor = System.Drawing.Color.Black;
            EmployeeEmailLabel.ForeColor = System.Drawing.Color.Black;
            EmployeeDeskPhoneLabel.ForeColor = System.Drawing.Color.Black;
            if (from == 1)
            {
                cbox_Non_Employee_Medicine_Distribution.Checked = false;
            }
        }
        /// <summary>
        /// Populates the employee data.
        /// </summary>
        /// <param name="resultQuery">The result query.</param>
        /// <param name="from">From.</param>
        /// <param name="EmployeeId">The employee identifier.</param>
        /// <param name="EmployeeName">Name of the employee.</param>
        /// <param name="EmployeeEmail">The employee email.</param>
        /// <param name="EmployeeDeskPhone">The employee desk phone.</param>
        private void populateEmployeeData(string resultQuery, int from, ref TextBox EmployeeId, ref TextBox EmployeeName, ref TextBox EmployeeEmail, ref TextBox EmployeeDeskPhone)
        {
            con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
            try
            {
                using (con)
                {
                    if (from == 0)
                    {
                        adapter = new OleDbDataAdapter(resultQuery, con);
                        ds = new DataSet();
                        adapter.Fill(ds, "tbl_Employee_Details");
                        employeeData.Clear();
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            tbox_Id.Text = ds.Tables[0].Rows[0][0].ToString();
                            employeeData.Add("Id", ds.Tables[0].Rows[0][0].ToString());
                            EmployeeId.Text = ds.Tables[0].Rows[0][1].ToString();
                            employeeData.Add("Employee_Id", ds.Tables[0].Rows[0][1].ToString());
                            EmployeeName.Text = ds.Tables[0].Rows[0][2].ToString();
                            employeeData.Add("Employee_Name", ds.Tables[0].Rows[0][2].ToString());
                            EmployeeEmail.Text = ds.Tables[0].Rows[0][3].ToString();
                            employeeData.Add("Employee_Email", ds.Tables[0].Rows[0][3].ToString());
                            EmployeeDeskPhone.Text = ds.Tables[0].Rows[0][4].ToString();
                            employeeData.Add("Extension", ds.Tables[0].Rows[0][4].ToString());
                            tbox_ManageEmployee_EmployeePersonalMobile.Text = ds.Tables[0].Rows[0][5].ToString();
                            employeeData.Add("Personal_Mobile", ds.Tables[0].Rows[0][5].ToString());
                            tbox_ManageEmployee_EmployeePersonalEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                            employeeData.Add("Personal_Email", ds.Tables[0].Rows[0][6].ToString());
                            tbox_ManageEmployee_EmployeeOfficialMobile.Text = ds.Tables[0].Rows[0][7].ToString();
                            employeeData.Add("Official_Mobile", ds.Tables[0].Rows[0][7].ToString());
                            tbox_ManageEmployee_EmployeeDepartment.Text = ds.Tables[0].Rows[0][8].ToString();
                            employeeData.Add("Department", ds.Tables[0].Rows[0][8].ToString());
                            tbox_ManageEmployee_EmployeeCompany.Text = ds.Tables[0].Rows[0][9].ToString();
                            employeeData.Add("Company", ds.Tables[0].Rows[0][9].ToString());
                            tbox_ManageEmployee_EmployeeManager.Text = ds.Tables[0].Rows[0][10].ToString();
                            employeeData.Add("Current_Manager_Name", ds.Tables[0].Rows[0][10].ToString());
                            tbox_ManageEmployee_EmployeeManagerId.Text = ds.Tables[0].Rows[0][11].ToString();
                            employeeData.Add("Current_Manager_Employee_Id", ds.Tables[0].Rows[0][11].ToString());
                            tbox_ManageEmployee_EmployeeLocation.Text = ds.Tables[0].Rows[0][12].ToString();
                            employeeData.Add("Location", ds.Tables[0].Rows[0][12].ToString());
                            if (ds.Tables[0].Rows[0][13].ToString() == "True")
                            {
                                rdBtn_EmployeeActive.Checked = true;
                            }
                            else
                            {
                                rdBtn_EmployeeInActive.Checked = true;
                            }
                            employeeData.Add("Active", ds.Tables[0].Rows[0][13].ToString());
                            makeInactive(0, ref  EmployeeId, ref  EmployeeName, ref  EmployeeEmail, ref  EmployeeDeskPhone);
                        }
                        else
                        {
                            MessageBox.Show("No Employee found!", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (from == 1 || from == 2)
                    {
                        adapter = new OleDbDataAdapter(resultQuery, con);
                        ds = new DataSet();
                        adapter.Fill(ds, "tbl_Employee_Details");
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            EmployeeId.Text = ds.Tables[0].Rows[0][1].ToString();
                            EmployeeName.Text = ds.Tables[0].Rows[0][2].ToString();
                            EmployeeEmail.Text = ds.Tables[0].Rows[0][3].ToString();
                            EmployeeDeskPhone.Text = ds.Tables[0].Rows[0][4].ToString();
                            makeInactive(from, ref EmployeeId, ref EmployeeName, ref EmployeeEmail, ref EmployeeDeskPhone);
                        }
                        else
                        {
                            MessageBox.Show("No Employee found!", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to the database failed " + ex, "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Searches the employee.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="EmployeeId">The employee identifier.</param>
        /// <param name="EmployeeName">Name of the employee.</param>
        /// <param name="EmployeeEmail">The employee email.</param>
        /// <param name="EmployeeDeskPhone">The employee desk phone.</param>
        /// <param name="EmployeeIdLabel">The employee identifier label.</param>
        /// <param name="EmployeeNameLabel">The employee name label.</param>
        /// <param name="EmployeeEmailLabel">The employee email label.</param>
        /// <param name="EmployeeDeskPhoneLabel">The employee desk phone label.</param>
        /// <param name="ErrorLabel">The error label.</param>
        private void searchEmployee(int from, ref TextBox EmployeeId, ref TextBox EmployeeName, ref TextBox EmployeeEmail, ref TextBox EmployeeDeskPhone, ref Label EmployeeIdLabel, ref Label EmployeeNameLabel, ref Label EmployeeEmailLabel, ref Label EmployeeDeskPhoneLabel, ref Label ErrorLabel)
        {
            string resultQuery = "SELECT * FROM tbl_Employee_Details";
            bool validateFrom = validateSearchCritaria(from, ref EmployeeId, ref  EmployeeName, ref  EmployeeEmail, ref  EmployeeDeskPhone, ref EmployeeIdLabel, ref EmployeeNameLabel, ref EmployeeEmailLabel, ref EmployeeDeskPhoneLabel, ref ErrorLabel);
            if (validateFrom != true)
            {
                bool whereFlag = false;
                if (EmployeeId.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Employee_Id = '" + EmployeeId.Text + "'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Employee_Id = '" + EmployeeId.Text + "'";
                    }
                }
                if (EmployeeName.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Employee_Name = '" + EmployeeName.Text + "'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Employee_Name = '" + EmployeeName.Text + "'";
                    }
                }
                if (EmployeeEmail.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Employee_Email = '" + EmployeeEmail.Text + "'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Employee_Email = '" + EmployeeEmail.Text + "'";
                    }
                }
                if (tbox_ManageEmployee_EmployeeExtection.Text != string.Empty)
                {
                    if (whereFlag == false)
                    {
                        resultQuery = resultQuery + " WHERE Extension = '" + EmployeeDeskPhone.Text + "'";
                        whereFlag = true;
                    }
                    else
                    {
                        resultQuery = resultQuery + " AND Extension = '" + EmployeeDeskPhone.Text + "'";
                    }
                }
                populateEmployeeData(resultQuery, from, ref EmployeeId, ref  EmployeeName, ref  EmployeeEmail, ref  EmployeeDeskPhone);
            }
        }
        /// <summary>
        /// Resets the med medcine data.
        /// </summary>
        private void resetMedMedcineData()
        {
            tbox_Med_Medcine_Name.Text = string.Empty;
            tbox_Med_Medcine_Quantity.Text = string.Empty;
            lbl_medNameChecker.Text = string.Empty;
            //pBox_Medcine_Signeture.Image = null;
        }
        /// <summary>
        /// Meds the stock validator.
        /// </summary>
        private void medStockValidator()
        {
            int? stock = medicineStockCounter(tbox_Med_Medcine_Name.Text);
            if (stock != null)
            {
                lbl_medNameChecker.Text = string.Empty;
                Regex regex = new Regex(@"[^0-9]");
                MatchCollection matches = regex.Matches(tbox_Med_Medcine_Quantity.Text);
                if (matches.Count > 0)
                {
                    lbl_medStockCounter.Text = "Only digits are allowed!";
                    if (tbox_Med_Medcine_Quantity.Text.Length > 0)
                    {
                        tbox_Med_Medcine_Quantity.Text = tbox_Med_Medcine_Quantity.Text.Substring(0, tbox_Med_Medcine_Quantity.Text.Length - 1);
                        int textLength = tbox_Med_Medcine_Quantity.Text.Length;
                        tbox_Med_Medcine_Quantity.SelectionStart = textLength;
                        tbox_Med_Medcine_Quantity.SelectionLength = 0;
                    }
                    frm_Main.medValidationPassed = false;
                    tbox_Med_Medcine_Updated_Stock.Text = string.Empty;
                }
                else
                {
                    lbl_medStockCounter.Text = string.Empty;
                    if (tbox_Med_Medcine_Quantity.Text != string.Empty)
                    {
                        if (tbox_Med_Medcine_Quantity.Text == "0")
                        {
                            lbl_medStockCounter.Text = "Cannot assign 0 nos.";
                            frm_Main.medValidationPassed = false;
                            tbox_Med_Medcine_Updated_Stock.Text = string.Empty;
                        }
                        else if (int.Parse(tbox_Med_Medcine_Quantity.Text) > stock)
                        {
                            lbl_medStockCounter.Text = "Cannot assign " + tbox_Med_Medcine_Quantity.Text + " nos. Stock is " + stock + " nos.";
                            frm_Main.medValidationPassed = false;
                            tbox_Med_Medcine_Updated_Stock.Text = string.Empty;
                        }
                        else
                        {
                            lbl_medStockCounter.Text = string.Empty;
                            frm_Main.medValidationPassed = true;
                            tbox_Med_Medcine_Updated_Stock.Text = (medicineStockCounter(tbox_Med_Medcine_Name.Text) - int.Parse(tbox_Med_Medcine_Quantity.Text)).ToString();
                        }
                    }
                    else
                    {
                        lbl_medStockCounter.Text = string.Empty;
                        frm_Main.medValidationPassed = false;
                        tbox_Med_Medcine_Updated_Stock.Text = string.Empty;
                    }
                }
            }
            else
            {
                lbl_medNameChecker.Text = "Please check the medicine name.";
            }
        }
        /// <summary>
        /// Medicines the stock counter.
        /// </summary>
        /// <param name="medcineName">Name of the medcine.</param>
        /// <returns></returns>
        private int? medicineStockCounter(string medcineName)
        {
            con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
            int? stockCount = null;
            try
            {
                using (con)
                {
                    adapter = new OleDbDataAdapter("SELECT Stock_Quantity FROM tbl_Medicine_Details WHERE Medicine_Name = '" + medcineName + "'", con);
                    ds = new DataSet();
                    adapter.Fill(ds, "tbl_Medicine_Details");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        stockCount = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    }
                }
                return stockCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to the database failed " + ex, "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return stockCount;
            }
        }
        /// <summary>
        /// Inserts the med assinment.
        /// </summary>
        /// <param name="stat">if set to <c>true</c> [stat].</param>
        private void insertMedAssinment(bool stat)
        {
            int result;
            if (stat == false)
            {
                result = DatabaseOperation.insertDetailsWithTransactionAndSinglePicture("INSERT INTO tbl_Medicine_Distrubution ( Employee_Id,Employee_Name,Employee_Email,Desk_Phone,Medcine_Name,Quantity,Date_Assign,Signature_Employee) VALUES (" + tbox_Med_Emp_Id.Text + ",'" + tbox_Med_Emp_Name.Text + "','" + tbox_Med_Emp_Email.Text + "','" + tbox_Med_Emp_Desk_Phone.Text + "','" + tbox_Med_Medcine_Name.Text + "','" + tbox_Med_Medcine_Quantity.Text + "','" + DateTime.Now.ToString("dd MMMM yyyy") + "',@Employee_Signeture)", "UPDATE tbl_Medicine_Details SET Stock_Quantity='" + tbox_Med_Medcine_Updated_Stock.Text + "' WHERE Medicine_Name='" + tbox_Med_Medcine_Name.Text + "'", ref pBox_Medcine_Signeture, "@Employee_Signeture");
                if (result == 1)
                {
                    MessageBox.Show("Details Captured", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetEmpData(1, ref tbox_Med_Emp_Id, ref tbox_Med_Emp_Name, ref tbox_Med_Emp_Email, ref tbox_Med_Emp_Desk_Phone, ref lbl_Med_Emp_Id, ref lbl_Med_Emp_Name, ref lbl_Med_Emp_Email, ref lbl_Med_Emp_Desk_Phone, ref lbl_Med_Error, ref btn_Med_Emp_Search);
                    resetMedMedcineData();
                }
                if (result == 0)
                {
                    MessageBox.Show("Operation Failed", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (stat == true)
            {
                result = DatabaseOperation.insertDetailsWithTransactionAndSinglePicture("INSERT INTO tbl_Medicine_Distrubution ( Employee_Id,Employee_Name,Employee_Email,Desk_Phone,Medcine_Name,Quantity,Date_Assign,Signature_Employee) VALUES ( " + 00000 + " ,'" + tbox_Med_Emp_Name.Text + "','NON_EMPLOYEE_EMAIL','NON_EMPLOYEE_DESK_PHONE','" + tbox_Med_Medcine_Name.Text + "','" + tbox_Med_Medcine_Quantity.Text + "','" + DateTime.Now.ToString("dd MMMM yyyy") + "',@Employee_Signeture)", "UPDATE tbl_Medicine_Details SET Stock_Quantity='" + tbox_Med_Medcine_Updated_Stock.Text + "' WHERE Medicine_Name='" + tbox_Med_Medcine_Name.Text + "'", ref pBox_Medcine_Signeture, "@Employee_Signeture");
                if (result == 1)
                {
                    MessageBox.Show("Details Captured", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetEmpData(1, ref tbox_Med_Emp_Id, ref tbox_Med_Emp_Name, ref tbox_Med_Emp_Email, ref tbox_Med_Emp_Desk_Phone, ref lbl_Med_Emp_Id, ref lbl_Med_Emp_Name, ref lbl_Med_Emp_Email, ref lbl_Med_Emp_Desk_Phone, ref lbl_Med_Error, ref btn_Med_Emp_Search);
                    resetMedMedcineData();
                }
                if (result == 0)
                {
                    MessageBox.Show("Operation Failed", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Plots the graph.
        /// </summary>
        /// <param name="type">The type.</param>
        private void plotGraph(string type)
        {
            con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
            if (chrt_Medicine_Stock.ChartAreas.Count > 0)
            {
                chrt_Medicine_Stock.ChartAreas.Remove(chrt_Medicine_Stock.ChartAreas[0]);
                chrt_Medicine_Stock.Legends.Remove(chrt_Medicine_Stock.Legends["MedicineStock"]);
                chrt_Medicine_Stock.Series.Remove(chrt_Medicine_Stock.Series["Medicine Stock"]);
                chrt_Medicine_Stock.Series.Remove(chrt_Medicine_Stock.Series["Warning Limit"]);
            }

            chrt_Medicine_Stock.ChartAreas.Add("MedicineStock");
            chrt_Medicine_Stock.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chrt_Medicine_Stock.ChartAreas[0].AxisX.Title = "Medicine Name";
            chrt_Medicine_Stock.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chrt_Medicine_Stock.ChartAreas[0].AxisY.Title = "Stock";

            chrt_Medicine_Stock.Legends.Add("MedicineStock");
            chrt_Medicine_Stock.Legends["MedicineStock"].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;

            chrt_Medicine_Stock.Series.Add("Medicine Stock");
            chrt_Medicine_Stock.Series.Add("Warning Limit").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chrt_Medicine_Stock.Series["Medicine Stock"].IsValueShownAsLabel = true;
            chrt_Medicine_Stock.Series["Warning Limit"].IsValueShownAsLabel = true;

            lbl_GraphDataError.Visible = false;
            try
            {
                using (con)
                {
                    adapter = new OleDbDataAdapter("SELECT Medicine_Name,Stock_Quantity,Warning_Quantity FROM tbl_Medicine_Details WHERE Active=" + type, con);
                    ds = new DataSet();
                    adapter.Fill(ds);
                }
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    chrt_Medicine_Stock.Series["Medicine Stock"].Points.AddXY(dr[0].ToString(), dr[1]);
                    chrt_Medicine_Stock.Series["Warning Limit"].Points.AddXY(dr[0].ToString(), dr[2]);
                }
                chrt_Medicine_Stock.Visible = true;
            }
            catch (Exception ex)
            {
                chrt_Medicine_Stock.Visible = false;
                lbl_GraphDataError.Text = "There is some problem to plot the graph.";
                lbl_GraphDataError.Visible = true;
            }
        }
        /// <summary>
        /// Updates the medicine details.
        /// </summary>
        private void updateMedicineDetails()
        {
            if (tbox_ManageMedicineId.Text != string.Empty)
            {
                medicineUpdatedData.Add("Id", tbox_ManageMedicineId.Text.Trim());
                medicineUpdatedData.Add("Medicine_Name", tbox_ManageMedicine_UpdateMedicineName.Text.Trim());
                medicineUpdatedData.Add("Stock_Quantity", nemUD_ManageMedicine_UpdateMedicineStock.Value.ToString());
                medicineUpdatedData.Add("Warning_Quantity", nemUD_ManageMedicine_UpdateWarning.Value.ToString());

                if (rdBtn_MedicineActive.Checked == true)
                {
                    medicineUpdatedData.Add("Active", "True");
                }
                else
                {
                    medicineUpdatedData.Add("Active", "False");
                }

                bool equal = compareData(medicineData, medicineUpdatedData);

                medicineData.Clear();
                medicineUpdatedData.Clear();
                if (equal == true)
                {
                    MessageBox.Show("There is no changes in data to update", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool active;
                    if (rdBtn_MedicineActive.Checked == true)
                    {
                        active = true;
                    }
                    else
                    {
                        active = false;
                    }
                    if (DatabaseOperation.updateData("UPDATE tbl_Medicine_Details SET Medicine_Name  = '" + tbox_ManageMedicine_UpdateMedicineName.Text.Trim() + "',Stock_Quantity=" + nemUD_ManageMedicine_UpdateMedicineStock.Value + ",Warning_Quantity='" + nemUD_ManageMedicine_UpdateWarning.Value + "',Active=" + active + " WHERE Id =" + tbox_ManageMedicineId.Text + "") > 0)
                    {
                        MessageBox.Show("Record Updated", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Updation Failed", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        /// <summary>
        /// Resets the add medicine.
        /// </summary>
        private void resetAddMedicine()
        {
            lbl_ExistingMedicine.Text = string.Empty;
            tbox_ManageMedicine_InsertMedicineName.Text = string.Empty;
            nemUD_ManageMedicine_InsertMedicineStock.Value = nemUD_ManageMedicine_InsertMedicineStock.Minimum;
            nemUD_ManageMedicine_InsertWarning.Value = nemUD_ManageMedicine_InsertWarning.Minimum;
        }
        /// <summary>
        /// Resets the update medicine.
        /// </summary>
        private void resetUpdateMedicine()
        {
            tbox_ManageMedicineId.Text = string.Empty;
            tbox_ManageMedicine_UpdateMedicineName.Text = string.Empty;
            tbox_ManageMedicine_UpdateMedicineName.Enabled = true;
            nemUD_ManageMedicine_UpdateMedicineStock.Value = nemUD_ManageMedicine_UpdateMedicineStock.Minimum;
            nemUD_ManageMedicine_UpdateWarning.Value = nemUD_ManageMedicine_UpdateWarning.Minimum;
            rdBtn_MedicineActive.Checked = false; ;
            rdBtn_MedicineInActive.Checked = false;
        }
        /// <summary>
        /// Gets the existing medicine names.
        /// </summary>
        /// <returns></returns>
        private List<string> getExistingData(string query)
        {
            con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
            List<string> ExistingData = new List<string>();
            try
            {
                using (con)
                {
                    adapter = new OleDbDataAdapter(query, con);
                    ds = new DataSet();
                    adapter.Fill(ds);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ExistingData.Add(dr[0].ToString());
                    }
                }
                return ExistingData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to the database failed " + ex, "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return ExistingData;
            }
        }
        /// <summary>
        /// Gets the medicine details.
        /// </summary>
        private void getMedicineDetails()
        {
            con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
            try
            {
                using (con)
                {
                    adapter = new OleDbDataAdapter("SELECT Id,Medicine_Name,Stock_Quantity,Warning_Quantity,Active FROM tbl_Medicine_Details WHERE Medicine_Name = '" + tbox_ManageMedicine_UpdateMedicineName.Text + "'", con);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    medicineData.Clear();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        btn_ManageMedicine_Search.Enabled = false;
                        tbox_ManageMedicine_UpdateMedicineName.Enabled = false;

                        tbox_ManageMedicineId.Text = ds.Tables[0].Rows[0][0].ToString();
                        medicineData.Add("Id", ds.Tables[0].Rows[0][0].ToString());
                        medicineData.Add("Medicine_Name", ds.Tables[0].Rows[0][1].ToString());
                        nemUD_ManageMedicine_UpdateMedicineStock.Value = int.Parse(ds.Tables[0].Rows[0][2].ToString());
                        medicineData.Add("Stock_Quantity", ds.Tables[0].Rows[0][2].ToString());
                        nemUD_ManageMedicine_UpdateWarning.Value = int.Parse(ds.Tables[0].Rows[0][3].ToString());
                        medicineData.Add("Warning_Quantity", ds.Tables[0].Rows[0][3].ToString());
                        if (ds.Tables[0].Rows[0][4].ToString() == "True")
                        {
                            rdBtn_MedicineActive.Checked = true;
                        }
                        else
                        {
                            rdBtn_MedicineInActive.Checked = true;
                        }
                        medicineData.Add("Active", ds.Tables[0].Rows[0][4].ToString());
                    }
                    else
                    {
                        MessageBox.Show("No medicine found!", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to the database failed " + ex, "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Databases the size calculator.
        /// </summary>
        private void databaseSizeCalculator()
        {
            pgBar_Database_Size.Value = 0;
            FileInfo databseFile = new FileInfo(Encrypter.Decrypt(RegManager.getKey("data source"), true));
            int databseSize = Convert.ToInt32(databseFile.Length / 1048576);
            pgBar_Database_Size.Value = pgBar_Database_Size.Value + Convert.ToInt32((databseSize / 1000.0) * 100) > 100 ? 100 : pgBar_Database_Size.Value + Convert.ToInt32((databseSize / 1000.0) * 100);
            lbl_DatabaseSize.Text = databseSize.ToString() + "MB";
        }
        /// <summary>
        /// Pgs the bar color changer.
        /// </summary>
        private void pgBarColorChanger()
        {
            ModifyProgressBarColor.SetState(pgBar_Database_Size, 1);
            if (pgBar_Database_Size.Value >= 80 && pgBar_Database_Size.Value <= 89)
            {
                ModifyProgressBarColor.SetState(pgBar_Database_Size, 3);
            }
            if (pgBar_Database_Size.Value >= 90)
            {
                ModifyProgressBarColor.SetState(pgBar_Database_Size, 2);
            }
        }
        /// <summary>
        /// Processes the backup and original database.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <param name="dst">The DST.</param>
        private void processBackupAndOriginalDatabase(string src, string dst)
        {
            OleDbConnection dstCon = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + ";OLE DB Services=-4; data source=" + dst);
            OleDbConnection srcCon = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + ";OLE DB Services=-4; data source=" + src);
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (dstCon)
                    {
                        dstCon.Open();
                        bg_Worker_BackupDatabase.ReportProgress(16, string.Format("Processing Databackup!!!"));
                        cmd = new OleDbCommand("DROP TABLE tbl_Employee_Details", dstCon);
                        cmd.ExecuteNonQuery();
                        bg_Worker_BackupDatabase.ReportProgress(16, string.Format("Processing Databackup!!!"));
                        cmd = new OleDbCommand("DROP TABLE tbl_Medicine_Details", dstCon);
                        cmd.ExecuteNonQuery();

                        using (srcCon)
                        {
                            srcCon.Open();
                            bg_Worker_BackupDatabase.ReportProgress(16, string.Format("Processing Databackup!!!"));
                            cmd = new OleDbCommand("DELETE FROM tbl_Inter_Office_Visitor", srcCon);
                            cmd.ExecuteNonQuery();
                            bg_Worker_BackupDatabase.ReportProgress(16, string.Format("Processing Databackup!!!"));
                            cmd = new OleDbCommand("DELETE FROM tbl_Medicine_Distrubution", srcCon);
                            cmd.ExecuteNonQuery();
                            bg_Worker_BackupDatabase.ReportProgress(16, string.Format("Processing Databackup!!!"));
                            cmd = new OleDbCommand("DELETE FROM tbl_Visitor_details", srcCon);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    scope.Complete();
                }
                backupSuccessful = true;
            }
            catch (Exception ex)
            {
                backupSuccessful = false;
                MessageBox.Show("Operation Failed due to : " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Changes the label.
        /// </summary>
        /// <param name="stat">if set to <c>true</c> [stat].</param>
        private void changeLabel(bool stat)
        {
            if (stat == true)
            {
                tbox_Med_Emp_Id.Text = string.Empty;
                tbox_Med_Emp_Name.Text = string.Empty;
                tbox_Med_Emp_Email.Text = string.Empty;
                tbox_Med_Emp_Desk_Phone.Text = string.Empty;
                tbox_Med_Emp_Id.Enabled = stat;
                tbox_Med_Emp_Name.Enabled = true;
                tbox_Med_Emp_Email.Enabled = stat;
                tbox_Med_Emp_Desk_Phone.Enabled = stat;
                lbl_Med_Error.Text = string.Empty;
                lbl_Med_Emp_Id.ForeColor = System.Drawing.Color.Black;
                lbl_Med_Emp_Name.ForeColor = System.Drawing.Color.Black;
                lbl_Med_Emp_Email.ForeColor = System.Drawing.Color.Black;
                lbl_Med_Emp_Desk_Phone.ForeColor = System.Drawing.Color.Black;
                lbl_Med_Emp_Id.Enabled = stat;
                lbl_Med_Emp_Name.Text = "Employee Name : ";
                lbl_Med_Emp_Name.Location = new Point(25, 93);
                lbl_Med_Emp_Email.Enabled = stat;
                lbl_Med_Emp_Desk_Phone.Enabled = stat;
            }
            else if (stat == false)
            {
                tbox_Med_Emp_Id.Text = string.Empty;
                tbox_Med_Emp_Name.Text = string.Empty;
                tbox_Med_Emp_Email.Text = string.Empty;
                tbox_Med_Emp_Desk_Phone.Text = string.Empty;
                tbox_Med_Emp_Id.Enabled = stat;
                tbox_Med_Emp_Name.Enabled = true;
                tbox_Med_Emp_Email.Enabled = stat;
                tbox_Med_Emp_Desk_Phone.Enabled = stat;
                lbl_Med_Error.Text = string.Empty;
                lbl_Med_Emp_Id.ForeColor = System.Drawing.Color.Black;
                lbl_Med_Emp_Name.ForeColor = System.Drawing.Color.Black;
                lbl_Med_Emp_Email.ForeColor = System.Drawing.Color.Black;
                lbl_Med_Emp_Desk_Phone.ForeColor = System.Drawing.Color.Black;
                lbl_Med_Emp_Id.Enabled = stat;
                lbl_Med_Emp_Name.Text = "Name : ";
                lbl_Med_Emp_Name.Location = new Point(83, 93);
                lbl_Med_Emp_Email.Enabled = stat;
                lbl_Med_Emp_Desk_Phone.Enabled = stat;
            }
        }
        /// <summary>
        /// Resets the add pedistal.
        /// </summary>
        private void resetAddPedistal()
        {
            lbl_ExistingPedistal.Text = string.Empty;
            lbl_ManageKeys_InsertKeys_Select_Floor.Text = string.Empty;
            lbl_ManageKeys_InsertKeys_InsertKeysKeyNo.Text = string.Empty;
            tbox_ManageKeys_InsertKeysPedistalNo.Text = string.Empty;
            tbox_ManageKeys_InsertKeysKeyNo.Text = string.Empty;
            nemUD_ManageKeys_InsertKeys.Value = nemUD_ManageKeys_InsertKeys.Minimum;
            cbox_ManageKeys_InsertKeysWhichFloor.SelectedItem = "--------------------Select--------------------";
        }
        /// <summary>
        /// Resets the update pedstal.
        /// </summary>
        private void resetUpdatePedstal()
        {
            
        }
        /// <summary>
        /// Gets the pedistal details.
        /// </summary>
        private void getPedistalDetails()
        {
            con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
            try
            {
                using (con)
                {
                    adapter = new OleDbDataAdapter("SELECT Pedistal_No,Key_No,No_Of_Keys,Location,Active FROM tbl_Pedistal_Details WHERE Pedistal_No = '" + tbox_ManageKeys_UpdateKeysPedistalNo.Text + "'", con);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    pedistalData.Clear();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        btn_ManageKeys_Search_By_PedistalNo.Enabled = false;
                        tbox_ManageKeys_UpdateKeysPedistalNo.Enabled = false;

                        pedistalData.Add("Pedistal_No", ds.Tables[0].Rows[0][0].ToString());

                        tbox_ManageKeys_UpdateKeysKeyNo.Text = ds.Tables[0].Rows[0][1].ToString();
                        pedistalData.Add("Key_No", ds.Tables[0].Rows[0][1].ToString());

                        nemUD_ManageKeys_UpdateKeys.Value = int.Parse(ds.Tables[0].Rows[0][2].ToString());
                        pedistalData.Add("No_Of_Keys", ds.Tables[0].Rows[0][2].ToString());

                        cbox_ManageKeys_UpdateKeysWhichFloor.SelectedItem = ds.Tables[0].Rows[0][3].ToString();
                        pedistalData.Add("Which_Floor", ds.Tables[0].Rows[0][3].ToString());

                        if (ds.Tables[0].Rows[0][4].ToString() == "True")
                        {
                            rdBtn_PedistalActive.Checked = true;
                        }
                        else
                        {
                            rdBtn_PedistalInActive.Checked = true;
                        }
                        pedistalData.Add("Active", ds.Tables[0].Rows[0][4].ToString());
                    }
                    else
                    {
                        MessageBox.Show("No pedistal found!", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to the database failed " + ex, "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Updates the pedistal details.
        /// </summary>
        private void updatePedistalDetails()
        {
            if (tbox_ManageKeys_UpdateKeysPedistalNo.Enabled == false)
            {
                pedistalUpdatedData.Add("Pedistal_No", tbox_ManageKeys_UpdateKeysPedistalNo.Text.Trim());
                pedistalUpdatedData.Add("Key_No", tbox_ManageKeys_UpdateKeysKeyNo.Text.Trim());
                pedistalUpdatedData.Add("No_Of_Keys", nemUD_ManageKeys_UpdateKeys.Value.ToString());
                pedistalUpdatedData.Add("Which_Floor", cbox_ManageKeys_UpdateKeysWhichFloor.SelectedItem.ToString());

                if (rdBtn_PedistalActive.Checked == true)
                {
                    pedistalUpdatedData.Add("Active", "True");
                }
                else
                {
                    pedistalUpdatedData.Add("Active", "False");
                }

                bool equal = compareData(pedistalData, pedistalUpdatedData);
                
                pedistalData.Clear();
                pedistalUpdatedData.Clear();
                if (equal == true)
                {
                    MessageBox.Show("There is no changes in data to update", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool active;
                    if (rdBtn_PedistalActive.Checked == true)
                    {
                        active = true;
                    }
                    else
                    {
                        active = false;
                    }
                    if (DatabaseOperation.updateData("UPDATE tbl_Pedistal_Details SET Key_No ='" + tbox_ManageKeys_UpdateKeysKeyNo.Text.Trim() + "', No_Of_Keys=" + nemUD_ManageKeys_UpdateKeys.Value + ", Location='" + cbox_ManageKeys_UpdateKeysWhichFloor.SelectedItem + "', Active= " + active + " WHERE Pedistal_No = '" + tbox_ManageKeys_UpdateKeysPedistalNo.Text + "'") > 0)
                    {
                        MessageBox.Show("Record Updated", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Updation Failed", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        /// <summary>
        /// Compares the data.
        /// </summary>
        /// <param name="firstData">The first data.</param>
        /// <param name="secondData">The second data.</param>
        /// <returns></returns>
        private bool compareData(Dictionary<string, string> firstData, Dictionary<string, string> secondData)
        {
            bool equal = false;
            if (firstData.Count == secondData.Count) // Require equal count.
            {
                equal = true;
                foreach (var pair in firstData)
                {
                    string value;
                    if (secondData.TryGetValue(pair.Key, out value))
                    {
                        if (!value.Equals(pair.Value))
                        {
                            equal = false;
                        }
                    }
                    else
                    {
                        equal = true;
                    }
                }
            }
            return equal;
        }

        #endregion Function
    }
}
﻿namespace AssetManagement
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.sts_Strip = new System.Windows.Forms.StatusStrip();
            this.lbl_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_LoggedinUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmr_Asset_Timer = new System.Windows.Forms.Timer(this.components);
            this.tbCtrl_Asset_Manager = new System.Windows.Forms.TabControl();
            this.tb_Page_VisitorDetails = new System.Windows.Forms.TabPage();
            this.tbCtrl_Visitor_Details = new System.Windows.Forms.TabControl();
            this.tb_Page_VisitorDetails_InDetails = new System.Windows.Forms.TabPage();
            this.grpBx_InTimeSigneture = new System.Windows.Forms.GroupBox();
            this.pBox_Signeture = new System.Windows.Forms.PictureBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.grpBx_InTimeImage = new System.Windows.Forms.GroupBox();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.btn_Webcam = new System.Windows.Forms.Button();
            this.btn_TakeImage = new System.Windows.Forms.Button();
            this.pBox_Image = new System.Windows.Forms.PictureBox();
            this.grpBx_InTimeThingsAndIdentityDetails = new System.Windows.Forms.GroupBox();
            this.lbl_Visitor_In_Identity_Card_Number = new System.Windows.Forms.Label();
            this.tbox_In_Id_Proof = new System.Windows.Forms.TextBox();
            this.lbl_Visitor_In_Device_Carrying = new System.Windows.Forms.Label();
            this.tbox_In_Carrying_Laptop = new System.Windows.Forms.TextBox();
            this.grpBx_InTimeDetails = new System.Windows.Forms.GroupBox();
            this.cbox_Interview_Purpose = new System.Windows.Forms.CheckBox();
            this.cBox_Floor_Number = new System.Windows.Forms.ComboBox();
            this.lbl_Visitor_Floor_Number = new System.Windows.Forms.Label();
            this.tbox_In_Time = new System.Windows.Forms.TextBox();
            this.tbox_In_Whom_To_Meet = new System.Windows.Forms.TextBox();
            this.tbox_In_Remarks = new System.Windows.Forms.TextBox();
            this.tbox_In_Escort_Name = new System.Windows.Forms.TextBox();
            this.tbox_In_Badge_Number = new System.Windows.Forms.TextBox();
            this.tbox_In_Purpose = new System.Windows.Forms.TextBox();
            this.tbox_In_ContactNumber = new System.Windows.Forms.TextBox();
            this.tbox_In_Address = new System.Windows.Forms.TextBox();
            this.tbox_In_Name = new System.Windows.Forms.TextBox();
            this.lbl_Visitor_In_Remarks = new System.Windows.Forms.Label();
            this.lbl_Visitor_In_Time = new System.Windows.Forms.Label();
            this.lbl_Visitor_In_Escort_Name = new System.Windows.Forms.Label();
            this.lbl_Visitor_In_Badge_Number = new System.Windows.Forms.Label();
            this.lbl_Visitor_In_Whom_To_Meet = new System.Windows.Forms.Label();
            this.lbl_Visitor_In_Purpose = new System.Windows.Forms.Label();
            this.lbl_Visitor_In_Contact_Number = new System.Windows.Forms.Label();
            this.lbl_Visitor_In_Address = new System.Windows.Forms.Label();
            this.lbl_Visitor_In_Name = new System.Windows.Forms.Label();
            this.tb_Page_VisitorDetails_OutDetails = new System.Windows.Forms.TabPage();
            this.btn_Search = new System.Windows.Forms.Button();
            this.grpBx_OutTimeSigneture = new System.Windows.Forms.GroupBox();
            this.pBox_Out_Signeture = new System.Windows.Forms.PictureBox();
            this.btn_Out_Reset = new System.Windows.Forms.Button();
            this.btn_Out_Update = new System.Windows.Forms.Button();
            this.grpBx_OutTimeImage = new System.Windows.Forms.GroupBox();
            this.pBox_Out_Image = new System.Windows.Forms.PictureBox();
            this.grpBx_OutTimeThingsAndIdentityDetails = new System.Windows.Forms.GroupBox();
            this.lbl_Visitor_Out_Identity_Card_Number = new System.Windows.Forms.Label();
            this.tbox_Out_Id_Proof = new System.Windows.Forms.TextBox();
            this.lbl_Visitor_Out_Device_Carrying = new System.Windows.Forms.Label();
            this.tbox_Out_Carrying_Laptop = new System.Windows.Forms.TextBox();
            this.grpBx_OutTimeDetails = new System.Windows.Forms.GroupBox();
            this.cbox_Interview_Out_Purpose = new System.Windows.Forms.CheckBox();
            this.tbox_Out_Serial_Number = new System.Windows.Forms.TextBox();
            this.cBox_Out_Floor_Number = new System.Windows.Forms.ComboBox();
            this.lbl_Visitor_Out_Floor_Number = new System.Windows.Forms.Label();
            this.tbox_Out_Time = new System.Windows.Forms.TextBox();
            this.tbox_Out_Whom_To_Meet = new System.Windows.Forms.TextBox();
            this.tbox_Out_Remarks = new System.Windows.Forms.TextBox();
            this.tbox_Out_Escort_Name = new System.Windows.Forms.TextBox();
            this.tbox_Out_Badge_Number = new System.Windows.Forms.TextBox();
            this.tbox_Out_Purpose = new System.Windows.Forms.TextBox();
            this.tbox_Out_ContactNumber = new System.Windows.Forms.TextBox();
            this.tbox_Out_Address = new System.Windows.Forms.TextBox();
            this.tbox_Out_Name = new System.Windows.Forms.TextBox();
            this.lbl_Visitor_Out_Remarks = new System.Windows.Forms.Label();
            this.lbl_Visitor_Out_Time = new System.Windows.Forms.Label();
            this.lbl_Visitor_Out_Escort_Name = new System.Windows.Forms.Label();
            this.lbl_Visitor_Out_Badge_Number = new System.Windows.Forms.Label();
            this.lbl_Visitor_Out_Whom_To_Meet = new System.Windows.Forms.Label();
            this.lbl_Visitor_Out_Purpose = new System.Windows.Forms.Label();
            this.lbl_Visitor_Out_Contact_Number = new System.Windows.Forms.Label();
            this.lbl_Visitor_Out_Address = new System.Windows.Forms.Label();
            this.lbl_Visitor_Out_Name = new System.Windows.Forms.Label();
            this.tb_Page_InterOffice_Visitor = new System.Windows.Forms.TabPage();
            this.tbox_InterOffice_Serial_Number = new System.Windows.Forms.TextBox();
            this.btn_Inter_Office_Reset = new System.Windows.Forms.Button();
            this.btn_Assign = new System.Windows.Forms.Button();
            this.cbox_Inter_Update_Return_Details = new System.Windows.Forms.CheckBox();
            this.grpBx_Inter_Office_Return_Details = new System.Windows.Forms.GroupBox();
            this.btn_Inter_Office_Return = new System.Windows.Forms.Button();
            this.tbox_InterOffce_Return_Return_Time = new System.Windows.Forms.TextBox();
            this.lbl_InterOffce_Return_Return_Time = new System.Windows.Forms.Label();
            this.tbox_InterOffce_Return_Return_Date = new System.Windows.Forms.TextBox();
            this.lbl_InterOffce_Return_Return_Date = new System.Windows.Forms.Label();
            this.btn_Inter_Office_Search = new System.Windows.Forms.Button();
            this.tbox_InterOffce_Return_Employee_Id = new System.Windows.Forms.TextBox();
            this.lbl_InterOffce_Return_Employee_Id = new System.Windows.Forms.Label();
            this.grpBx_Inter_Office_Emp_Signeture_Details = new System.Windows.Forms.GroupBox();
            this.pBox_Inter_Office_Signeture = new System.Windows.Forms.PictureBox();
            this.grpBx_Inter_Office_Emp_Image_Details = new System.Windows.Forms.GroupBox();
            this.btn_Inter_Office_Stop = new System.Windows.Forms.Button();
            this.btn_Inter_Office_Continue = new System.Windows.Forms.Button();
            this.btn_Inter_Office_Webcam = new System.Windows.Forms.Button();
            this.btn_Inter_Office_Take_Picture = new System.Windows.Forms.Button();
            this.pBox_Inter_Office_Image = new System.Windows.Forms.PictureBox();
            this.grpBx_Inter_Office_Access_Card_Details = new System.Windows.Forms.GroupBox();
            this.tbox_InterOffce_Issuing_Time = new System.Windows.Forms.TextBox();
            this.tbox_InterOffce_No_Of_Days = new System.Windows.Forms.TextBox();
            this.lbl_InterOffce_No_Of_Days = new System.Windows.Forms.Label();
            this.lbl_InterOffce_Issuing_Time = new System.Windows.Forms.Label();
            this.tbox_InterOffce_Access_Card_Number = new System.Windows.Forms.TextBox();
            this.lbl_InterOffce_Access_Card_Number = new System.Windows.Forms.Label();
            this.tbox_InterOffce_Badge_Number = new System.Windows.Forms.TextBox();
            this.lbl_InterOffce_Badge_Number = new System.Windows.Forms.Label();
            this.grpBx_Inter_Office_Emp_Details = new System.Windows.Forms.GroupBox();
            this.tbox_InterOffce_Remarks = new System.Windows.Forms.TextBox();
            this.lbl_InterOffce_Remarks = new System.Windows.Forms.Label();
            this.tbox_InterOffce_Employee_Id = new System.Windows.Forms.TextBox();
            this.lbl_InterOffce_Employee_Id = new System.Windows.Forms.Label();
            this.tbox_InterOffce_Date = new System.Windows.Forms.TextBox();
            this.tbox_InterOffce_Contact_Number = new System.Windows.Forms.TextBox();
            this.tbox_InterOffce_Employee_Name = new System.Windows.Forms.TextBox();
            this.tbox_InterOffce_Comming_From = new System.Windows.Forms.TextBox();
            this.lbl_InterOffce_Date = new System.Windows.Forms.Label();
            this.lbl_InterOffce_Contact_Number = new System.Windows.Forms.Label();
            this.lbl_InterOffce_Comming_From = new System.Windows.Forms.Label();
            this.lbl_InterOffce_Employee_Name = new System.Windows.Forms.Label();
            this.tb_Page_VisitorDetails_Report = new System.Windows.Forms.TabPage();
            this.grpBx_Inter_Office_Report = new System.Windows.Forms.GroupBox();
            this.btn_Report_Inter_Office_Last_7_Days = new System.Windows.Forms.Button();
            this.btn_Report_Inter_Office_Today = new System.Windows.Forms.Button();
            this.btn_Report_Inter_Office_Specific_Employee = new System.Windows.Forms.Button();
            this.btn_Report_Inter_Office_Specified_Employee = new System.Windows.Forms.Button();
            this.btn_Report_Inter_Office_1_Month = new System.Windows.Forms.Button();
            this.grpBx_QuickReport = new System.Windows.Forms.GroupBox();
            this.btn_Report_Interview_1_Month = new System.Windows.Forms.Button();
            this.btn_Report_Last_7_Days = new System.Windows.Forms.Button();
            this.btn_Report_Today = new System.Windows.Forms.Button();
            this.grpBx_DetailedReport = new System.Windows.Forms.GroupBox();
            this.cbox_Interview_Report_Purpose = new System.Windows.Forms.CheckBox();
            this.btn_Reset_Extract = new System.Windows.Forms.Button();
            this.cbox_dload_Images = new System.Windows.Forms.CheckBox();
            this.btn_Report_Extract = new System.Windows.Forms.Button();
            this.lbl_Visitor_Report_Identity_Card_Number = new System.Windows.Forms.Label();
            this.tbox_Report_Id_Proof = new System.Windows.Forms.TextBox();
            this.lbl_Visitor_Report_Device_Carrying = new System.Windows.Forms.Label();
            this.tbox_Report_Carrying_Laptop = new System.Windows.Forms.TextBox();
            this.dtPk_Report_OutTime = new System.Windows.Forms.DateTimePicker();
            this.dtPk_Report_InTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_Visitor_Report_OutTime = new System.Windows.Forms.Label();
            this.cBox_Report_Floor_Number = new System.Windows.Forms.ComboBox();
            this.lbl_Visitor_Report_Floor_Number = new System.Windows.Forms.Label();
            this.tbox_Report_Whom_To_Meet = new System.Windows.Forms.TextBox();
            this.tbox_Report_Remarks = new System.Windows.Forms.TextBox();
            this.tbox_Report_Escort_Name = new System.Windows.Forms.TextBox();
            this.tbox_Report_Badge_Number = new System.Windows.Forms.TextBox();
            this.tbox_Report_Purpose = new System.Windows.Forms.TextBox();
            this.tbox_Report_ContactNumber = new System.Windows.Forms.TextBox();
            this.tbox_Report_Address = new System.Windows.Forms.TextBox();
            this.tbox_Report_Name = new System.Windows.Forms.TextBox();
            this.lbl_Visitor_Report_Remarks = new System.Windows.Forms.Label();
            this.lbl_Visitor_Report_InTime = new System.Windows.Forms.Label();
            this.lbl_Visitor_Report_Escort_Name = new System.Windows.Forms.Label();
            this.lbl_Visitor_Report_Badge_Number = new System.Windows.Forms.Label();
            this.lbl_Visitor_Report_Whom_To_Meet = new System.Windows.Forms.Label();
            this.lbl_Visitor_Report_Purpose = new System.Windows.Forms.Label();
            this.lbl_Visitor_Report_Contact_Number = new System.Windows.Forms.Label();
            this.lbl_Visitor_Report_Address = new System.Windows.Forms.Label();
            this.lbl_Visitor_Report_Name = new System.Windows.Forms.Label();
            this.tb_Page_KeyDistributionDetails = new System.Windows.Forms.TabPage();
            this.tbCtrl_Key_Details = new System.Windows.Forms.TabControl();
            this.tb_Page_KeyDetails_OneTimeDetails = new System.Windows.Forms.TabPage();
            this.sp_Cont_Key_Distribution = new System.Windows.Forms.SplitContainer();
            this.sp_Cont_SubTop_Key_Distribution = new System.Windows.Forms.SplitContainer();
            this.lbl_Key_Error = new System.Windows.Forms.Label();
            this.btn_Key_Emp_Reset = new System.Windows.Forms.Button();
            this.btn_Key_Emp_Search = new System.Windows.Forms.Button();
            this.tbox_Key_Emp_Desk_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Key_Emp_Desk_Phone = new System.Windows.Forms.Label();
            this.tbox_Key_Emp_Email = new System.Windows.Forms.TextBox();
            this.lbl_Key_Emp_Email = new System.Windows.Forms.Label();
            this.tbox_Key_Emp_Name = new System.Windows.Forms.TextBox();
            this.lbl_Key_Emp_Name = new System.Windows.Forms.Label();
            this.tbox_Key_Emp_Id = new System.Windows.Forms.TextBox();
            this.lbl_Key_Emp_Id = new System.Windows.Forms.Label();
            this.lbl_KeyDistribution_EmployeeDetails = new System.Windows.Forms.Label();
            this.lbl_KeyDistribution_KeyDetails = new System.Windows.Forms.Label();
            this.sp_Cont_SubBot_Key_Distribution = new System.Windows.Forms.SplitContainer();
            this.lbl_KeyDistribution_TimeDetails = new System.Windows.Forms.Label();
            this.tb_Page_KeyDetails_TempDetails = new System.Windows.Forms.TabPage();
            this.tb_Page_MedicineDistributionDetails = new System.Windows.Forms.TabPage();
            this.grpBx_Medicine_Distribution_Report = new System.Windows.Forms.GroupBox();
            this.btn_MedReport_Non_Employee = new System.Windows.Forms.Button();
            this.btn_MedReport_Specified_Medicine = new System.Windows.Forms.Button();
            this.btn_MedReport_Today = new System.Windows.Forms.Button();
            this.btn_MedReport_Specified_Date_Range = new System.Windows.Forms.Button();
            this.btn_MedReport_Specified_Employee = new System.Windows.Forms.Button();
            this.btn_MedReport_LastOneMonth = new System.Windows.Forms.Button();
            this.grpBx_Medicine_Distribution = new System.Windows.Forms.GroupBox();
            this.sp_Cont_Medicine_Distribution = new System.Windows.Forms.SplitContainer();
            this.cbox_Non_Employee_Medicine_Distribution = new System.Windows.Forms.CheckBox();
            this.lbl_Med_Error = new System.Windows.Forms.Label();
            this.btn_Med_Emp_Reset = new System.Windows.Forms.Button();
            this.btn_Med_Emp_Search = new System.Windows.Forms.Button();
            this.tbox_Med_Emp_Desk_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Med_Emp_Desk_Phone = new System.Windows.Forms.Label();
            this.tbox_Med_Emp_Email = new System.Windows.Forms.TextBox();
            this.lbl_Med_Emp_Email = new System.Windows.Forms.Label();
            this.tbox_Med_Emp_Name = new System.Windows.Forms.TextBox();
            this.lbl_Med_Emp_Name = new System.Windows.Forms.Label();
            this.tbox_Med_Emp_Id = new System.Windows.Forms.TextBox();
            this.lbl_Med_Emp_Id = new System.Windows.Forms.Label();
            this.tbox_Med_Medcine_Updated_Stock = new System.Windows.Forms.TextBox();
            this.lbl_medStockCounter = new System.Windows.Forms.Label();
            this.grpBx_MedicineSigneture = new System.Windows.Forms.GroupBox();
            this.pBox_Medcine_Signeture = new System.Windows.Forms.PictureBox();
            this.btn_Med_Details_Reset = new System.Windows.Forms.Button();
            this.btn_Med_Assign = new System.Windows.Forms.Button();
            this.tbox_Med_Medcine_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Med_Medcine_Quantity = new System.Windows.Forms.Label();
            this.tbox_Med_Medcine_Name = new System.Windows.Forms.TextBox();
            this.lbl_Med_Medcine_Name = new System.Windows.Forms.Label();
            this.tb_Page_Settings = new System.Windows.Forms.TabPage();
            this.tbCtrl_Settings = new System.Windows.Forms.TabControl();
            this.tb_Page_Settings_Manage_Employee = new System.Windows.Forms.TabPage();
            this.sp_Cont_Manage_Employee = new System.Windows.Forms.SplitContainer();
            this.lbl_InsertEmployee = new System.Windows.Forms.Label();
            this.lblStateStatus = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.pgBar_Import_Progress = new System.Windows.Forms.ProgressBar();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.tbox_Browse = new System.Windows.Forms.TextBox();
            this.lbl_Browse = new System.Windows.Forms.Label();
            this.tbox_Id = new System.Windows.Forms.TextBox();
            this.btn_Employee_Reset = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.lbl_UpdateEmployee = new System.Windows.Forms.Label();
            this.btn_Employee_Update = new System.Windows.Forms.Button();
            this.btn_Employee_Search = new System.Windows.Forms.Button();
            this.rdBtn_EmployeeInActive = new System.Windows.Forms.RadioButton();
            this.rdBtn_EmployeeActive = new System.Windows.Forms.RadioButton();
            this.lbl_ManageEmployee_EmployeeLocation = new System.Windows.Forms.Label();
            this.tbox_ManageEmployee_EmployeeLocation = new System.Windows.Forms.TextBox();
            this.lbl_ManageEmployee_EmployeeManagerId = new System.Windows.Forms.Label();
            this.tbox_ManageEmployee_EmployeeManagerId = new System.Windows.Forms.TextBox();
            this.lbl_ManageEmployee_EmployeeManager = new System.Windows.Forms.Label();
            this.tbox_ManageEmployee_EmployeeManager = new System.Windows.Forms.TextBox();
            this.lbl_ManageEmployee_EmployeeCompany = new System.Windows.Forms.Label();
            this.tbox_ManageEmployee_EmployeeCompany = new System.Windows.Forms.TextBox();
            this.lbl_ManageEmployee_EmployeeDepartment = new System.Windows.Forms.Label();
            this.tbox_ManageEmployee_EmployeeDepartment = new System.Windows.Forms.TextBox();
            this.lbl_ManageEmployee_EmployeeOfficialMobile = new System.Windows.Forms.Label();
            this.lbl_ManageEmployee_EmployeePersonalEmail = new System.Windows.Forms.Label();
            this.lbl_ManageEmployee_EmployeePersonalMobile = new System.Windows.Forms.Label();
            this.lbl_ManageEmployee_EmployeeExtection = new System.Windows.Forms.Label();
            this.lbl_ManageEmployee_EmployeeEmail = new System.Windows.Forms.Label();
            this.lbl_ManageEmployee_EmployeeName = new System.Windows.Forms.Label();
            this.lbl_ManageEmployee_EmployeeId = new System.Windows.Forms.Label();
            this.tbox_ManageEmployee_EmployeeOfficialMobile = new System.Windows.Forms.TextBox();
            this.tbox_ManageEmployee_EmployeePersonalEmail = new System.Windows.Forms.TextBox();
            this.tbox_ManageEmployee_EmployeePersonalMobile = new System.Windows.Forms.TextBox();
            this.tbox_ManageEmployee_EmployeeExtection = new System.Windows.Forms.TextBox();
            this.tbox_ManageEmployee_EmployeeEmail = new System.Windows.Forms.TextBox();
            this.tbox_ManageEmployee_EmployeeName = new System.Windows.Forms.TextBox();
            this.tbox_ManageEmployee_EmployeeId = new System.Windows.Forms.TextBox();
            this.tb_Page_Settings_Manage_Medicine = new System.Windows.Forms.TabPage();
            this.sp_Cont_Manage_Medicine_Graph = new System.Windows.Forms.SplitContainer();
            this.sp_Cont_Manage_Medicine_Add_And_Update = new System.Windows.Forms.SplitContainer();
            this.lbl_InsertMedicine = new System.Windows.Forms.Label();
            this.lbl_ExistingMedicine = new System.Windows.Forms.Label();
            this.btn_ManageMedicine_Insert_Reset = new System.Windows.Forms.Button();
            this.btn_ManageMedicine_Add = new System.Windows.Forms.Button();
            this.nemUD_ManageMedicine_InsertWarning = new System.Windows.Forms.NumericUpDown();
            this.lbl_ManageMedicine_InsertWarning = new System.Windows.Forms.Label();
            this.nemUD_ManageMedicine_InsertMedicineStock = new System.Windows.Forms.NumericUpDown();
            this.lbl_ManageMedicine_InsertMedicineStock = new System.Windows.Forms.Label();
            this.tbox_ManageMedicine_InsertMedicineName = new System.Windows.Forms.TextBox();
            this.lbl_ManageMedicine_InsertMedicineName = new System.Windows.Forms.Label();
            this.tbox_ManageMedicineId = new System.Windows.Forms.TextBox();
            this.btn_ManageMedicine_Update_Reset = new System.Windows.Forms.Button();
            this.btn_ManageMedicine_Update = new System.Windows.Forms.Button();
            this.rdBtn_MedicineInActive = new System.Windows.Forms.RadioButton();
            this.rdBtn_MedicineActive = new System.Windows.Forms.RadioButton();
            this.nemUD_ManageMedicine_UpdateWarning = new System.Windows.Forms.NumericUpDown();
            this.lbl_ManageMedicine_UpdateWarning = new System.Windows.Forms.Label();
            this.nemUD_ManageMedicine_UpdateMedicineStock = new System.Windows.Forms.NumericUpDown();
            this.lbl_ManageMedicine_UpdateMedicineStock = new System.Windows.Forms.Label();
            this.btn_ManageMedicine_Search = new System.Windows.Forms.Button();
            this.tbox_ManageMedicine_UpdateMedicineName = new System.Windows.Forms.TextBox();
            this.lbl_ManageMedicine_UpdateMedicineName = new System.Windows.Forms.Label();
            this.lbl_UpdateMedicine = new System.Windows.Forms.Label();
            this.lbl_GraphDataError = new System.Windows.Forms.Label();
            this.rd_ManageMedicine_PlotInActiveMedicine = new System.Windows.Forms.RadioButton();
            this.rd_ManageMedicine_PlotActiveMedicine = new System.Windows.Forms.RadioButton();
            this.chrt_Medicine_Stock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tb_Page_Settings_Manage_Keys = new System.Windows.Forms.TabPage();
            this.sp_Cont_Manage_Kyes_Data = new System.Windows.Forms.SplitContainer();
            this.sp_Cont_Manage_Keys_Add_And_Update = new System.Windows.Forms.SplitContainer();
            this.lbl_ManageKeys_InsertKeys_InsertKeysKeyNo = new System.Windows.Forms.Label();
            this.lbl_ManageKeys_InsertKeys_Select_Floor = new System.Windows.Forms.Label();
            this.lbl_ExistingPedistal = new System.Windows.Forms.Label();
            this.tbox_ManageKeys_InsertKeysPedistalNo = new System.Windows.Forms.TextBox();
            this.nemUD_ManageKeys_InsertKeys = new System.Windows.Forms.NumericUpDown();
            this.lbl_ManageKeys_InsertKeysPedistalNo = new System.Windows.Forms.Label();
            this.btn_ManageKeys_Insert_Reset = new System.Windows.Forms.Button();
            this.btn_ManageKeys_Add = new System.Windows.Forms.Button();
            this.cbox_ManageKeys_InsertKeysWhichFloor = new System.Windows.Forms.ComboBox();
            this.lbl_ManageKeys_InsertKeysWhichFloor = new System.Windows.Forms.Label();
            this.lbl_ManageKeys_InsertKeysNoOfKeys = new System.Windows.Forms.Label();
            this.tbox_ManageKeys_InsertKeysKeyNo = new System.Windows.Forms.TextBox();
            this.lbl_InsertKeys = new System.Windows.Forms.Label();
            this.lbl_ManageKeys_InsertKeysKeyNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdBtn_PedistalInActive = new System.Windows.Forms.RadioButton();
            this.rdBtn_PedistalActive = new System.Windows.Forms.RadioButton();
            this.lbl_ManageKeys_UpdateKeys_Select_Floor = new System.Windows.Forms.Label();
            this.tbox_ManageKeys_UpdateKeysKeyNo = new System.Windows.Forms.TextBox();
            this.lbl_ManageKeys_UpdateKeysKeyNo = new System.Windows.Forms.Label();
            this.nemUD_ManageKeys_UpdateKeys = new System.Windows.Forms.NumericUpDown();
            this.btn_ManageKeys_Update_Reset = new System.Windows.Forms.Button();
            this.btn_ManageKeys_Update = new System.Windows.Forms.Button();
            this.btn_ManageKeys_Search_By_PedistalNo = new System.Windows.Forms.Button();
            this.cbox_ManageKeys_UpdateKeysWhichFloor = new System.Windows.Forms.ComboBox();
            this.lbl_ManageKeys_UpdateKeysWhichFloor = new System.Windows.Forms.Label();
            this.lbl_ManageKeys_UpdateKeysPedistalNo = new System.Windows.Forms.Label();
            this.lbl_ManageKeys_UpdateKeysNoOfKeys = new System.Windows.Forms.Label();
            this.tbox_ManageKeys_UpdateKeysPedistalNo = new System.Windows.Forms.TextBox();
            this.lbl_UpdateKeys = new System.Windows.Forms.Label();
            this.tb_Page_Settings_Manage_Database = new System.Windows.Forms.TabPage();
            this.lbl_ConnectedDatabase = new System.Windows.Forms.Label();
            this.lbl_BackupStatus = new System.Windows.Forms.Label();
            this.tbox_Log_Find = new System.Windows.Forms.TextBox();
            this.lbl_Log_Find = new System.Windows.Forms.Label();
            this.lbl_Daily_Log = new System.Windows.Forms.Label();
            this.grpbx_Database_Details = new System.Windows.Forms.GroupBox();
            this.lbl_DatabaseSize = new System.Windows.Forms.Label();
            this.lbl_Database_Last_BackedUp_On = new System.Windows.Forms.Label();
            this.pgBar_Database_Size = new System.Windows.Forms.ProgressBar();
            this.lbl_Database_Size = new System.Windows.Forms.Label();
            this.pgBar_Backup_Progress = new System.Windows.Forms.ProgressBar();
            this.rtbox_Daily_Log = new System.Windows.Forms.RichTextBox();
            this.btn_Change_Admin_Password = new System.Windows.Forms.Button();
            this.btn_Restore_Database = new System.Windows.Forms.Button();
            this.btn_Backup_Database = new System.Windows.Forms.Button();
            this.btn_Repoint_Database = new System.Windows.Forms.Button();
            this.svFlDlg_SaveReport = new System.Windows.Forms.SaveFileDialog();
            this.opFlDlg_SelectFile = new System.Windows.Forms.OpenFileDialog();
            this.bg_Worker_ImportEmployee = new System.ComponentModel.BackgroundWorker();
            this.fbDlg_Backup_Database = new System.Windows.Forms.FolderBrowserDialog();
            this.bg_Worker_BackupDatabase = new System.ComponentModel.BackgroundWorker();
            this.bg_Worker_RestoreDatabase = new System.ComponentModel.BackgroundWorker();
            this.lbl_medNameChecker = new System.Windows.Forms.Label();
            this.sts_Strip.SuspendLayout();
            this.tbCtrl_Asset_Manager.SuspendLayout();
            this.tb_Page_VisitorDetails.SuspendLayout();
            this.tbCtrl_Visitor_Details.SuspendLayout();
            this.tb_Page_VisitorDetails_InDetails.SuspendLayout();
            this.grpBx_InTimeSigneture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Signeture)).BeginInit();
            this.grpBx_InTimeImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Image)).BeginInit();
            this.grpBx_InTimeThingsAndIdentityDetails.SuspendLayout();
            this.grpBx_InTimeDetails.SuspendLayout();
            this.tb_Page_VisitorDetails_OutDetails.SuspendLayout();
            this.grpBx_OutTimeSigneture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Out_Signeture)).BeginInit();
            this.grpBx_OutTimeImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Out_Image)).BeginInit();
            this.grpBx_OutTimeThingsAndIdentityDetails.SuspendLayout();
            this.grpBx_OutTimeDetails.SuspendLayout();
            this.tb_Page_InterOffice_Visitor.SuspendLayout();
            this.grpBx_Inter_Office_Return_Details.SuspendLayout();
            this.grpBx_Inter_Office_Emp_Signeture_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Inter_Office_Signeture)).BeginInit();
            this.grpBx_Inter_Office_Emp_Image_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Inter_Office_Image)).BeginInit();
            this.grpBx_Inter_Office_Access_Card_Details.SuspendLayout();
            this.grpBx_Inter_Office_Emp_Details.SuspendLayout();
            this.tb_Page_VisitorDetails_Report.SuspendLayout();
            this.grpBx_Inter_Office_Report.SuspendLayout();
            this.grpBx_QuickReport.SuspendLayout();
            this.grpBx_DetailedReport.SuspendLayout();
            this.tb_Page_KeyDistributionDetails.SuspendLayout();
            this.tbCtrl_Key_Details.SuspendLayout();
            this.tb_Page_KeyDetails_OneTimeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_Key_Distribution)).BeginInit();
            this.sp_Cont_Key_Distribution.Panel1.SuspendLayout();
            this.sp_Cont_Key_Distribution.Panel2.SuspendLayout();
            this.sp_Cont_Key_Distribution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_SubTop_Key_Distribution)).BeginInit();
            this.sp_Cont_SubTop_Key_Distribution.Panel1.SuspendLayout();
            this.sp_Cont_SubTop_Key_Distribution.Panel2.SuspendLayout();
            this.sp_Cont_SubTop_Key_Distribution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_SubBot_Key_Distribution)).BeginInit();
            this.sp_Cont_SubBot_Key_Distribution.Panel1.SuspendLayout();
            this.sp_Cont_SubBot_Key_Distribution.SuspendLayout();
            this.tb_Page_MedicineDistributionDetails.SuspendLayout();
            this.grpBx_Medicine_Distribution_Report.SuspendLayout();
            this.grpBx_Medicine_Distribution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_Medicine_Distribution)).BeginInit();
            this.sp_Cont_Medicine_Distribution.Panel1.SuspendLayout();
            this.sp_Cont_Medicine_Distribution.Panel2.SuspendLayout();
            this.sp_Cont_Medicine_Distribution.SuspendLayout();
            this.grpBx_MedicineSigneture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Medcine_Signeture)).BeginInit();
            this.tb_Page_Settings.SuspendLayout();
            this.tbCtrl_Settings.SuspendLayout();
            this.tb_Page_Settings_Manage_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_Manage_Employee)).BeginInit();
            this.sp_Cont_Manage_Employee.Panel1.SuspendLayout();
            this.sp_Cont_Manage_Employee.Panel2.SuspendLayout();
            this.sp_Cont_Manage_Employee.SuspendLayout();
            this.tb_Page_Settings_Manage_Medicine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_Manage_Medicine_Graph)).BeginInit();
            this.sp_Cont_Manage_Medicine_Graph.Panel1.SuspendLayout();
            this.sp_Cont_Manage_Medicine_Graph.Panel2.SuspendLayout();
            this.sp_Cont_Manage_Medicine_Graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_Manage_Medicine_Add_And_Update)).BeginInit();
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel1.SuspendLayout();
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.SuspendLayout();
            this.sp_Cont_Manage_Medicine_Add_And_Update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nemUD_ManageMedicine_InsertWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemUD_ManageMedicine_InsertMedicineStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemUD_ManageMedicine_UpdateWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemUD_ManageMedicine_UpdateMedicineStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Medicine_Stock)).BeginInit();
            this.tb_Page_Settings_Manage_Keys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_Manage_Kyes_Data)).BeginInit();
            this.sp_Cont_Manage_Kyes_Data.Panel1.SuspendLayout();
            this.sp_Cont_Manage_Kyes_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_Manage_Keys_Add_And_Update)).BeginInit();
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.SuspendLayout();
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.SuspendLayout();
            this.sp_Cont_Manage_Keys_Add_And_Update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nemUD_ManageKeys_InsertKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemUD_ManageKeys_UpdateKeys)).BeginInit();
            this.tb_Page_Settings_Manage_Database.SuspendLayout();
            this.grpbx_Database_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // sts_Strip
            // 
            this.sts_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Date,
            this.lbl_time,
            this.lbl_LoggedinUser});
            this.sts_Strip.Location = new System.Drawing.Point(0, 607);
            this.sts_Strip.Name = "sts_Strip";
            this.sts_Strip.Size = new System.Drawing.Size(910, 23);
            this.sts_Strip.SizingGrip = false;
            this.sts_Strip.TabIndex = 2;
            this.sts_Strip.Text = "Date:";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = false;
            this.lbl_Date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(290, 18);
            this.lbl_Date.Text = "Date:";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = false;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(290, 18);
            this.lbl_time.Text = "Time Now:";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_LoggedinUser
            // 
            this.lbl_LoggedinUser.AutoSize = false;
            this.lbl_LoggedinUser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoggedinUser.Name = "lbl_LoggedinUser";
            this.lbl_LoggedinUser.Size = new System.Drawing.Size(290, 18);
            this.lbl_LoggedinUser.Text = "Login User: ";
            this.lbl_LoggedinUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmr_Asset_Timer
            // 
            this.tmr_Asset_Timer.Tick += new System.EventHandler(this.tmr_Ops_Timer_Tick);
            // 
            // tbCtrl_Asset_Manager
            // 
            this.tbCtrl_Asset_Manager.Controls.Add(this.tb_Page_VisitorDetails);
            this.tbCtrl_Asset_Manager.Controls.Add(this.tb_Page_KeyDistributionDetails);
            this.tbCtrl_Asset_Manager.Controls.Add(this.tb_Page_MedicineDistributionDetails);
            this.tbCtrl_Asset_Manager.Controls.Add(this.tb_Page_Settings);
            this.tbCtrl_Asset_Manager.Location = new System.Drawing.Point(12, 12);
            this.tbCtrl_Asset_Manager.Name = "tbCtrl_Asset_Manager";
            this.tbCtrl_Asset_Manager.SelectedIndex = 0;
            this.tbCtrl_Asset_Manager.Size = new System.Drawing.Size(886, 592);
            this.tbCtrl_Asset_Manager.TabIndex = 1;
            // 
            // tb_Page_VisitorDetails
            // 
            this.tb_Page_VisitorDetails.Controls.Add(this.tbCtrl_Visitor_Details);
            this.tb_Page_VisitorDetails.Location = new System.Drawing.Point(4, 22);
            this.tb_Page_VisitorDetails.Name = "tb_Page_VisitorDetails";
            this.tb_Page_VisitorDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Page_VisitorDetails.Size = new System.Drawing.Size(878, 566);
            this.tb_Page_VisitorDetails.TabIndex = 0;
            this.tb_Page_VisitorDetails.Text = "Visitor";
            this.tb_Page_VisitorDetails.UseVisualStyleBackColor = true;
            // 
            // tbCtrl_Visitor_Details
            // 
            this.tbCtrl_Visitor_Details.Controls.Add(this.tb_Page_VisitorDetails_InDetails);
            this.tbCtrl_Visitor_Details.Controls.Add(this.tb_Page_VisitorDetails_OutDetails);
            this.tbCtrl_Visitor_Details.Controls.Add(this.tb_Page_InterOffice_Visitor);
            this.tbCtrl_Visitor_Details.Controls.Add(this.tb_Page_VisitorDetails_Report);
            this.tbCtrl_Visitor_Details.Location = new System.Drawing.Point(6, 28);
            this.tbCtrl_Visitor_Details.Name = "tbCtrl_Visitor_Details";
            this.tbCtrl_Visitor_Details.SelectedIndex = 0;
            this.tbCtrl_Visitor_Details.Size = new System.Drawing.Size(869, 532);
            this.tbCtrl_Visitor_Details.TabIndex = 1;
            // 
            // tb_Page_VisitorDetails_InDetails
            // 
            this.tb_Page_VisitorDetails_InDetails.Controls.Add(this.grpBx_InTimeSigneture);
            this.tb_Page_VisitorDetails_InDetails.Controls.Add(this.btn_Reset);
            this.tb_Page_VisitorDetails_InDetails.Controls.Add(this.btn_Save);
            this.tb_Page_VisitorDetails_InDetails.Controls.Add(this.grpBx_InTimeImage);
            this.tb_Page_VisitorDetails_InDetails.Controls.Add(this.grpBx_InTimeThingsAndIdentityDetails);
            this.tb_Page_VisitorDetails_InDetails.Controls.Add(this.grpBx_InTimeDetails);
            this.tb_Page_VisitorDetails_InDetails.Location = new System.Drawing.Point(4, 22);
            this.tb_Page_VisitorDetails_InDetails.Name = "tb_Page_VisitorDetails_InDetails";
            this.tb_Page_VisitorDetails_InDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Page_VisitorDetails_InDetails.Size = new System.Drawing.Size(861, 506);
            this.tb_Page_VisitorDetails_InDetails.TabIndex = 0;
            this.tb_Page_VisitorDetails_InDetails.Text = "In Time";
            this.tb_Page_VisitorDetails_InDetails.UseVisualStyleBackColor = true;
            this.tb_Page_VisitorDetails_InDetails.Enter += new System.EventHandler(this.tb_Page_VisitorDetails_InDetails_Enter);
            // 
            // grpBx_InTimeSigneture
            // 
            this.grpBx_InTimeSigneture.Controls.Add(this.pBox_Signeture);
            this.grpBx_InTimeSigneture.Location = new System.Drawing.Point(450, 315);
            this.grpBx_InTimeSigneture.Name = "grpBx_InTimeSigneture";
            this.grpBx_InTimeSigneture.Size = new System.Drawing.Size(406, 135);
            this.grpBx_InTimeSigneture.TabIndex = 19;
            this.grpBx_InTimeSigneture.TabStop = false;
            this.grpBx_InTimeSigneture.Text = "Signeture";
            // 
            // pBox_Signeture
            // 
            this.pBox_Signeture.Cursor = System.Windows.Forms.Cursors.No;
            this.pBox_Signeture.Image = ((System.Drawing.Image)(resources.GetObject("pBox_Signeture.Image")));
            this.pBox_Signeture.Location = new System.Drawing.Point(6, 19);
            this.pBox_Signeture.Name = "pBox_Signeture";
            this.pBox_Signeture.Size = new System.Drawing.Size(394, 110);
            this.pBox_Signeture.TabIndex = 0;
            this.pBox_Signeture.TabStop = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(742, 465);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(108, 31);
            this.btn_Reset.TabIndex = 21;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(628, 465);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(108, 31);
            this.btn_Save.TabIndex = 20;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // grpBx_InTimeImage
            // 
            this.grpBx_InTimeImage.Controls.Add(this.btn_Stop);
            this.grpBx_InTimeImage.Controls.Add(this.btn_Continue);
            this.grpBx_InTimeImage.Controls.Add(this.btn_Webcam);
            this.grpBx_InTimeImage.Controls.Add(this.btn_TakeImage);
            this.grpBx_InTimeImage.Controls.Add(this.pBox_Image);
            this.grpBx_InTimeImage.Location = new System.Drawing.Point(452, 98);
            this.grpBx_InTimeImage.Name = "grpBx_InTimeImage";
            this.grpBx_InTimeImage.Size = new System.Drawing.Size(404, 209);
            this.grpBx_InTimeImage.TabIndex = 2;
            this.grpBx_InTimeImage.TabStop = false;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.Location = new System.Drawing.Point(215, 157);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(158, 38);
            this.btn_Stop.TabIndex = 18;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Continue
            // 
            this.btn_Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Continue.Location = new System.Drawing.Point(215, 69);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(158, 38);
            this.btn_Continue.TabIndex = 19;
            this.btn_Continue.Text = "Continue";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // btn_Webcam
            // 
            this.btn_Webcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Webcam.Location = new System.Drawing.Point(215, 25);
            this.btn_Webcam.Name = "btn_Webcam";
            this.btn_Webcam.Size = new System.Drawing.Size(158, 38);
            this.btn_Webcam.TabIndex = 16;
            this.btn_Webcam.Text = "Open Web Cam";
            this.btn_Webcam.UseVisualStyleBackColor = true;
            this.btn_Webcam.Click += new System.EventHandler(this.btn_Webcam_Click);
            // 
            // btn_TakeImage
            // 
            this.btn_TakeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TakeImage.Location = new System.Drawing.Point(215, 113);
            this.btn_TakeImage.Name = "btn_TakeImage";
            this.btn_TakeImage.Size = new System.Drawing.Size(158, 38);
            this.btn_TakeImage.TabIndex = 17;
            this.btn_TakeImage.Text = "Take Picture";
            this.btn_TakeImage.UseVisualStyleBackColor = true;
            this.btn_TakeImage.Click += new System.EventHandler(this.btn_TakeImage_Click);
            // 
            // pBox_Image
            // 
            this.pBox_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Image.Cursor = System.Windows.Forms.Cursors.No;
            this.pBox_Image.Location = new System.Drawing.Point(15, 25);
            this.pBox_Image.Name = "pBox_Image";
            this.pBox_Image.Size = new System.Drawing.Size(170, 170);
            this.pBox_Image.TabIndex = 0;
            this.pBox_Image.TabStop = false;
            // 
            // grpBx_InTimeThingsAndIdentityDetails
            // 
            this.grpBx_InTimeThingsAndIdentityDetails.Controls.Add(this.lbl_Visitor_In_Identity_Card_Number);
            this.grpBx_InTimeThingsAndIdentityDetails.Controls.Add(this.tbox_In_Id_Proof);
            this.grpBx_InTimeThingsAndIdentityDetails.Controls.Add(this.lbl_Visitor_In_Device_Carrying);
            this.grpBx_InTimeThingsAndIdentityDetails.Controls.Add(this.tbox_In_Carrying_Laptop);
            this.grpBx_InTimeThingsAndIdentityDetails.Location = new System.Drawing.Point(452, 6);
            this.grpBx_InTimeThingsAndIdentityDetails.Name = "grpBx_InTimeThingsAndIdentityDetails";
            this.grpBx_InTimeThingsAndIdentityDetails.Size = new System.Drawing.Size(404, 86);
            this.grpBx_InTimeThingsAndIdentityDetails.TabIndex = 1;
            this.grpBx_InTimeThingsAndIdentityDetails.TabStop = false;
            // 
            // lbl_Visitor_In_Identity_Card_Number
            // 
            this.lbl_Visitor_In_Identity_Card_Number.AutoSize = true;
            this.lbl_Visitor_In_Identity_Card_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_In_Identity_Card_Number.Location = new System.Drawing.Point(68, 51);
            this.lbl_Visitor_In_Identity_Card_Number.Name = "lbl_Visitor_In_Identity_Card_Number";
            this.lbl_Visitor_In_Identity_Card_Number.Size = new System.Drawing.Size(72, 16);
            this.lbl_Visitor_In_Identity_Card_Number.TabIndex = 5;
            this.lbl_Visitor_In_Identity_Card_Number.Text = "ID Proof :";
            // 
            // tbox_In_Id_Proof
            // 
            this.tbox_In_Id_Proof.Location = new System.Drawing.Point(146, 50);
            this.tbox_In_Id_Proof.Name = "tbox_In_Id_Proof";
            this.tbox_In_Id_Proof.Size = new System.Drawing.Size(252, 20);
            this.tbox_In_Id_Proof.TabIndex = 15;
            // 
            // lbl_Visitor_In_Device_Carrying
            // 
            this.lbl_Visitor_In_Device_Carrying.AutoSize = true;
            this.lbl_Visitor_In_Device_Carrying.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_In_Device_Carrying.Location = new System.Drawing.Point(6, 16);
            this.lbl_Visitor_In_Device_Carrying.Name = "lbl_Visitor_In_Device_Carrying";
            this.lbl_Visitor_In_Device_Carrying.Size = new System.Drawing.Size(134, 16);
            this.lbl_Visitor_In_Device_Carrying.TabIndex = 3;
            this.lbl_Visitor_In_Device_Carrying.Text = "Carrying Laptop? :";
            // 
            // tbox_In_Carrying_Laptop
            // 
            this.tbox_In_Carrying_Laptop.Location = new System.Drawing.Point(146, 15);
            this.tbox_In_Carrying_Laptop.Name = "tbox_In_Carrying_Laptop";
            this.tbox_In_Carrying_Laptop.Size = new System.Drawing.Size(252, 20);
            this.tbox_In_Carrying_Laptop.TabIndex = 14;
            // 
            // grpBx_InTimeDetails
            // 
            this.grpBx_InTimeDetails.Controls.Add(this.cbox_Interview_Purpose);
            this.grpBx_InTimeDetails.Controls.Add(this.cBox_Floor_Number);
            this.grpBx_InTimeDetails.Controls.Add(this.lbl_Visitor_Floor_Number);
            this.grpBx_InTimeDetails.Controls.Add(this.tbox_In_Time);
            this.grpBx_InTimeDetails.Controls.Add(this.tbox_In_Whom_To_Meet);
            this.grpBx_InTimeDetails.Controls.Add(this.tbox_In_Remarks);
            this.grpBx_InTimeDetails.Controls.Add(this.tbox_In_Escort_Name);
            this.grpBx_InTimeDetails.Controls.Add(this.tbox_In_Badge_Number);
            this.grpBx_InTimeDetails.Controls.Add(this.tbox_In_Purpose);
            this.grpBx_InTimeDetails.Controls.Add(this.tbox_In_ContactNumber);
            this.grpBx_InTimeDetails.Controls.Add(this.tbox_In_Address);
            this.grpBx_InTimeDetails.Controls.Add(this.tbox_In_Name);
            this.grpBx_InTimeDetails.Controls.Add(this.lbl_Visitor_In_Remarks);
            this.grpBx_InTimeDetails.Controls.Add(this.lbl_Visitor_In_Time);
            this.grpBx_InTimeDetails.Controls.Add(this.lbl_Visitor_In_Escort_Name);
            this.grpBx_InTimeDetails.Controls.Add(this.lbl_Visitor_In_Badge_Number);
            this.grpBx_InTimeDetails.Controls.Add(this.lbl_Visitor_In_Whom_To_Meet);
            this.grpBx_InTimeDetails.Controls.Add(this.lbl_Visitor_In_Purpose);
            this.grpBx_InTimeDetails.Controls.Add(this.lbl_Visitor_In_Contact_Number);
            this.grpBx_InTimeDetails.Controls.Add(this.lbl_Visitor_In_Address);
            this.grpBx_InTimeDetails.Controls.Add(this.lbl_Visitor_In_Name);
            this.grpBx_InTimeDetails.Location = new System.Drawing.Point(6, 6);
            this.grpBx_InTimeDetails.Name = "grpBx_InTimeDetails";
            this.grpBx_InTimeDetails.Size = new System.Drawing.Size(440, 490);
            this.grpBx_InTimeDetails.TabIndex = 0;
            this.grpBx_InTimeDetails.TabStop = false;
            // 
            // cbox_Interview_Purpose
            // 
            this.cbox_Interview_Purpose.AutoSize = true;
            this.cbox_Interview_Purpose.Location = new System.Drawing.Point(140, 168);
            this.cbox_Interview_Purpose.Name = "cbox_Interview_Purpose";
            this.cbox_Interview_Purpose.Size = new System.Drawing.Size(69, 17);
            this.cbox_Interview_Purpose.TabIndex = 6;
            this.cbox_Interview_Purpose.Text = "Interview";
            this.cbox_Interview_Purpose.UseVisualStyleBackColor = true;
            this.cbox_Interview_Purpose.CheckedChanged += new System.EventHandler(this.cbox_Interview_Purpose_CheckedChanged);
            // 
            // cBox_Floor_Number
            // 
            this.cBox_Floor_Number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Floor_Number.FormattingEnabled = true;
            this.cBox_Floor_Number.Items.AddRange(new object[] {
            "--------------------Select--------------------",
            "Floor - G",
            "Floor - 1",
            "Floor - 2",
            "Floor - 3",
            "Floor - 4",
            "Floor - 5",
            "Floor - 6",
            "Floor - 7",
            "Floor - 8",
            "Floor - 9"});
            this.cBox_Floor_Number.Location = new System.Drawing.Point(140, 363);
            this.cBox_Floor_Number.Name = "cBox_Floor_Number";
            this.cBox_Floor_Number.Size = new System.Drawing.Size(282, 21);
            this.cBox_Floor_Number.TabIndex = 12;
            // 
            // lbl_Visitor_Floor_Number
            // 
            this.lbl_Visitor_Floor_Number.AutoSize = true;
            this.lbl_Visitor_Floor_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Floor_Number.Location = new System.Drawing.Point(34, 364);
            this.lbl_Visitor_Floor_Number.Name = "lbl_Visitor_Floor_Number";
            this.lbl_Visitor_Floor_Number.Size = new System.Drawing.Size(98, 16);
            this.lbl_Visitor_Floor_Number.TabIndex = 51;
            this.lbl_Visitor_Floor_Number.Text = "Which Floor :";
            // 
            // tbox_In_Time
            // 
            this.tbox_In_Time.Enabled = false;
            this.tbox_In_Time.Location = new System.Drawing.Point(140, 328);
            this.tbox_In_Time.Name = "tbox_In_Time";
            this.tbox_In_Time.Size = new System.Drawing.Size(282, 20);
            this.tbox_In_Time.TabIndex = 11;
            // 
            // tbox_In_Whom_To_Meet
            // 
            this.tbox_In_Whom_To_Meet.Location = new System.Drawing.Point(140, 223);
            this.tbox_In_Whom_To_Meet.Name = "tbox_In_Whom_To_Meet";
            this.tbox_In_Whom_To_Meet.Size = new System.Drawing.Size(282, 20);
            this.tbox_In_Whom_To_Meet.TabIndex = 8;
            // 
            // tbox_In_Remarks
            // 
            this.tbox_In_Remarks.Location = new System.Drawing.Point(140, 398);
            this.tbox_In_Remarks.Multiline = true;
            this.tbox_In_Remarks.Name = "tbox_In_Remarks";
            this.tbox_In_Remarks.Size = new System.Drawing.Size(282, 68);
            this.tbox_In_Remarks.TabIndex = 13;
            // 
            // tbox_In_Escort_Name
            // 
            this.tbox_In_Escort_Name.Location = new System.Drawing.Point(140, 295);
            this.tbox_In_Escort_Name.Name = "tbox_In_Escort_Name";
            this.tbox_In_Escort_Name.Size = new System.Drawing.Size(282, 20);
            this.tbox_In_Escort_Name.TabIndex = 10;
            // 
            // tbox_In_Badge_Number
            // 
            this.tbox_In_Badge_Number.Location = new System.Drawing.Point(140, 260);
            this.tbox_In_Badge_Number.Name = "tbox_In_Badge_Number";
            this.tbox_In_Badge_Number.Size = new System.Drawing.Size(282, 20);
            this.tbox_In_Badge_Number.TabIndex = 9;
            // 
            // tbox_In_Purpose
            // 
            this.tbox_In_Purpose.Location = new System.Drawing.Point(140, 188);
            this.tbox_In_Purpose.Name = "tbox_In_Purpose";
            this.tbox_In_Purpose.Size = new System.Drawing.Size(282, 20);
            this.tbox_In_Purpose.TabIndex = 7;
            // 
            // tbox_In_ContactNumber
            // 
            this.tbox_In_ContactNumber.Location = new System.Drawing.Point(140, 142);
            this.tbox_In_ContactNumber.Name = "tbox_In_ContactNumber";
            this.tbox_In_ContactNumber.Size = new System.Drawing.Size(282, 20);
            this.tbox_In_ContactNumber.TabIndex = 5;
            // 
            // tbox_In_Address
            // 
            this.tbox_In_Address.Location = new System.Drawing.Point(140, 65);
            this.tbox_In_Address.Multiline = true;
            this.tbox_In_Address.Name = "tbox_In_Address";
            this.tbox_In_Address.Size = new System.Drawing.Size(282, 65);
            this.tbox_In_Address.TabIndex = 4;
            // 
            // tbox_In_Name
            // 
            this.tbox_In_Name.Location = new System.Drawing.Point(140, 31);
            this.tbox_In_Name.Name = "tbox_In_Name";
            this.tbox_In_Name.Size = new System.Drawing.Size(282, 20);
            this.tbox_In_Name.TabIndex = 3;
            // 
            // lbl_Visitor_In_Remarks
            // 
            this.lbl_Visitor_In_Remarks.AutoSize = true;
            this.lbl_Visitor_In_Remarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_In_Remarks.Location = new System.Drawing.Point(54, 399);
            this.lbl_Visitor_In_Remarks.Name = "lbl_Visitor_In_Remarks";
            this.lbl_Visitor_In_Remarks.Size = new System.Drawing.Size(78, 16);
            this.lbl_Visitor_In_Remarks.TabIndex = 49;
            this.lbl_Visitor_In_Remarks.Text = "Remarks :";
            // 
            // lbl_Visitor_In_Time
            // 
            this.lbl_Visitor_In_Time.AutoSize = true;
            this.lbl_Visitor_In_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_In_Time.Location = new System.Drawing.Point(65, 329);
            this.lbl_Visitor_In_Time.Name = "lbl_Visitor_In_Time";
            this.lbl_Visitor_In_Time.Size = new System.Drawing.Size(67, 16);
            this.lbl_Visitor_In_Time.TabIndex = 47;
            this.lbl_Visitor_In_Time.Text = "In Time :";
            // 
            // lbl_Visitor_In_Escort_Name
            // 
            this.lbl_Visitor_In_Escort_Name.AutoSize = true;
            this.lbl_Visitor_In_Escort_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_In_Escort_Name.Location = new System.Drawing.Point(29, 296);
            this.lbl_Visitor_In_Escort_Name.Name = "lbl_Visitor_In_Escort_Name";
            this.lbl_Visitor_In_Escort_Name.Size = new System.Drawing.Size(105, 16);
            this.lbl_Visitor_In_Escort_Name.TabIndex = 46;
            this.lbl_Visitor_In_Escort_Name.Text = "Escort Name :";
            // 
            // lbl_Visitor_In_Badge_Number
            // 
            this.lbl_Visitor_In_Badge_Number.AutoSize = true;
            this.lbl_Visitor_In_Badge_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_In_Badge_Number.Location = new System.Drawing.Point(12, 261);
            this.lbl_Visitor_In_Badge_Number.Name = "lbl_Visitor_In_Badge_Number";
            this.lbl_Visitor_In_Badge_Number.Size = new System.Drawing.Size(120, 16);
            this.lbl_Visitor_In_Badge_Number.TabIndex = 45;
            this.lbl_Visitor_In_Badge_Number.Text = "Badge Number :";
            // 
            // lbl_Visitor_In_Whom_To_Meet
            // 
            this.lbl_Visitor_In_Whom_To_Meet.AutoSize = true;
            this.lbl_Visitor_In_Whom_To_Meet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_In_Whom_To_Meet.Location = new System.Drawing.Point(14, 224);
            this.lbl_Visitor_In_Whom_To_Meet.Name = "lbl_Visitor_In_Whom_To_Meet";
            this.lbl_Visitor_In_Whom_To_Meet.Size = new System.Drawing.Size(120, 16);
            this.lbl_Visitor_In_Whom_To_Meet.TabIndex = 44;
            this.lbl_Visitor_In_Whom_To_Meet.Text = "Whom To Meet :";
            // 
            // lbl_Visitor_In_Purpose
            // 
            this.lbl_Visitor_In_Purpose.AutoSize = true;
            this.lbl_Visitor_In_Purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_In_Purpose.Location = new System.Drawing.Point(60, 189);
            this.lbl_Visitor_In_Purpose.Name = "lbl_Visitor_In_Purpose";
            this.lbl_Visitor_In_Purpose.Size = new System.Drawing.Size(74, 16);
            this.lbl_Visitor_In_Purpose.TabIndex = 43;
            this.lbl_Visitor_In_Purpose.Text = "Purpose :";
            // 
            // lbl_Visitor_In_Contact_Number
            // 
            this.lbl_Visitor_In_Contact_Number.AutoSize = true;
            this.lbl_Visitor_In_Contact_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_In_Contact_Number.Location = new System.Drawing.Point(6, 144);
            this.lbl_Visitor_In_Contact_Number.Name = "lbl_Visitor_In_Contact_Number";
            this.lbl_Visitor_In_Contact_Number.Size = new System.Drawing.Size(126, 16);
            this.lbl_Visitor_In_Contact_Number.TabIndex = 42;
            this.lbl_Visitor_In_Contact_Number.Text = "Contact Number :";
            // 
            // lbl_Visitor_In_Address
            // 
            this.lbl_Visitor_In_Address.AutoSize = true;
            this.lbl_Visitor_In_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_In_Address.Location = new System.Drawing.Point(19, 65);
            this.lbl_Visitor_In_Address.Name = "lbl_Visitor_In_Address";
            this.lbl_Visitor_In_Address.Size = new System.Drawing.Size(113, 16);
            this.lbl_Visitor_In_Address.TabIndex = 41;
            this.lbl_Visitor_In_Address.Text = "From Address :";
            // 
            // lbl_Visitor_In_Name
            // 
            this.lbl_Visitor_In_Name.AutoSize = true;
            this.lbl_Visitor_In_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Visitor_In_Name.Location = new System.Drawing.Point(77, 32);
            this.lbl_Visitor_In_Name.Name = "lbl_Visitor_In_Name";
            this.lbl_Visitor_In_Name.Size = new System.Drawing.Size(57, 16);
            this.lbl_Visitor_In_Name.TabIndex = 40;
            this.lbl_Visitor_In_Name.Text = "Name :";
            // 
            // tb_Page_VisitorDetails_OutDetails
            // 
            this.tb_Page_VisitorDetails_OutDetails.Controls.Add(this.btn_Search);
            this.tb_Page_VisitorDetails_OutDetails.Controls.Add(this.grpBx_OutTimeSigneture);
            this.tb_Page_VisitorDetails_OutDetails.Controls.Add(this.btn_Out_Reset);
            this.tb_Page_VisitorDetails_OutDetails.Controls.Add(this.btn_Out_Update);
            this.tb_Page_VisitorDetails_OutDetails.Controls.Add(this.grpBx_OutTimeImage);
            this.tb_Page_VisitorDetails_OutDetails.Controls.Add(this.grpBx_OutTimeThingsAndIdentityDetails);
            this.tb_Page_VisitorDetails_OutDetails.Controls.Add(this.grpBx_OutTimeDetails);
            this.tb_Page_VisitorDetails_OutDetails.Location = new System.Drawing.Point(4, 22);
            this.tb_Page_VisitorDetails_OutDetails.Name = "tb_Page_VisitorDetails_OutDetails";
            this.tb_Page_VisitorDetails_OutDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Page_VisitorDetails_OutDetails.Size = new System.Drawing.Size(861, 506);
            this.tb_Page_VisitorDetails_OutDetails.TabIndex = 1;
            this.tb_Page_VisitorDetails_OutDetails.Text = "Out Time";
            this.tb_Page_VisitorDetails_OutDetails.UseVisualStyleBackColor = true;
            this.tb_Page_VisitorDetails_OutDetails.Enter += new System.EventHandler(this.tb_Page_VisitorDetails_OutDetails_Enter);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(474, 181);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(149, 53);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // grpBx_OutTimeSigneture
            // 
            this.grpBx_OutTimeSigneture.Controls.Add(this.pBox_Out_Signeture);
            this.grpBx_OutTimeSigneture.Location = new System.Drawing.Point(447, 315);
            this.grpBx_OutTimeSigneture.Name = "grpBx_OutTimeSigneture";
            this.grpBx_OutTimeSigneture.Size = new System.Drawing.Size(406, 135);
            this.grpBx_OutTimeSigneture.TabIndex = 23;
            this.grpBx_OutTimeSigneture.TabStop = false;
            this.grpBx_OutTimeSigneture.Text = "Signeture";
            // 
            // pBox_Out_Signeture
            // 
            this.pBox_Out_Signeture.Cursor = System.Windows.Forms.Cursors.No;
            this.pBox_Out_Signeture.Location = new System.Drawing.Point(6, 14);
            this.pBox_Out_Signeture.Name = "pBox_Out_Signeture";
            this.pBox_Out_Signeture.Size = new System.Drawing.Size(394, 115);
            this.pBox_Out_Signeture.TabIndex = 0;
            this.pBox_Out_Signeture.TabStop = false;
            // 
            // btn_Out_Reset
            // 
            this.btn_Out_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Out_Reset.Location = new System.Drawing.Point(739, 465);
            this.btn_Out_Reset.Name = "btn_Out_Reset";
            this.btn_Out_Reset.Size = new System.Drawing.Size(108, 31);
            this.btn_Out_Reset.TabIndex = 18;
            this.btn_Out_Reset.Text = "Reset";
            this.btn_Out_Reset.UseVisualStyleBackColor = true;
            this.btn_Out_Reset.Click += new System.EventHandler(this.btn_Out_Reset_Click);
            // 
            // btn_Out_Update
            // 
            this.btn_Out_Update.Enabled = false;
            this.btn_Out_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Out_Update.Location = new System.Drawing.Point(625, 465);
            this.btn_Out_Update.Name = "btn_Out_Update";
            this.btn_Out_Update.Size = new System.Drawing.Size(108, 31);
            this.btn_Out_Update.TabIndex = 17;
            this.btn_Out_Update.Text = "Update";
            this.btn_Out_Update.UseVisualStyleBackColor = true;
            this.btn_Out_Update.Click += new System.EventHandler(this.btn_Out_Update_Click);
            // 
            // grpBx_OutTimeImage
            // 
            this.grpBx_OutTimeImage.Controls.Add(this.pBox_Out_Image);
            this.grpBx_OutTimeImage.Location = new System.Drawing.Point(646, 100);
            this.grpBx_OutTimeImage.Name = "grpBx_OutTimeImage";
            this.grpBx_OutTimeImage.Size = new System.Drawing.Size(205, 209);
            this.grpBx_OutTimeImage.TabIndex = 22;
            this.grpBx_OutTimeImage.TabStop = false;
            // 
            // pBox_Out_Image
            // 
            this.pBox_Out_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Out_Image.Cursor = System.Windows.Forms.Cursors.No;
            this.pBox_Out_Image.Location = new System.Drawing.Point(9, 13);
            this.pBox_Out_Image.Name = "pBox_Out_Image";
            this.pBox_Out_Image.Size = new System.Drawing.Size(190, 190);
            this.pBox_Out_Image.TabIndex = 0;
            this.pBox_Out_Image.TabStop = false;
            // 
            // grpBx_OutTimeThingsAndIdentityDetails
            // 
            this.grpBx_OutTimeThingsAndIdentityDetails.Controls.Add(this.lbl_Visitor_Out_Identity_Card_Number);
            this.grpBx_OutTimeThingsAndIdentityDetails.Controls.Add(this.tbox_Out_Id_Proof);
            this.grpBx_OutTimeThingsAndIdentityDetails.Controls.Add(this.lbl_Visitor_Out_Device_Carrying);
            this.grpBx_OutTimeThingsAndIdentityDetails.Controls.Add(this.tbox_Out_Carrying_Laptop);
            this.grpBx_OutTimeThingsAndIdentityDetails.Location = new System.Drawing.Point(449, 6);
            this.grpBx_OutTimeThingsAndIdentityDetails.Name = "grpBx_OutTimeThingsAndIdentityDetails";
            this.grpBx_OutTimeThingsAndIdentityDetails.Size = new System.Drawing.Size(404, 86);
            this.grpBx_OutTimeThingsAndIdentityDetails.TabIndex = 21;
            this.grpBx_OutTimeThingsAndIdentityDetails.TabStop = false;
            // 
            // lbl_Visitor_Out_Identity_Card_Number
            // 
            this.lbl_Visitor_Out_Identity_Card_Number.AutoSize = true;
            this.lbl_Visitor_Out_Identity_Card_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Out_Identity_Card_Number.Location = new System.Drawing.Point(68, 51);
            this.lbl_Visitor_Out_Identity_Card_Number.Name = "lbl_Visitor_Out_Identity_Card_Number";
            this.lbl_Visitor_Out_Identity_Card_Number.Size = new System.Drawing.Size(72, 16);
            this.lbl_Visitor_Out_Identity_Card_Number.TabIndex = 5;
            this.lbl_Visitor_Out_Identity_Card_Number.Text = "ID Proof :";
            // 
            // tbox_Out_Id_Proof
            // 
            this.tbox_Out_Id_Proof.Location = new System.Drawing.Point(146, 50);
            this.tbox_Out_Id_Proof.Name = "tbox_Out_Id_Proof";
            this.tbox_Out_Id_Proof.Size = new System.Drawing.Size(252, 20);
            this.tbox_Out_Id_Proof.TabIndex = 15;
            // 
            // lbl_Visitor_Out_Device_Carrying
            // 
            this.lbl_Visitor_Out_Device_Carrying.AutoSize = true;
            this.lbl_Visitor_Out_Device_Carrying.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Out_Device_Carrying.Location = new System.Drawing.Point(6, 16);
            this.lbl_Visitor_Out_Device_Carrying.Name = "lbl_Visitor_Out_Device_Carrying";
            this.lbl_Visitor_Out_Device_Carrying.Size = new System.Drawing.Size(134, 16);
            this.lbl_Visitor_Out_Device_Carrying.TabIndex = 3;
            this.lbl_Visitor_Out_Device_Carrying.Text = "Carrying Laptop? :";
            // 
            // tbox_Out_Carrying_Laptop
            // 
            this.tbox_Out_Carrying_Laptop.Location = new System.Drawing.Point(146, 15);
            this.tbox_Out_Carrying_Laptop.Name = "tbox_Out_Carrying_Laptop";
            this.tbox_Out_Carrying_Laptop.Size = new System.Drawing.Size(252, 20);
            this.tbox_Out_Carrying_Laptop.TabIndex = 14;
            // 
            // grpBx_OutTimeDetails
            // 
            this.grpBx_OutTimeDetails.Controls.Add(this.cbox_Interview_Out_Purpose);
            this.grpBx_OutTimeDetails.Controls.Add(this.tbox_Out_Serial_Number);
            this.grpBx_OutTimeDetails.Controls.Add(this.cBox_Out_Floor_Number);
            this.grpBx_OutTimeDetails.Controls.Add(this.lbl_Visitor_Out_Floor_Number);
            this.grpBx_OutTimeDetails.Controls.Add(this.tbox_Out_Time);
            this.grpBx_OutTimeDetails.Controls.Add(this.tbox_Out_Whom_To_Meet);
            this.grpBx_OutTimeDetails.Controls.Add(this.tbox_Out_Remarks);
            this.grpBx_OutTimeDetails.Controls.Add(this.tbox_Out_Escort_Name);
            this.grpBx_OutTimeDetails.Controls.Add(this.tbox_Out_Badge_Number);
            this.grpBx_OutTimeDetails.Controls.Add(this.tbox_Out_Purpose);
            this.grpBx_OutTimeDetails.Controls.Add(this.tbox_Out_ContactNumber);
            this.grpBx_OutTimeDetails.Controls.Add(this.tbox_Out_Address);
            this.grpBx_OutTimeDetails.Controls.Add(this.tbox_Out_Name);
            this.grpBx_OutTimeDetails.Controls.Add(this.lbl_Visitor_Out_Remarks);
            this.grpBx_OutTimeDetails.Controls.Add(this.lbl_Visitor_Out_Time);
            this.grpBx_OutTimeDetails.Controls.Add(this.lbl_Visitor_Out_Escort_Name);
            this.grpBx_OutTimeDetails.Controls.Add(this.lbl_Visitor_Out_Badge_Number);
            this.grpBx_OutTimeDetails.Controls.Add(this.lbl_Visitor_Out_Whom_To_Meet);
            this.grpBx_OutTimeDetails.Controls.Add(this.lbl_Visitor_Out_Purpose);
            this.grpBx_OutTimeDetails.Controls.Add(this.lbl_Visitor_Out_Contact_Number);
            this.grpBx_OutTimeDetails.Controls.Add(this.lbl_Visitor_Out_Address);
            this.grpBx_OutTimeDetails.Controls.Add(this.lbl_Visitor_Out_Name);
            this.grpBx_OutTimeDetails.Location = new System.Drawing.Point(3, 6);
            this.grpBx_OutTimeDetails.Name = "grpBx_OutTimeDetails";
            this.grpBx_OutTimeDetails.Size = new System.Drawing.Size(440, 490);
            this.grpBx_OutTimeDetails.TabIndex = 20;
            this.grpBx_OutTimeDetails.TabStop = false;
            // 
            // cbox_Interview_Out_Purpose
            // 
            this.cbox_Interview_Out_Purpose.AutoSize = true;
            this.cbox_Interview_Out_Purpose.Location = new System.Drawing.Point(140, 163);
            this.cbox_Interview_Out_Purpose.Name = "cbox_Interview_Out_Purpose";
            this.cbox_Interview_Out_Purpose.Size = new System.Drawing.Size(69, 17);
            this.cbox_Interview_Out_Purpose.TabIndex = 6;
            this.cbox_Interview_Out_Purpose.Text = "Interview";
            this.cbox_Interview_Out_Purpose.UseVisualStyleBackColor = true;
            this.cbox_Interview_Out_Purpose.CheckedChanged += new System.EventHandler(this.cbox_Interview_Out_Purpose_CheckedChanged);
            // 
            // tbox_Out_Serial_Number
            // 
            this.tbox_Out_Serial_Number.Location = new System.Drawing.Point(3, 12);
            this.tbox_Out_Serial_Number.Name = "tbox_Out_Serial_Number";
            this.tbox_Out_Serial_Number.Size = new System.Drawing.Size(39, 20);
            this.tbox_Out_Serial_Number.TabIndex = 27;
            this.tbox_Out_Serial_Number.Visible = false;
            this.tbox_Out_Serial_Number.TextChanged += new System.EventHandler(this.tbox_Out_Serial_Number_TextChanged);
            // 
            // cBox_Out_Floor_Number
            // 
            this.cBox_Out_Floor_Number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Out_Floor_Number.FormattingEnabled = true;
            this.cBox_Out_Floor_Number.Items.AddRange(new object[] {
            "--------------------Select--------------------",
            "Floor - G",
            "Floor - 1",
            "Floor - 2",
            "Floor - 3",
            "Floor - 4",
            "Floor - 5",
            "Floor - 6",
            "Floor - 7",
            "Floor - 8",
            "Floor - 9"});
            this.cBox_Out_Floor_Number.Location = new System.Drawing.Point(140, 364);
            this.cBox_Out_Floor_Number.Name = "cBox_Out_Floor_Number";
            this.cBox_Out_Floor_Number.Size = new System.Drawing.Size(282, 21);
            this.cBox_Out_Floor_Number.TabIndex = 12;
            // 
            // lbl_Visitor_Out_Floor_Number
            // 
            this.lbl_Visitor_Out_Floor_Number.AutoSize = true;
            this.lbl_Visitor_Out_Floor_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Out_Floor_Number.Location = new System.Drawing.Point(34, 365);
            this.lbl_Visitor_Out_Floor_Number.Name = "lbl_Visitor_Out_Floor_Number";
            this.lbl_Visitor_Out_Floor_Number.Size = new System.Drawing.Size(98, 16);
            this.lbl_Visitor_Out_Floor_Number.TabIndex = 53;
            this.lbl_Visitor_Out_Floor_Number.Text = "Which Floor :";
            // 
            // tbox_Out_Time
            // 
            this.tbox_Out_Time.Enabled = false;
            this.tbox_Out_Time.Location = new System.Drawing.Point(140, 328);
            this.tbox_Out_Time.Name = "tbox_Out_Time";
            this.tbox_Out_Time.Size = new System.Drawing.Size(282, 20);
            this.tbox_Out_Time.TabIndex = 11;
            // 
            // tbox_Out_Whom_To_Meet
            // 
            this.tbox_Out_Whom_To_Meet.Location = new System.Drawing.Point(140, 221);
            this.tbox_Out_Whom_To_Meet.Name = "tbox_Out_Whom_To_Meet";
            this.tbox_Out_Whom_To_Meet.Size = new System.Drawing.Size(282, 20);
            this.tbox_Out_Whom_To_Meet.TabIndex = 8;
            // 
            // tbox_Out_Remarks
            // 
            this.tbox_Out_Remarks.Enabled = false;
            this.tbox_Out_Remarks.Location = new System.Drawing.Point(140, 400);
            this.tbox_Out_Remarks.Multiline = true;
            this.tbox_Out_Remarks.Name = "tbox_Out_Remarks";
            this.tbox_Out_Remarks.Size = new System.Drawing.Size(282, 68);
            this.tbox_Out_Remarks.TabIndex = 13;
            // 
            // tbox_Out_Escort_Name
            // 
            this.tbox_Out_Escort_Name.Location = new System.Drawing.Point(140, 295);
            this.tbox_Out_Escort_Name.Name = "tbox_Out_Escort_Name";
            this.tbox_Out_Escort_Name.Size = new System.Drawing.Size(282, 20);
            this.tbox_Out_Escort_Name.TabIndex = 10;
            // 
            // tbox_Out_Badge_Number
            // 
            this.tbox_Out_Badge_Number.Location = new System.Drawing.Point(140, 259);
            this.tbox_Out_Badge_Number.Name = "tbox_Out_Badge_Number";
            this.tbox_Out_Badge_Number.Size = new System.Drawing.Size(282, 20);
            this.tbox_Out_Badge_Number.TabIndex = 9;
            // 
            // tbox_Out_Purpose
            // 
            this.tbox_Out_Purpose.Location = new System.Drawing.Point(140, 186);
            this.tbox_Out_Purpose.Name = "tbox_Out_Purpose";
            this.tbox_Out_Purpose.Size = new System.Drawing.Size(282, 20);
            this.tbox_Out_Purpose.TabIndex = 7;
            // 
            // tbox_Out_ContactNumber
            // 
            this.tbox_Out_ContactNumber.Location = new System.Drawing.Point(140, 138);
            this.tbox_Out_ContactNumber.Name = "tbox_Out_ContactNumber";
            this.tbox_Out_ContactNumber.Size = new System.Drawing.Size(282, 20);
            this.tbox_Out_ContactNumber.TabIndex = 5;
            // 
            // tbox_Out_Address
            // 
            this.tbox_Out_Address.Location = new System.Drawing.Point(140, 60);
            this.tbox_Out_Address.Multiline = true;
            this.tbox_Out_Address.Name = "tbox_Out_Address";
            this.tbox_Out_Address.Size = new System.Drawing.Size(282, 66);
            this.tbox_Out_Address.TabIndex = 4;
            // 
            // tbox_Out_Name
            // 
            this.tbox_Out_Name.Location = new System.Drawing.Point(140, 31);
            this.tbox_Out_Name.Name = "tbox_Out_Name";
            this.tbox_Out_Name.Size = new System.Drawing.Size(282, 20);
            this.tbox_Out_Name.TabIndex = 3;
            // 
            // lbl_Visitor_Out_Remarks
            // 
            this.lbl_Visitor_Out_Remarks.AutoSize = true;
            this.lbl_Visitor_Out_Remarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Out_Remarks.Location = new System.Drawing.Point(56, 400);
            this.lbl_Visitor_Out_Remarks.Name = "lbl_Visitor_Out_Remarks";
            this.lbl_Visitor_Out_Remarks.Size = new System.Drawing.Size(78, 16);
            this.lbl_Visitor_Out_Remarks.TabIndex = 49;
            this.lbl_Visitor_Out_Remarks.Text = "Remarks :";
            // 
            // lbl_Visitor_Out_Time
            // 
            this.lbl_Visitor_Out_Time.AutoSize = true;
            this.lbl_Visitor_Out_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Out_Time.Location = new System.Drawing.Point(54, 329);
            this.lbl_Visitor_Out_Time.Name = "lbl_Visitor_Out_Time";
            this.lbl_Visitor_Out_Time.Size = new System.Drawing.Size(78, 16);
            this.lbl_Visitor_Out_Time.TabIndex = 47;
            this.lbl_Visitor_Out_Time.Text = "Out Time :";
            // 
            // lbl_Visitor_Out_Escort_Name
            // 
            this.lbl_Visitor_Out_Escort_Name.AutoSize = true;
            this.lbl_Visitor_Out_Escort_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Out_Escort_Name.Location = new System.Drawing.Point(29, 296);
            this.lbl_Visitor_Out_Escort_Name.Name = "lbl_Visitor_Out_Escort_Name";
            this.lbl_Visitor_Out_Escort_Name.Size = new System.Drawing.Size(105, 16);
            this.lbl_Visitor_Out_Escort_Name.TabIndex = 46;
            this.lbl_Visitor_Out_Escort_Name.Text = "Escort Name :";
            // 
            // lbl_Visitor_Out_Badge_Number
            // 
            this.lbl_Visitor_Out_Badge_Number.AutoSize = true;
            this.lbl_Visitor_Out_Badge_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Out_Badge_Number.Location = new System.Drawing.Point(12, 260);
            this.lbl_Visitor_Out_Badge_Number.Name = "lbl_Visitor_Out_Badge_Number";
            this.lbl_Visitor_Out_Badge_Number.Size = new System.Drawing.Size(120, 16);
            this.lbl_Visitor_Out_Badge_Number.TabIndex = 45;
            this.lbl_Visitor_Out_Badge_Number.Text = "Badge Number :";
            // 
            // lbl_Visitor_Out_Whom_To_Meet
            // 
            this.lbl_Visitor_Out_Whom_To_Meet.AutoSize = true;
            this.lbl_Visitor_Out_Whom_To_Meet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Out_Whom_To_Meet.Location = new System.Drawing.Point(14, 222);
            this.lbl_Visitor_Out_Whom_To_Meet.Name = "lbl_Visitor_Out_Whom_To_Meet";
            this.lbl_Visitor_Out_Whom_To_Meet.Size = new System.Drawing.Size(120, 16);
            this.lbl_Visitor_Out_Whom_To_Meet.TabIndex = 44;
            this.lbl_Visitor_Out_Whom_To_Meet.Text = "Whom To Meet :";
            // 
            // lbl_Visitor_Out_Purpose
            // 
            this.lbl_Visitor_Out_Purpose.AutoSize = true;
            this.lbl_Visitor_Out_Purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Out_Purpose.Location = new System.Drawing.Point(60, 187);
            this.lbl_Visitor_Out_Purpose.Name = "lbl_Visitor_Out_Purpose";
            this.lbl_Visitor_Out_Purpose.Size = new System.Drawing.Size(74, 16);
            this.lbl_Visitor_Out_Purpose.TabIndex = 43;
            this.lbl_Visitor_Out_Purpose.Text = "Purpose :";
            // 
            // lbl_Visitor_Out_Contact_Number
            // 
            this.lbl_Visitor_Out_Contact_Number.AutoSize = true;
            this.lbl_Visitor_Out_Contact_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Out_Contact_Number.Location = new System.Drawing.Point(6, 140);
            this.lbl_Visitor_Out_Contact_Number.Name = "lbl_Visitor_Out_Contact_Number";
            this.lbl_Visitor_Out_Contact_Number.Size = new System.Drawing.Size(126, 16);
            this.lbl_Visitor_Out_Contact_Number.TabIndex = 42;
            this.lbl_Visitor_Out_Contact_Number.Text = "Contact Number :";
            // 
            // lbl_Visitor_Out_Address
            // 
            this.lbl_Visitor_Out_Address.AutoSize = true;
            this.lbl_Visitor_Out_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Out_Address.Location = new System.Drawing.Point(19, 61);
            this.lbl_Visitor_Out_Address.Name = "lbl_Visitor_Out_Address";
            this.lbl_Visitor_Out_Address.Size = new System.Drawing.Size(113, 16);
            this.lbl_Visitor_Out_Address.TabIndex = 41;
            this.lbl_Visitor_Out_Address.Text = "From Address :";
            // 
            // lbl_Visitor_Out_Name
            // 
            this.lbl_Visitor_Out_Name.AutoSize = true;
            this.lbl_Visitor_Out_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Visitor_Out_Name.Location = new System.Drawing.Point(77, 32);
            this.lbl_Visitor_Out_Name.Name = "lbl_Visitor_Out_Name";
            this.lbl_Visitor_Out_Name.Size = new System.Drawing.Size(57, 16);
            this.lbl_Visitor_Out_Name.TabIndex = 40;
            this.lbl_Visitor_Out_Name.Text = "Name :";
            // 
            // tb_Page_InterOffice_Visitor
            // 
            this.tb_Page_InterOffice_Visitor.Controls.Add(this.tbox_InterOffice_Serial_Number);
            this.tb_Page_InterOffice_Visitor.Controls.Add(this.btn_Inter_Office_Reset);
            this.tb_Page_InterOffice_Visitor.Controls.Add(this.btn_Assign);
            this.tb_Page_InterOffice_Visitor.Controls.Add(this.cbox_Inter_Update_Return_Details);
            this.tb_Page_InterOffice_Visitor.Controls.Add(this.grpBx_Inter_Office_Return_Details);
            this.tb_Page_InterOffice_Visitor.Controls.Add(this.grpBx_Inter_Office_Emp_Signeture_Details);
            this.tb_Page_InterOffice_Visitor.Controls.Add(this.grpBx_Inter_Office_Emp_Image_Details);
            this.tb_Page_InterOffice_Visitor.Controls.Add(this.grpBx_Inter_Office_Access_Card_Details);
            this.tb_Page_InterOffice_Visitor.Controls.Add(this.grpBx_Inter_Office_Emp_Details);
            this.tb_Page_InterOffice_Visitor.Location = new System.Drawing.Point(4, 22);
            this.tb_Page_InterOffice_Visitor.Name = "tb_Page_InterOffice_Visitor";
            this.tb_Page_InterOffice_Visitor.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Page_InterOffice_Visitor.Size = new System.Drawing.Size(861, 506);
            this.tb_Page_InterOffice_Visitor.TabIndex = 3;
            this.tb_Page_InterOffice_Visitor.Text = "Inter Office";
            this.tb_Page_InterOffice_Visitor.UseVisualStyleBackColor = true;
            this.tb_Page_InterOffice_Visitor.Enter += new System.EventHandler(this.tb_Page_InterOffice_Visitor_Enter);
            // 
            // tbox_InterOffice_Serial_Number
            // 
            this.tbox_InterOffice_Serial_Number.Location = new System.Drawing.Point(431, 373);
            this.tbox_InterOffice_Serial_Number.Name = "tbox_InterOffice_Serial_Number";
            this.tbox_InterOffice_Serial_Number.Size = new System.Drawing.Size(31, 20);
            this.tbox_InterOffice_Serial_Number.TabIndex = 27;
            this.tbox_InterOffice_Serial_Number.Visible = false;
            // 
            // btn_Inter_Office_Reset
            // 
            this.btn_Inter_Office_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inter_Office_Reset.Location = new System.Drawing.Point(780, 370);
            this.btn_Inter_Office_Reset.Name = "btn_Inter_Office_Reset";
            this.btn_Inter_Office_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Inter_Office_Reset.TabIndex = 26;
            this.btn_Inter_Office_Reset.Text = "Reset";
            this.btn_Inter_Office_Reset.UseVisualStyleBackColor = true;
            this.btn_Inter_Office_Reset.Click += new System.EventHandler(this.btn_Inter_Office_Reset_Click);
            // 
            // btn_Assign
            // 
            this.btn_Assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Assign.Location = new System.Drawing.Point(699, 370);
            this.btn_Assign.Name = "btn_Assign";
            this.btn_Assign.Size = new System.Drawing.Size(75, 23);
            this.btn_Assign.TabIndex = 25;
            this.btn_Assign.Text = "Assign";
            this.btn_Assign.UseVisualStyleBackColor = true;
            this.btn_Assign.Click += new System.EventHandler(this.btn_Assign_Click);
            // 
            // cbox_Inter_Update_Return_Details
            // 
            this.cbox_Inter_Update_Return_Details.AutoSize = true;
            this.cbox_Inter_Update_Return_Details.Location = new System.Drawing.Point(9, 374);
            this.cbox_Inter_Update_Return_Details.Name = "cbox_Inter_Update_Return_Details";
            this.cbox_Inter_Update_Return_Details.Size = new System.Drawing.Size(131, 17);
            this.cbox_Inter_Update_Return_Details.TabIndex = 24;
            this.cbox_Inter_Update_Return_Details.Text = "Update Return Details";
            this.cbox_Inter_Update_Return_Details.UseVisualStyleBackColor = true;
            this.cbox_Inter_Update_Return_Details.CheckedChanged += new System.EventHandler(this.cbox_Inter_Update_Return_Details_CheckedChanged);
            // 
            // grpBx_Inter_Office_Return_Details
            // 
            this.grpBx_Inter_Office_Return_Details.Controls.Add(this.btn_Inter_Office_Return);
            this.grpBx_Inter_Office_Return_Details.Controls.Add(this.tbox_InterOffce_Return_Return_Time);
            this.grpBx_Inter_Office_Return_Details.Controls.Add(this.lbl_InterOffce_Return_Return_Time);
            this.grpBx_Inter_Office_Return_Details.Controls.Add(this.tbox_InterOffce_Return_Return_Date);
            this.grpBx_Inter_Office_Return_Details.Controls.Add(this.lbl_InterOffce_Return_Return_Date);
            this.grpBx_Inter_Office_Return_Details.Controls.Add(this.btn_Inter_Office_Search);
            this.grpBx_Inter_Office_Return_Details.Controls.Add(this.tbox_InterOffce_Return_Employee_Id);
            this.grpBx_Inter_Office_Return_Details.Controls.Add(this.lbl_InterOffce_Return_Employee_Id);
            this.grpBx_Inter_Office_Return_Details.Location = new System.Drawing.Point(6, 394);
            this.grpBx_Inter_Office_Return_Details.Name = "grpBx_Inter_Office_Return_Details";
            this.grpBx_Inter_Office_Return_Details.Size = new System.Drawing.Size(849, 106);
            this.grpBx_Inter_Office_Return_Details.TabIndex = 23;
            this.grpBx_Inter_Office_Return_Details.TabStop = false;
            this.grpBx_Inter_Office_Return_Details.Text = "Return Details";
            // 
            // btn_Inter_Office_Return
            // 
            this.btn_Inter_Office_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inter_Office_Return.Location = new System.Drawing.Point(716, 37);
            this.btn_Inter_Office_Return.Name = "btn_Inter_Office_Return";
            this.btn_Inter_Office_Return.Size = new System.Drawing.Size(102, 38);
            this.btn_Inter_Office_Return.TabIndex = 27;
            this.btn_Inter_Office_Return.Text = "Return";
            this.btn_Inter_Office_Return.UseVisualStyleBackColor = true;
            this.btn_Inter_Office_Return.Click += new System.EventHandler(this.btn_Inter_Office_Return_Click);
            // 
            // tbox_InterOffce_Return_Return_Time
            // 
            this.tbox_InterOffce_Return_Return_Time.Enabled = false;
            this.tbox_InterOffce_Return_Return_Time.Location = new System.Drawing.Point(372, 63);
            this.tbox_InterOffce_Return_Return_Time.Name = "tbox_InterOffce_Return_Return_Time";
            this.tbox_InterOffce_Return_Return_Time.Size = new System.Drawing.Size(168, 20);
            this.tbox_InterOffce_Return_Return_Time.TabIndex = 59;
            // 
            // lbl_InterOffce_Return_Return_Time
            // 
            this.lbl_InterOffce_Return_Return_Time.AutoSize = true;
            this.lbl_InterOffce_Return_Return_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_InterOffce_Return_Return_Time.Location = new System.Drawing.Point(270, 64);
            this.lbl_InterOffce_Return_Return_Time.Name = "lbl_InterOffce_Return_Return_Time";
            this.lbl_InterOffce_Return_Return_Time.Size = new System.Drawing.Size(100, 16);
            this.lbl_InterOffce_Return_Return_Time.TabIndex = 60;
            this.lbl_InterOffce_Return_Return_Time.Text = "Return Time :";
            // 
            // tbox_InterOffce_Return_Return_Date
            // 
            this.tbox_InterOffce_Return_Return_Date.Enabled = false;
            this.tbox_InterOffce_Return_Return_Date.Location = new System.Drawing.Point(124, 63);
            this.tbox_InterOffce_Return_Return_Date.Name = "tbox_InterOffce_Return_Return_Date";
            this.tbox_InterOffce_Return_Return_Date.Size = new System.Drawing.Size(117, 20);
            this.tbox_InterOffce_Return_Return_Date.TabIndex = 57;
            // 
            // lbl_InterOffce_Return_Return_Date
            // 
            this.lbl_InterOffce_Return_Return_Date.AutoSize = true;
            this.lbl_InterOffce_Return_Return_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_InterOffce_Return_Return_Date.Location = new System.Drawing.Point(24, 64);
            this.lbl_InterOffce_Return_Return_Date.Name = "lbl_InterOffce_Return_Return_Date";
            this.lbl_InterOffce_Return_Return_Date.Size = new System.Drawing.Size(98, 16);
            this.lbl_InterOffce_Return_Return_Date.TabIndex = 58;
            this.lbl_InterOffce_Return_Return_Date.Text = "Return Date :";
            // 
            // btn_Inter_Office_Search
            // 
            this.btn_Inter_Office_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inter_Office_Search.Location = new System.Drawing.Point(425, 23);
            this.btn_Inter_Office_Search.Name = "btn_Inter_Office_Search";
            this.btn_Inter_Office_Search.Size = new System.Drawing.Size(95, 22);
            this.btn_Inter_Office_Search.TabIndex = 56;
            this.btn_Inter_Office_Search.Text = "Search";
            this.btn_Inter_Office_Search.UseVisualStyleBackColor = true;
            this.btn_Inter_Office_Search.Click += new System.EventHandler(this.btn_Inter_Office_Search_Click);
            // 
            // tbox_InterOffce_Return_Employee_Id
            // 
            this.tbox_InterOffce_Return_Employee_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_InterOffce_Return_Employee_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_InterOffce_Return_Employee_Id.Location = new System.Drawing.Point(137, 24);
            this.tbox_InterOffce_Return_Employee_Id.Name = "tbox_InterOffce_Return_Employee_Id";
            this.tbox_InterOffce_Return_Employee_Id.Size = new System.Drawing.Size(282, 20);
            this.tbox_InterOffce_Return_Employee_Id.TabIndex = 54;
            this.tbox_InterOffce_Return_Employee_Id.TextChanged += new System.EventHandler(this.tbox_InterOffce_Return_Employee_Id_TextChanged);
            // 
            // lbl_InterOffce_Return_Employee_Id
            // 
            this.lbl_InterOffce_Return_Employee_Id.AutoSize = true;
            this.lbl_InterOffce_Return_Employee_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_InterOffce_Return_Employee_Id.Location = new System.Drawing.Point(20, 25);
            this.lbl_InterOffce_Return_Employee_Id.Name = "lbl_InterOffce_Return_Employee_Id";
            this.lbl_InterOffce_Return_Employee_Id.Size = new System.Drawing.Size(103, 16);
            this.lbl_InterOffce_Return_Employee_Id.TabIndex = 55;
            this.lbl_InterOffce_Return_Employee_Id.Text = "Employee Id :";
            // 
            // grpBx_Inter_Office_Emp_Signeture_Details
            // 
            this.grpBx_Inter_Office_Emp_Signeture_Details.Controls.Add(this.pBox_Inter_Office_Signeture);
            this.grpBx_Inter_Office_Emp_Signeture_Details.Location = new System.Drawing.Point(455, 233);
            this.grpBx_Inter_Office_Emp_Signeture_Details.Name = "grpBx_Inter_Office_Emp_Signeture_Details";
            this.grpBx_Inter_Office_Emp_Signeture_Details.Size = new System.Drawing.Size(400, 135);
            this.grpBx_Inter_Office_Emp_Signeture_Details.TabIndex = 20;
            this.grpBx_Inter_Office_Emp_Signeture_Details.TabStop = false;
            this.grpBx_Inter_Office_Emp_Signeture_Details.Text = "Signeture";
            // 
            // pBox_Inter_Office_Signeture
            // 
            this.pBox_Inter_Office_Signeture.Cursor = System.Windows.Forms.Cursors.No;
            this.pBox_Inter_Office_Signeture.Image = ((System.Drawing.Image)(resources.GetObject("pBox_Inter_Office_Signeture.Image")));
            this.pBox_Inter_Office_Signeture.Location = new System.Drawing.Point(6, 19);
            this.pBox_Inter_Office_Signeture.Name = "pBox_Inter_Office_Signeture";
            this.pBox_Inter_Office_Signeture.Size = new System.Drawing.Size(388, 110);
            this.pBox_Inter_Office_Signeture.TabIndex = 0;
            this.pBox_Inter_Office_Signeture.TabStop = false;
            // 
            // grpBx_Inter_Office_Emp_Image_Details
            // 
            this.grpBx_Inter_Office_Emp_Image_Details.Controls.Add(this.btn_Inter_Office_Stop);
            this.grpBx_Inter_Office_Emp_Image_Details.Controls.Add(this.btn_Inter_Office_Continue);
            this.grpBx_Inter_Office_Emp_Image_Details.Controls.Add(this.btn_Inter_Office_Webcam);
            this.grpBx_Inter_Office_Emp_Image_Details.Controls.Add(this.btn_Inter_Office_Take_Picture);
            this.grpBx_Inter_Office_Emp_Image_Details.Controls.Add(this.pBox_Inter_Office_Image);
            this.grpBx_Inter_Office_Emp_Image_Details.Location = new System.Drawing.Point(455, 6);
            this.grpBx_Inter_Office_Emp_Image_Details.Name = "grpBx_Inter_Office_Emp_Image_Details";
            this.grpBx_Inter_Office_Emp_Image_Details.Size = new System.Drawing.Size(400, 221);
            this.grpBx_Inter_Office_Emp_Image_Details.TabIndex = 3;
            this.grpBx_Inter_Office_Emp_Image_Details.TabStop = false;
            this.grpBx_Inter_Office_Emp_Image_Details.Text = "Employee Image";
            // 
            // btn_Inter_Office_Stop
            // 
            this.btn_Inter_Office_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inter_Office_Stop.Location = new System.Drawing.Point(224, 162);
            this.btn_Inter_Office_Stop.Name = "btn_Inter_Office_Stop";
            this.btn_Inter_Office_Stop.Size = new System.Drawing.Size(158, 38);
            this.btn_Inter_Office_Stop.TabIndex = 23;
            this.btn_Inter_Office_Stop.Text = "Stop";
            this.btn_Inter_Office_Stop.UseVisualStyleBackColor = true;
            this.btn_Inter_Office_Stop.Click += new System.EventHandler(this.btn_Inter_Office_Stop_Click);
            // 
            // btn_Inter_Office_Continue
            // 
            this.btn_Inter_Office_Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Inter_Office_Continue.Location = new System.Drawing.Point(224, 74);
            this.btn_Inter_Office_Continue.Name = "btn_Inter_Office_Continue";
            this.btn_Inter_Office_Continue.Size = new System.Drawing.Size(158, 38);
            this.btn_Inter_Office_Continue.TabIndex = 24;
            this.btn_Inter_Office_Continue.Text = "Continue";
            this.btn_Inter_Office_Continue.UseVisualStyleBackColor = true;
            this.btn_Inter_Office_Continue.Click += new System.EventHandler(this.btn_Inter_Office_Continue_Click);
            // 
            // btn_Inter_Office_Webcam
            // 
            this.btn_Inter_Office_Webcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inter_Office_Webcam.Location = new System.Drawing.Point(224, 30);
            this.btn_Inter_Office_Webcam.Name = "btn_Inter_Office_Webcam";
            this.btn_Inter_Office_Webcam.Size = new System.Drawing.Size(158, 38);
            this.btn_Inter_Office_Webcam.TabIndex = 21;
            this.btn_Inter_Office_Webcam.Text = "Open Web Cam";
            this.btn_Inter_Office_Webcam.UseVisualStyleBackColor = true;
            this.btn_Inter_Office_Webcam.Click += new System.EventHandler(this.btn_Inter_Office_Webcam_Click);
            // 
            // btn_Inter_Office_Take_Picture
            // 
            this.btn_Inter_Office_Take_Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inter_Office_Take_Picture.Location = new System.Drawing.Point(224, 118);
            this.btn_Inter_Office_Take_Picture.Name = "btn_Inter_Office_Take_Picture";
            this.btn_Inter_Office_Take_Picture.Size = new System.Drawing.Size(158, 38);
            this.btn_Inter_Office_Take_Picture.TabIndex = 22;
            this.btn_Inter_Office_Take_Picture.Text = "Take Picture";
            this.btn_Inter_Office_Take_Picture.UseVisualStyleBackColor = true;
            this.btn_Inter_Office_Take_Picture.Click += new System.EventHandler(this.btn_Inter_Office_Take_Picture_Click);
            // 
            // pBox_Inter_Office_Image
            // 
            this.pBox_Inter_Office_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Inter_Office_Image.Cursor = System.Windows.Forms.Cursors.No;
            this.pBox_Inter_Office_Image.Location = new System.Drawing.Point(24, 30);
            this.pBox_Inter_Office_Image.Name = "pBox_Inter_Office_Image";
            this.pBox_Inter_Office_Image.Size = new System.Drawing.Size(170, 170);
            this.pBox_Inter_Office_Image.TabIndex = 20;
            this.pBox_Inter_Office_Image.TabStop = false;
            // 
            // grpBx_Inter_Office_Access_Card_Details
            // 
            this.grpBx_Inter_Office_Access_Card_Details.Controls.Add(this.tbox_InterOffce_Issuing_Time);
            this.grpBx_Inter_Office_Access_Card_Details.Controls.Add(this.tbox_InterOffce_No_Of_Days);
            this.grpBx_Inter_Office_Access_Card_Details.Controls.Add(this.lbl_InterOffce_No_Of_Days);
            this.grpBx_Inter_Office_Access_Card_Details.Controls.Add(this.lbl_InterOffce_Issuing_Time);
            this.grpBx_Inter_Office_Access_Card_Details.Controls.Add(this.tbox_InterOffce_Access_Card_Number);
            this.grpBx_Inter_Office_Access_Card_Details.Controls.Add(this.lbl_InterOffce_Access_Card_Number);
            this.grpBx_Inter_Office_Access_Card_Details.Controls.Add(this.tbox_InterOffce_Badge_Number);
            this.grpBx_Inter_Office_Access_Card_Details.Controls.Add(this.lbl_InterOffce_Badge_Number);
            this.grpBx_Inter_Office_Access_Card_Details.Location = new System.Drawing.Point(9, 233);
            this.grpBx_Inter_Office_Access_Card_Details.Name = "grpBx_Inter_Office_Access_Card_Details";
            this.grpBx_Inter_Office_Access_Card_Details.Size = new System.Drawing.Size(437, 135);
            this.grpBx_Inter_Office_Access_Card_Details.TabIndex = 2;
            this.grpBx_Inter_Office_Access_Card_Details.TabStop = false;
            this.grpBx_Inter_Office_Access_Card_Details.Text = "Access Card Assignment Details";
            // 
            // tbox_InterOffce_Issuing_Time
            // 
            this.tbox_InterOffce_Issuing_Time.Enabled = false;
            this.tbox_InterOffce_Issuing_Time.Location = new System.Drawing.Point(140, 75);
            this.tbox_InterOffce_Issuing_Time.Name = "tbox_InterOffce_Issuing_Time";
            this.tbox_InterOffce_Issuing_Time.Size = new System.Drawing.Size(282, 20);
            this.tbox_InterOffce_Issuing_Time.TabIndex = 54;
            // 
            // tbox_InterOffce_No_Of_Days
            // 
            this.tbox_InterOffce_No_Of_Days.Location = new System.Drawing.Point(140, 101);
            this.tbox_InterOffce_No_Of_Days.Name = "tbox_InterOffce_No_Of_Days";
            this.tbox_InterOffce_No_Of_Days.Size = new System.Drawing.Size(282, 20);
            this.tbox_InterOffce_No_Of_Days.TabIndex = 54;
            // 
            // lbl_InterOffce_No_Of_Days
            // 
            this.lbl_InterOffce_No_Of_Days.AutoSize = true;
            this.lbl_InterOffce_No_Of_Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_InterOffce_No_Of_Days.Location = new System.Drawing.Point(31, 102);
            this.lbl_InterOffce_No_Of_Days.Name = "lbl_InterOffce_No_Of_Days";
            this.lbl_InterOffce_No_Of_Days.Size = new System.Drawing.Size(95, 16);
            this.lbl_InterOffce_No_Of_Days.TabIndex = 55;
            this.lbl_InterOffce_No_Of_Days.Text = "No Of Days :";
            // 
            // lbl_InterOffce_Issuing_Time
            // 
            this.lbl_InterOffce_Issuing_Time.AutoSize = true;
            this.lbl_InterOffce_Issuing_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_InterOffce_Issuing_Time.Location = new System.Drawing.Point(13, 76);
            this.lbl_InterOffce_Issuing_Time.Name = "lbl_InterOffce_Issuing_Time";
            this.lbl_InterOffce_Issuing_Time.Size = new System.Drawing.Size(113, 16);
            this.lbl_InterOffce_Issuing_Time.TabIndex = 58;
            this.lbl_InterOffce_Issuing_Time.Text = "Issueing Time :";
            // 
            // tbox_InterOffce_Access_Card_Number
            // 
            this.tbox_InterOffce_Access_Card_Number.Location = new System.Drawing.Point(140, 49);
            this.tbox_InterOffce_Access_Card_Number.Name = "tbox_InterOffce_Access_Card_Number";
            this.tbox_InterOffce_Access_Card_Number.Size = new System.Drawing.Size(282, 20);
            this.tbox_InterOffce_Access_Card_Number.TabIndex = 10;
            // 
            // lbl_InterOffce_Access_Card_Number
            // 
            this.lbl_InterOffce_Access_Card_Number.AutoSize = true;
            this.lbl_InterOffce_Access_Card_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_InterOffce_Access_Card_Number.Location = new System.Drawing.Point(6, 50);
            this.lbl_InterOffce_Access_Card_Number.Name = "lbl_InterOffce_Access_Card_Number";
            this.lbl_InterOffce_Access_Card_Number.Size = new System.Drawing.Size(132, 16);
            this.lbl_InterOffce_Access_Card_Number.TabIndex = 57;
            this.lbl_InterOffce_Access_Card_Number.Text = "Access Card No. :";
            // 
            // tbox_InterOffce_Badge_Number
            // 
            this.tbox_InterOffce_Badge_Number.Location = new System.Drawing.Point(140, 23);
            this.tbox_InterOffce_Badge_Number.Name = "tbox_InterOffce_Badge_Number";
            this.tbox_InterOffce_Badge_Number.Size = new System.Drawing.Size(282, 20);
            this.tbox_InterOffce_Badge_Number.TabIndex = 9;
            // 
            // lbl_InterOffce_Badge_Number
            // 
            this.lbl_InterOffce_Badge_Number.AutoSize = true;
            this.lbl_InterOffce_Badge_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_InterOffce_Badge_Number.Location = new System.Drawing.Point(6, 24);
            this.lbl_InterOffce_Badge_Number.Name = "lbl_InterOffce_Badge_Number";
            this.lbl_InterOffce_Badge_Number.Size = new System.Drawing.Size(120, 16);
            this.lbl_InterOffce_Badge_Number.TabIndex = 55;
            this.lbl_InterOffce_Badge_Number.Text = "Badge Number :";
            // 
            // grpBx_Inter_Office_Emp_Details
            // 
            this.grpBx_Inter_Office_Emp_Details.Controls.Add(this.tbox_InterOffce_Remarks);
            this.grpBx_Inter_Office_Emp_Details.Controls.Add(this.lbl_InterOffce_Remarks);
            this.grpBx_Inter_Office_Emp_Details.Controls.Add(this.tbox_InterOffce_Employee_Id);
            this.grpBx_Inter_Office_Emp_Details.Controls.Add(this.lbl_InterOffce_Employee_Id);
            this.grpBx_Inter_Office_Emp_Details.Controls.Add(this.tbox_InterOffce_Date);
            this.grpBx_Inter_Office_Emp_Details.Controls.Add(this.tbox_InterOffce_Contact_Number);
            this.grpBx_Inter_Office_Emp_Details.Controls.Add(this.tbox_InterOffce_Employee_Name);
            this.grpBx_Inter_Office_Emp_Details.Controls.Add(this.tbox_InterOffce_Comming_From);
            this.grpBx_Inter_Office_Emp_Details.Controls.Add(this.lbl_InterOffce_Date);
            this.grpBx_Inter_Office_Emp_Details.Controls.Add(this.lbl_InterOffce_Contact_Number);
            this.grpBx_Inter_Office_Emp_Details.Controls.Add(this.lbl_InterOffce_Comming_From);
            this.grpBx_Inter_Office_Emp_Details.Controls.Add(this.lbl_InterOffce_Employee_Name);
            this.grpBx_Inter_Office_Emp_Details.Location = new System.Drawing.Point(6, 6);
            this.grpBx_Inter_Office_Emp_Details.Name = "grpBx_Inter_Office_Emp_Details";
            this.grpBx_Inter_Office_Emp_Details.Size = new System.Drawing.Size(440, 221);
            this.grpBx_Inter_Office_Emp_Details.TabIndex = 1;
            this.grpBx_Inter_Office_Emp_Details.TabStop = false;
            this.grpBx_Inter_Office_Emp_Details.Text = "Employee Details";
            // 
            // tbox_InterOffce_Remarks
            // 
            this.tbox_InterOffce_Remarks.Location = new System.Drawing.Point(143, 161);
            this.tbox_InterOffce_Remarks.Multiline = true;
            this.tbox_InterOffce_Remarks.Name = "tbox_InterOffce_Remarks";
            this.tbox_InterOffce_Remarks.Size = new System.Drawing.Size(282, 52);
            this.tbox_InterOffce_Remarks.TabIndex = 54;
            // 
            // lbl_InterOffce_Remarks
            // 
            this.lbl_InterOffce_Remarks.AutoSize = true;
            this.lbl_InterOffce_Remarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_InterOffce_Remarks.Location = new System.Drawing.Point(51, 162);
            this.lbl_InterOffce_Remarks.Name = "lbl_InterOffce_Remarks";
            this.lbl_InterOffce_Remarks.Size = new System.Drawing.Size(78, 16);
            this.lbl_InterOffce_Remarks.TabIndex = 55;
            this.lbl_InterOffce_Remarks.Text = "Remarks :";
            // 
            // tbox_InterOffce_Employee_Id
            // 
            this.tbox_InterOffce_Employee_Id.Location = new System.Drawing.Point(143, 18);
            this.tbox_InterOffce_Employee_Id.Name = "tbox_InterOffce_Employee_Id";
            this.tbox_InterOffce_Employee_Id.Size = new System.Drawing.Size(282, 20);
            this.tbox_InterOffce_Employee_Id.TabIndex = 3;
            // 
            // lbl_InterOffce_Employee_Id
            // 
            this.lbl_InterOffce_Employee_Id.AutoSize = true;
            this.lbl_InterOffce_Employee_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_InterOffce_Employee_Id.Location = new System.Drawing.Point(26, 19);
            this.lbl_InterOffce_Employee_Id.Name = "lbl_InterOffce_Employee_Id";
            this.lbl_InterOffce_Employee_Id.Size = new System.Drawing.Size(103, 16);
            this.lbl_InterOffce_Employee_Id.TabIndex = 53;
            this.lbl_InterOffce_Employee_Id.Text = "Employee Id :";
            // 
            // tbox_InterOffce_Date
            // 
            this.tbox_InterOffce_Date.Enabled = false;
            this.tbox_InterOffce_Date.Location = new System.Drawing.Point(143, 131);
            this.tbox_InterOffce_Date.Name = "tbox_InterOffce_Date";
            this.tbox_InterOffce_Date.Size = new System.Drawing.Size(282, 20);
            this.tbox_InterOffce_Date.TabIndex = 8;
            // 
            // tbox_InterOffce_Contact_Number
            // 
            this.tbox_InterOffce_Contact_Number.Location = new System.Drawing.Point(143, 104);
            this.tbox_InterOffce_Contact_Number.Name = "tbox_InterOffce_Contact_Number";
            this.tbox_InterOffce_Contact_Number.Size = new System.Drawing.Size(282, 20);
            this.tbox_InterOffce_Contact_Number.TabIndex = 6;
            // 
            // tbox_InterOffce_Employee_Name
            // 
            this.tbox_InterOffce_Employee_Name.Location = new System.Drawing.Point(143, 46);
            this.tbox_InterOffce_Employee_Name.Name = "tbox_InterOffce_Employee_Name";
            this.tbox_InterOffce_Employee_Name.Size = new System.Drawing.Size(282, 20);
            this.tbox_InterOffce_Employee_Name.TabIndex = 4;
            // 
            // tbox_InterOffce_Comming_From
            // 
            this.tbox_InterOffce_Comming_From.Location = new System.Drawing.Point(143, 74);
            this.tbox_InterOffce_Comming_From.Name = "tbox_InterOffce_Comming_From";
            this.tbox_InterOffce_Comming_From.Size = new System.Drawing.Size(282, 20);
            this.tbox_InterOffce_Comming_From.TabIndex = 5;
            // 
            // lbl_InterOffce_Date
            // 
            this.lbl_InterOffce_Date.AutoSize = true;
            this.lbl_InterOffce_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_InterOffce_Date.Location = new System.Drawing.Point(80, 132);
            this.lbl_InterOffce_Date.Name = "lbl_InterOffce_Date";
            this.lbl_InterOffce_Date.Size = new System.Drawing.Size(49, 16);
            this.lbl_InterOffce_Date.TabIndex = 47;
            this.lbl_InterOffce_Date.Text = "Date :";
            // 
            // lbl_InterOffce_Contact_Number
            // 
            this.lbl_InterOffce_Contact_Number.AutoSize = true;
            this.lbl_InterOffce_Contact_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_InterOffce_Contact_Number.Location = new System.Drawing.Point(3, 105);
            this.lbl_InterOffce_Contact_Number.Name = "lbl_InterOffce_Contact_Number";
            this.lbl_InterOffce_Contact_Number.Size = new System.Drawing.Size(126, 16);
            this.lbl_InterOffce_Contact_Number.TabIndex = 42;
            this.lbl_InterOffce_Contact_Number.Text = "Contact Number :";
            // 
            // lbl_InterOffce_Comming_From
            // 
            this.lbl_InterOffce_Comming_From.AutoSize = true;
            this.lbl_InterOffce_Comming_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_InterOffce_Comming_From.Location = new System.Drawing.Point(10, 75);
            this.lbl_InterOffce_Comming_From.Name = "lbl_InterOffce_Comming_From";
            this.lbl_InterOffce_Comming_From.Size = new System.Drawing.Size(119, 16);
            this.lbl_InterOffce_Comming_From.TabIndex = 41;
            this.lbl_InterOffce_Comming_From.Text = "Comming From :";
            // 
            // lbl_InterOffce_Employee_Name
            // 
            this.lbl_InterOffce_Employee_Name.AutoSize = true;
            this.lbl_InterOffce_Employee_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InterOffce_Employee_Name.Location = new System.Drawing.Point(72, 47);
            this.lbl_InterOffce_Employee_Name.Name = "lbl_InterOffce_Employee_Name";
            this.lbl_InterOffce_Employee_Name.Size = new System.Drawing.Size(57, 16);
            this.lbl_InterOffce_Employee_Name.TabIndex = 40;
            this.lbl_InterOffce_Employee_Name.Text = "Name :";
            // 
            // tb_Page_VisitorDetails_Report
            // 
            this.tb_Page_VisitorDetails_Report.Controls.Add(this.grpBx_Inter_Office_Report);
            this.tb_Page_VisitorDetails_Report.Controls.Add(this.grpBx_QuickReport);
            this.tb_Page_VisitorDetails_Report.Controls.Add(this.grpBx_DetailedReport);
            this.tb_Page_VisitorDetails_Report.Location = new System.Drawing.Point(4, 22);
            this.tb_Page_VisitorDetails_Report.Name = "tb_Page_VisitorDetails_Report";
            this.tb_Page_VisitorDetails_Report.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Page_VisitorDetails_Report.Size = new System.Drawing.Size(861, 506);
            this.tb_Page_VisitorDetails_Report.TabIndex = 2;
            this.tb_Page_VisitorDetails_Report.Text = "Report";
            this.tb_Page_VisitorDetails_Report.UseVisualStyleBackColor = true;
            this.tb_Page_VisitorDetails_Report.Enter += new System.EventHandler(this.tb_Page_VisitorDetails_Report_Enter);
            // 
            // grpBx_Inter_Office_Report
            // 
            this.grpBx_Inter_Office_Report.Controls.Add(this.btn_Report_Inter_Office_Last_7_Days);
            this.grpBx_Inter_Office_Report.Controls.Add(this.btn_Report_Inter_Office_Today);
            this.grpBx_Inter_Office_Report.Controls.Add(this.btn_Report_Inter_Office_Specific_Employee);
            this.grpBx_Inter_Office_Report.Controls.Add(this.btn_Report_Inter_Office_Specified_Employee);
            this.grpBx_Inter_Office_Report.Controls.Add(this.btn_Report_Inter_Office_1_Month);
            this.grpBx_Inter_Office_Report.Location = new System.Drawing.Point(6, 425);
            this.grpBx_Inter_Office_Report.Name = "grpBx_Inter_Office_Report";
            this.grpBx_Inter_Office_Report.Size = new System.Drawing.Size(849, 78);
            this.grpBx_Inter_Office_Report.TabIndex = 3;
            this.grpBx_Inter_Office_Report.TabStop = false;
            this.grpBx_Inter_Office_Report.Text = "Inter Office Report";
            // 
            // btn_Report_Inter_Office_Last_7_Days
            // 
            this.btn_Report_Inter_Office_Last_7_Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report_Inter_Office_Last_7_Days.Location = new System.Drawing.Point(199, 19);
            this.btn_Report_Inter_Office_Last_7_Days.Name = "btn_Report_Inter_Office_Last_7_Days";
            this.btn_Report_Inter_Office_Last_7_Days.Size = new System.Drawing.Size(142, 47);
            this.btn_Report_Inter_Office_Last_7_Days.TabIndex = 7;
            this.btn_Report_Inter_Office_Last_7_Days.Text = "Inter Office Last 7 Days";
            this.btn_Report_Inter_Office_Last_7_Days.UseVisualStyleBackColor = true;
            this.btn_Report_Inter_Office_Last_7_Days.Click += new System.EventHandler(this.btn_Report_Inter_Office_Last_7_Days_Click);
            // 
            // btn_Report_Inter_Office_Today
            // 
            this.btn_Report_Inter_Office_Today.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report_Inter_Office_Today.Location = new System.Drawing.Point(47, 19);
            this.btn_Report_Inter_Office_Today.Name = "btn_Report_Inter_Office_Today";
            this.btn_Report_Inter_Office_Today.Size = new System.Drawing.Size(142, 47);
            this.btn_Report_Inter_Office_Today.TabIndex = 6;
            this.btn_Report_Inter_Office_Today.Text = "Inter Office Today";
            this.btn_Report_Inter_Office_Today.UseVisualStyleBackColor = true;
            this.btn_Report_Inter_Office_Today.Click += new System.EventHandler(this.btn_Report_Inter_Office_Today_Click);
            // 
            // btn_Report_Inter_Office_Specific_Employee
            // 
            this.btn_Report_Inter_Office_Specific_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report_Inter_Office_Specific_Employee.Location = new System.Drawing.Point(643, 19);
            this.btn_Report_Inter_Office_Specific_Employee.Name = "btn_Report_Inter_Office_Specific_Employee";
            this.btn_Report_Inter_Office_Specific_Employee.Size = new System.Drawing.Size(160, 47);
            this.btn_Report_Inter_Office_Specific_Employee.TabIndex = 5;
            this.btn_Report_Inter_Office_Specific_Employee.Text = "Specified Date Range";
            this.btn_Report_Inter_Office_Specific_Employee.UseVisualStyleBackColor = true;
            this.btn_Report_Inter_Office_Specific_Employee.Click += new System.EventHandler(this.btn_Report_Inter_Office_Specific_Employee_Click);
            // 
            // btn_Report_Inter_Office_Specified_Employee
            // 
            this.btn_Report_Inter_Office_Specified_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report_Inter_Office_Specified_Employee.Location = new System.Drawing.Point(495, 19);
            this.btn_Report_Inter_Office_Specified_Employee.Name = "btn_Report_Inter_Office_Specified_Employee";
            this.btn_Report_Inter_Office_Specified_Employee.Size = new System.Drawing.Size(142, 47);
            this.btn_Report_Inter_Office_Specified_Employee.TabIndex = 4;
            this.btn_Report_Inter_Office_Specified_Employee.Text = "Sepcified Employee";
            this.btn_Report_Inter_Office_Specified_Employee.UseVisualStyleBackColor = true;
            this.btn_Report_Inter_Office_Specified_Employee.Click += new System.EventHandler(this.btn_Report_Inter_Office_Specified_Employee_Click);
            // 
            // btn_Report_Inter_Office_1_Month
            // 
            this.btn_Report_Inter_Office_1_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report_Inter_Office_1_Month.Location = new System.Drawing.Point(347, 19);
            this.btn_Report_Inter_Office_1_Month.Name = "btn_Report_Inter_Office_1_Month";
            this.btn_Report_Inter_Office_1_Month.Size = new System.Drawing.Size(142, 47);
            this.btn_Report_Inter_Office_1_Month.TabIndex = 3;
            this.btn_Report_Inter_Office_1_Month.Text = "Inter-Office Last 1 Month";
            this.btn_Report_Inter_Office_1_Month.UseVisualStyleBackColor = true;
            this.btn_Report_Inter_Office_1_Month.Click += new System.EventHandler(this.btn_Report_Inter_Office_1_Month_Click);
            // 
            // grpBx_QuickReport
            // 
            this.grpBx_QuickReport.Controls.Add(this.btn_Report_Interview_1_Month);
            this.grpBx_QuickReport.Controls.Add(this.btn_Report_Last_7_Days);
            this.grpBx_QuickReport.Controls.Add(this.btn_Report_Today);
            this.grpBx_QuickReport.Location = new System.Drawing.Point(6, 342);
            this.grpBx_QuickReport.Name = "grpBx_QuickReport";
            this.grpBx_QuickReport.Size = new System.Drawing.Size(849, 78);
            this.grpBx_QuickReport.TabIndex = 2;
            this.grpBx_QuickReport.TabStop = false;
            this.grpBx_QuickReport.Text = "Visitor Quick Report";
            // 
            // btn_Report_Interview_1_Month
            // 
            this.btn_Report_Interview_1_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report_Interview_1_Month.Location = new System.Drawing.Point(534, 19);
            this.btn_Report_Interview_1_Month.Name = "btn_Report_Interview_1_Month";
            this.btn_Report_Interview_1_Month.Size = new System.Drawing.Size(167, 47);
            this.btn_Report_Interview_1_Month.TabIndex = 2;
            this.btn_Report_Interview_1_Month.Text = "Interview Candidate Last 1 Month";
            this.btn_Report_Interview_1_Month.UseVisualStyleBackColor = true;
            this.btn_Report_Interview_1_Month.Click += new System.EventHandler(this.btn_Report_Interview_1_Month_Click);
            // 
            // btn_Report_Last_7_Days
            // 
            this.btn_Report_Last_7_Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report_Last_7_Days.Location = new System.Drawing.Point(368, 19);
            this.btn_Report_Last_7_Days.Name = "btn_Report_Last_7_Days";
            this.btn_Report_Last_7_Days.Size = new System.Drawing.Size(142, 47);
            this.btn_Report_Last_7_Days.TabIndex = 1;
            this.btn_Report_Last_7_Days.Text = "Last 7 Days";
            this.btn_Report_Last_7_Days.UseVisualStyleBackColor = true;
            this.btn_Report_Last_7_Days.Click += new System.EventHandler(this.btn_Report_Last_7_Days_Click);
            // 
            // btn_Report_Today
            // 
            this.btn_Report_Today.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report_Today.Location = new System.Drawing.Point(199, 19);
            this.btn_Report_Today.Name = "btn_Report_Today";
            this.btn_Report_Today.Size = new System.Drawing.Size(142, 47);
            this.btn_Report_Today.TabIndex = 0;
            this.btn_Report_Today.Text = "Today";
            this.btn_Report_Today.UseVisualStyleBackColor = true;
            this.btn_Report_Today.Click += new System.EventHandler(this.btn_Report_Today_Click);
            // 
            // grpBx_DetailedReport
            // 
            this.grpBx_DetailedReport.Controls.Add(this.cbox_Interview_Report_Purpose);
            this.grpBx_DetailedReport.Controls.Add(this.btn_Reset_Extract);
            this.grpBx_DetailedReport.Controls.Add(this.cbox_dload_Images);
            this.grpBx_DetailedReport.Controls.Add(this.btn_Report_Extract);
            this.grpBx_DetailedReport.Controls.Add(this.lbl_Visitor_Report_Identity_Card_Number);
            this.grpBx_DetailedReport.Controls.Add(this.tbox_Report_Id_Proof);
            this.grpBx_DetailedReport.Controls.Add(this.lbl_Visitor_Report_Device_Carrying);
            this.grpBx_DetailedReport.Controls.Add(this.tbox_Report_Carrying_Laptop);
            this.grpBx_DetailedReport.Controls.Add(this.dtPk_Report_OutTime);
            this.grpBx_DetailedReport.Controls.Add(this.dtPk_Report_InTime);
            this.grpBx_DetailedReport.Controls.Add(this.lbl_Visitor_Report_OutTime);
            this.grpBx_DetailedReport.Controls.Add(this.cBox_Report_Floor_Number);
            this.grpBx_DetailedReport.Controls.Add(this.lbl_Visitor_Report_Floor_Number);
            this.grpBx_DetailedReport.Controls.Add(this.tbox_Report_Whom_To_Meet);
            this.grpBx_DetailedReport.Controls.Add(this.tbox_Report_Remarks);
            this.grpBx_DetailedReport.Controls.Add(this.tbox_Report_Escort_Name);
            this.grpBx_DetailedReport.Controls.Add(this.tbox_Report_Badge_Number);
            this.grpBx_DetailedReport.Controls.Add(this.tbox_Report_Purpose);
            this.grpBx_DetailedReport.Controls.Add(this.tbox_Report_ContactNumber);
            this.grpBx_DetailedReport.Controls.Add(this.tbox_Report_Address);
            this.grpBx_DetailedReport.Controls.Add(this.tbox_Report_Name);
            this.grpBx_DetailedReport.Controls.Add(this.lbl_Visitor_Report_Remarks);
            this.grpBx_DetailedReport.Controls.Add(this.lbl_Visitor_Report_InTime);
            this.grpBx_DetailedReport.Controls.Add(this.lbl_Visitor_Report_Escort_Name);
            this.grpBx_DetailedReport.Controls.Add(this.lbl_Visitor_Report_Badge_Number);
            this.grpBx_DetailedReport.Controls.Add(this.lbl_Visitor_Report_Whom_To_Meet);
            this.grpBx_DetailedReport.Controls.Add(this.lbl_Visitor_Report_Purpose);
            this.grpBx_DetailedReport.Controls.Add(this.lbl_Visitor_Report_Contact_Number);
            this.grpBx_DetailedReport.Controls.Add(this.lbl_Visitor_Report_Address);
            this.grpBx_DetailedReport.Controls.Add(this.lbl_Visitor_Report_Name);
            this.grpBx_DetailedReport.Location = new System.Drawing.Point(6, 6);
            this.grpBx_DetailedReport.Name = "grpBx_DetailedReport";
            this.grpBx_DetailedReport.Size = new System.Drawing.Size(849, 330);
            this.grpBx_DetailedReport.TabIndex = 1;
            this.grpBx_DetailedReport.TabStop = false;
            this.grpBx_DetailedReport.Text = "Detailed Report";
            // 
            // cbox_Interview_Report_Purpose
            // 
            this.cbox_Interview_Report_Purpose.AutoSize = true;
            this.cbox_Interview_Report_Purpose.Location = new System.Drawing.Point(131, 173);
            this.cbox_Interview_Report_Purpose.Name = "cbox_Interview_Report_Purpose";
            this.cbox_Interview_Report_Purpose.Size = new System.Drawing.Size(69, 17);
            this.cbox_Interview_Report_Purpose.TabIndex = 58;
            this.cbox_Interview_Report_Purpose.Text = "Interview";
            this.cbox_Interview_Report_Purpose.UseVisualStyleBackColor = true;
            this.cbox_Interview_Report_Purpose.CheckedChanged += new System.EventHandler(this.cbox_Interview_Report_Purpose_CheckedChanged);
            // 
            // btn_Reset_Extract
            // 
            this.btn_Reset_Extract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset_Extract.Location = new System.Drawing.Point(676, 286);
            this.btn_Reset_Extract.Name = "btn_Reset_Extract";
            this.btn_Reset_Extract.Size = new System.Drawing.Size(64, 31);
            this.btn_Reset_Extract.TabIndex = 18;
            this.btn_Reset_Extract.Text = "Reset";
            this.btn_Reset_Extract.UseVisualStyleBackColor = true;
            this.btn_Reset_Extract.Click += new System.EventHandler(this.btn_Reset_Extract_Click);
            // 
            // cbox_dload_Images
            // 
            this.cbox_dload_Images.AutoSize = true;
            this.cbox_dload_Images.Location = new System.Drawing.Point(559, 294);
            this.cbox_dload_Images.Name = "cbox_dload_Images";
            this.cbox_dload_Images.Size = new System.Drawing.Size(111, 17);
            this.cbox_dload_Images.TabIndex = 16;
            this.cbox_dload_Images.Text = "Download Images";
            this.cbox_dload_Images.UseVisualStyleBackColor = true;
            // 
            // btn_Report_Extract
            // 
            this.btn_Report_Extract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report_Extract.Location = new System.Drawing.Point(746, 286);
            this.btn_Report_Extract.Name = "btn_Report_Extract";
            this.btn_Report_Extract.Size = new System.Drawing.Size(95, 31);
            this.btn_Report_Extract.TabIndex = 17;
            this.btn_Report_Extract.Text = "Extract";
            this.btn_Report_Extract.UseVisualStyleBackColor = true;
            this.btn_Report_Extract.Click += new System.EventHandler(this.btn_Report_Extract_Click);
            // 
            // lbl_Visitor_Report_Identity_Card_Number
            // 
            this.lbl_Visitor_Report_Identity_Card_Number.AutoSize = true;
            this.lbl_Visitor_Report_Identity_Card_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Report_Identity_Card_Number.Location = new System.Drawing.Point(481, 249);
            this.lbl_Visitor_Report_Identity_Card_Number.Name = "lbl_Visitor_Report_Identity_Card_Number";
            this.lbl_Visitor_Report_Identity_Card_Number.Size = new System.Drawing.Size(72, 16);
            this.lbl_Visitor_Report_Identity_Card_Number.TabIndex = 57;
            this.lbl_Visitor_Report_Identity_Card_Number.Text = "ID Proof :";
            // 
            // tbox_Report_Id_Proof
            // 
            this.tbox_Report_Id_Proof.Location = new System.Drawing.Point(559, 248);
            this.tbox_Report_Id_Proof.Name = "tbox_Report_Id_Proof";
            this.tbox_Report_Id_Proof.Size = new System.Drawing.Size(282, 20);
            this.tbox_Report_Id_Proof.TabIndex = 15;
            // 
            // lbl_Visitor_Report_Device_Carrying
            // 
            this.lbl_Visitor_Report_Device_Carrying.AutoSize = true;
            this.lbl_Visitor_Report_Device_Carrying.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Report_Device_Carrying.Location = new System.Drawing.Point(419, 214);
            this.lbl_Visitor_Report_Device_Carrying.Name = "lbl_Visitor_Report_Device_Carrying";
            this.lbl_Visitor_Report_Device_Carrying.Size = new System.Drawing.Size(134, 16);
            this.lbl_Visitor_Report_Device_Carrying.TabIndex = 56;
            this.lbl_Visitor_Report_Device_Carrying.Text = "Carrying Laptop? :";
            // 
            // tbox_Report_Carrying_Laptop
            // 
            this.tbox_Report_Carrying_Laptop.Location = new System.Drawing.Point(559, 213);
            this.tbox_Report_Carrying_Laptop.Name = "tbox_Report_Carrying_Laptop";
            this.tbox_Report_Carrying_Laptop.Size = new System.Drawing.Size(282, 20);
            this.tbox_Report_Carrying_Laptop.TabIndex = 14;
            // 
            // dtPk_Report_OutTime
            // 
            this.dtPk_Report_OutTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPk_Report_OutTime.Location = new System.Drawing.Point(559, 59);
            this.dtPk_Report_OutTime.Name = "dtPk_Report_OutTime";
            this.dtPk_Report_OutTime.ShowCheckBox = true;
            this.dtPk_Report_OutTime.Size = new System.Drawing.Size(282, 20);
            this.dtPk_Report_OutTime.TabIndex = 11;
            // 
            // dtPk_Report_InTime
            // 
            this.dtPk_Report_InTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPk_Report_InTime.Location = new System.Drawing.Point(559, 22);
            this.dtPk_Report_InTime.Name = "dtPk_Report_InTime";
            this.dtPk_Report_InTime.ShowCheckBox = true;
            this.dtPk_Report_InTime.Size = new System.Drawing.Size(282, 20);
            this.dtPk_Report_InTime.TabIndex = 10;
            // 
            // lbl_Visitor_Report_OutTime
            // 
            this.lbl_Visitor_Report_OutTime.AutoSize = true;
            this.lbl_Visitor_Report_OutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Report_OutTime.Location = new System.Drawing.Point(475, 59);
            this.lbl_Visitor_Report_OutTime.Name = "lbl_Visitor_Report_OutTime";
            this.lbl_Visitor_Report_OutTime.Size = new System.Drawing.Size(78, 16);
            this.lbl_Visitor_Report_OutTime.TabIndex = 53;
            this.lbl_Visitor_Report_OutTime.Text = "Out Time :";
            // 
            // cBox_Report_Floor_Number
            // 
            this.cBox_Report_Floor_Number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Report_Floor_Number.FormattingEnabled = true;
            this.cBox_Report_Floor_Number.Items.AddRange(new object[] {
            "--------------------Select--------------------",
            "Floor - G",
            "Floor - 1",
            "Floor - 2",
            "Floor - 3",
            "Floor - 4",
            "Floor - 5",
            "Floor - 6",
            "Floor - 7",
            "Floor - 8",
            "Floor - 9"});
            this.cBox_Report_Floor_Number.Location = new System.Drawing.Point(559, 90);
            this.cBox_Report_Floor_Number.Name = "cBox_Report_Floor_Number";
            this.cBox_Report_Floor_Number.Size = new System.Drawing.Size(282, 21);
            this.cBox_Report_Floor_Number.TabIndex = 12;
            // 
            // lbl_Visitor_Report_Floor_Number
            // 
            this.lbl_Visitor_Report_Floor_Number.AutoSize = true;
            this.lbl_Visitor_Report_Floor_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Report_Floor_Number.Location = new System.Drawing.Point(455, 91);
            this.lbl_Visitor_Report_Floor_Number.Name = "lbl_Visitor_Report_Floor_Number";
            this.lbl_Visitor_Report_Floor_Number.Size = new System.Drawing.Size(98, 16);
            this.lbl_Visitor_Report_Floor_Number.TabIndex = 51;
            this.lbl_Visitor_Report_Floor_Number.Text = "Which Floor :";
            // 
            // tbox_Report_Whom_To_Meet
            // 
            this.tbox_Report_Whom_To_Meet.Location = new System.Drawing.Point(131, 231);
            this.tbox_Report_Whom_To_Meet.Name = "tbox_Report_Whom_To_Meet";
            this.tbox_Report_Whom_To_Meet.Size = new System.Drawing.Size(282, 20);
            this.tbox_Report_Whom_To_Meet.TabIndex = 7;
            // 
            // tbox_Report_Remarks
            // 
            this.tbox_Report_Remarks.Location = new System.Drawing.Point(559, 125);
            this.tbox_Report_Remarks.Multiline = true;
            this.tbox_Report_Remarks.Name = "tbox_Report_Remarks";
            this.tbox_Report_Remarks.Size = new System.Drawing.Size(282, 68);
            this.tbox_Report_Remarks.TabIndex = 13;
            // 
            // tbox_Report_Escort_Name
            // 
            this.tbox_Report_Escort_Name.Location = new System.Drawing.Point(131, 300);
            this.tbox_Report_Escort_Name.Name = "tbox_Report_Escort_Name";
            this.tbox_Report_Escort_Name.Size = new System.Drawing.Size(282, 20);
            this.tbox_Report_Escort_Name.TabIndex = 9;
            // 
            // tbox_Report_Badge_Number
            // 
            this.tbox_Report_Badge_Number.Location = new System.Drawing.Point(131, 268);
            this.tbox_Report_Badge_Number.Name = "tbox_Report_Badge_Number";
            this.tbox_Report_Badge_Number.Size = new System.Drawing.Size(282, 20);
            this.tbox_Report_Badge_Number.TabIndex = 8;
            // 
            // tbox_Report_Purpose
            // 
            this.tbox_Report_Purpose.Location = new System.Drawing.Point(131, 196);
            this.tbox_Report_Purpose.Name = "tbox_Report_Purpose";
            this.tbox_Report_Purpose.Size = new System.Drawing.Size(282, 20);
            this.tbox_Report_Purpose.TabIndex = 6;
            // 
            // tbox_Report_ContactNumber
            // 
            this.tbox_Report_ContactNumber.Location = new System.Drawing.Point(131, 144);
            this.tbox_Report_ContactNumber.Name = "tbox_Report_ContactNumber";
            this.tbox_Report_ContactNumber.Size = new System.Drawing.Size(282, 20);
            this.tbox_Report_ContactNumber.TabIndex = 5;
            // 
            // tbox_Report_Address
            // 
            this.tbox_Report_Address.Location = new System.Drawing.Point(131, 60);
            this.tbox_Report_Address.Multiline = true;
            this.tbox_Report_Address.Name = "tbox_Report_Address";
            this.tbox_Report_Address.Size = new System.Drawing.Size(282, 66);
            this.tbox_Report_Address.TabIndex = 4;
            // 
            // tbox_Report_Name
            // 
            this.tbox_Report_Name.Location = new System.Drawing.Point(131, 23);
            this.tbox_Report_Name.Name = "tbox_Report_Name";
            this.tbox_Report_Name.Size = new System.Drawing.Size(282, 20);
            this.tbox_Report_Name.TabIndex = 3;
            // 
            // lbl_Visitor_Report_Remarks
            // 
            this.lbl_Visitor_Report_Remarks.AutoSize = true;
            this.lbl_Visitor_Report_Remarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Report_Remarks.Location = new System.Drawing.Point(475, 126);
            this.lbl_Visitor_Report_Remarks.Name = "lbl_Visitor_Report_Remarks";
            this.lbl_Visitor_Report_Remarks.Size = new System.Drawing.Size(78, 16);
            this.lbl_Visitor_Report_Remarks.TabIndex = 49;
            this.lbl_Visitor_Report_Remarks.Text = "Remarks :";
            // 
            // lbl_Visitor_Report_InTime
            // 
            this.lbl_Visitor_Report_InTime.AutoSize = true;
            this.lbl_Visitor_Report_InTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Report_InTime.Location = new System.Drawing.Point(486, 21);
            this.lbl_Visitor_Report_InTime.Name = "lbl_Visitor_Report_InTime";
            this.lbl_Visitor_Report_InTime.Size = new System.Drawing.Size(67, 16);
            this.lbl_Visitor_Report_InTime.TabIndex = 47;
            this.lbl_Visitor_Report_InTime.Text = "In Time :";
            // 
            // lbl_Visitor_Report_Escort_Name
            // 
            this.lbl_Visitor_Report_Escort_Name.AutoSize = true;
            this.lbl_Visitor_Report_Escort_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Report_Escort_Name.Location = new System.Drawing.Point(27, 302);
            this.lbl_Visitor_Report_Escort_Name.Name = "lbl_Visitor_Report_Escort_Name";
            this.lbl_Visitor_Report_Escort_Name.Size = new System.Drawing.Size(105, 16);
            this.lbl_Visitor_Report_Escort_Name.TabIndex = 46;
            this.lbl_Visitor_Report_Escort_Name.Text = "Escort Name :";
            // 
            // lbl_Visitor_Report_Badge_Number
            // 
            this.lbl_Visitor_Report_Badge_Number.AutoSize = true;
            this.lbl_Visitor_Report_Badge_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Report_Badge_Number.Location = new System.Drawing.Point(12, 270);
            this.lbl_Visitor_Report_Badge_Number.Name = "lbl_Visitor_Report_Badge_Number";
            this.lbl_Visitor_Report_Badge_Number.Size = new System.Drawing.Size(120, 16);
            this.lbl_Visitor_Report_Badge_Number.TabIndex = 45;
            this.lbl_Visitor_Report_Badge_Number.Text = "Badge Number :";
            // 
            // lbl_Visitor_Report_Whom_To_Meet
            // 
            this.lbl_Visitor_Report_Whom_To_Meet.AutoSize = true;
            this.lbl_Visitor_Report_Whom_To_Meet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Report_Whom_To_Meet.Location = new System.Drawing.Point(14, 233);
            this.lbl_Visitor_Report_Whom_To_Meet.Name = "lbl_Visitor_Report_Whom_To_Meet";
            this.lbl_Visitor_Report_Whom_To_Meet.Size = new System.Drawing.Size(120, 16);
            this.lbl_Visitor_Report_Whom_To_Meet.TabIndex = 44;
            this.lbl_Visitor_Report_Whom_To_Meet.Text = "Whom To Meet :";
            // 
            // lbl_Visitor_Report_Purpose
            // 
            this.lbl_Visitor_Report_Purpose.AutoSize = true;
            this.lbl_Visitor_Report_Purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Report_Purpose.Location = new System.Drawing.Point(60, 198);
            this.lbl_Visitor_Report_Purpose.Name = "lbl_Visitor_Report_Purpose";
            this.lbl_Visitor_Report_Purpose.Size = new System.Drawing.Size(74, 16);
            this.lbl_Visitor_Report_Purpose.TabIndex = 43;
            this.lbl_Visitor_Report_Purpose.Text = "Purpose :";
            // 
            // lbl_Visitor_Report_Contact_Number
            // 
            this.lbl_Visitor_Report_Contact_Number.AutoSize = true;
            this.lbl_Visitor_Report_Contact_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Report_Contact_Number.Location = new System.Drawing.Point(6, 145);
            this.lbl_Visitor_Report_Contact_Number.Name = "lbl_Visitor_Report_Contact_Number";
            this.lbl_Visitor_Report_Contact_Number.Size = new System.Drawing.Size(126, 16);
            this.lbl_Visitor_Report_Contact_Number.TabIndex = 42;
            this.lbl_Visitor_Report_Contact_Number.Text = "Contact Number :";
            // 
            // lbl_Visitor_Report_Address
            // 
            this.lbl_Visitor_Report_Address.AutoSize = true;
            this.lbl_Visitor_Report_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Report_Address.Location = new System.Drawing.Point(19, 62);
            this.lbl_Visitor_Report_Address.Name = "lbl_Visitor_Report_Address";
            this.lbl_Visitor_Report_Address.Size = new System.Drawing.Size(113, 16);
            this.lbl_Visitor_Report_Address.TabIndex = 41;
            this.lbl_Visitor_Report_Address.Text = "From Address :";
            // 
            // lbl_Visitor_Report_Name
            // 
            this.lbl_Visitor_Report_Name.AutoSize = true;
            this.lbl_Visitor_Report_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Visitor_Report_Name.Location = new System.Drawing.Point(77, 24);
            this.lbl_Visitor_Report_Name.Name = "lbl_Visitor_Report_Name";
            this.lbl_Visitor_Report_Name.Size = new System.Drawing.Size(57, 16);
            this.lbl_Visitor_Report_Name.TabIndex = 40;
            this.lbl_Visitor_Report_Name.Text = "Name :";
            // 
            // tb_Page_KeyDistributionDetails
            // 
            this.tb_Page_KeyDistributionDetails.Controls.Add(this.tbCtrl_Key_Details);
            this.tb_Page_KeyDistributionDetails.Location = new System.Drawing.Point(4, 22);
            this.tb_Page_KeyDistributionDetails.Name = "tb_Page_KeyDistributionDetails";
            this.tb_Page_KeyDistributionDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Page_KeyDistributionDetails.Size = new System.Drawing.Size(878, 566);
            this.tb_Page_KeyDistributionDetails.TabIndex = 1;
            this.tb_Page_KeyDistributionDetails.Text = "Key Distribution";
            this.tb_Page_KeyDistributionDetails.UseVisualStyleBackColor = true;
            // 
            // tbCtrl_Key_Details
            // 
            this.tbCtrl_Key_Details.Controls.Add(this.tb_Page_KeyDetails_OneTimeDetails);
            this.tbCtrl_Key_Details.Controls.Add(this.tb_Page_KeyDetails_TempDetails);
            this.tbCtrl_Key_Details.Location = new System.Drawing.Point(3, 22);
            this.tbCtrl_Key_Details.Name = "tbCtrl_Key_Details";
            this.tbCtrl_Key_Details.SelectedIndex = 0;
            this.tbCtrl_Key_Details.Size = new System.Drawing.Size(872, 541);
            this.tbCtrl_Key_Details.TabIndex = 0;
            // 
            // tb_Page_KeyDetails_OneTimeDetails
            // 
            this.tb_Page_KeyDetails_OneTimeDetails.Controls.Add(this.sp_Cont_Key_Distribution);
            this.tb_Page_KeyDetails_OneTimeDetails.Location = new System.Drawing.Point(4, 22);
            this.tb_Page_KeyDetails_OneTimeDetails.Name = "tb_Page_KeyDetails_OneTimeDetails";
            this.tb_Page_KeyDetails_OneTimeDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Page_KeyDetails_OneTimeDetails.Size = new System.Drawing.Size(864, 515);
            this.tb_Page_KeyDetails_OneTimeDetails.TabIndex = 0;
            this.tb_Page_KeyDetails_OneTimeDetails.Text = "One Time Distribution";
            this.tb_Page_KeyDetails_OneTimeDetails.UseVisualStyleBackColor = true;
            // 
            // sp_Cont_Key_Distribution
            // 
            this.sp_Cont_Key_Distribution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sp_Cont_Key_Distribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Cont_Key_Distribution.Location = new System.Drawing.Point(3, 3);
            this.sp_Cont_Key_Distribution.Name = "sp_Cont_Key_Distribution";
            this.sp_Cont_Key_Distribution.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sp_Cont_Key_Distribution.Panel1
            // 
            this.sp_Cont_Key_Distribution.Panel1.Controls.Add(this.sp_Cont_SubTop_Key_Distribution);
            // 
            // sp_Cont_Key_Distribution.Panel2
            // 
            this.sp_Cont_Key_Distribution.Panel2.Controls.Add(this.sp_Cont_SubBot_Key_Distribution);
            this.sp_Cont_Key_Distribution.Size = new System.Drawing.Size(858, 509);
            this.sp_Cont_Key_Distribution.SplitterDistance = 240;
            this.sp_Cont_Key_Distribution.TabIndex = 0;
            // 
            // sp_Cont_SubTop_Key_Distribution
            // 
            this.sp_Cont_SubTop_Key_Distribution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sp_Cont_SubTop_Key_Distribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Cont_SubTop_Key_Distribution.IsSplitterFixed = true;
            this.sp_Cont_SubTop_Key_Distribution.Location = new System.Drawing.Point(0, 0);
            this.sp_Cont_SubTop_Key_Distribution.Name = "sp_Cont_SubTop_Key_Distribution";
            // 
            // sp_Cont_SubTop_Key_Distribution.Panel1
            // 
            this.sp_Cont_SubTop_Key_Distribution.Panel1.Controls.Add(this.lbl_Key_Error);
            this.sp_Cont_SubTop_Key_Distribution.Panel1.Controls.Add(this.btn_Key_Emp_Reset);
            this.sp_Cont_SubTop_Key_Distribution.Panel1.Controls.Add(this.btn_Key_Emp_Search);
            this.sp_Cont_SubTop_Key_Distribution.Panel1.Controls.Add(this.tbox_Key_Emp_Desk_Phone);
            this.sp_Cont_SubTop_Key_Distribution.Panel1.Controls.Add(this.lbl_Key_Emp_Desk_Phone);
            this.sp_Cont_SubTop_Key_Distribution.Panel1.Controls.Add(this.tbox_Key_Emp_Email);
            this.sp_Cont_SubTop_Key_Distribution.Panel1.Controls.Add(this.lbl_Key_Emp_Email);
            this.sp_Cont_SubTop_Key_Distribution.Panel1.Controls.Add(this.tbox_Key_Emp_Name);
            this.sp_Cont_SubTop_Key_Distribution.Panel1.Controls.Add(this.lbl_Key_Emp_Name);
            this.sp_Cont_SubTop_Key_Distribution.Panel1.Controls.Add(this.tbox_Key_Emp_Id);
            this.sp_Cont_SubTop_Key_Distribution.Panel1.Controls.Add(this.lbl_Key_Emp_Id);
            this.sp_Cont_SubTop_Key_Distribution.Panel1.Controls.Add(this.lbl_KeyDistribution_EmployeeDetails);
            // 
            // sp_Cont_SubTop_Key_Distribution.Panel2
            // 
            this.sp_Cont_SubTop_Key_Distribution.Panel2.Controls.Add(this.lbl_KeyDistribution_KeyDetails);
            this.sp_Cont_SubTop_Key_Distribution.Size = new System.Drawing.Size(858, 240);
            this.sp_Cont_SubTop_Key_Distribution.SplitterDistance = 432;
            this.sp_Cont_SubTop_Key_Distribution.TabIndex = 0;
            // 
            // lbl_Key_Error
            // 
            this.lbl_Key_Error.AutoSize = true;
            this.lbl_Key_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Key_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Key_Error.Location = new System.Drawing.Point(3, 211);
            this.lbl_Key_Error.Name = "lbl_Key_Error";
            this.lbl_Key_Error.Size = new System.Drawing.Size(0, 20);
            this.lbl_Key_Error.TabIndex = 22;
            // 
            // btn_Key_Emp_Reset
            // 
            this.btn_Key_Emp_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Key_Emp_Reset.Location = new System.Drawing.Point(321, 173);
            this.btn_Key_Emp_Reset.Name = "btn_Key_Emp_Reset";
            this.btn_Key_Emp_Reset.Size = new System.Drawing.Size(95, 33);
            this.btn_Key_Emp_Reset.TabIndex = 20;
            this.btn_Key_Emp_Reset.Text = "Reset";
            this.btn_Key_Emp_Reset.UseVisualStyleBackColor = true;
            this.btn_Key_Emp_Reset.Click += new System.EventHandler(this.btn_Key_Emp_Reset_Click);
            // 
            // btn_Key_Emp_Search
            // 
            this.btn_Key_Emp_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Key_Emp_Search.Location = new System.Drawing.Point(220, 173);
            this.btn_Key_Emp_Search.Name = "btn_Key_Emp_Search";
            this.btn_Key_Emp_Search.Size = new System.Drawing.Size(95, 33);
            this.btn_Key_Emp_Search.TabIndex = 19;
            this.btn_Key_Emp_Search.Text = "Search";
            this.btn_Key_Emp_Search.UseVisualStyleBackColor = true;
            this.btn_Key_Emp_Search.Click += new System.EventHandler(this.btn_Key_Emp_Search_Click);
            // 
            // tbox_Key_Emp_Desk_Phone
            // 
            this.tbox_Key_Emp_Desk_Phone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_Key_Emp_Desk_Phone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_Key_Emp_Desk_Phone.Location = new System.Drawing.Point(156, 138);
            this.tbox_Key_Emp_Desk_Phone.Name = "tbox_Key_Emp_Desk_Phone";
            this.tbox_Key_Emp_Desk_Phone.Size = new System.Drawing.Size(261, 20);
            this.tbox_Key_Emp_Desk_Phone.TabIndex = 17;
            this.tbox_Key_Emp_Desk_Phone.TextChanged += new System.EventHandler(this.tbox_Key_Emp_Desk_Phone_TextChanged);
            // 
            // lbl_Key_Emp_Desk_Phone
            // 
            this.lbl_Key_Emp_Desk_Phone.AutoSize = true;
            this.lbl_Key_Emp_Desk_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Key_Emp_Desk_Phone.Location = new System.Drawing.Point(66, 141);
            this.lbl_Key_Emp_Desk_Phone.Name = "lbl_Key_Emp_Desk_Phone";
            this.lbl_Key_Emp_Desk_Phone.Size = new System.Drawing.Size(84, 13);
            this.lbl_Key_Emp_Desk_Phone.TabIndex = 21;
            this.lbl_Key_Emp_Desk_Phone.Text = "Desk Phone :";
            // 
            // tbox_Key_Emp_Email
            // 
            this.tbox_Key_Emp_Email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_Key_Emp_Email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_Key_Emp_Email.Location = new System.Drawing.Point(156, 106);
            this.tbox_Key_Emp_Email.Name = "tbox_Key_Emp_Email";
            this.tbox_Key_Emp_Email.Size = new System.Drawing.Size(261, 20);
            this.tbox_Key_Emp_Email.TabIndex = 16;
            this.tbox_Key_Emp_Email.TextChanged += new System.EventHandler(this.tbox_Key_Emp_Email_TextChanged);
            // 
            // lbl_Key_Emp_Email
            // 
            this.lbl_Key_Emp_Email.AutoSize = true;
            this.lbl_Key_Emp_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Key_Emp_Email.Location = new System.Drawing.Point(47, 109);
            this.lbl_Key_Emp_Email.Name = "lbl_Key_Emp_Email";
            this.lbl_Key_Emp_Email.Size = new System.Drawing.Size(103, 13);
            this.lbl_Key_Emp_Email.TabIndex = 18;
            this.lbl_Key_Emp_Email.Text = "Employee Email :";
            // 
            // tbox_Key_Emp_Name
            // 
            this.tbox_Key_Emp_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_Key_Emp_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_Key_Emp_Name.Location = new System.Drawing.Point(156, 75);
            this.tbox_Key_Emp_Name.Name = "tbox_Key_Emp_Name";
            this.tbox_Key_Emp_Name.Size = new System.Drawing.Size(261, 20);
            this.tbox_Key_Emp_Name.TabIndex = 14;
            this.tbox_Key_Emp_Name.TextChanged += new System.EventHandler(this.tbox_Key_Emp_Name_TextChanged);
            // 
            // lbl_Key_Emp_Name
            // 
            this.lbl_Key_Emp_Name.AutoSize = true;
            this.lbl_Key_Emp_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Key_Emp_Name.Location = new System.Drawing.Point(45, 78);
            this.lbl_Key_Emp_Name.Name = "lbl_Key_Emp_Name";
            this.lbl_Key_Emp_Name.Size = new System.Drawing.Size(105, 13);
            this.lbl_Key_Emp_Name.TabIndex = 15;
            this.lbl_Key_Emp_Name.Text = "Employee Name :";
            // 
            // tbox_Key_Emp_Id
            // 
            this.tbox_Key_Emp_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_Key_Emp_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_Key_Emp_Id.Location = new System.Drawing.Point(156, 44);
            this.tbox_Key_Emp_Id.Name = "tbox_Key_Emp_Id";
            this.tbox_Key_Emp_Id.Size = new System.Drawing.Size(261, 20);
            this.tbox_Key_Emp_Id.TabIndex = 13;
            this.tbox_Key_Emp_Id.TextChanged += new System.EventHandler(this.tbox_Key_Emp_Id_TextChanged);
            // 
            // lbl_Key_Emp_Id
            // 
            this.lbl_Key_Emp_Id.AutoSize = true;
            this.lbl_Key_Emp_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Key_Emp_Id.Location = new System.Drawing.Point(66, 47);
            this.lbl_Key_Emp_Id.Name = "lbl_Key_Emp_Id";
            this.lbl_Key_Emp_Id.Size = new System.Drawing.Size(84, 13);
            this.lbl_Key_Emp_Id.TabIndex = 12;
            this.lbl_Key_Emp_Id.Text = "Employee Id :";
            // 
            // lbl_KeyDistribution_EmployeeDetails
            // 
            this.lbl_KeyDistribution_EmployeeDetails.AutoSize = true;
            this.lbl_KeyDistribution_EmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KeyDistribution_EmployeeDetails.ForeColor = System.Drawing.Color.Blue;
            this.lbl_KeyDistribution_EmployeeDetails.Location = new System.Drawing.Point(0, 0);
            this.lbl_KeyDistribution_EmployeeDetails.Name = "lbl_KeyDistribution_EmployeeDetails";
            this.lbl_KeyDistribution_EmployeeDetails.Size = new System.Drawing.Size(195, 25);
            this.lbl_KeyDistribution_EmployeeDetails.TabIndex = 11;
            this.lbl_KeyDistribution_EmployeeDetails.Text = "Employee Details";
            // 
            // lbl_KeyDistribution_KeyDetails
            // 
            this.lbl_KeyDistribution_KeyDetails.AutoSize = true;
            this.lbl_KeyDistribution_KeyDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KeyDistribution_KeyDetails.ForeColor = System.Drawing.Color.Blue;
            this.lbl_KeyDistribution_KeyDetails.Location = new System.Drawing.Point(3, 0);
            this.lbl_KeyDistribution_KeyDetails.Name = "lbl_KeyDistribution_KeyDetails";
            this.lbl_KeyDistribution_KeyDetails.Size = new System.Drawing.Size(132, 25);
            this.lbl_KeyDistribution_KeyDetails.TabIndex = 12;
            this.lbl_KeyDistribution_KeyDetails.Text = "Key Details";
            // 
            // sp_Cont_SubBot_Key_Distribution
            // 
            this.sp_Cont_SubBot_Key_Distribution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sp_Cont_SubBot_Key_Distribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Cont_SubBot_Key_Distribution.IsSplitterFixed = true;
            this.sp_Cont_SubBot_Key_Distribution.Location = new System.Drawing.Point(0, 0);
            this.sp_Cont_SubBot_Key_Distribution.Name = "sp_Cont_SubBot_Key_Distribution";
            // 
            // sp_Cont_SubBot_Key_Distribution.Panel1
            // 
            this.sp_Cont_SubBot_Key_Distribution.Panel1.Controls.Add(this.lbl_KeyDistribution_TimeDetails);
            this.sp_Cont_SubBot_Key_Distribution.Size = new System.Drawing.Size(858, 265);
            this.sp_Cont_SubBot_Key_Distribution.SplitterDistance = 432;
            this.sp_Cont_SubBot_Key_Distribution.TabIndex = 0;
            // 
            // lbl_KeyDistribution_TimeDetails
            // 
            this.lbl_KeyDistribution_TimeDetails.AutoSize = true;
            this.lbl_KeyDistribution_TimeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KeyDistribution_TimeDetails.ForeColor = System.Drawing.Color.Blue;
            this.lbl_KeyDistribution_TimeDetails.Location = new System.Drawing.Point(0, 0);
            this.lbl_KeyDistribution_TimeDetails.Name = "lbl_KeyDistribution_TimeDetails";
            this.lbl_KeyDistribution_TimeDetails.Size = new System.Drawing.Size(199, 25);
            this.lbl_KeyDistribution_TimeDetails.TabIndex = 13;
            this.lbl_KeyDistribution_TimeDetails.Text = "Date Time Details";
            // 
            // tb_Page_KeyDetails_TempDetails
            // 
            this.tb_Page_KeyDetails_TempDetails.Location = new System.Drawing.Point(4, 22);
            this.tb_Page_KeyDetails_TempDetails.Name = "tb_Page_KeyDetails_TempDetails";
            this.tb_Page_KeyDetails_TempDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Page_KeyDetails_TempDetails.Size = new System.Drawing.Size(864, 515);
            this.tb_Page_KeyDetails_TempDetails.TabIndex = 1;
            this.tb_Page_KeyDetails_TempDetails.Text = "Temp Key Distribution";
            this.tb_Page_KeyDetails_TempDetails.UseVisualStyleBackColor = true;
            // 
            // tb_Page_MedicineDistributionDetails
            // 
            this.tb_Page_MedicineDistributionDetails.Controls.Add(this.grpBx_Medicine_Distribution_Report);
            this.tb_Page_MedicineDistributionDetails.Controls.Add(this.grpBx_Medicine_Distribution);
            this.tb_Page_MedicineDistributionDetails.Location = new System.Drawing.Point(4, 22);
            this.tb_Page_MedicineDistributionDetails.Name = "tb_Page_MedicineDistributionDetails";
            this.tb_Page_MedicineDistributionDetails.Size = new System.Drawing.Size(878, 566);
            this.tb_Page_MedicineDistributionDetails.TabIndex = 2;
            this.tb_Page_MedicineDistributionDetails.Text = "Medicine Distribution";
            this.tb_Page_MedicineDistributionDetails.UseVisualStyleBackColor = true;
            // 
            // grpBx_Medicine_Distribution_Report
            // 
            this.grpBx_Medicine_Distribution_Report.Controls.Add(this.btn_MedReport_Non_Employee);
            this.grpBx_Medicine_Distribution_Report.Controls.Add(this.btn_MedReport_Specified_Medicine);
            this.grpBx_Medicine_Distribution_Report.Controls.Add(this.btn_MedReport_Today);
            this.grpBx_Medicine_Distribution_Report.Controls.Add(this.btn_MedReport_Specified_Date_Range);
            this.grpBx_Medicine_Distribution_Report.Controls.Add(this.btn_MedReport_Specified_Employee);
            this.grpBx_Medicine_Distribution_Report.Controls.Add(this.btn_MedReport_LastOneMonth);
            this.grpBx_Medicine_Distribution_Report.Location = new System.Drawing.Point(3, 350);
            this.grpBx_Medicine_Distribution_Report.Name = "grpBx_Medicine_Distribution_Report";
            this.grpBx_Medicine_Distribution_Report.Size = new System.Drawing.Size(872, 216);
            this.grpBx_Medicine_Distribution_Report.TabIndex = 1;
            this.grpBx_Medicine_Distribution_Report.TabStop = false;
            this.grpBx_Medicine_Distribution_Report.Text = "Medicine Distribution Report";
            // 
            // btn_MedReport_Non_Employee
            // 
            this.btn_MedReport_Non_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MedReport_Non_Employee.Location = new System.Drawing.Point(599, 56);
            this.btn_MedReport_Non_Employee.Name = "btn_MedReport_Non_Employee";
            this.btn_MedReport_Non_Employee.Size = new System.Drawing.Size(185, 47);
            this.btn_MedReport_Non_Employee.TabIndex = 13;
            this.btn_MedReport_Non_Employee.Text = "Non Employee\'s Report";
            this.btn_MedReport_Non_Employee.UseVisualStyleBackColor = true;
            this.btn_MedReport_Non_Employee.Click += new System.EventHandler(this.btn_MedReport_Non_Employee_Click);
            // 
            // btn_MedReport_Specified_Medicine
            // 
            this.btn_MedReport_Specified_Medicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MedReport_Specified_Medicine.Location = new System.Drawing.Point(599, 119);
            this.btn_MedReport_Specified_Medicine.Name = "btn_MedReport_Specified_Medicine";
            this.btn_MedReport_Specified_Medicine.Size = new System.Drawing.Size(185, 47);
            this.btn_MedReport_Specified_Medicine.TabIndex = 12;
            this.btn_MedReport_Specified_Medicine.Text = "Specified Medicine";
            this.btn_MedReport_Specified_Medicine.UseVisualStyleBackColor = true;
            this.btn_MedReport_Specified_Medicine.Click += new System.EventHandler(this.btn_MedReport_Specified_Medicine_Click);
            // 
            // btn_MedReport_Today
            // 
            this.btn_MedReport_Today.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MedReport_Today.Location = new System.Drawing.Point(106, 56);
            this.btn_MedReport_Today.Name = "btn_MedReport_Today";
            this.btn_MedReport_Today.Size = new System.Drawing.Size(185, 47);
            this.btn_MedReport_Today.TabIndex = 11;
            this.btn_MedReport_Today.Text = "Today\'s Report";
            this.btn_MedReport_Today.UseVisualStyleBackColor = true;
            this.btn_MedReport_Today.Click += new System.EventHandler(this.btn_MedReport_Today_Click);
            // 
            // btn_MedReport_Specified_Date_Range
            // 
            this.btn_MedReport_Specified_Date_Range.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MedReport_Specified_Date_Range.Location = new System.Drawing.Point(347, 119);
            this.btn_MedReport_Specified_Date_Range.Name = "btn_MedReport_Specified_Date_Range";
            this.btn_MedReport_Specified_Date_Range.Size = new System.Drawing.Size(185, 47);
            this.btn_MedReport_Specified_Date_Range.TabIndex = 10;
            this.btn_MedReport_Specified_Date_Range.Text = "Specified Date Range";
            this.btn_MedReport_Specified_Date_Range.UseVisualStyleBackColor = true;
            this.btn_MedReport_Specified_Date_Range.Click += new System.EventHandler(this.btn_MedReport_Specified_Date_Range_Click);
            // 
            // btn_MedReport_Specified_Employee
            // 
            this.btn_MedReport_Specified_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MedReport_Specified_Employee.Location = new System.Drawing.Point(106, 119);
            this.btn_MedReport_Specified_Employee.Name = "btn_MedReport_Specified_Employee";
            this.btn_MedReport_Specified_Employee.Size = new System.Drawing.Size(185, 47);
            this.btn_MedReport_Specified_Employee.TabIndex = 9;
            this.btn_MedReport_Specified_Employee.Text = "Sepcified Employee";
            this.btn_MedReport_Specified_Employee.UseVisualStyleBackColor = true;
            this.btn_MedReport_Specified_Employee.Click += new System.EventHandler(this.btn_MedReport_Specified_Employee_Click);
            // 
            // btn_MedReport_LastOneMonth
            // 
            this.btn_MedReport_LastOneMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MedReport_LastOneMonth.Location = new System.Drawing.Point(347, 56);
            this.btn_MedReport_LastOneMonth.Name = "btn_MedReport_LastOneMonth";
            this.btn_MedReport_LastOneMonth.Size = new System.Drawing.Size(185, 47);
            this.btn_MedReport_LastOneMonth.TabIndex = 8;
            this.btn_MedReport_LastOneMonth.Text = "Last 1 Month\'s Report";
            this.btn_MedReport_LastOneMonth.UseVisualStyleBackColor = true;
            this.btn_MedReport_LastOneMonth.Click += new System.EventHandler(this.btn_MedReport_LastOneMonth_Click);
            // 
            // grpBx_Medicine_Distribution
            // 
            this.grpBx_Medicine_Distribution.Controls.Add(this.sp_Cont_Medicine_Distribution);
            this.grpBx_Medicine_Distribution.Location = new System.Drawing.Point(3, 3);
            this.grpBx_Medicine_Distribution.Name = "grpBx_Medicine_Distribution";
            this.grpBx_Medicine_Distribution.Size = new System.Drawing.Size(872, 344);
            this.grpBx_Medicine_Distribution.TabIndex = 0;
            this.grpBx_Medicine_Distribution.TabStop = false;
            this.grpBx_Medicine_Distribution.Text = "Medicine Distribution";
            // 
            // sp_Cont_Medicine_Distribution
            // 
            this.sp_Cont_Medicine_Distribution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sp_Cont_Medicine_Distribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Cont_Medicine_Distribution.IsSplitterFixed = true;
            this.sp_Cont_Medicine_Distribution.Location = new System.Drawing.Point(3, 16);
            this.sp_Cont_Medicine_Distribution.Name = "sp_Cont_Medicine_Distribution";
            // 
            // sp_Cont_Medicine_Distribution.Panel1
            // 
            this.sp_Cont_Medicine_Distribution.Panel1.Controls.Add(this.cbox_Non_Employee_Medicine_Distribution);
            this.sp_Cont_Medicine_Distribution.Panel1.Controls.Add(this.lbl_Med_Error);
            this.sp_Cont_Medicine_Distribution.Panel1.Controls.Add(this.btn_Med_Emp_Reset);
            this.sp_Cont_Medicine_Distribution.Panel1.Controls.Add(this.btn_Med_Emp_Search);
            this.sp_Cont_Medicine_Distribution.Panel1.Controls.Add(this.tbox_Med_Emp_Desk_Phone);
            this.sp_Cont_Medicine_Distribution.Panel1.Controls.Add(this.lbl_Med_Emp_Desk_Phone);
            this.sp_Cont_Medicine_Distribution.Panel1.Controls.Add(this.tbox_Med_Emp_Email);
            this.sp_Cont_Medicine_Distribution.Panel1.Controls.Add(this.lbl_Med_Emp_Email);
            this.sp_Cont_Medicine_Distribution.Panel1.Controls.Add(this.tbox_Med_Emp_Name);
            this.sp_Cont_Medicine_Distribution.Panel1.Controls.Add(this.lbl_Med_Emp_Name);
            this.sp_Cont_Medicine_Distribution.Panel1.Controls.Add(this.tbox_Med_Emp_Id);
            this.sp_Cont_Medicine_Distribution.Panel1.Controls.Add(this.lbl_Med_Emp_Id);
            // 
            // sp_Cont_Medicine_Distribution.Panel2
            // 
            this.sp_Cont_Medicine_Distribution.Panel2.Controls.Add(this.lbl_medNameChecker);
            this.sp_Cont_Medicine_Distribution.Panel2.Controls.Add(this.tbox_Med_Medcine_Updated_Stock);
            this.sp_Cont_Medicine_Distribution.Panel2.Controls.Add(this.lbl_medStockCounter);
            this.sp_Cont_Medicine_Distribution.Panel2.Controls.Add(this.grpBx_MedicineSigneture);
            this.sp_Cont_Medicine_Distribution.Panel2.Controls.Add(this.btn_Med_Details_Reset);
            this.sp_Cont_Medicine_Distribution.Panel2.Controls.Add(this.btn_Med_Assign);
            this.sp_Cont_Medicine_Distribution.Panel2.Controls.Add(this.tbox_Med_Medcine_Quantity);
            this.sp_Cont_Medicine_Distribution.Panel2.Controls.Add(this.lbl_Med_Medcine_Quantity);
            this.sp_Cont_Medicine_Distribution.Panel2.Controls.Add(this.tbox_Med_Medcine_Name);
            this.sp_Cont_Medicine_Distribution.Panel2.Controls.Add(this.lbl_Med_Medcine_Name);
            this.sp_Cont_Medicine_Distribution.Size = new System.Drawing.Size(866, 325);
            this.sp_Cont_Medicine_Distribution.SplitterDistance = 434;
            this.sp_Cont_Medicine_Distribution.TabIndex = 0;
            // 
            // cbox_Non_Employee_Medicine_Distribution
            // 
            this.cbox_Non_Employee_Medicine_Distribution.AutoSize = true;
            this.cbox_Non_Employee_Medicine_Distribution.Location = new System.Drawing.Point(136, 15);
            this.cbox_Non_Employee_Medicine_Distribution.Name = "cbox_Non_Employee_Medicine_Distribution";
            this.cbox_Non_Employee_Medicine_Distribution.Size = new System.Drawing.Size(95, 17);
            this.cbox_Non_Employee_Medicine_Distribution.TabIndex = 0;
            this.cbox_Non_Employee_Medicine_Distribution.Text = "Non-Employee";
            this.cbox_Non_Employee_Medicine_Distribution.UseVisualStyleBackColor = true;
            this.cbox_Non_Employee_Medicine_Distribution.CheckedChanged += new System.EventHandler(this.cbox_Non_Employee_Medicine_Distribution_CheckedChanged);
            // 
            // lbl_Med_Error
            // 
            this.lbl_Med_Error.AutoSize = true;
            this.lbl_Med_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Med_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Med_Error.Location = new System.Drawing.Point(3, 279);
            this.lbl_Med_Error.Name = "lbl_Med_Error";
            this.lbl_Med_Error.Size = new System.Drawing.Size(0, 20);
            this.lbl_Med_Error.TabIndex = 7;
            // 
            // btn_Med_Emp_Reset
            // 
            this.btn_Med_Emp_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Med_Emp_Reset.Location = new System.Drawing.Point(302, 213);
            this.btn_Med_Emp_Reset.Name = "btn_Med_Emp_Reset";
            this.btn_Med_Emp_Reset.Size = new System.Drawing.Size(95, 33);
            this.btn_Med_Emp_Reset.TabIndex = 6;
            this.btn_Med_Emp_Reset.Text = "Reset";
            this.btn_Med_Emp_Reset.UseVisualStyleBackColor = true;
            this.btn_Med_Emp_Reset.Click += new System.EventHandler(this.btn_Med_Emp_Reset_Click);
            // 
            // btn_Med_Emp_Search
            // 
            this.btn_Med_Emp_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Med_Emp_Search.Location = new System.Drawing.Point(192, 213);
            this.btn_Med_Emp_Search.Name = "btn_Med_Emp_Search";
            this.btn_Med_Emp_Search.Size = new System.Drawing.Size(95, 33);
            this.btn_Med_Emp_Search.TabIndex = 5;
            this.btn_Med_Emp_Search.Text = "Search";
            this.btn_Med_Emp_Search.UseVisualStyleBackColor = true;
            this.btn_Med_Emp_Search.Click += new System.EventHandler(this.btn_Med_Emp_Search_Click);
            // 
            // tbox_Med_Emp_Desk_Phone
            // 
            this.tbox_Med_Emp_Desk_Phone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_Med_Emp_Desk_Phone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_Med_Emp_Desk_Phone.Location = new System.Drawing.Point(136, 170);
            this.tbox_Med_Emp_Desk_Phone.Name = "tbox_Med_Emp_Desk_Phone";
            this.tbox_Med_Emp_Desk_Phone.Size = new System.Drawing.Size(261, 20);
            this.tbox_Med_Emp_Desk_Phone.TabIndex = 4;
            this.tbox_Med_Emp_Desk_Phone.TextChanged += new System.EventHandler(this.tbox_Med_Emp_Desk_Phone_TextChanged);
            // 
            // lbl_Med_Emp_Desk_Phone
            // 
            this.lbl_Med_Emp_Desk_Phone.AutoSize = true;
            this.lbl_Med_Emp_Desk_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Med_Emp_Desk_Phone.Location = new System.Drawing.Point(46, 173);
            this.lbl_Med_Emp_Desk_Phone.Name = "lbl_Med_Emp_Desk_Phone";
            this.lbl_Med_Emp_Desk_Phone.Size = new System.Drawing.Size(84, 13);
            this.lbl_Med_Emp_Desk_Phone.TabIndex = 6;
            this.lbl_Med_Emp_Desk_Phone.Text = "Desk Phone :";
            // 
            // tbox_Med_Emp_Email
            // 
            this.tbox_Med_Emp_Email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_Med_Emp_Email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_Med_Emp_Email.Location = new System.Drawing.Point(136, 130);
            this.tbox_Med_Emp_Email.Name = "tbox_Med_Emp_Email";
            this.tbox_Med_Emp_Email.Size = new System.Drawing.Size(261, 20);
            this.tbox_Med_Emp_Email.TabIndex = 3;
            this.tbox_Med_Emp_Email.TextChanged += new System.EventHandler(this.tbox_Med_Emp_Email_TextChanged);
            // 
            // lbl_Med_Emp_Email
            // 
            this.lbl_Med_Emp_Email.AutoSize = true;
            this.lbl_Med_Emp_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Med_Emp_Email.Location = new System.Drawing.Point(27, 133);
            this.lbl_Med_Emp_Email.Name = "lbl_Med_Emp_Email";
            this.lbl_Med_Emp_Email.Size = new System.Drawing.Size(103, 13);
            this.lbl_Med_Emp_Email.TabIndex = 4;
            this.lbl_Med_Emp_Email.Text = "Employee Email :";
            // 
            // tbox_Med_Emp_Name
            // 
            this.tbox_Med_Emp_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_Med_Emp_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_Med_Emp_Name.Location = new System.Drawing.Point(136, 90);
            this.tbox_Med_Emp_Name.Name = "tbox_Med_Emp_Name";
            this.tbox_Med_Emp_Name.Size = new System.Drawing.Size(261, 20);
            this.tbox_Med_Emp_Name.TabIndex = 2;
            this.tbox_Med_Emp_Name.TextChanged += new System.EventHandler(this.tbox_Med_Emp_Name_TextChanged);
            // 
            // lbl_Med_Emp_Name
            // 
            this.lbl_Med_Emp_Name.AutoSize = true;
            this.lbl_Med_Emp_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Med_Emp_Name.Location = new System.Drawing.Point(25, 93);
            this.lbl_Med_Emp_Name.Name = "lbl_Med_Emp_Name";
            this.lbl_Med_Emp_Name.Size = new System.Drawing.Size(105, 13);
            this.lbl_Med_Emp_Name.TabIndex = 2;
            this.lbl_Med_Emp_Name.Text = "Employee Name :";
            // 
            // tbox_Med_Emp_Id
            // 
            this.tbox_Med_Emp_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_Med_Emp_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_Med_Emp_Id.Location = new System.Drawing.Point(136, 49);
            this.tbox_Med_Emp_Id.Name = "tbox_Med_Emp_Id";
            this.tbox_Med_Emp_Id.Size = new System.Drawing.Size(261, 20);
            this.tbox_Med_Emp_Id.TabIndex = 1;
            this.tbox_Med_Emp_Id.TextChanged += new System.EventHandler(this.tbox_Med_Emp_Id_TextChanged);
            // 
            // lbl_Med_Emp_Id
            // 
            this.lbl_Med_Emp_Id.AutoSize = true;
            this.lbl_Med_Emp_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Med_Emp_Id.Location = new System.Drawing.Point(46, 52);
            this.lbl_Med_Emp_Id.Name = "lbl_Med_Emp_Id";
            this.lbl_Med_Emp_Id.Size = new System.Drawing.Size(84, 13);
            this.lbl_Med_Emp_Id.TabIndex = 0;
            this.lbl_Med_Emp_Id.Text = "Employee Id :";
            // 
            // tbox_Med_Medcine_Updated_Stock
            // 
            this.tbox_Med_Medcine_Updated_Stock.Location = new System.Drawing.Point(23, 288);
            this.tbox_Med_Medcine_Updated_Stock.Name = "tbox_Med_Medcine_Updated_Stock";
            this.tbox_Med_Medcine_Updated_Stock.Size = new System.Drawing.Size(100, 20);
            this.tbox_Med_Medcine_Updated_Stock.TabIndex = 22;
            this.tbox_Med_Medcine_Updated_Stock.Visible = false;
            this.tbox_Med_Medcine_Updated_Stock.TextChanged += new System.EventHandler(this.tbox_Med_Medcine_Updated_Stock_TextChanged);
            // 
            // lbl_medStockCounter
            // 
            this.lbl_medStockCounter.AutoSize = true;
            this.lbl_medStockCounter.ForeColor = System.Drawing.Color.Red;
            this.lbl_medStockCounter.Location = new System.Drawing.Point(135, 113);
            this.lbl_medStockCounter.Name = "lbl_medStockCounter";
            this.lbl_medStockCounter.Size = new System.Drawing.Size(0, 13);
            this.lbl_medStockCounter.TabIndex = 21;
            // 
            // grpBx_MedicineSigneture
            // 
            this.grpBx_MedicineSigneture.Controls.Add(this.pBox_Medcine_Signeture);
            this.grpBx_MedicineSigneture.Location = new System.Drawing.Point(10, 128);
            this.grpBx_MedicineSigneture.Name = "grpBx_MedicineSigneture";
            this.grpBx_MedicineSigneture.Size = new System.Drawing.Size(406, 135);
            this.grpBx_MedicineSigneture.TabIndex = 20;
            this.grpBx_MedicineSigneture.TabStop = false;
            this.grpBx_MedicineSigneture.Text = "Signeture";
            // 
            // pBox_Medcine_Signeture
            // 
            this.pBox_Medcine_Signeture.Cursor = System.Windows.Forms.Cursors.No;
            this.pBox_Medcine_Signeture.Image = ((System.Drawing.Image)(resources.GetObject("pBox_Medcine_Signeture.Image")));
            this.pBox_Medcine_Signeture.Location = new System.Drawing.Point(6, 19);
            this.pBox_Medcine_Signeture.Name = "pBox_Medcine_Signeture";
            this.pBox_Medcine_Signeture.Size = new System.Drawing.Size(394, 110);
            this.pBox_Medcine_Signeture.TabIndex = 0;
            this.pBox_Medcine_Signeture.TabStop = false;
            // 
            // btn_Med_Details_Reset
            // 
            this.btn_Med_Details_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Med_Details_Reset.Location = new System.Drawing.Point(316, 274);
            this.btn_Med_Details_Reset.Name = "btn_Med_Details_Reset";
            this.btn_Med_Details_Reset.Size = new System.Drawing.Size(95, 33);
            this.btn_Med_Details_Reset.TabIndex = 10;
            this.btn_Med_Details_Reset.Text = "Reset";
            this.btn_Med_Details_Reset.UseVisualStyleBackColor = true;
            this.btn_Med_Details_Reset.Click += new System.EventHandler(this.btn_Med_Details_Reset_Click);
            // 
            // btn_Med_Assign
            // 
            this.btn_Med_Assign.Enabled = false;
            this.btn_Med_Assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Med_Assign.Location = new System.Drawing.Point(215, 274);
            this.btn_Med_Assign.Name = "btn_Med_Assign";
            this.btn_Med_Assign.Size = new System.Drawing.Size(95, 33);
            this.btn_Med_Assign.TabIndex = 9;
            this.btn_Med_Assign.Text = "Assign";
            this.btn_Med_Assign.UseVisualStyleBackColor = true;
            this.btn_Med_Assign.Click += new System.EventHandler(this.btn_Med_Assign_Click);
            // 
            // tbox_Med_Medcine_Quantity
            // 
            this.tbox_Med_Medcine_Quantity.Enabled = false;
            this.tbox_Med_Medcine_Quantity.Location = new System.Drawing.Point(138, 90);
            this.tbox_Med_Medcine_Quantity.Name = "tbox_Med_Medcine_Quantity";
            this.tbox_Med_Medcine_Quantity.Size = new System.Drawing.Size(261, 20);
            this.tbox_Med_Medcine_Quantity.TabIndex = 8;
            this.tbox_Med_Medcine_Quantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbox_Med_Medcine_Quantity_KeyUp);
            // 
            // lbl_Med_Medcine_Quantity
            // 
            this.lbl_Med_Medcine_Quantity.AutoSize = true;
            this.lbl_Med_Medcine_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Med_Medcine_Quantity.Location = new System.Drawing.Point(70, 93);
            this.lbl_Med_Medcine_Quantity.Name = "lbl_Med_Medcine_Quantity";
            this.lbl_Med_Medcine_Quantity.Size = new System.Drawing.Size(62, 13);
            this.lbl_Med_Medcine_Quantity.TabIndex = 10;
            this.lbl_Med_Medcine_Quantity.Text = "Quantity :";
            // 
            // tbox_Med_Medcine_Name
            // 
            this.tbox_Med_Medcine_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_Med_Medcine_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_Med_Medcine_Name.Location = new System.Drawing.Point(138, 49);
            this.tbox_Med_Medcine_Name.Name = "tbox_Med_Medcine_Name";
            this.tbox_Med_Medcine_Name.Size = new System.Drawing.Size(261, 20);
            this.tbox_Med_Medcine_Name.TabIndex = 7;
            this.tbox_Med_Medcine_Name.TextChanged += new System.EventHandler(this.tbox_Med_Medcine_Name_TextChanged);
            // 
            // lbl_Med_Medcine_Name
            // 
            this.lbl_Med_Medcine_Name.AutoSize = true;
            this.lbl_Med_Medcine_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Med_Medcine_Name.Location = new System.Drawing.Point(33, 52);
            this.lbl_Med_Medcine_Name.Name = "lbl_Med_Medcine_Name";
            this.lbl_Med_Medcine_Name.Size = new System.Drawing.Size(99, 13);
            this.lbl_Med_Medcine_Name.TabIndex = 8;
            this.lbl_Med_Medcine_Name.Text = "Medcine Name :";
            // 
            // tb_Page_Settings
            // 
            this.tb_Page_Settings.Controls.Add(this.tbCtrl_Settings);
            this.tb_Page_Settings.Location = new System.Drawing.Point(4, 22);
            this.tb_Page_Settings.Name = "tb_Page_Settings";
            this.tb_Page_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Page_Settings.Size = new System.Drawing.Size(878, 566);
            this.tb_Page_Settings.TabIndex = 3;
            this.tb_Page_Settings.Text = "Settings";
            this.tb_Page_Settings.UseVisualStyleBackColor = true;
            this.tb_Page_Settings.Enter += new System.EventHandler(this.tb_Page_Settings_Enter);
            // 
            // tbCtrl_Settings
            // 
            this.tbCtrl_Settings.Controls.Add(this.tb_Page_Settings_Manage_Employee);
            this.tbCtrl_Settings.Controls.Add(this.tb_Page_Settings_Manage_Medicine);
            this.tbCtrl_Settings.Controls.Add(this.tb_Page_Settings_Manage_Keys);
            this.tbCtrl_Settings.Controls.Add(this.tb_Page_Settings_Manage_Database);
            this.tbCtrl_Settings.Location = new System.Drawing.Point(6, 19);
            this.tbCtrl_Settings.Name = "tbCtrl_Settings";
            this.tbCtrl_Settings.SelectedIndex = 0;
            this.tbCtrl_Settings.Size = new System.Drawing.Size(869, 541);
            this.tbCtrl_Settings.TabIndex = 0;
            // 
            // tb_Page_Settings_Manage_Employee
            // 
            this.tb_Page_Settings_Manage_Employee.Controls.Add(this.sp_Cont_Manage_Employee);
            this.tb_Page_Settings_Manage_Employee.Location = new System.Drawing.Point(4, 22);
            this.tb_Page_Settings_Manage_Employee.Name = "tb_Page_Settings_Manage_Employee";
            this.tb_Page_Settings_Manage_Employee.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Page_Settings_Manage_Employee.Size = new System.Drawing.Size(861, 515);
            this.tb_Page_Settings_Manage_Employee.TabIndex = 0;
            this.tb_Page_Settings_Manage_Employee.Text = "Manage Employee";
            this.tb_Page_Settings_Manage_Employee.UseVisualStyleBackColor = true;
            // 
            // sp_Cont_Manage_Employee
            // 
            this.sp_Cont_Manage_Employee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sp_Cont_Manage_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Cont_Manage_Employee.IsSplitterFixed = true;
            this.sp_Cont_Manage_Employee.Location = new System.Drawing.Point(3, 3);
            this.sp_Cont_Manage_Employee.Name = "sp_Cont_Manage_Employee";
            this.sp_Cont_Manage_Employee.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sp_Cont_Manage_Employee.Panel1
            // 
            this.sp_Cont_Manage_Employee.Panel1.Controls.Add(this.lbl_InsertEmployee);
            this.sp_Cont_Manage_Employee.Panel1.Controls.Add(this.lblStateStatus);
            this.sp_Cont_Manage_Employee.Panel1.Controls.Add(this.btn_Start);
            this.sp_Cont_Manage_Employee.Panel1.Controls.Add(this.pgBar_Import_Progress);
            this.sp_Cont_Manage_Employee.Panel1.Controls.Add(this.btn_Browse);
            this.sp_Cont_Manage_Employee.Panel1.Controls.Add(this.tbox_Browse);
            this.sp_Cont_Manage_Employee.Panel1.Controls.Add(this.lbl_Browse);
            // 
            // sp_Cont_Manage_Employee.Panel2
            // 
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.tbox_Id);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.btn_Employee_Reset);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.lbl_Error);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.lbl_UpdateEmployee);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.btn_Employee_Update);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.btn_Employee_Search);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.rdBtn_EmployeeInActive);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.rdBtn_EmployeeActive);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.lbl_ManageEmployee_EmployeeLocation);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.tbox_ManageEmployee_EmployeeLocation);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.lbl_ManageEmployee_EmployeeManagerId);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.tbox_ManageEmployee_EmployeeManagerId);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.lbl_ManageEmployee_EmployeeManager);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.tbox_ManageEmployee_EmployeeManager);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.lbl_ManageEmployee_EmployeeCompany);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.tbox_ManageEmployee_EmployeeCompany);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.lbl_ManageEmployee_EmployeeDepartment);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.tbox_ManageEmployee_EmployeeDepartment);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.lbl_ManageEmployee_EmployeeOfficialMobile);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.lbl_ManageEmployee_EmployeePersonalEmail);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.lbl_ManageEmployee_EmployeePersonalMobile);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.lbl_ManageEmployee_EmployeeExtection);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.lbl_ManageEmployee_EmployeeEmail);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.lbl_ManageEmployee_EmployeeName);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.lbl_ManageEmployee_EmployeeId);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.tbox_ManageEmployee_EmployeeOfficialMobile);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.tbox_ManageEmployee_EmployeePersonalEmail);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.tbox_ManageEmployee_EmployeePersonalMobile);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.tbox_ManageEmployee_EmployeeExtection);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.tbox_ManageEmployee_EmployeeEmail);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.tbox_ManageEmployee_EmployeeName);
            this.sp_Cont_Manage_Employee.Panel2.Controls.Add(this.tbox_ManageEmployee_EmployeeId);
            this.sp_Cont_Manage_Employee.Size = new System.Drawing.Size(855, 509);
            this.sp_Cont_Manage_Employee.SplitterDistance = 134;
            this.sp_Cont_Manage_Employee.TabIndex = 0;
            // 
            // lbl_InsertEmployee
            // 
            this.lbl_InsertEmployee.AutoSize = true;
            this.lbl_InsertEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertEmployee.ForeColor = System.Drawing.Color.Blue;
            this.lbl_InsertEmployee.Location = new System.Drawing.Point(-1, 0);
            this.lbl_InsertEmployee.Name = "lbl_InsertEmployee";
            this.lbl_InsertEmployee.Size = new System.Drawing.Size(261, 25);
            this.lbl_InsertEmployee.TabIndex = 9;
            this.lbl_InsertEmployee.Text = "Insert Employee Details";
            // 
            // lblStateStatus
            // 
            this.lblStateStatus.AutoSize = true;
            this.lblStateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateStatus.Location = new System.Drawing.Point(12, 101);
            this.lblStateStatus.Name = "lblStateStatus";
            this.lblStateStatus.Size = new System.Drawing.Size(0, 15);
            this.lblStateStatus.TabIndex = 6;
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(752, 40);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(83, 24);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // pgBar_Import_Progress
            // 
            this.pgBar_Import_Progress.Location = new System.Drawing.Point(15, 75);
            this.pgBar_Import_Progress.Name = "pgBar_Import_Progress";
            this.pgBar_Import_Progress.Size = new System.Drawing.Size(820, 23);
            this.pgBar_Import_Progress.TabIndex = 4;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(663, 40);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(83, 24);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // tbox_Browse
            // 
            this.tbox_Browse.Location = new System.Drawing.Point(127, 44);
            this.tbox_Browse.Name = "tbox_Browse";
            this.tbox_Browse.Size = new System.Drawing.Size(530, 20);
            this.tbox_Browse.TabIndex = 1;
            // 
            // lbl_Browse
            // 
            this.lbl_Browse.AutoSize = true;
            this.lbl_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Browse.Location = new System.Drawing.Point(12, 45);
            this.lbl_Browse.Name = "lbl_Browse";
            this.lbl_Browse.Size = new System.Drawing.Size(111, 15);
            this.lbl_Browse.TabIndex = 0;
            this.lbl_Browse.Text = "Select The File :";
            // 
            // tbox_Id
            // 
            this.tbox_Id.Location = new System.Drawing.Point(161, 28);
            this.tbox_Id.Name = "tbox_Id";
            this.tbox_Id.Size = new System.Drawing.Size(100, 20);
            this.tbox_Id.TabIndex = 30;
            this.tbox_Id.Visible = false;
            // 
            // btn_Employee_Reset
            // 
            this.btn_Employee_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee_Reset.Location = new System.Drawing.Point(740, 285);
            this.btn_Employee_Reset.Name = "btn_Employee_Reset";
            this.btn_Employee_Reset.Size = new System.Drawing.Size(75, 39);
            this.btn_Employee_Reset.TabIndex = 29;
            this.btn_Employee_Reset.Text = "Reset";
            this.btn_Employee_Reset.UseVisualStyleBackColor = true;
            this.btn_Employee_Reset.Click += new System.EventHandler(this.btn_Employee_Reset_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(303, 341);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 20);
            this.lbl_Error.TabIndex = 28;
            // 
            // lbl_UpdateEmployee
            // 
            this.lbl_UpdateEmployee.AutoSize = true;
            this.lbl_UpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UpdateEmployee.ForeColor = System.Drawing.Color.Blue;
            this.lbl_UpdateEmployee.Location = new System.Drawing.Point(-1, 0);
            this.lbl_UpdateEmployee.Name = "lbl_UpdateEmployee";
            this.lbl_UpdateEmployee.Size = new System.Drawing.Size(277, 25);
            this.lbl_UpdateEmployee.TabIndex = 8;
            this.lbl_UpdateEmployee.Text = "Update Employee Details";
            // 
            // btn_Employee_Update
            // 
            this.btn_Employee_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee_Update.Location = new System.Drawing.Point(659, 285);
            this.btn_Employee_Update.Name = "btn_Employee_Update";
            this.btn_Employee_Update.Size = new System.Drawing.Size(75, 39);
            this.btn_Employee_Update.TabIndex = 27;
            this.btn_Employee_Update.Text = "Update";
            this.btn_Employee_Update.UseVisualStyleBackColor = true;
            this.btn_Employee_Update.Click += new System.EventHandler(this.btn_Employee_Update_Click);
            // 
            // btn_Employee_Search
            // 
            this.btn_Employee_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee_Search.Location = new System.Drawing.Point(578, 285);
            this.btn_Employee_Search.Name = "btn_Employee_Search";
            this.btn_Employee_Search.Size = new System.Drawing.Size(75, 39);
            this.btn_Employee_Search.TabIndex = 26;
            this.btn_Employee_Search.Text = "Search";
            this.btn_Employee_Search.UseVisualStyleBackColor = true;
            this.btn_Employee_Search.Click += new System.EventHandler(this.btn_Employee_Search_Click);
            // 
            // rdBtn_EmployeeInActive
            // 
            this.rdBtn_EmployeeInActive.AutoSize = true;
            this.rdBtn_EmployeeInActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_EmployeeInActive.Location = new System.Drawing.Point(229, 295);
            this.rdBtn_EmployeeInActive.Name = "rdBtn_EmployeeInActive";
            this.rdBtn_EmployeeInActive.Size = new System.Drawing.Size(79, 19);
            this.rdBtn_EmployeeInActive.TabIndex = 25;
            this.rdBtn_EmployeeInActive.TabStop = true;
            this.rdBtn_EmployeeInActive.Text = "In-Active";
            this.rdBtn_EmployeeInActive.UseVisualStyleBackColor = true;
            // 
            // rdBtn_EmployeeActive
            // 
            this.rdBtn_EmployeeActive.AutoSize = true;
            this.rdBtn_EmployeeActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_EmployeeActive.Location = new System.Drawing.Point(161, 295);
            this.rdBtn_EmployeeActive.Name = "rdBtn_EmployeeActive";
            this.rdBtn_EmployeeActive.Size = new System.Drawing.Size(62, 19);
            this.rdBtn_EmployeeActive.TabIndex = 24;
            this.rdBtn_EmployeeActive.TabStop = true;
            this.rdBtn_EmployeeActive.Text = "Active";
            this.rdBtn_EmployeeActive.UseVisualStyleBackColor = true;
            // 
            // lbl_ManageEmployee_EmployeeLocation
            // 
            this.lbl_ManageEmployee_EmployeeLocation.AutoSize = true;
            this.lbl_ManageEmployee_EmployeeLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageEmployee_EmployeeLocation.Location = new System.Drawing.Point(483, 246);
            this.lbl_ManageEmployee_EmployeeLocation.Name = "lbl_ManageEmployee_EmployeeLocation";
            this.lbl_ManageEmployee_EmployeeLocation.Size = new System.Drawing.Size(70, 15);
            this.lbl_ManageEmployee_EmployeeLocation.TabIndex = 23;
            this.lbl_ManageEmployee_EmployeeLocation.Text = "Location :";
            // 
            // tbox_ManageEmployee_EmployeeLocation
            // 
            this.tbox_ManageEmployee_EmployeeLocation.Location = new System.Drawing.Point(562, 245);
            this.tbox_ManageEmployee_EmployeeLocation.Name = "tbox_ManageEmployee_EmployeeLocation";
            this.tbox_ManageEmployee_EmployeeLocation.Size = new System.Drawing.Size(253, 20);
            this.tbox_ManageEmployee_EmployeeLocation.TabIndex = 22;
            // 
            // lbl_ManageEmployee_EmployeeManagerId
            // 
            this.lbl_ManageEmployee_EmployeeManagerId.AutoSize = true;
            this.lbl_ManageEmployee_EmployeeManagerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageEmployee_EmployeeManagerId.Location = new System.Drawing.Point(421, 208);
            this.lbl_ManageEmployee_EmployeeManagerId.Name = "lbl_ManageEmployee_EmployeeManagerId";
            this.lbl_ManageEmployee_EmployeeManagerId.Size = new System.Drawing.Size(132, 15);
            this.lbl_ManageEmployee_EmployeeManagerId.TabIndex = 21;
            this.lbl_ManageEmployee_EmployeeManagerId.Text = "Manager\'s Emp Id :";
            // 
            // tbox_ManageEmployee_EmployeeManagerId
            // 
            this.tbox_ManageEmployee_EmployeeManagerId.Location = new System.Drawing.Point(562, 208);
            this.tbox_ManageEmployee_EmployeeManagerId.Name = "tbox_ManageEmployee_EmployeeManagerId";
            this.tbox_ManageEmployee_EmployeeManagerId.Size = new System.Drawing.Size(253, 20);
            this.tbox_ManageEmployee_EmployeeManagerId.TabIndex = 20;
            // 
            // lbl_ManageEmployee_EmployeeManager
            // 
            this.lbl_ManageEmployee_EmployeeManager.AutoSize = true;
            this.lbl_ManageEmployee_EmployeeManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageEmployee_EmployeeManager.Location = new System.Drawing.Point(439, 173);
            this.lbl_ManageEmployee_EmployeeManager.Name = "lbl_ManageEmployee_EmployeeManager";
            this.lbl_ManageEmployee_EmployeeManager.Size = new System.Drawing.Size(114, 15);
            this.lbl_ManageEmployee_EmployeeManager.TabIndex = 19;
            this.lbl_ManageEmployee_EmployeeManager.Text = "Manager Name :";
            // 
            // tbox_ManageEmployee_EmployeeManager
            // 
            this.tbox_ManageEmployee_EmployeeManager.Location = new System.Drawing.Point(562, 172);
            this.tbox_ManageEmployee_EmployeeManager.Name = "tbox_ManageEmployee_EmployeeManager";
            this.tbox_ManageEmployee_EmployeeManager.Size = new System.Drawing.Size(253, 20);
            this.tbox_ManageEmployee_EmployeeManager.TabIndex = 18;
            // 
            // lbl_ManageEmployee_EmployeeCompany
            // 
            this.lbl_ManageEmployee_EmployeeCompany.AutoSize = true;
            this.lbl_ManageEmployee_EmployeeCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageEmployee_EmployeeCompany.Location = new System.Drawing.Point(479, 136);
            this.lbl_ManageEmployee_EmployeeCompany.Name = "lbl_ManageEmployee_EmployeeCompany";
            this.lbl_ManageEmployee_EmployeeCompany.Size = new System.Drawing.Size(74, 15);
            this.lbl_ManageEmployee_EmployeeCompany.TabIndex = 17;
            this.lbl_ManageEmployee_EmployeeCompany.Text = "Company :";
            // 
            // tbox_ManageEmployee_EmployeeCompany
            // 
            this.tbox_ManageEmployee_EmployeeCompany.Location = new System.Drawing.Point(562, 135);
            this.tbox_ManageEmployee_EmployeeCompany.Name = "tbox_ManageEmployee_EmployeeCompany";
            this.tbox_ManageEmployee_EmployeeCompany.Size = new System.Drawing.Size(253, 20);
            this.tbox_ManageEmployee_EmployeeCompany.TabIndex = 16;
            // 
            // lbl_ManageEmployee_EmployeeDepartment
            // 
            this.lbl_ManageEmployee_EmployeeDepartment.AutoSize = true;
            this.lbl_ManageEmployee_EmployeeDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageEmployee_EmployeeDepartment.Location = new System.Drawing.Point(463, 100);
            this.lbl_ManageEmployee_EmployeeDepartment.Name = "lbl_ManageEmployee_EmployeeDepartment";
            this.lbl_ManageEmployee_EmployeeDepartment.Size = new System.Drawing.Size(90, 15);
            this.lbl_ManageEmployee_EmployeeDepartment.TabIndex = 15;
            this.lbl_ManageEmployee_EmployeeDepartment.Text = "Department :";
            // 
            // tbox_ManageEmployee_EmployeeDepartment
            // 
            this.tbox_ManageEmployee_EmployeeDepartment.Location = new System.Drawing.Point(562, 99);
            this.tbox_ManageEmployee_EmployeeDepartment.Name = "tbox_ManageEmployee_EmployeeDepartment";
            this.tbox_ManageEmployee_EmployeeDepartment.Size = new System.Drawing.Size(253, 20);
            this.tbox_ManageEmployee_EmployeeDepartment.TabIndex = 14;
            // 
            // lbl_ManageEmployee_EmployeeOfficialMobile
            // 
            this.lbl_ManageEmployee_EmployeeOfficialMobile.AutoSize = true;
            this.lbl_ManageEmployee_EmployeeOfficialMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageEmployee_EmployeeOfficialMobile.Location = new System.Drawing.Point(448, 63);
            this.lbl_ManageEmployee_EmployeeOfficialMobile.Name = "lbl_ManageEmployee_EmployeeOfficialMobile";
            this.lbl_ManageEmployee_EmployeeOfficialMobile.Size = new System.Drawing.Size(108, 15);
            this.lbl_ManageEmployee_EmployeeOfficialMobile.TabIndex = 13;
            this.lbl_ManageEmployee_EmployeeOfficialMobile.Text = "Official Mobile :";
            // 
            // lbl_ManageEmployee_EmployeePersonalEmail
            // 
            this.lbl_ManageEmployee_EmployeePersonalEmail.AutoSize = true;
            this.lbl_ManageEmployee_EmployeePersonalEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageEmployee_EmployeePersonalEmail.Location = new System.Drawing.Point(37, 246);
            this.lbl_ManageEmployee_EmployeePersonalEmail.Name = "lbl_ManageEmployee_EmployeePersonalEmail";
            this.lbl_ManageEmployee_EmployeePersonalEmail.Size = new System.Drawing.Size(113, 15);
            this.lbl_ManageEmployee_EmployeePersonalEmail.TabIndex = 12;
            this.lbl_ManageEmployee_EmployeePersonalEmail.Text = "Personal Email :";
            // 
            // lbl_ManageEmployee_EmployeePersonalMobile
            // 
            this.lbl_ManageEmployee_EmployeePersonalMobile.AutoSize = true;
            this.lbl_ManageEmployee_EmployeePersonalMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageEmployee_EmployeePersonalMobile.Location = new System.Drawing.Point(30, 208);
            this.lbl_ManageEmployee_EmployeePersonalMobile.Name = "lbl_ManageEmployee_EmployeePersonalMobile";
            this.lbl_ManageEmployee_EmployeePersonalMobile.Size = new System.Drawing.Size(120, 15);
            this.lbl_ManageEmployee_EmployeePersonalMobile.TabIndex = 11;
            this.lbl_ManageEmployee_EmployeePersonalMobile.Text = "Personal Mobile :";
            // 
            // lbl_ManageEmployee_EmployeeExtection
            // 
            this.lbl_ManageEmployee_EmployeeExtection.AutoSize = true;
            this.lbl_ManageEmployee_EmployeeExtection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageEmployee_EmployeeExtection.Location = new System.Drawing.Point(72, 172);
            this.lbl_ManageEmployee_EmployeeExtection.Name = "lbl_ManageEmployee_EmployeeExtection";
            this.lbl_ManageEmployee_EmployeeExtection.Size = new System.Drawing.Size(78, 15);
            this.lbl_ManageEmployee_EmployeeExtection.TabIndex = 10;
            this.lbl_ManageEmployee_EmployeeExtection.Text = "Extension :";
            // 
            // lbl_ManageEmployee_EmployeeEmail
            // 
            this.lbl_ManageEmployee_EmployeeEmail.AutoSize = true;
            this.lbl_ManageEmployee_EmployeeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageEmployee_EmployeeEmail.Location = new System.Drawing.Point(49, 136);
            this.lbl_ManageEmployee_EmployeeEmail.Name = "lbl_ManageEmployee_EmployeeEmail";
            this.lbl_ManageEmployee_EmployeeEmail.Size = new System.Drawing.Size(101, 15);
            this.lbl_ManageEmployee_EmployeeEmail.TabIndex = 9;
            this.lbl_ManageEmployee_EmployeeEmail.Text = "Official Email :";
            // 
            // lbl_ManageEmployee_EmployeeName
            // 
            this.lbl_ManageEmployee_EmployeeName.AutoSize = true;
            this.lbl_ManageEmployee_EmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageEmployee_EmployeeName.Location = new System.Drawing.Point(97, 100);
            this.lbl_ManageEmployee_EmployeeName.Name = "lbl_ManageEmployee_EmployeeName";
            this.lbl_ManageEmployee_EmployeeName.Size = new System.Drawing.Size(53, 15);
            this.lbl_ManageEmployee_EmployeeName.TabIndex = 8;
            this.lbl_ManageEmployee_EmployeeName.Text = "Name :";
            // 
            // lbl_ManageEmployee_EmployeeId
            // 
            this.lbl_ManageEmployee_EmployeeId.AutoSize = true;
            this.lbl_ManageEmployee_EmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageEmployee_EmployeeId.Location = new System.Drawing.Point(56, 63);
            this.lbl_ManageEmployee_EmployeeId.Name = "lbl_ManageEmployee_EmployeeId";
            this.lbl_ManageEmployee_EmployeeId.Size = new System.Drawing.Size(94, 15);
            this.lbl_ManageEmployee_EmployeeId.TabIndex = 7;
            this.lbl_ManageEmployee_EmployeeId.Text = "Employee Id :";
            // 
            // tbox_ManageEmployee_EmployeeOfficialMobile
            // 
            this.tbox_ManageEmployee_EmployeeOfficialMobile.Location = new System.Drawing.Point(562, 62);
            this.tbox_ManageEmployee_EmployeeOfficialMobile.Name = "tbox_ManageEmployee_EmployeeOfficialMobile";
            this.tbox_ManageEmployee_EmployeeOfficialMobile.Size = new System.Drawing.Size(253, 20);
            this.tbox_ManageEmployee_EmployeeOfficialMobile.TabIndex = 6;
            // 
            // tbox_ManageEmployee_EmployeePersonalEmail
            // 
            this.tbox_ManageEmployee_EmployeePersonalEmail.Location = new System.Drawing.Point(161, 245);
            this.tbox_ManageEmployee_EmployeePersonalEmail.Name = "tbox_ManageEmployee_EmployeePersonalEmail";
            this.tbox_ManageEmployee_EmployeePersonalEmail.Size = new System.Drawing.Size(253, 20);
            this.tbox_ManageEmployee_EmployeePersonalEmail.TabIndex = 5;
            // 
            // tbox_ManageEmployee_EmployeePersonalMobile
            // 
            this.tbox_ManageEmployee_EmployeePersonalMobile.Location = new System.Drawing.Point(161, 207);
            this.tbox_ManageEmployee_EmployeePersonalMobile.Name = "tbox_ManageEmployee_EmployeePersonalMobile";
            this.tbox_ManageEmployee_EmployeePersonalMobile.Size = new System.Drawing.Size(253, 20);
            this.tbox_ManageEmployee_EmployeePersonalMobile.TabIndex = 4;
            // 
            // tbox_ManageEmployee_EmployeeExtection
            // 
            this.tbox_ManageEmployee_EmployeeExtection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_ManageEmployee_EmployeeExtection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_ManageEmployee_EmployeeExtection.Location = new System.Drawing.Point(161, 171);
            this.tbox_ManageEmployee_EmployeeExtection.Name = "tbox_ManageEmployee_EmployeeExtection";
            this.tbox_ManageEmployee_EmployeeExtection.Size = new System.Drawing.Size(253, 20);
            this.tbox_ManageEmployee_EmployeeExtection.TabIndex = 3;
            this.tbox_ManageEmployee_EmployeeExtection.TextChanged += new System.EventHandler(this.tbox_ManageEmployee_EmployeeExtection_TextChanged);
            // 
            // tbox_ManageEmployee_EmployeeEmail
            // 
            this.tbox_ManageEmployee_EmployeeEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_ManageEmployee_EmployeeEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_ManageEmployee_EmployeeEmail.Location = new System.Drawing.Point(161, 135);
            this.tbox_ManageEmployee_EmployeeEmail.Name = "tbox_ManageEmployee_EmployeeEmail";
            this.tbox_ManageEmployee_EmployeeEmail.Size = new System.Drawing.Size(253, 20);
            this.tbox_ManageEmployee_EmployeeEmail.TabIndex = 2;
            this.tbox_ManageEmployee_EmployeeEmail.TextChanged += new System.EventHandler(this.tbox_ManageEmployee_EmployeeEmail_TextChanged);
            // 
            // tbox_ManageEmployee_EmployeeName
            // 
            this.tbox_ManageEmployee_EmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_ManageEmployee_EmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_ManageEmployee_EmployeeName.Location = new System.Drawing.Point(161, 98);
            this.tbox_ManageEmployee_EmployeeName.Name = "tbox_ManageEmployee_EmployeeName";
            this.tbox_ManageEmployee_EmployeeName.Size = new System.Drawing.Size(253, 20);
            this.tbox_ManageEmployee_EmployeeName.TabIndex = 1;
            this.tbox_ManageEmployee_EmployeeName.TextChanged += new System.EventHandler(this.tbox_ManageEmployee_EmployeeName_TextChanged);
            // 
            // tbox_ManageEmployee_EmployeeId
            // 
            this.tbox_ManageEmployee_EmployeeId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_ManageEmployee_EmployeeId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_ManageEmployee_EmployeeId.Location = new System.Drawing.Point(161, 62);
            this.tbox_ManageEmployee_EmployeeId.Name = "tbox_ManageEmployee_EmployeeId";
            this.tbox_ManageEmployee_EmployeeId.Size = new System.Drawing.Size(253, 20);
            this.tbox_ManageEmployee_EmployeeId.TabIndex = 0;
            this.tbox_ManageEmployee_EmployeeId.TextChanged += new System.EventHandler(this.tbox_ManageEmployee_EmployeeId_TextChanged);
            // 
            // tb_Page_Settings_Manage_Medicine
            // 
            this.tb_Page_Settings_Manage_Medicine.Controls.Add(this.sp_Cont_Manage_Medicine_Graph);
            this.tb_Page_Settings_Manage_Medicine.Location = new System.Drawing.Point(4, 22);
            this.tb_Page_Settings_Manage_Medicine.Name = "tb_Page_Settings_Manage_Medicine";
            this.tb_Page_Settings_Manage_Medicine.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Page_Settings_Manage_Medicine.Size = new System.Drawing.Size(861, 515);
            this.tb_Page_Settings_Manage_Medicine.TabIndex = 2;
            this.tb_Page_Settings_Manage_Medicine.Text = "Manage Medicine";
            this.tb_Page_Settings_Manage_Medicine.UseVisualStyleBackColor = true;
            this.tb_Page_Settings_Manage_Medicine.Enter += new System.EventHandler(this.tb_Page_Settings_Manage_Medicine_Enter);
            this.tb_Page_Settings_Manage_Medicine.Leave += new System.EventHandler(this.tb_Page_Settings_Manage_Medicine_Leave);
            // 
            // sp_Cont_Manage_Medicine_Graph
            // 
            this.sp_Cont_Manage_Medicine_Graph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sp_Cont_Manage_Medicine_Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Cont_Manage_Medicine_Graph.IsSplitterFixed = true;
            this.sp_Cont_Manage_Medicine_Graph.Location = new System.Drawing.Point(3, 3);
            this.sp_Cont_Manage_Medicine_Graph.Name = "sp_Cont_Manage_Medicine_Graph";
            // 
            // sp_Cont_Manage_Medicine_Graph.Panel1
            // 
            this.sp_Cont_Manage_Medicine_Graph.Panel1.Controls.Add(this.sp_Cont_Manage_Medicine_Add_And_Update);
            // 
            // sp_Cont_Manage_Medicine_Graph.Panel2
            // 
            this.sp_Cont_Manage_Medicine_Graph.Panel2.Controls.Add(this.lbl_GraphDataError);
            this.sp_Cont_Manage_Medicine_Graph.Panel2.Controls.Add(this.rd_ManageMedicine_PlotInActiveMedicine);
            this.sp_Cont_Manage_Medicine_Graph.Panel2.Controls.Add(this.rd_ManageMedicine_PlotActiveMedicine);
            this.sp_Cont_Manage_Medicine_Graph.Panel2.Controls.Add(this.chrt_Medicine_Stock);
            this.sp_Cont_Manage_Medicine_Graph.Size = new System.Drawing.Size(855, 509);
            this.sp_Cont_Manage_Medicine_Graph.SplitterDistance = 346;
            this.sp_Cont_Manage_Medicine_Graph.TabIndex = 0;
            // 
            // sp_Cont_Manage_Medicine_Add_And_Update
            // 
            this.sp_Cont_Manage_Medicine_Add_And_Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sp_Cont_Manage_Medicine_Add_And_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Cont_Manage_Medicine_Add_And_Update.IsSplitterFixed = true;
            this.sp_Cont_Manage_Medicine_Add_And_Update.Location = new System.Drawing.Point(0, 0);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Name = "sp_Cont_Manage_Medicine_Add_And_Update";
            this.sp_Cont_Manage_Medicine_Add_And_Update.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sp_Cont_Manage_Medicine_Add_And_Update.Panel1
            // 
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel1.Controls.Add(this.lbl_InsertMedicine);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel1.Controls.Add(this.lbl_ExistingMedicine);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel1.Controls.Add(this.btn_ManageMedicine_Insert_Reset);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel1.Controls.Add(this.btn_ManageMedicine_Add);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel1.Controls.Add(this.nemUD_ManageMedicine_InsertWarning);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel1.Controls.Add(this.lbl_ManageMedicine_InsertWarning);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel1.Controls.Add(this.nemUD_ManageMedicine_InsertMedicineStock);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel1.Controls.Add(this.lbl_ManageMedicine_InsertMedicineStock);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel1.Controls.Add(this.tbox_ManageMedicine_InsertMedicineName);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel1.Controls.Add(this.lbl_ManageMedicine_InsertMedicineName);
            // 
            // sp_Cont_Manage_Medicine_Add_And_Update.Panel2
            // 
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.Controls.Add(this.tbox_ManageMedicineId);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.Controls.Add(this.btn_ManageMedicine_Update_Reset);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.Controls.Add(this.btn_ManageMedicine_Update);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.Controls.Add(this.rdBtn_MedicineInActive);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.Controls.Add(this.rdBtn_MedicineActive);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.Controls.Add(this.nemUD_ManageMedicine_UpdateWarning);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.Controls.Add(this.lbl_ManageMedicine_UpdateWarning);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.Controls.Add(this.nemUD_ManageMedicine_UpdateMedicineStock);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.Controls.Add(this.lbl_ManageMedicine_UpdateMedicineStock);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.Controls.Add(this.btn_ManageMedicine_Search);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.Controls.Add(this.tbox_ManageMedicine_UpdateMedicineName);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.Controls.Add(this.lbl_ManageMedicine_UpdateMedicineName);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.Controls.Add(this.lbl_UpdateMedicine);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Size = new System.Drawing.Size(346, 509);
            this.sp_Cont_Manage_Medicine_Add_And_Update.SplitterDistance = 245;
            this.sp_Cont_Manage_Medicine_Add_And_Update.TabIndex = 0;
            // 
            // lbl_InsertMedicine
            // 
            this.lbl_InsertMedicine.AutoSize = true;
            this.lbl_InsertMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertMedicine.ForeColor = System.Drawing.Color.Blue;
            this.lbl_InsertMedicine.Location = new System.Drawing.Point(-1, 0);
            this.lbl_InsertMedicine.Name = "lbl_InsertMedicine";
            this.lbl_InsertMedicine.Size = new System.Drawing.Size(253, 25);
            this.lbl_InsertMedicine.TabIndex = 10;
            this.lbl_InsertMedicine.Text = "Insert Medicine Details";
            // 
            // lbl_ExistingMedicine
            // 
            this.lbl_ExistingMedicine.AutoSize = true;
            this.lbl_ExistingMedicine.ForeColor = System.Drawing.Color.Red;
            this.lbl_ExistingMedicine.Location = new System.Drawing.Point(142, 47);
            this.lbl_ExistingMedicine.Name = "lbl_ExistingMedicine";
            this.lbl_ExistingMedicine.Size = new System.Drawing.Size(0, 13);
            this.lbl_ExistingMedicine.TabIndex = 8;
            // 
            // btn_ManageMedicine_Insert_Reset
            // 
            this.btn_ManageMedicine_Insert_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageMedicine_Insert_Reset.Location = new System.Drawing.Point(249, 172);
            this.btn_ManageMedicine_Insert_Reset.Name = "btn_ManageMedicine_Insert_Reset";
            this.btn_ManageMedicine_Insert_Reset.Size = new System.Drawing.Size(87, 38);
            this.btn_ManageMedicine_Insert_Reset.TabIndex = 7;
            this.btn_ManageMedicine_Insert_Reset.Text = "Reset";
            this.btn_ManageMedicine_Insert_Reset.UseVisualStyleBackColor = true;
            this.btn_ManageMedicine_Insert_Reset.Click += new System.EventHandler(this.btn_ManageMedicine_Insert_Reset_Click);
            // 
            // btn_ManageMedicine_Add
            // 
            this.btn_ManageMedicine_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageMedicine_Add.Location = new System.Drawing.Point(151, 172);
            this.btn_ManageMedicine_Add.Name = "btn_ManageMedicine_Add";
            this.btn_ManageMedicine_Add.Size = new System.Drawing.Size(87, 38);
            this.btn_ManageMedicine_Add.TabIndex = 6;
            this.btn_ManageMedicine_Add.Text = "Insert";
            this.btn_ManageMedicine_Add.UseVisualStyleBackColor = true;
            this.btn_ManageMedicine_Add.Click += new System.EventHandler(this.btn_ManageMedicine_Add_Click);
            // 
            // nemUD_ManageMedicine_InsertWarning
            // 
            this.nemUD_ManageMedicine_InsertWarning.Location = new System.Drawing.Point(141, 134);
            this.nemUD_ManageMedicine_InsertWarning.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nemUD_ManageMedicine_InsertWarning.Name = "nemUD_ManageMedicine_InsertWarning";
            this.nemUD_ManageMedicine_InsertWarning.Size = new System.Drawing.Size(195, 20);
            this.nemUD_ManageMedicine_InsertWarning.TabIndex = 3;
            this.nemUD_ManageMedicine_InsertWarning.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_ManageMedicine_InsertWarning
            // 
            this.lbl_ManageMedicine_InsertWarning.AutoSize = true;
            this.lbl_ManageMedicine_InsertWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageMedicine_InsertWarning.Location = new System.Drawing.Point(7, 135);
            this.lbl_ManageMedicine_InsertWarning.Name = "lbl_ManageMedicine_InsertWarning";
            this.lbl_ManageMedicine_InsertWarning.Size = new System.Drawing.Size(136, 15);
            this.lbl_ManageMedicine_InsertWarning.TabIndex = 4;
            this.lbl_ManageMedicine_InsertWarning.Text = "Warnning Quantity : ";
            // 
            // nemUD_ManageMedicine_InsertMedicineStock
            // 
            this.nemUD_ManageMedicine_InsertMedicineStock.Location = new System.Drawing.Point(141, 99);
            this.nemUD_ManageMedicine_InsertMedicineStock.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nemUD_ManageMedicine_InsertMedicineStock.Name = "nemUD_ManageMedicine_InsertMedicineStock";
            this.nemUD_ManageMedicine_InsertMedicineStock.Size = new System.Drawing.Size(195, 20);
            this.nemUD_ManageMedicine_InsertMedicineStock.TabIndex = 2;
            this.nemUD_ManageMedicine_InsertMedicineStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_ManageMedicine_InsertMedicineStock
            // 
            this.lbl_ManageMedicine_InsertMedicineStock.AutoSize = true;
            this.lbl_ManageMedicine_InsertMedicineStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageMedicine_InsertMedicineStock.Location = new System.Drawing.Point(33, 101);
            this.lbl_ManageMedicine_InsertMedicineStock.Name = "lbl_ManageMedicine_InsertMedicineStock";
            this.lbl_ManageMedicine_InsertMedicineStock.Size = new System.Drawing.Size(110, 15);
            this.lbl_ManageMedicine_InsertMedicineStock.TabIndex = 2;
            this.lbl_ManageMedicine_InsertMedicineStock.Text = "Stock Quantity : ";
            // 
            // tbox_ManageMedicine_InsertMedicineName
            // 
            this.tbox_ManageMedicine_InsertMedicineName.Location = new System.Drawing.Point(141, 63);
            this.tbox_ManageMedicine_InsertMedicineName.Name = "tbox_ManageMedicine_InsertMedicineName";
            this.tbox_ManageMedicine_InsertMedicineName.Size = new System.Drawing.Size(195, 20);
            this.tbox_ManageMedicine_InsertMedicineName.TabIndex = 1;
            // 
            // lbl_ManageMedicine_InsertMedicineName
            // 
            this.lbl_ManageMedicine_InsertMedicineName.AutoSize = true;
            this.lbl_ManageMedicine_InsertMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageMedicine_InsertMedicineName.Location = new System.Drawing.Point(24, 64);
            this.lbl_ManageMedicine_InsertMedicineName.Name = "lbl_ManageMedicine_InsertMedicineName";
            this.lbl_ManageMedicine_InsertMedicineName.Size = new System.Drawing.Size(120, 15);
            this.lbl_ManageMedicine_InsertMedicineName.TabIndex = 0;
            this.lbl_ManageMedicine_InsertMedicineName.Text = "Medicine Name : ";
            // 
            // tbox_ManageMedicineId
            // 
            this.tbox_ManageMedicineId.Location = new System.Drawing.Point(10, 216);
            this.tbox_ManageMedicineId.Name = "tbox_ManageMedicineId";
            this.tbox_ManageMedicineId.Size = new System.Drawing.Size(76, 20);
            this.tbox_ManageMedicineId.TabIndex = 21;
            this.tbox_ManageMedicineId.Visible = false;
            // 
            // btn_ManageMedicine_Update_Reset
            // 
            this.btn_ManageMedicine_Update_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageMedicine_Update_Reset.Location = new System.Drawing.Point(249, 205);
            this.btn_ManageMedicine_Update_Reset.Name = "btn_ManageMedicine_Update_Reset";
            this.btn_ManageMedicine_Update_Reset.Size = new System.Drawing.Size(87, 38);
            this.btn_ManageMedicine_Update_Reset.TabIndex = 20;
            this.btn_ManageMedicine_Update_Reset.Text = "Reset";
            this.btn_ManageMedicine_Update_Reset.UseVisualStyleBackColor = true;
            this.btn_ManageMedicine_Update_Reset.Click += new System.EventHandler(this.btn_ManageMedicine_Update_Reset_Click);
            // 
            // btn_ManageMedicine_Update
            // 
            this.btn_ManageMedicine_Update.Enabled = false;
            this.btn_ManageMedicine_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageMedicine_Update.Location = new System.Drawing.Point(151, 205);
            this.btn_ManageMedicine_Update.Name = "btn_ManageMedicine_Update";
            this.btn_ManageMedicine_Update.Size = new System.Drawing.Size(87, 38);
            this.btn_ManageMedicine_Update.TabIndex = 19;
            this.btn_ManageMedicine_Update.Text = "Update";
            this.btn_ManageMedicine_Update.UseVisualStyleBackColor = true;
            this.btn_ManageMedicine_Update.Click += new System.EventHandler(this.btn_ManageMedicine_Update_Click);
            // 
            // rdBtn_MedicineInActive
            // 
            this.rdBtn_MedicineInActive.AutoSize = true;
            this.rdBtn_MedicineInActive.Enabled = false;
            this.rdBtn_MedicineInActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_MedicineInActive.Location = new System.Drawing.Point(202, 178);
            this.rdBtn_MedicineInActive.Name = "rdBtn_MedicineInActive";
            this.rdBtn_MedicineInActive.Size = new System.Drawing.Size(76, 17);
            this.rdBtn_MedicineInActive.TabIndex = 18;
            this.rdBtn_MedicineInActive.TabStop = true;
            this.rdBtn_MedicineInActive.Text = "In-Active";
            this.rdBtn_MedicineInActive.UseVisualStyleBackColor = true;
            // 
            // rdBtn_MedicineActive
            // 
            this.rdBtn_MedicineActive.AutoSize = true;
            this.rdBtn_MedicineActive.Enabled = false;
            this.rdBtn_MedicineActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_MedicineActive.Location = new System.Drawing.Point(141, 178);
            this.rdBtn_MedicineActive.Name = "rdBtn_MedicineActive";
            this.rdBtn_MedicineActive.Size = new System.Drawing.Size(61, 17);
            this.rdBtn_MedicineActive.TabIndex = 17;
            this.rdBtn_MedicineActive.TabStop = true;
            this.rdBtn_MedicineActive.Text = "Active";
            this.rdBtn_MedicineActive.UseVisualStyleBackColor = true;
            // 
            // nemUD_ManageMedicine_UpdateWarning
            // 
            this.nemUD_ManageMedicine_UpdateWarning.Enabled = false;
            this.nemUD_ManageMedicine_UpdateWarning.Location = new System.Drawing.Point(141, 152);
            this.nemUD_ManageMedicine_UpdateWarning.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nemUD_ManageMedicine_UpdateWarning.Name = "nemUD_ManageMedicine_UpdateWarning";
            this.nemUD_ManageMedicine_UpdateWarning.Size = new System.Drawing.Size(195, 20);
            this.nemUD_ManageMedicine_UpdateWarning.TabIndex = 15;
            this.nemUD_ManageMedicine_UpdateWarning.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_ManageMedicine_UpdateWarning
            // 
            this.lbl_ManageMedicine_UpdateWarning.AutoSize = true;
            this.lbl_ManageMedicine_UpdateWarning.Enabled = false;
            this.lbl_ManageMedicine_UpdateWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageMedicine_UpdateWarning.Location = new System.Drawing.Point(7, 153);
            this.lbl_ManageMedicine_UpdateWarning.Name = "lbl_ManageMedicine_UpdateWarning";
            this.lbl_ManageMedicine_UpdateWarning.Size = new System.Drawing.Size(136, 15);
            this.lbl_ManageMedicine_UpdateWarning.TabIndex = 16;
            this.lbl_ManageMedicine_UpdateWarning.Text = "Warnning Quantity : ";
            // 
            // nemUD_ManageMedicine_UpdateMedicineStock
            // 
            this.nemUD_ManageMedicine_UpdateMedicineStock.Enabled = false;
            this.nemUD_ManageMedicine_UpdateMedicineStock.Location = new System.Drawing.Point(141, 117);
            this.nemUD_ManageMedicine_UpdateMedicineStock.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nemUD_ManageMedicine_UpdateMedicineStock.Name = "nemUD_ManageMedicine_UpdateMedicineStock";
            this.nemUD_ManageMedicine_UpdateMedicineStock.Size = new System.Drawing.Size(195, 20);
            this.nemUD_ManageMedicine_UpdateMedicineStock.TabIndex = 13;
            this.nemUD_ManageMedicine_UpdateMedicineStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_ManageMedicine_UpdateMedicineStock
            // 
            this.lbl_ManageMedicine_UpdateMedicineStock.AutoSize = true;
            this.lbl_ManageMedicine_UpdateMedicineStock.Enabled = false;
            this.lbl_ManageMedicine_UpdateMedicineStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageMedicine_UpdateMedicineStock.Location = new System.Drawing.Point(33, 119);
            this.lbl_ManageMedicine_UpdateMedicineStock.Name = "lbl_ManageMedicine_UpdateMedicineStock";
            this.lbl_ManageMedicine_UpdateMedicineStock.Size = new System.Drawing.Size(110, 15);
            this.lbl_ManageMedicine_UpdateMedicineStock.TabIndex = 14;
            this.lbl_ManageMedicine_UpdateMedicineStock.Text = "Stock Quantity : ";
            // 
            // btn_ManageMedicine_Search
            // 
            this.btn_ManageMedicine_Search.Enabled = false;
            this.btn_ManageMedicine_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageMedicine_Search.Location = new System.Drawing.Point(249, 73);
            this.btn_ManageMedicine_Search.Name = "btn_ManageMedicine_Search";
            this.btn_ManageMedicine_Search.Size = new System.Drawing.Size(87, 38);
            this.btn_ManageMedicine_Search.TabIndex = 12;
            this.btn_ManageMedicine_Search.Text = "Search";
            this.btn_ManageMedicine_Search.UseVisualStyleBackColor = true;
            this.btn_ManageMedicine_Search.Click += new System.EventHandler(this.btn_ManageMedicine_Search_Click);
            // 
            // tbox_ManageMedicine_UpdateMedicineName
            // 
            this.tbox_ManageMedicine_UpdateMedicineName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_ManageMedicine_UpdateMedicineName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_ManageMedicine_UpdateMedicineName.Location = new System.Drawing.Point(141, 47);
            this.tbox_ManageMedicine_UpdateMedicineName.Name = "tbox_ManageMedicine_UpdateMedicineName";
            this.tbox_ManageMedicine_UpdateMedicineName.Size = new System.Drawing.Size(195, 20);
            this.tbox_ManageMedicine_UpdateMedicineName.TabIndex = 11;
            this.tbox_ManageMedicine_UpdateMedicineName.EnabledChanged += new System.EventHandler(this.tbox_ManageMedicine_UpdateMedicineName_EnabledChanged);
            this.tbox_ManageMedicine_UpdateMedicineName.TextChanged += new System.EventHandler(this.tbox_ManageMedicine_UpdateMedicineName_TextChanged);
            // 
            // lbl_ManageMedicine_UpdateMedicineName
            // 
            this.lbl_ManageMedicine_UpdateMedicineName.AutoSize = true;
            this.lbl_ManageMedicine_UpdateMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageMedicine_UpdateMedicineName.Location = new System.Drawing.Point(23, 48);
            this.lbl_ManageMedicine_UpdateMedicineName.Name = "lbl_ManageMedicine_UpdateMedicineName";
            this.lbl_ManageMedicine_UpdateMedicineName.Size = new System.Drawing.Size(120, 15);
            this.lbl_ManageMedicine_UpdateMedicineName.TabIndex = 10;
            this.lbl_ManageMedicine_UpdateMedicineName.Text = "Medicine Name : ";
            // 
            // lbl_UpdateMedicine
            // 
            this.lbl_UpdateMedicine.AutoSize = true;
            this.lbl_UpdateMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UpdateMedicine.ForeColor = System.Drawing.Color.Blue;
            this.lbl_UpdateMedicine.Location = new System.Drawing.Point(-1, 0);
            this.lbl_UpdateMedicine.Name = "lbl_UpdateMedicine";
            this.lbl_UpdateMedicine.Size = new System.Drawing.Size(269, 25);
            this.lbl_UpdateMedicine.TabIndex = 9;
            this.lbl_UpdateMedicine.Text = "Update Medicine Details";
            // 
            // lbl_GraphDataError
            // 
            this.lbl_GraphDataError.AutoSize = true;
            this.lbl_GraphDataError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GraphDataError.ForeColor = System.Drawing.Color.Red;
            this.lbl_GraphDataError.Location = new System.Drawing.Point(54, 230);
            this.lbl_GraphDataError.Name = "lbl_GraphDataError";
            this.lbl_GraphDataError.Size = new System.Drawing.Size(0, 18);
            this.lbl_GraphDataError.TabIndex = 3;
            // 
            // rd_ManageMedicine_PlotInActiveMedicine
            // 
            this.rd_ManageMedicine_PlotInActiveMedicine.AutoSize = true;
            this.rd_ManageMedicine_PlotInActiveMedicine.Location = new System.Drawing.Point(255, 13);
            this.rd_ManageMedicine_PlotInActiveMedicine.Name = "rd_ManageMedicine_PlotInActiveMedicine";
            this.rd_ManageMedicine_PlotInActiveMedicine.Size = new System.Drawing.Size(145, 17);
            this.rd_ManageMedicine_PlotInActiveMedicine.TabIndex = 2;
            this.rd_ManageMedicine_PlotInActiveMedicine.TabStop = true;
            this.rd_ManageMedicine_PlotInActiveMedicine.Text = "In-Active Medicine Graph";
            this.rd_ManageMedicine_PlotInActiveMedicine.UseVisualStyleBackColor = true;
            this.rd_ManageMedicine_PlotInActiveMedicine.CheckedChanged += new System.EventHandler(this.rd_ManageMedicine_PlotInActiveMedicine_CheckedChanged);
            // 
            // rd_ManageMedicine_PlotActiveMedicine
            // 
            this.rd_ManageMedicine_PlotActiveMedicine.AutoSize = true;
            this.rd_ManageMedicine_PlotActiveMedicine.Location = new System.Drawing.Point(117, 13);
            this.rd_ManageMedicine_PlotActiveMedicine.Name = "rd_ManageMedicine_PlotActiveMedicine";
            this.rd_ManageMedicine_PlotActiveMedicine.Size = new System.Drawing.Size(133, 17);
            this.rd_ManageMedicine_PlotActiveMedicine.TabIndex = 1;
            this.rd_ManageMedicine_PlotActiveMedicine.TabStop = true;
            this.rd_ManageMedicine_PlotActiveMedicine.Text = "Active Medicine Graph";
            this.rd_ManageMedicine_PlotActiveMedicine.UseVisualStyleBackColor = true;
            this.rd_ManageMedicine_PlotActiveMedicine.CheckedChanged += new System.EventHandler(this.rd_ManageMedicine_PlotActiveMedicine_CheckedChanged);
            // 
            // chrt_Medicine_Stock
            // 
            this.chrt_Medicine_Stock.Location = new System.Drawing.Point(3, 41);
            this.chrt_Medicine_Stock.Name = "chrt_Medicine_Stock";
            this.chrt_Medicine_Stock.Size = new System.Drawing.Size(499, 465);
            this.chrt_Medicine_Stock.TabIndex = 0;
            this.chrt_Medicine_Stock.Text = "chart1";
            // 
            // tb_Page_Settings_Manage_Keys
            // 
            this.tb_Page_Settings_Manage_Keys.Controls.Add(this.sp_Cont_Manage_Kyes_Data);
            this.tb_Page_Settings_Manage_Keys.Location = new System.Drawing.Point(4, 22);
            this.tb_Page_Settings_Manage_Keys.Name = "tb_Page_Settings_Manage_Keys";
            this.tb_Page_Settings_Manage_Keys.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Page_Settings_Manage_Keys.Size = new System.Drawing.Size(861, 515);
            this.tb_Page_Settings_Manage_Keys.TabIndex = 3;
            this.tb_Page_Settings_Manage_Keys.Text = "Manage Keys";
            this.tb_Page_Settings_Manage_Keys.UseVisualStyleBackColor = true;
            this.tb_Page_Settings_Manage_Keys.Enter += new System.EventHandler(this.tb_Page_Settings_Manage_Keys_Enter);
            // 
            // sp_Cont_Manage_Kyes_Data
            // 
            this.sp_Cont_Manage_Kyes_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sp_Cont_Manage_Kyes_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Cont_Manage_Kyes_Data.IsSplitterFixed = true;
            this.sp_Cont_Manage_Kyes_Data.Location = new System.Drawing.Point(3, 3);
            this.sp_Cont_Manage_Kyes_Data.Name = "sp_Cont_Manage_Kyes_Data";
            // 
            // sp_Cont_Manage_Kyes_Data.Panel1
            // 
            this.sp_Cont_Manage_Kyes_Data.Panel1.Controls.Add(this.sp_Cont_Manage_Keys_Add_And_Update);
            this.sp_Cont_Manage_Kyes_Data.Size = new System.Drawing.Size(855, 509);
            this.sp_Cont_Manage_Kyes_Data.SplitterDistance = 348;
            this.sp_Cont_Manage_Kyes_Data.TabIndex = 0;
            // 
            // sp_Cont_Manage_Keys_Add_And_Update
            // 
            this.sp_Cont_Manage_Keys_Add_And_Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sp_Cont_Manage_Keys_Add_And_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Cont_Manage_Keys_Add_And_Update.IsSplitterFixed = true;
            this.sp_Cont_Manage_Keys_Add_And_Update.Location = new System.Drawing.Point(0, 0);
            this.sp_Cont_Manage_Keys_Add_And_Update.Name = "sp_Cont_Manage_Keys_Add_And_Update";
            this.sp_Cont_Manage_Keys_Add_And_Update.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sp_Cont_Manage_Keys_Add_And_Update.Panel1
            // 
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.Controls.Add(this.lbl_ManageKeys_InsertKeys_InsertKeysKeyNo);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.Controls.Add(this.lbl_ManageKeys_InsertKeys_Select_Floor);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.Controls.Add(this.lbl_ExistingPedistal);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.Controls.Add(this.tbox_ManageKeys_InsertKeysPedistalNo);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.Controls.Add(this.nemUD_ManageKeys_InsertKeys);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.Controls.Add(this.lbl_ManageKeys_InsertKeysPedistalNo);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.Controls.Add(this.btn_ManageKeys_Insert_Reset);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.Controls.Add(this.btn_ManageKeys_Add);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.Controls.Add(this.cbox_ManageKeys_InsertKeysWhichFloor);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.Controls.Add(this.lbl_ManageKeys_InsertKeysWhichFloor);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.Controls.Add(this.lbl_ManageKeys_InsertKeysNoOfKeys);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.Controls.Add(this.tbox_ManageKeys_InsertKeysKeyNo);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.Controls.Add(this.lbl_InsertKeys);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.Controls.Add(this.lbl_ManageKeys_InsertKeysKeyNo);
            // 
            // sp_Cont_Manage_Keys_Add_And_Update.Panel2
            // 
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.label1);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.rdBtn_PedistalInActive);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.rdBtn_PedistalActive);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.lbl_ManageKeys_UpdateKeys_Select_Floor);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.tbox_ManageKeys_UpdateKeysKeyNo);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.lbl_ManageKeys_UpdateKeysKeyNo);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.nemUD_ManageKeys_UpdateKeys);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.btn_ManageKeys_Update_Reset);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.btn_ManageKeys_Update);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.btn_ManageKeys_Search_By_PedistalNo);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.cbox_ManageKeys_UpdateKeysWhichFloor);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.lbl_ManageKeys_UpdateKeysWhichFloor);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.lbl_ManageKeys_UpdateKeysPedistalNo);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.lbl_ManageKeys_UpdateKeysNoOfKeys);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.tbox_ManageKeys_UpdateKeysPedistalNo);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.Controls.Add(this.lbl_UpdateKeys);
            this.sp_Cont_Manage_Keys_Add_And_Update.Size = new System.Drawing.Size(348, 509);
            this.sp_Cont_Manage_Keys_Add_And_Update.SplitterDistance = 242;
            this.sp_Cont_Manage_Keys_Add_And_Update.TabIndex = 0;
            // 
            // lbl_ManageKeys_InsertKeys_InsertKeysKeyNo
            // 
            this.lbl_ManageKeys_InsertKeys_InsertKeysKeyNo.AutoSize = true;
            this.lbl_ManageKeys_InsertKeys_InsertKeysKeyNo.ForeColor = System.Drawing.Color.Red;
            this.lbl_ManageKeys_InsertKeys_InsertKeysKeyNo.Location = new System.Drawing.Point(124, 101);
            this.lbl_ManageKeys_InsertKeys_InsertKeysKeyNo.Name = "lbl_ManageKeys_InsertKeys_InsertKeysKeyNo";
            this.lbl_ManageKeys_InsertKeys_InsertKeysKeyNo.Size = new System.Drawing.Size(19, 13);
            this.lbl_ManageKeys_InsertKeys_InsertKeysKeyNo.TabIndex = 24;
            this.lbl_ManageKeys_InsertKeys_InsertKeysKeyNo.Text = "kk";
            // 
            // lbl_ManageKeys_InsertKeys_Select_Floor
            // 
            this.lbl_ManageKeys_InsertKeys_Select_Floor.AutoSize = true;
            this.lbl_ManageKeys_InsertKeys_Select_Floor.ForeColor = System.Drawing.Color.Red;
            this.lbl_ManageKeys_InsertKeys_Select_Floor.Location = new System.Drawing.Point(124, 174);
            this.lbl_ManageKeys_InsertKeys_Select_Floor.Name = "lbl_ManageKeys_InsertKeys_Select_Floor";
            this.lbl_ManageKeys_InsertKeys_Select_Floor.Size = new System.Drawing.Size(0, 13);
            this.lbl_ManageKeys_InsertKeys_Select_Floor.TabIndex = 23;
            // 
            // lbl_ExistingPedistal
            // 
            this.lbl_ExistingPedistal.AutoSize = true;
            this.lbl_ExistingPedistal.ForeColor = System.Drawing.Color.Red;
            this.lbl_ExistingPedistal.Location = new System.Drawing.Point(121, 25);
            this.lbl_ExistingPedistal.Name = "lbl_ExistingPedistal";
            this.lbl_ExistingPedistal.Size = new System.Drawing.Size(0, 13);
            this.lbl_ExistingPedistal.TabIndex = 22;
            // 
            // tbox_ManageKeys_InsertKeysPedistalNo
            // 
            this.tbox_ManageKeys_InsertKeysPedistalNo.Location = new System.Drawing.Point(122, 41);
            this.tbox_ManageKeys_InsertKeysPedistalNo.Name = "tbox_ManageKeys_InsertKeysPedistalNo";
            this.tbox_ManageKeys_InsertKeysPedistalNo.Size = new System.Drawing.Size(204, 20);
            this.tbox_ManageKeys_InsertKeysPedistalNo.TabIndex = 1;
            // 
            // nemUD_ManageKeys_InsertKeys
            // 
            this.nemUD_ManageKeys_InsertKeys.Location = new System.Drawing.Point(123, 116);
            this.nemUD_ManageKeys_InsertKeys.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nemUD_ManageKeys_InsertKeys.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nemUD_ManageKeys_InsertKeys.Name = "nemUD_ManageKeys_InsertKeys";
            this.nemUD_ManageKeys_InsertKeys.Size = new System.Drawing.Size(204, 20);
            this.nemUD_ManageKeys_InsertKeys.TabIndex = 3;
            this.nemUD_ManageKeys_InsertKeys.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_ManageKeys_InsertKeysPedistalNo
            // 
            this.lbl_ManageKeys_InsertKeysPedistalNo.AutoSize = true;
            this.lbl_ManageKeys_InsertKeysPedistalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageKeys_InsertKeysPedistalNo.Location = new System.Drawing.Point(36, 44);
            this.lbl_ManageKeys_InsertKeysPedistalNo.Name = "lbl_ManageKeys_InsertKeysPedistalNo";
            this.lbl_ManageKeys_InsertKeysPedistalNo.Size = new System.Drawing.Size(80, 13);
            this.lbl_ManageKeys_InsertKeysPedistalNo.TabIndex = 13;
            this.lbl_ManageKeys_InsertKeysPedistalNo.Text = "Pedistal No :";
            // 
            // btn_ManageKeys_Insert_Reset
            // 
            this.btn_ManageKeys_Insert_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageKeys_Insert_Reset.Location = new System.Drawing.Point(240, 188);
            this.btn_ManageKeys_Insert_Reset.Name = "btn_ManageKeys_Insert_Reset";
            this.btn_ManageKeys_Insert_Reset.Size = new System.Drawing.Size(87, 38);
            this.btn_ManageKeys_Insert_Reset.TabIndex = 6;
            this.btn_ManageKeys_Insert_Reset.Text = "Reset";
            this.btn_ManageKeys_Insert_Reset.UseVisualStyleBackColor = true;
            this.btn_ManageKeys_Insert_Reset.Click += new System.EventHandler(this.btn_ManageKeys_Insert_Reset_Click);
            // 
            // btn_ManageKeys_Add
            // 
            this.btn_ManageKeys_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageKeys_Add.Location = new System.Drawing.Point(147, 188);
            this.btn_ManageKeys_Add.Name = "btn_ManageKeys_Add";
            this.btn_ManageKeys_Add.Size = new System.Drawing.Size(87, 38);
            this.btn_ManageKeys_Add.TabIndex = 5;
            this.btn_ManageKeys_Add.Text = "Insert";
            this.btn_ManageKeys_Add.UseVisualStyleBackColor = true;
            this.btn_ManageKeys_Add.Click += new System.EventHandler(this.btn_ManageKeys_Add_Click);
            // 
            // cbox_ManageKeys_InsertKeysWhichFloor
            // 
            this.cbox_ManageKeys_InsertKeysWhichFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ManageKeys_InsertKeysWhichFloor.FormattingEnabled = true;
            this.cbox_ManageKeys_InsertKeysWhichFloor.Items.AddRange(new object[] {
            "--------------------Select--------------------",
            "Floor - G",
            "Floor - 1",
            "Floor - 2",
            "Floor - 3",
            "Floor - 4",
            "Floor - 5",
            "Floor - 6",
            "Floor - 7",
            "Floor - 8",
            "Floor - 9"});
            this.cbox_ManageKeys_InsertKeysWhichFloor.Location = new System.Drawing.Point(123, 150);
            this.cbox_ManageKeys_InsertKeysWhichFloor.Name = "cbox_ManageKeys_InsertKeysWhichFloor";
            this.cbox_ManageKeys_InsertKeysWhichFloor.Size = new System.Drawing.Size(204, 21);
            this.cbox_ManageKeys_InsertKeysWhichFloor.TabIndex = 4;
            // 
            // lbl_ManageKeys_InsertKeysWhichFloor
            // 
            this.lbl_ManageKeys_InsertKeysWhichFloor.AutoSize = true;
            this.lbl_ManageKeys_InsertKeysWhichFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageKeys_InsertKeysWhichFloor.Location = new System.Drawing.Point(52, 153);
            this.lbl_ManageKeys_InsertKeysWhichFloor.Name = "lbl_ManageKeys_InsertKeysWhichFloor";
            this.lbl_ManageKeys_InsertKeysWhichFloor.Size = new System.Drawing.Size(64, 13);
            this.lbl_ManageKeys_InsertKeysWhichFloor.TabIndex = 17;
            this.lbl_ManageKeys_InsertKeysWhichFloor.Text = "Location :";
            // 
            // lbl_ManageKeys_InsertKeysNoOfKeys
            // 
            this.lbl_ManageKeys_InsertKeysNoOfKeys.AutoSize = true;
            this.lbl_ManageKeys_InsertKeysNoOfKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageKeys_InsertKeysNoOfKeys.Location = new System.Drawing.Point(37, 118);
            this.lbl_ManageKeys_InsertKeysNoOfKeys.Name = "lbl_ManageKeys_InsertKeysNoOfKeys";
            this.lbl_ManageKeys_InsertKeysNoOfKeys.Size = new System.Drawing.Size(79, 13);
            this.lbl_ManageKeys_InsertKeysNoOfKeys.TabIndex = 15;
            this.lbl_ManageKeys_InsertKeysNoOfKeys.Text = "No Of Keys :";
            // 
            // tbox_ManageKeys_InsertKeysKeyNo
            // 
            this.tbox_ManageKeys_InsertKeysKeyNo.Location = new System.Drawing.Point(122, 78);
            this.tbox_ManageKeys_InsertKeysKeyNo.Name = "tbox_ManageKeys_InsertKeysKeyNo";
            this.tbox_ManageKeys_InsertKeysKeyNo.Size = new System.Drawing.Size(204, 20);
            this.tbox_ManageKeys_InsertKeysKeyNo.TabIndex = 2;
            // 
            // lbl_InsertKeys
            // 
            this.lbl_InsertKeys.AutoSize = true;
            this.lbl_InsertKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertKeys.ForeColor = System.Drawing.Color.Blue;
            this.lbl_InsertKeys.Location = new System.Drawing.Point(-1, 0);
            this.lbl_InsertKeys.Name = "lbl_InsertKeys";
            this.lbl_InsertKeys.Size = new System.Drawing.Size(198, 25);
            this.lbl_InsertKeys.TabIndex = 11;
            this.lbl_InsertKeys.Text = "Insert Key Details";
            // 
            // lbl_ManageKeys_InsertKeysKeyNo
            // 
            this.lbl_ManageKeys_InsertKeysKeyNo.AutoSize = true;
            this.lbl_ManageKeys_InsertKeysKeyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageKeys_InsertKeysKeyNo.Location = new System.Drawing.Point(60, 81);
            this.lbl_ManageKeys_InsertKeysKeyNo.Name = "lbl_ManageKeys_InsertKeysKeyNo";
            this.lbl_ManageKeys_InsertKeysKeyNo.Size = new System.Drawing.Size(56, 13);
            this.lbl_ManageKeys_InsertKeysKeyNo.TabIndex = 0;
            this.lbl_ManageKeys_InsertKeysKeyNo.Text = "Key No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(124, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "kk";
            // 
            // rdBtn_PedistalInActive
            // 
            this.rdBtn_PedistalInActive.AutoSize = true;
            this.rdBtn_PedistalInActive.Enabled = false;
            this.rdBtn_PedistalInActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_PedistalInActive.Location = new System.Drawing.Point(183, 183);
            this.rdBtn_PedistalInActive.Name = "rdBtn_PedistalInActive";
            this.rdBtn_PedistalInActive.Size = new System.Drawing.Size(76, 17);
            this.rdBtn_PedistalInActive.TabIndex = 36;
            this.rdBtn_PedistalInActive.TabStop = true;
            this.rdBtn_PedistalInActive.Text = "In-Active";
            this.rdBtn_PedistalInActive.UseVisualStyleBackColor = true;
            // 
            // rdBtn_PedistalActive
            // 
            this.rdBtn_PedistalActive.AutoSize = true;
            this.rdBtn_PedistalActive.Enabled = false;
            this.rdBtn_PedistalActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_PedistalActive.Location = new System.Drawing.Point(122, 183);
            this.rdBtn_PedistalActive.Name = "rdBtn_PedistalActive";
            this.rdBtn_PedistalActive.Size = new System.Drawing.Size(61, 17);
            this.rdBtn_PedistalActive.TabIndex = 35;
            this.rdBtn_PedistalActive.TabStop = true;
            this.rdBtn_PedistalActive.Text = "Active";
            this.rdBtn_PedistalActive.UseVisualStyleBackColor = true;
            // 
            // lbl_ManageKeys_UpdateKeys_Select_Floor
            // 
            this.lbl_ManageKeys_UpdateKeys_Select_Floor.AutoSize = true;
            this.lbl_ManageKeys_UpdateKeys_Select_Floor.ForeColor = System.Drawing.Color.Red;
            this.lbl_ManageKeys_UpdateKeys_Select_Floor.Location = new System.Drawing.Point(124, 135);
            this.lbl_ManageKeys_UpdateKeys_Select_Floor.Name = "lbl_ManageKeys_UpdateKeys_Select_Floor";
            this.lbl_ManageKeys_UpdateKeys_Select_Floor.Size = new System.Drawing.Size(19, 13);
            this.lbl_ManageKeys_UpdateKeys_Select_Floor.TabIndex = 34;
            this.lbl_ManageKeys_UpdateKeys_Select_Floor.Text = "kk";
            // 
            // tbox_ManageKeys_UpdateKeysKeyNo
            // 
            this.tbox_ManageKeys_UpdateKeysKeyNo.Enabled = false;
            this.tbox_ManageKeys_UpdateKeysKeyNo.Location = new System.Drawing.Point(122, 78);
            this.tbox_ManageKeys_UpdateKeysKeyNo.Name = "tbox_ManageKeys_UpdateKeysKeyNo";
            this.tbox_ManageKeys_UpdateKeysKeyNo.Size = new System.Drawing.Size(204, 20);
            this.tbox_ManageKeys_UpdateKeysKeyNo.TabIndex = 9;
            // 
            // lbl_ManageKeys_UpdateKeysKeyNo
            // 
            this.lbl_ManageKeys_UpdateKeysKeyNo.AutoSize = true;
            this.lbl_ManageKeys_UpdateKeysKeyNo.Enabled = false;
            this.lbl_ManageKeys_UpdateKeysKeyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageKeys_UpdateKeysKeyNo.Location = new System.Drawing.Point(60, 81);
            this.lbl_ManageKeys_UpdateKeysKeyNo.Name = "lbl_ManageKeys_UpdateKeysKeyNo";
            this.lbl_ManageKeys_UpdateKeysKeyNo.Size = new System.Drawing.Size(56, 13);
            this.lbl_ManageKeys_UpdateKeysKeyNo.TabIndex = 22;
            this.lbl_ManageKeys_UpdateKeysKeyNo.Text = "Key No :";
            // 
            // nemUD_ManageKeys_UpdateKeys
            // 
            this.nemUD_ManageKeys_UpdateKeys.Enabled = false;
            this.nemUD_ManageKeys_UpdateKeys.Location = new System.Drawing.Point(123, 112);
            this.nemUD_ManageKeys_UpdateKeys.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nemUD_ManageKeys_UpdateKeys.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nemUD_ManageKeys_UpdateKeys.Name = "nemUD_ManageKeys_UpdateKeys";
            this.nemUD_ManageKeys_UpdateKeys.Size = new System.Drawing.Size(204, 20);
            this.nemUD_ManageKeys_UpdateKeys.TabIndex = 10;
            this.nemUD_ManageKeys_UpdateKeys.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_ManageKeys_Update_Reset
            // 
            this.btn_ManageKeys_Update_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageKeys_Update_Reset.Location = new System.Drawing.Point(240, 207);
            this.btn_ManageKeys_Update_Reset.Name = "btn_ManageKeys_Update_Reset";
            this.btn_ManageKeys_Update_Reset.Size = new System.Drawing.Size(87, 38);
            this.btn_ManageKeys_Update_Reset.TabIndex = 13;
            this.btn_ManageKeys_Update_Reset.Text = "Reset";
            this.btn_ManageKeys_Update_Reset.UseVisualStyleBackColor = true;
            this.btn_ManageKeys_Update_Reset.Click += new System.EventHandler(this.btn_ManageKeys_Update_Reset_Click);
            // 
            // btn_ManageKeys_Update
            // 
            this.btn_ManageKeys_Update.Enabled = false;
            this.btn_ManageKeys_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageKeys_Update.Location = new System.Drawing.Point(146, 207);
            this.btn_ManageKeys_Update.Name = "btn_ManageKeys_Update";
            this.btn_ManageKeys_Update.Size = new System.Drawing.Size(87, 38);
            this.btn_ManageKeys_Update.TabIndex = 12;
            this.btn_ManageKeys_Update.Text = "Update";
            this.btn_ManageKeys_Update.UseVisualStyleBackColor = true;
            this.btn_ManageKeys_Update.Click += new System.EventHandler(this.btn_ManageKeys_Update_Click);
            // 
            // btn_ManageKeys_Search_By_PedistalNo
            // 
            this.btn_ManageKeys_Search_By_PedistalNo.Enabled = false;
            this.btn_ManageKeys_Search_By_PedistalNo.Location = new System.Drawing.Point(270, 34);
            this.btn_ManageKeys_Search_By_PedistalNo.Name = "btn_ManageKeys_Search_By_PedistalNo";
            this.btn_ManageKeys_Search_By_PedistalNo.Size = new System.Drawing.Size(57, 20);
            this.btn_ManageKeys_Search_By_PedistalNo.TabIndex = 8;
            this.btn_ManageKeys_Search_By_PedistalNo.Text = "Search";
            this.btn_ManageKeys_Search_By_PedistalNo.UseVisualStyleBackColor = true;
            this.btn_ManageKeys_Search_By_PedistalNo.Click += new System.EventHandler(this.btn_ManageKeys_Search_By_PedistalNo_Click);
            // 
            // cbox_ManageKeys_UpdateKeysWhichFloor
            // 
            this.cbox_ManageKeys_UpdateKeysWhichFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ManageKeys_UpdateKeysWhichFloor.Enabled = false;
            this.cbox_ManageKeys_UpdateKeysWhichFloor.FormattingEnabled = true;
            this.cbox_ManageKeys_UpdateKeysWhichFloor.Items.AddRange(new object[] {
            "--------------------Select--------------------",
            "Floor - G",
            "Floor - 1",
            "Floor - 2",
            "Floor - 3",
            "Floor - 4",
            "Floor - 5",
            "Floor - 6",
            "Floor - 7",
            "Floor - 8",
            "Floor - 9"});
            this.cbox_ManageKeys_UpdateKeysWhichFloor.Location = new System.Drawing.Point(123, 152);
            this.cbox_ManageKeys_UpdateKeysWhichFloor.Name = "cbox_ManageKeys_UpdateKeysWhichFloor";
            this.cbox_ManageKeys_UpdateKeysWhichFloor.Size = new System.Drawing.Size(204, 21);
            this.cbox_ManageKeys_UpdateKeysWhichFloor.TabIndex = 11;
            // 
            // lbl_ManageKeys_UpdateKeysWhichFloor
            // 
            this.lbl_ManageKeys_UpdateKeysWhichFloor.AutoSize = true;
            this.lbl_ManageKeys_UpdateKeysWhichFloor.Enabled = false;
            this.lbl_ManageKeys_UpdateKeysWhichFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageKeys_UpdateKeysWhichFloor.Location = new System.Drawing.Point(52, 155);
            this.lbl_ManageKeys_UpdateKeysWhichFloor.Name = "lbl_ManageKeys_UpdateKeysWhichFloor";
            this.lbl_ManageKeys_UpdateKeysWhichFloor.Size = new System.Drawing.Size(64, 13);
            this.lbl_ManageKeys_UpdateKeysWhichFloor.TabIndex = 27;
            this.lbl_ManageKeys_UpdateKeysWhichFloor.Text = "Location :";
            // 
            // lbl_ManageKeys_UpdateKeysPedistalNo
            // 
            this.lbl_ManageKeys_UpdateKeysPedistalNo.AutoSize = true;
            this.lbl_ManageKeys_UpdateKeysPedistalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageKeys_UpdateKeysPedistalNo.Location = new System.Drawing.Point(35, 37);
            this.lbl_ManageKeys_UpdateKeysPedistalNo.Name = "lbl_ManageKeys_UpdateKeysPedistalNo";
            this.lbl_ManageKeys_UpdateKeysPedistalNo.Size = new System.Drawing.Size(80, 13);
            this.lbl_ManageKeys_UpdateKeysPedistalNo.TabIndex = 24;
            this.lbl_ManageKeys_UpdateKeysPedistalNo.Text = "Pedistal No :";
            // 
            // lbl_ManageKeys_UpdateKeysNoOfKeys
            // 
            this.lbl_ManageKeys_UpdateKeysNoOfKeys.AutoSize = true;
            this.lbl_ManageKeys_UpdateKeysNoOfKeys.Enabled = false;
            this.lbl_ManageKeys_UpdateKeysNoOfKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageKeys_UpdateKeysNoOfKeys.Location = new System.Drawing.Point(37, 114);
            this.lbl_ManageKeys_UpdateKeysNoOfKeys.Name = "lbl_ManageKeys_UpdateKeysNoOfKeys";
            this.lbl_ManageKeys_UpdateKeysNoOfKeys.Size = new System.Drawing.Size(79, 13);
            this.lbl_ManageKeys_UpdateKeysNoOfKeys.TabIndex = 26;
            this.lbl_ManageKeys_UpdateKeysNoOfKeys.Text = "No Of Keys :";
            // 
            // tbox_ManageKeys_UpdateKeysPedistalNo
            // 
            this.tbox_ManageKeys_UpdateKeysPedistalNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_ManageKeys_UpdateKeysPedistalNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_ManageKeys_UpdateKeysPedistalNo.Location = new System.Drawing.Point(122, 34);
            this.tbox_ManageKeys_UpdateKeysPedistalNo.Name = "tbox_ManageKeys_UpdateKeysPedistalNo";
            this.tbox_ManageKeys_UpdateKeysPedistalNo.Size = new System.Drawing.Size(141, 20);
            this.tbox_ManageKeys_UpdateKeysPedistalNo.TabIndex = 7;
            this.tbox_ManageKeys_UpdateKeysPedistalNo.EnabledChanged += new System.EventHandler(this.tbox_ManageKeys_UpdateKeysPedistalNo_EnabledChanged);
            this.tbox_ManageKeys_UpdateKeysPedistalNo.TextChanged += new System.EventHandler(this.tbox_ManageKeys_UpdateKeysPedistalNo_TextChanged);
            // 
            // lbl_UpdateKeys
            // 
            this.lbl_UpdateKeys.AutoSize = true;
            this.lbl_UpdateKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UpdateKeys.ForeColor = System.Drawing.Color.Blue;
            this.lbl_UpdateKeys.Location = new System.Drawing.Point(-1, 0);
            this.lbl_UpdateKeys.Name = "lbl_UpdateKeys";
            this.lbl_UpdateKeys.Size = new System.Drawing.Size(214, 25);
            this.lbl_UpdateKeys.TabIndex = 12;
            this.lbl_UpdateKeys.Text = "Update Key Details";
            // 
            // tb_Page_Settings_Manage_Database
            // 
            this.tb_Page_Settings_Manage_Database.Controls.Add(this.lbl_ConnectedDatabase);
            this.tb_Page_Settings_Manage_Database.Controls.Add(this.lbl_BackupStatus);
            this.tb_Page_Settings_Manage_Database.Controls.Add(this.tbox_Log_Find);
            this.tb_Page_Settings_Manage_Database.Controls.Add(this.lbl_Log_Find);
            this.tb_Page_Settings_Manage_Database.Controls.Add(this.lbl_Daily_Log);
            this.tb_Page_Settings_Manage_Database.Controls.Add(this.grpbx_Database_Details);
            this.tb_Page_Settings_Manage_Database.Controls.Add(this.pgBar_Backup_Progress);
            this.tb_Page_Settings_Manage_Database.Controls.Add(this.rtbox_Daily_Log);
            this.tb_Page_Settings_Manage_Database.Controls.Add(this.btn_Change_Admin_Password);
            this.tb_Page_Settings_Manage_Database.Controls.Add(this.btn_Restore_Database);
            this.tb_Page_Settings_Manage_Database.Controls.Add(this.btn_Backup_Database);
            this.tb_Page_Settings_Manage_Database.Controls.Add(this.btn_Repoint_Database);
            this.tb_Page_Settings_Manage_Database.Location = new System.Drawing.Point(4, 22);
            this.tb_Page_Settings_Manage_Database.Name = "tb_Page_Settings_Manage_Database";
            this.tb_Page_Settings_Manage_Database.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Page_Settings_Manage_Database.Size = new System.Drawing.Size(861, 515);
            this.tb_Page_Settings_Manage_Database.TabIndex = 1;
            this.tb_Page_Settings_Manage_Database.Text = "Manage Database And Password";
            this.tb_Page_Settings_Manage_Database.UseVisualStyleBackColor = true;
            this.tb_Page_Settings_Manage_Database.Enter += new System.EventHandler(this.tb_Page_Settings_Manage_Database_Enter);
            // 
            // lbl_ConnectedDatabase
            // 
            this.lbl_ConnectedDatabase.AutoSize = true;
            this.lbl_ConnectedDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConnectedDatabase.Location = new System.Drawing.Point(6, 117);
            this.lbl_ConnectedDatabase.Name = "lbl_ConnectedDatabase";
            this.lbl_ConnectedDatabase.Size = new System.Drawing.Size(220, 18);
            this.lbl_ConnectedDatabase.TabIndex = 11;
            this.lbl_ConnectedDatabase.Text = "Connected Database Location : ";
            // 
            // lbl_BackupStatus
            // 
            this.lbl_BackupStatus.AutoSize = true;
            this.lbl_BackupStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BackupStatus.Location = new System.Drawing.Point(6, 93);
            this.lbl_BackupStatus.Name = "lbl_BackupStatus";
            this.lbl_BackupStatus.Size = new System.Drawing.Size(0, 15);
            this.lbl_BackupStatus.TabIndex = 10;
            // 
            // tbox_Log_Find
            // 
            this.tbox_Log_Find.Location = new System.Drawing.Point(487, 157);
            this.tbox_Log_Find.Name = "tbox_Log_Find";
            this.tbox_Log_Find.Size = new System.Drawing.Size(365, 20);
            this.tbox_Log_Find.TabIndex = 9;
            // 
            // lbl_Log_Find
            // 
            this.lbl_Log_Find.AutoSize = true;
            this.lbl_Log_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Log_Find.Location = new System.Drawing.Point(441, 158);
            this.lbl_Log_Find.Name = "lbl_Log_Find";
            this.lbl_Log_Find.Size = new System.Drawing.Size(40, 15);
            this.lbl_Log_Find.TabIndex = 8;
            this.lbl_Log_Find.Text = "Find : ";
            // 
            // lbl_Daily_Log
            // 
            this.lbl_Daily_Log.AutoSize = true;
            this.lbl_Daily_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Daily_Log.Location = new System.Drawing.Point(3, 156);
            this.lbl_Daily_Log.Name = "lbl_Daily_Log";
            this.lbl_Daily_Log.Size = new System.Drawing.Size(81, 18);
            this.lbl_Daily_Log.TabIndex = 7;
            this.lbl_Daily_Log.Text = "Daily Log : ";
            // 
            // grpbx_Database_Details
            // 
            this.grpbx_Database_Details.Controls.Add(this.lbl_DatabaseSize);
            this.grpbx_Database_Details.Controls.Add(this.lbl_Database_Last_BackedUp_On);
            this.grpbx_Database_Details.Controls.Add(this.pgBar_Database_Size);
            this.grpbx_Database_Details.Controls.Add(this.lbl_Database_Size);
            this.grpbx_Database_Details.Location = new System.Drawing.Point(489, 6);
            this.grpbx_Database_Details.Name = "grpbx_Database_Details";
            this.grpbx_Database_Details.Size = new System.Drawing.Size(363, 92);
            this.grpbx_Database_Details.TabIndex = 6;
            this.grpbx_Database_Details.TabStop = false;
            this.grpbx_Database_Details.Text = "Database Backup Details";
            // 
            // lbl_DatabaseSize
            // 
            this.lbl_DatabaseSize.AutoSize = true;
            this.lbl_DatabaseSize.Location = new System.Drawing.Point(133, 44);
            this.lbl_DatabaseSize.Name = "lbl_DatabaseSize";
            this.lbl_DatabaseSize.Size = new System.Drawing.Size(0, 13);
            this.lbl_DatabaseSize.TabIndex = 3;
            // 
            // lbl_Database_Last_BackedUp_On
            // 
            this.lbl_Database_Last_BackedUp_On.AutoSize = true;
            this.lbl_Database_Last_BackedUp_On.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Database_Last_BackedUp_On.Location = new System.Drawing.Point(6, 66);
            this.lbl_Database_Last_BackedUp_On.Name = "lbl_Database_Last_BackedUp_On";
            this.lbl_Database_Last_BackedUp_On.Size = new System.Drawing.Size(149, 16);
            this.lbl_Database_Last_BackedUp_On.TabIndex = 2;
            this.lbl_Database_Last_BackedUp_On.Text = "Last BackedUp On : ";
            // 
            // pgBar_Database_Size
            // 
            this.pgBar_Database_Size.Location = new System.Drawing.Point(130, 18);
            this.pgBar_Database_Size.Name = "pgBar_Database_Size";
            this.pgBar_Database_Size.Size = new System.Drawing.Size(227, 23);
            this.pgBar_Database_Size.TabIndex = 1;
            // 
            // lbl_Database_Size
            // 
            this.lbl_Database_Size.AutoSize = true;
            this.lbl_Database_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Database_Size.Location = new System.Drawing.Point(6, 23);
            this.lbl_Database_Size.Name = "lbl_Database_Size";
            this.lbl_Database_Size.Size = new System.Drawing.Size(122, 16);
            this.lbl_Database_Size.TabIndex = 0;
            this.lbl_Database_Size.Text = "Database Size : ";
            // 
            // pgBar_Backup_Progress
            // 
            this.pgBar_Backup_Progress.Location = new System.Drawing.Point(6, 75);
            this.pgBar_Backup_Progress.Name = "pgBar_Backup_Progress";
            this.pgBar_Backup_Progress.Size = new System.Drawing.Size(465, 15);
            this.pgBar_Backup_Progress.TabIndex = 5;
            // 
            // rtbox_Daily_Log
            // 
            this.rtbox_Daily_Log.Location = new System.Drawing.Point(6, 177);
            this.rtbox_Daily_Log.Name = "rtbox_Daily_Log";
            this.rtbox_Daily_Log.Size = new System.Drawing.Size(846, 332);
            this.rtbox_Daily_Log.TabIndex = 4;
            this.rtbox_Daily_Log.Text = "";
            // 
            // btn_Change_Admin_Password
            // 
            this.btn_Change_Admin_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change_Admin_Password.Location = new System.Drawing.Point(360, 6);
            this.btn_Change_Admin_Password.Name = "btn_Change_Admin_Password";
            this.btn_Change_Admin_Password.Size = new System.Drawing.Size(111, 63);
            this.btn_Change_Admin_Password.TabIndex = 3;
            this.btn_Change_Admin_Password.Text = "Change Admin Login Details";
            this.btn_Change_Admin_Password.UseVisualStyleBackColor = true;
            this.btn_Change_Admin_Password.Click += new System.EventHandler(this.btn_Change_Admin_Password_Click);
            // 
            // btn_Restore_Database
            // 
            this.btn_Restore_Database.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Restore_Database.Location = new System.Drawing.Point(243, 6);
            this.btn_Restore_Database.Name = "btn_Restore_Database";
            this.btn_Restore_Database.Size = new System.Drawing.Size(111, 63);
            this.btn_Restore_Database.TabIndex = 2;
            this.btn_Restore_Database.Text = "Restore Database";
            this.btn_Restore_Database.UseVisualStyleBackColor = true;
            this.btn_Restore_Database.Click += new System.EventHandler(this.btn_Restore_Database_Click);
            // 
            // btn_Backup_Database
            // 
            this.btn_Backup_Database.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Backup_Database.Location = new System.Drawing.Point(123, 6);
            this.btn_Backup_Database.Name = "btn_Backup_Database";
            this.btn_Backup_Database.Size = new System.Drawing.Size(111, 63);
            this.btn_Backup_Database.TabIndex = 1;
            this.btn_Backup_Database.Text = "Backup Database";
            this.btn_Backup_Database.UseVisualStyleBackColor = true;
            this.btn_Backup_Database.Click += new System.EventHandler(this.btn_Backup_Database_Click);
            // 
            // btn_Repoint_Database
            // 
            this.btn_Repoint_Database.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Repoint_Database.Location = new System.Drawing.Point(6, 6);
            this.btn_Repoint_Database.Name = "btn_Repoint_Database";
            this.btn_Repoint_Database.Size = new System.Drawing.Size(111, 63);
            this.btn_Repoint_Database.TabIndex = 0;
            this.btn_Repoint_Database.Text = "Repoint Database";
            this.btn_Repoint_Database.UseVisualStyleBackColor = true;
            this.btn_Repoint_Database.Click += new System.EventHandler(this.btn_Repoint_Database_Click);
            // 
            // svFlDlg_SaveReport
            // 
            this.svFlDlg_SaveReport.FileOk += new System.ComponentModel.CancelEventHandler(this.svFlDlg_SaveReport_FileOk);
            // 
            // bg_Worker_ImportEmployee
            // 
            this.bg_Worker_ImportEmployee.WorkerReportsProgress = true;
            this.bg_Worker_ImportEmployee.WorkerSupportsCancellation = true;
            this.bg_Worker_ImportEmployee.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_Worker_ImportEmployee_DoWork);
            // 
            // bg_Worker_BackupDatabase
            // 
            this.bg_Worker_BackupDatabase.WorkerReportsProgress = true;
            this.bg_Worker_BackupDatabase.WorkerSupportsCancellation = true;
            this.bg_Worker_BackupDatabase.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_Worker_BackupDatabase_DoWork);
            this.bg_Worker_BackupDatabase.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bg_Worker_BackupDatabase_ProgressChanged);
            this.bg_Worker_BackupDatabase.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bg_Worker_BackupDatabase_RunWorkerCompleted);
            // 
            // bg_Worker_RestoreDatabase
            // 
            this.bg_Worker_RestoreDatabase.WorkerReportsProgress = true;
            this.bg_Worker_RestoreDatabase.WorkerSupportsCancellation = true;
            this.bg_Worker_RestoreDatabase.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_Worker_RestoreDatabase_DoWork);
            this.bg_Worker_RestoreDatabase.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bg_Worker_RestoreDatabase_ProgressChanged);
            this.bg_Worker_RestoreDatabase.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bg_Worker_RestoreDatabase_RunWorkerCompleted);
            // 
            // lbl_medNameChecker
            // 
            this.lbl_medNameChecker.AutoSize = true;
            this.lbl_medNameChecker.ForeColor = System.Drawing.Color.Red;
            this.lbl_medNameChecker.Location = new System.Drawing.Point(135, 33);
            this.lbl_medNameChecker.Name = "lbl_medNameChecker";
            this.lbl_medNameChecker.Size = new System.Drawing.Size(0, 13);
            this.lbl_medNameChecker.TabIndex = 22;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 630);
            this.Controls.Add(this.tbCtrl_Asset_Manager);
            this.Controls.Add(this.sts_Strip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Manager";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.sts_Strip.ResumeLayout(false);
            this.sts_Strip.PerformLayout();
            this.tbCtrl_Asset_Manager.ResumeLayout(false);
            this.tb_Page_VisitorDetails.ResumeLayout(false);
            this.tbCtrl_Visitor_Details.ResumeLayout(false);
            this.tb_Page_VisitorDetails_InDetails.ResumeLayout(false);
            this.grpBx_InTimeSigneture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Signeture)).EndInit();
            this.grpBx_InTimeImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Image)).EndInit();
            this.grpBx_InTimeThingsAndIdentityDetails.ResumeLayout(false);
            this.grpBx_InTimeThingsAndIdentityDetails.PerformLayout();
            this.grpBx_InTimeDetails.ResumeLayout(false);
            this.grpBx_InTimeDetails.PerformLayout();
            this.tb_Page_VisitorDetails_OutDetails.ResumeLayout(false);
            this.grpBx_OutTimeSigneture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Out_Signeture)).EndInit();
            this.grpBx_OutTimeImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Out_Image)).EndInit();
            this.grpBx_OutTimeThingsAndIdentityDetails.ResumeLayout(false);
            this.grpBx_OutTimeThingsAndIdentityDetails.PerformLayout();
            this.grpBx_OutTimeDetails.ResumeLayout(false);
            this.grpBx_OutTimeDetails.PerformLayout();
            this.tb_Page_InterOffice_Visitor.ResumeLayout(false);
            this.tb_Page_InterOffice_Visitor.PerformLayout();
            this.grpBx_Inter_Office_Return_Details.ResumeLayout(false);
            this.grpBx_Inter_Office_Return_Details.PerformLayout();
            this.grpBx_Inter_Office_Emp_Signeture_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Inter_Office_Signeture)).EndInit();
            this.grpBx_Inter_Office_Emp_Image_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Inter_Office_Image)).EndInit();
            this.grpBx_Inter_Office_Access_Card_Details.ResumeLayout(false);
            this.grpBx_Inter_Office_Access_Card_Details.PerformLayout();
            this.grpBx_Inter_Office_Emp_Details.ResumeLayout(false);
            this.grpBx_Inter_Office_Emp_Details.PerformLayout();
            this.tb_Page_VisitorDetails_Report.ResumeLayout(false);
            this.grpBx_Inter_Office_Report.ResumeLayout(false);
            this.grpBx_QuickReport.ResumeLayout(false);
            this.grpBx_DetailedReport.ResumeLayout(false);
            this.grpBx_DetailedReport.PerformLayout();
            this.tb_Page_KeyDistributionDetails.ResumeLayout(false);
            this.tbCtrl_Key_Details.ResumeLayout(false);
            this.tb_Page_KeyDetails_OneTimeDetails.ResumeLayout(false);
            this.sp_Cont_Key_Distribution.Panel1.ResumeLayout(false);
            this.sp_Cont_Key_Distribution.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_Key_Distribution)).EndInit();
            this.sp_Cont_Key_Distribution.ResumeLayout(false);
            this.sp_Cont_SubTop_Key_Distribution.Panel1.ResumeLayout(false);
            this.sp_Cont_SubTop_Key_Distribution.Panel1.PerformLayout();
            this.sp_Cont_SubTop_Key_Distribution.Panel2.ResumeLayout(false);
            this.sp_Cont_SubTop_Key_Distribution.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_SubTop_Key_Distribution)).EndInit();
            this.sp_Cont_SubTop_Key_Distribution.ResumeLayout(false);
            this.sp_Cont_SubBot_Key_Distribution.Panel1.ResumeLayout(false);
            this.sp_Cont_SubBot_Key_Distribution.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_SubBot_Key_Distribution)).EndInit();
            this.sp_Cont_SubBot_Key_Distribution.ResumeLayout(false);
            this.tb_Page_MedicineDistributionDetails.ResumeLayout(false);
            this.grpBx_Medicine_Distribution_Report.ResumeLayout(false);
            this.grpBx_Medicine_Distribution.ResumeLayout(false);
            this.sp_Cont_Medicine_Distribution.Panel1.ResumeLayout(false);
            this.sp_Cont_Medicine_Distribution.Panel1.PerformLayout();
            this.sp_Cont_Medicine_Distribution.Panel2.ResumeLayout(false);
            this.sp_Cont_Medicine_Distribution.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_Medicine_Distribution)).EndInit();
            this.sp_Cont_Medicine_Distribution.ResumeLayout(false);
            this.grpBx_MedicineSigneture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Medcine_Signeture)).EndInit();
            this.tb_Page_Settings.ResumeLayout(false);
            this.tbCtrl_Settings.ResumeLayout(false);
            this.tb_Page_Settings_Manage_Employee.ResumeLayout(false);
            this.sp_Cont_Manage_Employee.Panel1.ResumeLayout(false);
            this.sp_Cont_Manage_Employee.Panel1.PerformLayout();
            this.sp_Cont_Manage_Employee.Panel2.ResumeLayout(false);
            this.sp_Cont_Manage_Employee.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_Manage_Employee)).EndInit();
            this.sp_Cont_Manage_Employee.ResumeLayout(false);
            this.tb_Page_Settings_Manage_Medicine.ResumeLayout(false);
            this.sp_Cont_Manage_Medicine_Graph.Panel1.ResumeLayout(false);
            this.sp_Cont_Manage_Medicine_Graph.Panel2.ResumeLayout(false);
            this.sp_Cont_Manage_Medicine_Graph.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_Manage_Medicine_Graph)).EndInit();
            this.sp_Cont_Manage_Medicine_Graph.ResumeLayout(false);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel1.ResumeLayout(false);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel1.PerformLayout();
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.ResumeLayout(false);
            this.sp_Cont_Manage_Medicine_Add_And_Update.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_Manage_Medicine_Add_And_Update)).EndInit();
            this.sp_Cont_Manage_Medicine_Add_And_Update.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nemUD_ManageMedicine_InsertWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemUD_ManageMedicine_InsertMedicineStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemUD_ManageMedicine_UpdateWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemUD_ManageMedicine_UpdateMedicineStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Medicine_Stock)).EndInit();
            this.tb_Page_Settings_Manage_Keys.ResumeLayout(false);
            this.sp_Cont_Manage_Kyes_Data.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_Manage_Kyes_Data)).EndInit();
            this.sp_Cont_Manage_Kyes_Data.ResumeLayout(false);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.ResumeLayout(false);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel1.PerformLayout();
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.ResumeLayout(false);
            this.sp_Cont_Manage_Keys_Add_And_Update.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Cont_Manage_Keys_Add_And_Update)).EndInit();
            this.sp_Cont_Manage_Keys_Add_And_Update.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nemUD_ManageKeys_InsertKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemUD_ManageKeys_UpdateKeys)).EndInit();
            this.tb_Page_Settings_Manage_Database.ResumeLayout(false);
            this.tb_Page_Settings_Manage_Database.PerformLayout();
            this.grpbx_Database_Details.ResumeLayout(false);
            this.grpbx_Database_Details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sts_Strip;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Date;
        private System.Windows.Forms.ToolStripStatusLabel lbl_LoggedinUser;
        private System.Windows.Forms.ToolStripStatusLabel lbl_time;
        private System.Windows.Forms.Timer tmr_Asset_Timer;
        private System.Windows.Forms.TabControl tbCtrl_Asset_Manager;
        private System.Windows.Forms.TabPage tb_Page_VisitorDetails;
        private System.Windows.Forms.TabPage tb_Page_KeyDistributionDetails;
        private System.Windows.Forms.TabPage tb_Page_MedicineDistributionDetails;
        private System.Windows.Forms.TabControl tbCtrl_Visitor_Details;
        private System.Windows.Forms.TabPage tb_Page_VisitorDetails_InDetails;
        private System.Windows.Forms.GroupBox grpBx_InTimeSigneture;
        private System.Windows.Forms.PictureBox pBox_Signeture;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox grpBx_InTimeImage;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.Button btn_Webcam;
        private System.Windows.Forms.Button btn_TakeImage;
        private System.Windows.Forms.PictureBox pBox_Image;
        private System.Windows.Forms.GroupBox grpBx_InTimeThingsAndIdentityDetails;
        private System.Windows.Forms.Label lbl_Visitor_In_Identity_Card_Number;
        private System.Windows.Forms.TextBox tbox_In_Id_Proof;
        private System.Windows.Forms.Label lbl_Visitor_In_Device_Carrying;
        private System.Windows.Forms.TextBox tbox_In_Carrying_Laptop;
        private System.Windows.Forms.GroupBox grpBx_InTimeDetails;
        private System.Windows.Forms.ComboBox cBox_Floor_Number;
        private System.Windows.Forms.Label lbl_Visitor_Floor_Number;
        private System.Windows.Forms.TextBox tbox_In_Time;
        private System.Windows.Forms.TextBox tbox_In_Whom_To_Meet;
        private System.Windows.Forms.TextBox tbox_In_Remarks;
        private System.Windows.Forms.TextBox tbox_In_Escort_Name;
        private System.Windows.Forms.TextBox tbox_In_Badge_Number;
        private System.Windows.Forms.TextBox tbox_In_Purpose;
        private System.Windows.Forms.TextBox tbox_In_ContactNumber;
        private System.Windows.Forms.TextBox tbox_In_Address;
        private System.Windows.Forms.TextBox tbox_In_Name;
        private System.Windows.Forms.Label lbl_Visitor_In_Remarks;
        private System.Windows.Forms.Label lbl_Visitor_In_Time;
        private System.Windows.Forms.Label lbl_Visitor_In_Escort_Name;
        private System.Windows.Forms.Label lbl_Visitor_In_Badge_Number;
        private System.Windows.Forms.Label lbl_Visitor_In_Whom_To_Meet;
        private System.Windows.Forms.Label lbl_Visitor_In_Purpose;
        private System.Windows.Forms.Label lbl_Visitor_In_Contact_Number;
        private System.Windows.Forms.Label lbl_Visitor_In_Address;
        private System.Windows.Forms.Label lbl_Visitor_In_Name;
        private System.Windows.Forms.TabPage tb_Page_VisitorDetails_OutDetails;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox grpBx_OutTimeSigneture;
        private System.Windows.Forms.PictureBox pBox_Out_Signeture;
        private System.Windows.Forms.Button btn_Out_Reset;
        private System.Windows.Forms.Button btn_Out_Update;
        private System.Windows.Forms.GroupBox grpBx_OutTimeImage;
        private System.Windows.Forms.PictureBox pBox_Out_Image;
        private System.Windows.Forms.GroupBox grpBx_OutTimeThingsAndIdentityDetails;
        private System.Windows.Forms.Label lbl_Visitor_Out_Identity_Card_Number;
        private System.Windows.Forms.TextBox tbox_Out_Id_Proof;
        private System.Windows.Forms.Label lbl_Visitor_Out_Device_Carrying;
        private System.Windows.Forms.TextBox tbox_Out_Carrying_Laptop;
        private System.Windows.Forms.GroupBox grpBx_OutTimeDetails;
        private System.Windows.Forms.TextBox tbox_Out_Serial_Number;
        private System.Windows.Forms.ComboBox cBox_Out_Floor_Number;
        private System.Windows.Forms.Label lbl_Visitor_Out_Floor_Number;
        private System.Windows.Forms.TextBox tbox_Out_Time;
        private System.Windows.Forms.TextBox tbox_Out_Whom_To_Meet;
        private System.Windows.Forms.TextBox tbox_Out_Remarks;
        private System.Windows.Forms.TextBox tbox_Out_Escort_Name;
        private System.Windows.Forms.TextBox tbox_Out_Badge_Number;
        private System.Windows.Forms.TextBox tbox_Out_Purpose;
        private System.Windows.Forms.TextBox tbox_Out_ContactNumber;
        private System.Windows.Forms.TextBox tbox_Out_Address;
        private System.Windows.Forms.TextBox tbox_Out_Name;
        private System.Windows.Forms.Label lbl_Visitor_Out_Remarks;
        private System.Windows.Forms.Label lbl_Visitor_Out_Time;
        private System.Windows.Forms.Label lbl_Visitor_Out_Escort_Name;
        private System.Windows.Forms.Label lbl_Visitor_Out_Badge_Number;
        private System.Windows.Forms.Label lbl_Visitor_Out_Whom_To_Meet;
        private System.Windows.Forms.Label lbl_Visitor_Out_Purpose;
        private System.Windows.Forms.Label lbl_Visitor_Out_Contact_Number;
        private System.Windows.Forms.Label lbl_Visitor_Out_Address;
        private System.Windows.Forms.Label lbl_Visitor_Out_Name;
        private System.Windows.Forms.TabPage tb_Page_InterOffice_Visitor;
        private System.Windows.Forms.TabPage tb_Page_VisitorDetails_Report;
        private System.Windows.Forms.GroupBox grpBx_QuickReport;
        private System.Windows.Forms.Button btn_Report_Interview_1_Month;
        private System.Windows.Forms.Button btn_Report_Last_7_Days;
        private System.Windows.Forms.Button btn_Report_Today;
        private System.Windows.Forms.GroupBox grpBx_DetailedReport;
        private System.Windows.Forms.DateTimePicker dtPk_Report_OutTime;
        private System.Windows.Forms.DateTimePicker dtPk_Report_InTime;
        private System.Windows.Forms.Label lbl_Visitor_Report_OutTime;
        private System.Windows.Forms.ComboBox cBox_Report_Floor_Number;
        private System.Windows.Forms.Label lbl_Visitor_Report_Floor_Number;
        private System.Windows.Forms.TextBox tbox_Report_Whom_To_Meet;
        private System.Windows.Forms.TextBox tbox_Report_Remarks;
        private System.Windows.Forms.TextBox tbox_Report_Escort_Name;
        private System.Windows.Forms.TextBox tbox_Report_Badge_Number;
        private System.Windows.Forms.TextBox tbox_Report_Purpose;
        private System.Windows.Forms.TextBox tbox_Report_ContactNumber;
        private System.Windows.Forms.TextBox tbox_Report_Address;
        private System.Windows.Forms.TextBox tbox_Report_Name;
        private System.Windows.Forms.Label lbl_Visitor_Report_Remarks;
        private System.Windows.Forms.Label lbl_Visitor_Report_InTime;
        private System.Windows.Forms.Label lbl_Visitor_Report_Escort_Name;
        private System.Windows.Forms.Label lbl_Visitor_Report_Badge_Number;
        private System.Windows.Forms.Label lbl_Visitor_Report_Whom_To_Meet;
        private System.Windows.Forms.Label lbl_Visitor_Report_Purpose;
        private System.Windows.Forms.Label lbl_Visitor_Report_Contact_Number;
        private System.Windows.Forms.Label lbl_Visitor_Report_Address;
        private System.Windows.Forms.Label lbl_Visitor_Report_Name;
        private System.Windows.Forms.Label lbl_Visitor_Report_Identity_Card_Number;
        private System.Windows.Forms.TextBox tbox_Report_Id_Proof;
        private System.Windows.Forms.Label lbl_Visitor_Report_Device_Carrying;
        private System.Windows.Forms.TextBox tbox_Report_Carrying_Laptop;
        private System.Windows.Forms.Button btn_Report_Extract;
        private System.Windows.Forms.CheckBox cbox_Interview_Purpose;
        private System.Windows.Forms.SaveFileDialog svFlDlg_SaveReport;
        private System.Windows.Forms.CheckBox cbox_dload_Images;
        private System.Windows.Forms.Button btn_Reset_Extract;
        private System.Windows.Forms.CheckBox cbox_Interview_Out_Purpose;
        private System.Windows.Forms.GroupBox grpBx_Inter_Office_Emp_Details;
        private System.Windows.Forms.TextBox tbox_InterOffce_Employee_Id;
        private System.Windows.Forms.Label lbl_InterOffce_Employee_Id;
        private System.Windows.Forms.TextBox tbox_InterOffce_Contact_Number;
        private System.Windows.Forms.TextBox tbox_InterOffce_Employee_Name;
        private System.Windows.Forms.TextBox tbox_InterOffce_Comming_From;
        private System.Windows.Forms.Label lbl_InterOffce_Contact_Number;
        private System.Windows.Forms.Label lbl_InterOffce_Comming_From;
        private System.Windows.Forms.Label lbl_InterOffce_Employee_Name;
        private System.Windows.Forms.GroupBox grpBx_Inter_Office_Access_Card_Details;
        private System.Windows.Forms.TextBox tbox_InterOffce_Date;
        private System.Windows.Forms.Label lbl_InterOffce_Date;
        private System.Windows.Forms.TextBox tbox_InterOffce_Access_Card_Number;
        private System.Windows.Forms.Label lbl_InterOffce_Access_Card_Number;
        private System.Windows.Forms.TextBox tbox_InterOffce_Badge_Number;
        private System.Windows.Forms.Label lbl_InterOffce_Badge_Number;
        private System.Windows.Forms.Label lbl_InterOffce_Issuing_Time;
        private System.Windows.Forms.TextBox tbox_InterOffce_No_Of_Days;
        private System.Windows.Forms.Label lbl_InterOffce_No_Of_Days;
        private System.Windows.Forms.GroupBox grpBx_Inter_Office_Emp_Signeture_Details;
        private System.Windows.Forms.PictureBox pBox_Inter_Office_Signeture;
        private System.Windows.Forms.GroupBox grpBx_Inter_Office_Emp_Image_Details;
        private System.Windows.Forms.TextBox tbox_InterOffce_Issuing_Time;
        private System.Windows.Forms.GroupBox grpBx_Inter_Office_Return_Details;
        private System.Windows.Forms.CheckBox cbox_Inter_Update_Return_Details;
        private System.Windows.Forms.Button btn_Inter_Office_Search;
        private System.Windows.Forms.TextBox tbox_InterOffce_Return_Employee_Id;
        private System.Windows.Forms.Label lbl_InterOffce_Return_Employee_Id;
        private System.Windows.Forms.Button btn_Inter_Office_Reset;
        private System.Windows.Forms.Button btn_Assign;
        private System.Windows.Forms.Button btn_Inter_Office_Stop;
        private System.Windows.Forms.Button btn_Inter_Office_Continue;
        private System.Windows.Forms.Button btn_Inter_Office_Webcam;
        private System.Windows.Forms.Button btn_Inter_Office_Take_Picture;
        private System.Windows.Forms.PictureBox pBox_Inter_Office_Image;
        private System.Windows.Forms.TextBox tbox_InterOffce_Remarks;
        private System.Windows.Forms.Label lbl_InterOffce_Remarks;
        private System.Windows.Forms.Button btn_Inter_Office_Return;
        private System.Windows.Forms.TextBox tbox_InterOffce_Return_Return_Time;
        private System.Windows.Forms.Label lbl_InterOffce_Return_Return_Time;
        private System.Windows.Forms.TextBox tbox_InterOffce_Return_Return_Date;
        private System.Windows.Forms.Label lbl_InterOffce_Return_Return_Date;
        private System.Windows.Forms.GroupBox grpBx_Inter_Office_Report;
        private System.Windows.Forms.Button btn_Report_Inter_Office_1_Month;
        private System.Windows.Forms.Button btn_Report_Inter_Office_Specific_Employee;
        private System.Windows.Forms.Button btn_Report_Inter_Office_Specified_Employee;
        private System.Windows.Forms.TextBox tbox_InterOffice_Serial_Number;
        private System.Windows.Forms.Button btn_Report_Inter_Office_Last_7_Days;
        private System.Windows.Forms.Button btn_Report_Inter_Office_Today;
        private System.Windows.Forms.GroupBox grpBx_Medicine_Distribution_Report;
        private System.Windows.Forms.GroupBox grpBx_Medicine_Distribution;
        private System.Windows.Forms.SplitContainer sp_Cont_Medicine_Distribution;
        private System.Windows.Forms.Button btn_Med_Emp_Reset;
        private System.Windows.Forms.Button btn_Med_Emp_Search;
        private System.Windows.Forms.TextBox tbox_Med_Emp_Desk_Phone;
        private System.Windows.Forms.Label lbl_Med_Emp_Desk_Phone;
        private System.Windows.Forms.TextBox tbox_Med_Emp_Email;
        private System.Windows.Forms.Label lbl_Med_Emp_Email;
        private System.Windows.Forms.TextBox tbox_Med_Emp_Name;
        private System.Windows.Forms.Label lbl_Med_Emp_Name;
        private System.Windows.Forms.TextBox tbox_Med_Emp_Id;
        private System.Windows.Forms.Label lbl_Med_Emp_Id;
        private System.Windows.Forms.Button btn_Med_Details_Reset;
        private System.Windows.Forms.Button btn_Med_Assign;
        private System.Windows.Forms.TextBox tbox_Med_Medcine_Quantity;
        private System.Windows.Forms.Label lbl_Med_Medcine_Quantity;
        private System.Windows.Forms.TextBox tbox_Med_Medcine_Name;
        private System.Windows.Forms.Label lbl_Med_Medcine_Name;
        private System.Windows.Forms.GroupBox grpBx_MedicineSigneture;
        private System.Windows.Forms.PictureBox pBox_Medcine_Signeture;
        private System.Windows.Forms.TabPage tb_Page_Settings;
        private System.Windows.Forms.TabControl tbCtrl_Settings;
        private System.Windows.Forms.TabPage tb_Page_Settings_Manage_Database;
        private System.Windows.Forms.TabPage tb_Page_Settings_Manage_Employee;
        private System.Windows.Forms.SplitContainer sp_Cont_Manage_Employee;
        private System.Windows.Forms.ProgressBar pgBar_Import_Progress;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox tbox_Browse;
        private System.Windows.Forms.Label lbl_Browse;
        private System.Windows.Forms.OpenFileDialog opFlDlg_SelectFile;
        private System.Windows.Forms.Button btn_Start;
        private System.ComponentModel.BackgroundWorker bg_Worker_ImportEmployee;
        private System.Windows.Forms.Label lblStateStatus;
        private System.Windows.Forms.Button btn_Employee_Update;
        private System.Windows.Forms.Button btn_Employee_Search;
        private System.Windows.Forms.RadioButton rdBtn_EmployeeInActive;
        private System.Windows.Forms.RadioButton rdBtn_EmployeeActive;
        private System.Windows.Forms.Label lbl_ManageEmployee_EmployeeLocation;
        private System.Windows.Forms.TextBox tbox_ManageEmployee_EmployeeLocation;
        private System.Windows.Forms.Label lbl_ManageEmployee_EmployeeManagerId;
        private System.Windows.Forms.TextBox tbox_ManageEmployee_EmployeeManagerId;
        private System.Windows.Forms.Label lbl_ManageEmployee_EmployeeManager;
        private System.Windows.Forms.TextBox tbox_ManageEmployee_EmployeeManager;
        private System.Windows.Forms.Label lbl_ManageEmployee_EmployeeCompany;
        private System.Windows.Forms.TextBox tbox_ManageEmployee_EmployeeCompany;
        private System.Windows.Forms.Label lbl_ManageEmployee_EmployeeDepartment;
        private System.Windows.Forms.TextBox tbox_ManageEmployee_EmployeeDepartment;
        private System.Windows.Forms.Label lbl_ManageEmployee_EmployeeOfficialMobile;
        private System.Windows.Forms.Label lbl_ManageEmployee_EmployeePersonalEmail;
        private System.Windows.Forms.Label lbl_ManageEmployee_EmployeePersonalMobile;
        private System.Windows.Forms.Label lbl_ManageEmployee_EmployeeExtection;
        private System.Windows.Forms.Label lbl_ManageEmployee_EmployeeEmail;
        private System.Windows.Forms.Label lbl_ManageEmployee_EmployeeName;
        private System.Windows.Forms.Label lbl_ManageEmployee_EmployeeId;
        private System.Windows.Forms.TextBox tbox_ManageEmployee_EmployeeOfficialMobile;
        private System.Windows.Forms.TextBox tbox_ManageEmployee_EmployeePersonalEmail;
        private System.Windows.Forms.TextBox tbox_ManageEmployee_EmployeePersonalMobile;
        private System.Windows.Forms.TextBox tbox_ManageEmployee_EmployeeExtection;
        private System.Windows.Forms.TextBox tbox_ManageEmployee_EmployeeEmail;
        private System.Windows.Forms.TextBox tbox_ManageEmployee_EmployeeName;
        private System.Windows.Forms.TextBox tbox_ManageEmployee_EmployeeId;
        private System.Windows.Forms.Label lbl_InsertEmployee;
        private System.Windows.Forms.Label lbl_UpdateEmployee;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button btn_Employee_Reset;
        private System.Windows.Forms.TextBox tbox_Id;
        private System.Windows.Forms.Label lbl_Med_Error;
        private System.Windows.Forms.CheckBox cbox_Interview_Report_Purpose;
        private System.Windows.Forms.Label lbl_medStockCounter;
        private System.Windows.Forms.TextBox tbox_Med_Medcine_Updated_Stock;
        private System.Windows.Forms.FolderBrowserDialog fbDlg_Backup_Database;
        private System.Windows.Forms.TabPage tb_Page_Settings_Manage_Medicine;
        private System.Windows.Forms.SplitContainer sp_Cont_Manage_Medicine_Graph;
        private System.Windows.Forms.SplitContainer sp_Cont_Manage_Medicine_Add_And_Update;
        private System.Windows.Forms.Label lbl_ExistingMedicine;
        private System.Windows.Forms.Button btn_ManageMedicine_Insert_Reset;
        private System.Windows.Forms.Button btn_ManageMedicine_Add;
        private System.Windows.Forms.NumericUpDown nemUD_ManageMedicine_InsertWarning;
        private System.Windows.Forms.Label lbl_ManageMedicine_InsertWarning;
        private System.Windows.Forms.NumericUpDown nemUD_ManageMedicine_InsertMedicineStock;
        private System.Windows.Forms.Label lbl_ManageMedicine_InsertMedicineStock;
        private System.Windows.Forms.TextBox tbox_ManageMedicine_InsertMedicineName;
        private System.Windows.Forms.Label lbl_ManageMedicine_InsertMedicineName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_Medicine_Stock;
        private System.Windows.Forms.RadioButton rd_ManageMedicine_PlotInActiveMedicine;
        private System.Windows.Forms.RadioButton rd_ManageMedicine_PlotActiveMedicine;
        private System.Windows.Forms.Label lbl_GraphDataError;
        private System.Windows.Forms.Label lbl_InsertMedicine;
        private System.Windows.Forms.Label lbl_UpdateMedicine;
        private System.Windows.Forms.Button btn_ManageMedicine_Update_Reset;
        private System.Windows.Forms.Button btn_ManageMedicine_Update;
        private System.Windows.Forms.RadioButton rdBtn_MedicineInActive;
        private System.Windows.Forms.RadioButton rdBtn_MedicineActive;
        private System.Windows.Forms.NumericUpDown nemUD_ManageMedicine_UpdateWarning;
        private System.Windows.Forms.Label lbl_ManageMedicine_UpdateWarning;
        private System.Windows.Forms.NumericUpDown nemUD_ManageMedicine_UpdateMedicineStock;
        private System.Windows.Forms.Label lbl_ManageMedicine_UpdateMedicineStock;
        private System.Windows.Forms.Button btn_ManageMedicine_Search;
        private System.Windows.Forms.TextBox tbox_ManageMedicine_UpdateMedicineName;
        private System.Windows.Forms.Label lbl_ManageMedicine_UpdateMedicineName;
        private System.Windows.Forms.TextBox tbox_ManageMedicineId;
        private System.Windows.Forms.Button btn_Repoint_Database;
        private System.Windows.Forms.Button btn_Change_Admin_Password;
        private System.Windows.Forms.Button btn_Restore_Database;
        private System.Windows.Forms.Button btn_Backup_Database;
        private System.Windows.Forms.ProgressBar pgBar_Backup_Progress;
        private System.Windows.Forms.RichTextBox rtbox_Daily_Log;
        private System.Windows.Forms.Label lbl_Daily_Log;
        private System.Windows.Forms.Label lbl_Log_Find;
        private System.Windows.Forms.TextBox tbox_Log_Find;
        private System.Windows.Forms.GroupBox grpbx_Database_Details;
        private System.Windows.Forms.ProgressBar pgBar_Database_Size;
        private System.Windows.Forms.Label lbl_Database_Size;
        private System.Windows.Forms.Label lbl_Database_Last_BackedUp_On;
        private System.ComponentModel.BackgroundWorker bg_Worker_BackupDatabase;
        private System.Windows.Forms.Label lbl_BackupStatus;
        private System.Windows.Forms.Label lbl_DatabaseSize;
        private System.ComponentModel.BackgroundWorker bg_Worker_RestoreDatabase;
        private System.Windows.Forms.CheckBox cbox_Non_Employee_Medicine_Distribution;
        private System.Windows.Forms.Button btn_MedReport_Non_Employee;
        private System.Windows.Forms.Button btn_MedReport_Specified_Medicine;
        private System.Windows.Forms.Button btn_MedReport_Today;
        private System.Windows.Forms.Button btn_MedReport_Specified_Date_Range;
        private System.Windows.Forms.Button btn_MedReport_Specified_Employee;
        private System.Windows.Forms.Button btn_MedReport_LastOneMonth;
        private System.Windows.Forms.TabControl tbCtrl_Key_Details;
        private System.Windows.Forms.TabPage tb_Page_KeyDetails_OneTimeDetails;
        private System.Windows.Forms.TabPage tb_Page_KeyDetails_TempDetails;
        private System.Windows.Forms.SplitContainer sp_Cont_Key_Distribution;
        private System.Windows.Forms.SplitContainer sp_Cont_SubTop_Key_Distribution;
        private System.Windows.Forms.Label lbl_KeyDistribution_EmployeeDetails;
        private System.Windows.Forms.Label lbl_KeyDistribution_KeyDetails;
        private System.Windows.Forms.SplitContainer sp_Cont_SubBot_Key_Distribution;
        private System.Windows.Forms.Button btn_Key_Emp_Reset;
        private System.Windows.Forms.Button btn_Key_Emp_Search;
        private System.Windows.Forms.TextBox tbox_Key_Emp_Desk_Phone;
        private System.Windows.Forms.Label lbl_Key_Emp_Desk_Phone;
        private System.Windows.Forms.TextBox tbox_Key_Emp_Email;
        private System.Windows.Forms.Label lbl_Key_Emp_Email;
        private System.Windows.Forms.TextBox tbox_Key_Emp_Name;
        private System.Windows.Forms.Label lbl_Key_Emp_Name;
        private System.Windows.Forms.TextBox tbox_Key_Emp_Id;
        private System.Windows.Forms.Label lbl_Key_Emp_Id;
        private System.Windows.Forms.Label lbl_KeyDistribution_TimeDetails;
        private System.Windows.Forms.Label lbl_Key_Error;
        private System.Windows.Forms.Label lbl_ConnectedDatabase;
        private System.Windows.Forms.TabPage tb_Page_Settings_Manage_Keys;
        private System.Windows.Forms.SplitContainer sp_Cont_Manage_Kyes_Data;
        private System.Windows.Forms.SplitContainer sp_Cont_Manage_Keys_Add_And_Update;
        private System.Windows.Forms.ComboBox cbox_ManageKeys_InsertKeysWhichFloor;
        private System.Windows.Forms.Label lbl_ManageKeys_InsertKeysWhichFloor;
        private System.Windows.Forms.Label lbl_ManageKeys_InsertKeysNoOfKeys;
        private System.Windows.Forms.TextBox tbox_ManageKeys_InsertKeysPedistalNo;
        private System.Windows.Forms.Label lbl_ManageKeys_InsertKeysPedistalNo;
        private System.Windows.Forms.TextBox tbox_ManageKeys_InsertKeysKeyNo;
        private System.Windows.Forms.Label lbl_InsertKeys;
        private System.Windows.Forms.Label lbl_ManageKeys_InsertKeysKeyNo;
        private System.Windows.Forms.Label lbl_UpdateKeys;
        private System.Windows.Forms.Button btn_ManageKeys_Insert_Reset;
        private System.Windows.Forms.Button btn_ManageKeys_Add;
        private System.Windows.Forms.NumericUpDown nemUD_ManageKeys_InsertKeys;
        private System.Windows.Forms.NumericUpDown nemUD_ManageKeys_UpdateKeys;
        private System.Windows.Forms.Button btn_ManageKeys_Update_Reset;
        private System.Windows.Forms.Button btn_ManageKeys_Update;
        private System.Windows.Forms.ComboBox cbox_ManageKeys_UpdateKeysWhichFloor;
        private System.Windows.Forms.Label lbl_ManageKeys_UpdateKeysWhichFloor;
        private System.Windows.Forms.Label lbl_ManageKeys_UpdateKeysNoOfKeys;
        private System.Windows.Forms.TextBox tbox_ManageKeys_UpdateKeysPedistalNo;
        private System.Windows.Forms.Label lbl_ManageKeys_UpdateKeysPedistalNo;
        private System.Windows.Forms.TextBox tbox_ManageKeys_UpdateKeysKeyNo;
        private System.Windows.Forms.Label lbl_ManageKeys_UpdateKeysKeyNo;
        private System.Windows.Forms.Button btn_ManageKeys_Search_By_PedistalNo;
        private System.Windows.Forms.Label lbl_ExistingPedistal;
        private System.Windows.Forms.Label lbl_ManageKeys_InsertKeys_Select_Floor;
        private System.Windows.Forms.Label lbl_ManageKeys_UpdateKeys_Select_Floor;
        private System.Windows.Forms.Label lbl_ManageKeys_InsertKeys_InsertKeysKeyNo;
        private System.Windows.Forms.RadioButton rdBtn_PedistalInActive;
        private System.Windows.Forms.RadioButton rdBtn_PedistalActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_medNameChecker;
    }
}


using AssetManagement.HelperClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AssetManagement
{
    public partial class frm_ReportDataCollector : Form
    {
        #region Private Variable

        private int p;

        #endregion Private Variable

        #region constructor

        public frm_ReportDataCollector(int pFrom)
        {
            this.p = pFrom;
            InitializeComponent();
            formShapper(p);
        }

        #endregion constructor

        #region Function

        private void formShapper(int pFrom)
        {
            if (pFrom == 0 || pFrom == 4)
            {
                lbl_Visitor_Report_DataCollector_EmployeeId.Visible = true;
                tbox_Visitor_Report_DataCollector_EmployeeId.Visible = true;
                btn_Ok.Visible = true;

                lbl_Visitor_Report_DataCollector_EmployeeId.Text = "Employee Id :";
                lbl_Visitor_Report_DataCollector_EmployeeId.Location = new Point(44, 9);

                lbl_Visitor_Report_DataCollector_OutTime.Visible = false;
                dtPk_Report_DataCollector_OutTime.Visible = false;
                dtPk_Report_DataCollector_InTime.Visible = false;
            }
            else if (pFrom == 1)
            {
                lbl_Visitor_Report_DataCollector_EmployeeId.Visible = true;
                tbox_Visitor_Report_DataCollector_EmployeeId.Visible = false;
                btn_Ok.Visible = true;

                lbl_Visitor_Report_DataCollector_EmployeeId.Text = "In Time :";
                lbl_Visitor_Report_DataCollector_EmployeeId.Location = new Point(80, 9);

                lbl_Visitor_Report_DataCollector_OutTime.Visible = true;
                dtPk_Report_DataCollector_OutTime.Visible = true;
                dtPk_Report_DataCollector_InTime.Visible = true;
                dtPk_Report_DataCollector_InTime.Checked = false;
                dtPk_Report_DataCollector_OutTime.Checked = false;
                dtPk_Report_DataCollector_OutTime.Format = DateTimePickerFormat.Custom;
                dtPk_Report_DataCollector_OutTime.CustomFormat = "dd MMMM yyyy";
                dtPk_Report_DataCollector_InTime.Format = DateTimePickerFormat.Custom;
                dtPk_Report_DataCollector_InTime.CustomFormat = "dd MMMM yyyy";
            }
            else if (pFrom == 2)
            {
                lbl_Visitor_Report_DataCollector_EmployeeId.Visible = true;
                tbox_Visitor_Report_DataCollector_EmployeeId.Visible = true;
                btn_Ok.Visible = true;

                lbl_Visitor_Report_DataCollector_EmployeeId.Text = "Medicine Name :";
                lbl_Visitor_Report_DataCollector_EmployeeId.Location = new Point(22, 9);

                lbl_Visitor_Report_DataCollector_OutTime.Visible = false;
                dtPk_Report_DataCollector_OutTime.Visible = false;
                dtPk_Report_DataCollector_InTime.Visible = false;
            }
            else if (pFrom == 3)
            {
                lbl_Visitor_Report_DataCollector_EmployeeId.Visible = true;
                tbox_Visitor_Report_DataCollector_EmployeeId.Visible = false;
                btn_Ok.Visible = true;

                lbl_Visitor_Report_DataCollector_EmployeeId.Text = "Start Date :";
                lbl_Visitor_Report_DataCollector_EmployeeId.Location = new Point(62, 9);

                lbl_Visitor_Report_DataCollector_OutTime.Text = "End Date :";
                lbl_Visitor_Report_DataCollector_OutTime.Location = new Point(67, 35);

                lbl_Visitor_Report_DataCollector_OutTime.Visible = true;
                dtPk_Report_DataCollector_OutTime.Visible = true;
                dtPk_Report_DataCollector_InTime.Visible = true;
                dtPk_Report_DataCollector_InTime.Checked = false;
                dtPk_Report_DataCollector_OutTime.Checked = false;
                dtPk_Report_DataCollector_OutTime.Format = DateTimePickerFormat.Custom;
                dtPk_Report_DataCollector_OutTime.CustomFormat = "dd MMMM yyyy";
                dtPk_Report_DataCollector_InTime.Format = DateTimePickerFormat.Custom;
                dtPk_Report_DataCollector_InTime.CustomFormat = "dd MMMM yyyy";
            }
        }

        #endregion Function

        #region Event

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (p == 0 || p == 4)
            {
                if (tbox_Visitor_Report_DataCollector_EmployeeId.Text != "")
                {
                    frm_Main.employeeId = tbox_Visitor_Report_DataCollector_EmployeeId.Text;
                    frm_Main.toDo = 1;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Please provide some value...", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (p == 1)
            {
                if (dtPk_Report_DataCollector_InTime.Checked == true)
                {
                    frm_Main.InTime = dtPk_Report_DataCollector_InTime.Value;
                    frm_Main.toDo = 1;
                }
                if (dtPk_Report_DataCollector_OutTime.Checked == true)
                {
                    frm_Main.OutTime = dtPk_Report_DataCollector_OutTime.Value;
                    frm_Main.toDo = 1;
                }
                if (dtPk_Report_DataCollector_OutTime.Checked != true && dtPk_Report_DataCollector_InTime.Checked != true)
                {
                    frm_Main.InTime = null;
                    frm_Main.OutTime = null;
                    frm_Main.toDo = 1;
                }
                this.Dispose();
            }
            else if (p == 2)
            {
                if (tbox_Visitor_Report_DataCollector_EmployeeId.Text != "")
                {
                    frm_Main.medicineName = tbox_Visitor_Report_DataCollector_EmployeeId.Text;
                    frm_Main.toDo = 1;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Please provide some value...", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (p == 3)
            {
                if (dtPk_Report_DataCollector_OutTime.Checked != true && dtPk_Report_DataCollector_InTime.Checked != true)
                {
                    frm_Main.InTime = null;
                    frm_Main.OutTime = null;
                    frm_Main.toDo = 1;
                    this.Dispose();
                }
                if (dtPk_Report_DataCollector_OutTime.Checked == true && dtPk_Report_DataCollector_InTime.Checked == true)
                {
                    frm_Main.InTime = dtPk_Report_DataCollector_InTime.Value;
                    frm_Main.OutTime = dtPk_Report_DataCollector_OutTime.Value;
                    frm_Main.toDo = 1;
                    this.Dispose();
                }
                if (dtPk_Report_DataCollector_OutTime.Checked == true && dtPk_Report_DataCollector_InTime.Checked != true)
                {
                    MessageBox.Show("Please provide both value...", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (dtPk_Report_DataCollector_OutTime.Checked != true && dtPk_Report_DataCollector_InTime.Checked == true)
                {
                    MessageBox.Show("Please provide both value...", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tbox_Visitor_Report_DataCollector_EmployeeId_TextChanged(object sender, EventArgs e)
        {
            if (p == 0)
            {
                autoCompleteTextbox.autocompletedata(ref tbox_Visitor_Report_DataCollector_EmployeeId, "Employee_Id", "tbl_Inter_Office_Visitor");
            }
            else if (p == 4)
            {
                autoCompleteTextbox.autocompletedata(ref tbox_Visitor_Report_DataCollector_EmployeeId, "Employee_Id", "tbl_Medicine_Distrubution");
            }
            else if (p == 2)
            {
                autoCompleteTextbox.autocompletedata(ref tbox_Visitor_Report_DataCollector_EmployeeId, "Medcine_Name", "tbl_Medicine_Distrubution");
            }
        }

        #endregion Event
    }
}
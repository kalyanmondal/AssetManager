using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement
{
    public partial class frm_ReportDataCollector : Form
    {
        #region Private Variable

        int p;

        #endregion

        #region constructor

        public frm_ReportDataCollector(int pFrom)
        {
            this.p = pFrom;
            InitializeComponent();
            formShapper(p);
        }

        #endregion

        #region Function

        private void formShapper(int pFrom)
        {
            if(pFrom == 0)
            {
                lbl_Visitor_Report_DataCollector_EmployeeId.Visible = true;
                tbox_Visitor_Report_DataCollector_EmployeeId.Visible = true;
                btn_Ok.Visible = true;

                lbl_Visitor_Report_DataCollector_EmployeeId.Text = "Employee Id :";

                lbl_Visitor_Report_DataCollector_OutTime.Visible = false;
                dtPk_Report_DataCollector_OutTime.Visible = false;
                dtPk_Report_DataCollector_InTime.Visible = false;
            }
            else
            {
                lbl_Visitor_Report_DataCollector_EmployeeId.Visible = true;
                tbox_Visitor_Report_DataCollector_EmployeeId.Visible = false;
                btn_Ok.Visible = true;

                lbl_Visitor_Report_DataCollector_EmployeeId.Text = "In Time :";
                lbl_Visitor_Report_DataCollector_EmployeeId.Location = new Point(57,8);

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

        #endregion

        #region Event

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if(p==0)
            {
                frm_Main.employeeId = tbox_Visitor_Report_DataCollector_EmployeeId.Text;
                this.Dispose();
            }
            else
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
        }

        #endregion
    }
}

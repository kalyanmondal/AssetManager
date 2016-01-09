namespace AssetManagement
{
    partial class frm_ReportDataCollector
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
            this.dtPk_Report_DataCollector_OutTime = new System.Windows.Forms.DateTimePicker();
            this.dtPk_Report_DataCollector_InTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_Visitor_Report_DataCollector_OutTime = new System.Windows.Forms.Label();
            this.lbl_Visitor_Report_DataCollector_EmployeeId = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.tbox_Visitor_Report_DataCollector_EmployeeId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtPk_Report_DataCollector_OutTime
            // 
            this.dtPk_Report_DataCollector_OutTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPk_Report_DataCollector_OutTime.Location = new System.Drawing.Point(153, 34);
            this.dtPk_Report_DataCollector_OutTime.Name = "dtPk_Report_DataCollector_OutTime";
            this.dtPk_Report_DataCollector_OutTime.ShowCheckBox = true;
            this.dtPk_Report_DataCollector_OutTime.Size = new System.Drawing.Size(259, 20);
            this.dtPk_Report_DataCollector_OutTime.TabIndex = 55;
            this.dtPk_Report_DataCollector_OutTime.Visible = false;
            // 
            // dtPk_Report_DataCollector_InTime
            // 
            this.dtPk_Report_DataCollector_InTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPk_Report_DataCollector_InTime.Location = new System.Drawing.Point(153, 8);
            this.dtPk_Report_DataCollector_InTime.Name = "dtPk_Report_DataCollector_InTime";
            this.dtPk_Report_DataCollector_InTime.ShowCheckBox = true;
            this.dtPk_Report_DataCollector_InTime.Size = new System.Drawing.Size(259, 20);
            this.dtPk_Report_DataCollector_InTime.TabIndex = 54;
            this.dtPk_Report_DataCollector_InTime.Visible = false;
            // 
            // lbl_Visitor_Report_DataCollector_OutTime
            // 
            this.lbl_Visitor_Report_DataCollector_OutTime.AutoSize = true;
            this.lbl_Visitor_Report_DataCollector_OutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Report_DataCollector_OutTime.Location = new System.Drawing.Point(69, 38);
            this.lbl_Visitor_Report_DataCollector_OutTime.Name = "lbl_Visitor_Report_DataCollector_OutTime";
            this.lbl_Visitor_Report_DataCollector_OutTime.Size = new System.Drawing.Size(78, 16);
            this.lbl_Visitor_Report_DataCollector_OutTime.TabIndex = 57;
            this.lbl_Visitor_Report_DataCollector_OutTime.Text = "Out Time :";
            this.lbl_Visitor_Report_DataCollector_OutTime.Visible = false;
            // 
            // lbl_Visitor_Report_DataCollector_EmployeeId
            // 
            this.lbl_Visitor_Report_DataCollector_EmployeeId.AutoSize = true;
            this.lbl_Visitor_Report_DataCollector_EmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Visitor_Report_DataCollector_EmployeeId.Location = new System.Drawing.Point(44, 9);
            this.lbl_Visitor_Report_DataCollector_EmployeeId.Name = "lbl_Visitor_Report_DataCollector_EmployeeId";
            this.lbl_Visitor_Report_DataCollector_EmployeeId.Size = new System.Drawing.Size(103, 16);
            this.lbl_Visitor_Report_DataCollector_EmployeeId.TabIndex = 56;
            this.lbl_Visitor_Report_DataCollector_EmployeeId.Text = "Employee Id :";
            this.lbl_Visitor_Report_DataCollector_EmployeeId.Visible = false;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Location = new System.Drawing.Point(331, 60);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(81, 27);
            this.btn_Ok.TabIndex = 58;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Visible = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // tbox_Visitor_Report_DataCollector_EmployeeId
            // 
            this.tbox_Visitor_Report_DataCollector_EmployeeId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbox_Visitor_Report_DataCollector_EmployeeId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_Visitor_Report_DataCollector_EmployeeId.Location = new System.Drawing.Point(153, 8);
            this.tbox_Visitor_Report_DataCollector_EmployeeId.Name = "tbox_Visitor_Report_DataCollector_EmployeeId";
            this.tbox_Visitor_Report_DataCollector_EmployeeId.Size = new System.Drawing.Size(260, 20);
            this.tbox_Visitor_Report_DataCollector_EmployeeId.TabIndex = 59;
            this.tbox_Visitor_Report_DataCollector_EmployeeId.Visible = false;
            this.tbox_Visitor_Report_DataCollector_EmployeeId.TextChanged += new System.EventHandler(this.tbox_Visitor_Report_DataCollector_EmployeeId_TextChanged);
            // 
            // frm_ReportDataCollector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 94);
            this.Controls.Add(this.tbox_Visitor_Report_DataCollector_EmployeeId);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.dtPk_Report_DataCollector_OutTime);
            this.Controls.Add(this.dtPk_Report_DataCollector_InTime);
            this.Controls.Add(this.lbl_Visitor_Report_DataCollector_OutTime);
            this.Controls.Add(this.lbl_Visitor_Report_DataCollector_EmployeeId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_ReportDataCollector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPk_Report_DataCollector_OutTime;
        private System.Windows.Forms.DateTimePicker dtPk_Report_DataCollector_InTime;
        private System.Windows.Forms.Label lbl_Visitor_Report_DataCollector_OutTime;
        private System.Windows.Forms.Label lbl_Visitor_Report_DataCollector_EmployeeId;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.TextBox tbox_Visitor_Report_DataCollector_EmployeeId;
    }
}
namespace AssetManagement
{
    partial class frm_DatabaseSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DatabaseSelector));
            this.lbl_Select_The_Database = new System.Windows.Forms.Label();
            this.tbox_Select_The_Database = new System.Windows.Forms.TextBox();
            this.btn_Browse_Database = new System.Windows.Forms.Button();
            this.btn_Ok_Database = new System.Windows.Forms.Button();
            this.dlg_OpenFile_Database_Selector = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbl_Select_The_Database
            // 
            this.lbl_Select_The_Database.AutoSize = true;
            this.lbl_Select_The_Database.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Select_The_Database.Location = new System.Drawing.Point(5, 19);
            this.lbl_Select_The_Database.Name = "lbl_Select_The_Database";
            this.lbl_Select_The_Database.Size = new System.Drawing.Size(107, 15);
            this.lbl_Select_The_Database.TabIndex = 0;
            this.lbl_Select_The_Database.Text = "Select the file : ";
            // 
            // tbox_Select_The_Database
            // 
            this.tbox_Select_The_Database.Location = new System.Drawing.Point(109, 18);
            this.tbox_Select_The_Database.Name = "tbox_Select_The_Database";
            this.tbox_Select_The_Database.Size = new System.Drawing.Size(523, 20);
            this.tbox_Select_The_Database.TabIndex = 1;
            this.tbox_Select_The_Database.TextChanged += new System.EventHandler(this.tbox_Select_The_Database_TextChanged);
            // 
            // btn_Browse_Database
            // 
            this.btn_Browse_Database.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse_Database.Location = new System.Drawing.Point(638, 16);
            this.btn_Browse_Database.Name = "btn_Browse_Database";
            this.btn_Browse_Database.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse_Database.TabIndex = 2;
            this.btn_Browse_Database.Text = "Browse";
            this.btn_Browse_Database.UseVisualStyleBackColor = true;
            this.btn_Browse_Database.Click += new System.EventHandler(this.btn_Browse_Database_Click);
            // 
            // btn_Ok_Database
            // 
            this.btn_Ok_Database.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok_Database.Location = new System.Drawing.Point(719, 15);
            this.btn_Ok_Database.Name = "btn_Ok_Database";
            this.btn_Ok_Database.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok_Database.TabIndex = 3;
            this.btn_Ok_Database.Text = "Ok";
            this.btn_Ok_Database.UseVisualStyleBackColor = true;
            this.btn_Ok_Database.Click += new System.EventHandler(this.btn_Ok_Database_Click);
            // 
            // frm_DatabaseSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 55);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Ok_Database);
            this.Controls.Add(this.btn_Browse_Database);
            this.Controls.Add(this.tbox_Select_The_Database);
            this.Controls.Add(this.lbl_Select_The_Database);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DatabaseSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Manager";
            this.Load += new System.EventHandler(this.frm_DatabaseSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Select_The_Database;
        private System.Windows.Forms.TextBox tbox_Select_The_Database;
        private System.Windows.Forms.Button btn_Browse_Database;
        private System.Windows.Forms.Button btn_Ok_Database;
        private System.Windows.Forms.OpenFileDialog dlg_OpenFile_Database_Selector;
    }
}
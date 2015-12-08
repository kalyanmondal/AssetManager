namespace AssetManagement
{
    partial class frm_SheetSelector
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
            this.lbl_SheetSelect = new System.Windows.Forms.Label();
            this.cbox_SheetSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_SheetSelect
            // 
            this.lbl_SheetSelect.AutoSize = true;
            this.lbl_SheetSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SheetSelect.Location = new System.Drawing.Point(12, 25);
            this.lbl_SheetSelect.Name = "lbl_SheetSelect";
            this.lbl_SheetSelect.Size = new System.Drawing.Size(124, 15);
            this.lbl_SheetSelect.TabIndex = 0;
            this.lbl_SheetSelect.Text = "Select The Sheet :";
            // 
            // cbox_SheetSelect
            // 
            this.cbox_SheetSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_SheetSelect.FormattingEnabled = true;
            this.cbox_SheetSelect.Location = new System.Drawing.Point(142, 24);
            this.cbox_SheetSelect.Name = "cbox_SheetSelect";
            this.cbox_SheetSelect.Size = new System.Drawing.Size(206, 21);
            this.cbox_SheetSelect.TabIndex = 1;
            this.cbox_SheetSelect.SelectedIndexChanged += new System.EventHandler(this.cbox_SheetSelect_SelectedIndexChanged);
            // 
            // frm_SheetSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 71);
            this.Controls.Add(this.cbox_SheetSelect);
            this.Controls.Add(this.lbl_SheetSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_SheetSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SheetSelect;
        private System.Windows.Forms.ComboBox cbox_SheetSelect;
    }
}
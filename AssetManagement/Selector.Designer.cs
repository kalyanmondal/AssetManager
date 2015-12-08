namespace AssetManagement
{
    partial class frm_Selector
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
            this.dtGrVw_Selector = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrVw_Selector)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrVw_Selector
            // 
            this.dtGrVw_Selector.AllowUserToAddRows = false;
            this.dtGrVw_Selector.AllowUserToDeleteRows = false;
            this.dtGrVw_Selector.AllowUserToResizeRows = false;
            this.dtGrVw_Selector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrVw_Selector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrVw_Selector.Location = new System.Drawing.Point(1, 5);
            this.dtGrVw_Selector.MultiSelect = false;
            this.dtGrVw_Selector.Name = "dtGrVw_Selector";
            this.dtGrVw_Selector.Size = new System.Drawing.Size(1246, 136);
            this.dtGrVw_Selector.TabIndex = 0;
            this.dtGrVw_Selector.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrVw_Selector_CellClick);
            this.dtGrVw_Selector.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrVw_Selector_CellDoubleClick);
            // 
            // frm_Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 147);
            this.Controls.Add(this.dtGrVw_Selector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Selector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrVw_Selector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrVw_Selector;

    }
}
namespace AssetManagement
{
    partial class frm_AdminLogin
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
            this.lbl_AdminLogin_Id = new System.Windows.Forms.Label();
            this.lbl_AdminLogin_Password = new System.Windows.Forms.Label();
            this.tbox_AdminLogin_Id = new System.Windows.Forms.TextBox();
            this.tbox_AdminLogin_Password = new System.Windows.Forms.TextBox();
            this.btn_AdminLogin_Login = new System.Windows.Forms.Button();
            this.btn_AdminLogin_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_AdminLogin_Id
            // 
            this.lbl_AdminLogin_Id.AutoSize = true;
            this.lbl_AdminLogin_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminLogin_Id.Location = new System.Drawing.Point(68, 18);
            this.lbl_AdminLogin_Id.Name = "lbl_AdminLogin_Id";
            this.lbl_AdminLogin_Id.Size = new System.Drawing.Size(33, 16);
            this.lbl_AdminLogin_Id.TabIndex = 0;
            this.lbl_AdminLogin_Id.Text = "Id : ";
            // 
            // lbl_AdminLogin_Password
            // 
            this.lbl_AdminLogin_Password.AutoSize = true;
            this.lbl_AdminLogin_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_AdminLogin_Password.Location = new System.Drawing.Point(13, 44);
            this.lbl_AdminLogin_Password.Name = "lbl_AdminLogin_Password";
            this.lbl_AdminLogin_Password.Size = new System.Drawing.Size(88, 16);
            this.lbl_AdminLogin_Password.TabIndex = 1;
            this.lbl_AdminLogin_Password.Text = "Password : ";
            // 
            // tbox_AdminLogin_Id
            // 
            this.tbox_AdminLogin_Id.Location = new System.Drawing.Point(107, 17);
            this.tbox_AdminLogin_Id.Name = "tbox_AdminLogin_Id";
            this.tbox_AdminLogin_Id.Size = new System.Drawing.Size(177, 20);
            this.tbox_AdminLogin_Id.TabIndex = 2;
            this.tbox_AdminLogin_Id.TextChanged += new System.EventHandler(this.tbox_AdminLogin_Id_TextChanged);
            // 
            // tbox_AdminLogin_Password
            // 
            this.tbox_AdminLogin_Password.Location = new System.Drawing.Point(107, 43);
            this.tbox_AdminLogin_Password.Name = "tbox_AdminLogin_Password";
            this.tbox_AdminLogin_Password.PasswordChar = '#';
            this.tbox_AdminLogin_Password.Size = new System.Drawing.Size(177, 20);
            this.tbox_AdminLogin_Password.TabIndex = 3;
            this.tbox_AdminLogin_Password.TextChanged += new System.EventHandler(this.tbox_AdminLogin_Password_TextChanged);
            // 
            // btn_AdminLogin_Login
            // 
            this.btn_AdminLogin_Login.Enabled = false;
            this.btn_AdminLogin_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminLogin_Login.Location = new System.Drawing.Point(128, 70);
            this.btn_AdminLogin_Login.Name = "btn_AdminLogin_Login";
            this.btn_AdminLogin_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminLogin_Login.TabIndex = 4;
            this.btn_AdminLogin_Login.Text = "Login";
            this.btn_AdminLogin_Login.UseVisualStyleBackColor = true;
            this.btn_AdminLogin_Login.Click += new System.EventHandler(this.btn_AdminLogin_Login_Click);
            // 
            // btn_AdminLogin_Cancel
            // 
            this.btn_AdminLogin_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminLogin_Cancel.Location = new System.Drawing.Point(209, 70);
            this.btn_AdminLogin_Cancel.Name = "btn_AdminLogin_Cancel";
            this.btn_AdminLogin_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminLogin_Cancel.TabIndex = 5;
            this.btn_AdminLogin_Cancel.Text = "Cancel";
            this.btn_AdminLogin_Cancel.UseVisualStyleBackColor = true;
            this.btn_AdminLogin_Cancel.Click += new System.EventHandler(this.btn_AdminLogin_Cancel_Click);
            // 
            // frm_AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 105);
            this.ControlBox = false;
            this.Controls.Add(this.btn_AdminLogin_Cancel);
            this.Controls.Add(this.btn_AdminLogin_Login);
            this.Controls.Add(this.tbox_AdminLogin_Password);
            this.Controls.Add(this.tbox_AdminLogin_Id);
            this.Controls.Add(this.lbl_AdminLogin_Password);
            this.Controls.Add(this.lbl_AdminLogin_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_AdminLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AdminLogin_Id;
        private System.Windows.Forms.Label lbl_AdminLogin_Password;
        private System.Windows.Forms.TextBox tbox_AdminLogin_Id;
        private System.Windows.Forms.TextBox tbox_AdminLogin_Password;
        private System.Windows.Forms.Button btn_AdminLogin_Login;
        private System.Windows.Forms.Button btn_AdminLogin_Cancel;
    }
}
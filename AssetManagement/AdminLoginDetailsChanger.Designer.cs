namespace AssetManagement
{
    partial class frm_AdminLoginDetailsChanger
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
            this.spcont_AdminLoginChanger = new System.Windows.Forms.SplitContainer();
            this.lbl_AdminUserNameStatus = new System.Windows.Forms.Label();
            this.lbl_Update_UserName = new System.Windows.Forms.Label();
            this.btn_Update_UserName = new System.Windows.Forms.Button();
            this.tbox_AdminUserName = new System.Windows.Forms.TextBox();
            this.lbl_AdminUserName = new System.Windows.Forms.Label();
            this.lbl_Update_Password = new System.Windows.Forms.Label();
            this.tbox_AdminPassword = new System.Windows.Forms.TextBox();
            this.tbox_AdminConfirmPassword = new System.Windows.Forms.TextBox();
            this.btn_Update_Password = new System.Windows.Forms.Button();
            this.lbl_AdminPasswordStatus = new System.Windows.Forms.Label();
            this.lbl_AdminPassword = new System.Windows.Forms.Label();
            this.lbl_AdminConfirmPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spcont_AdminLoginChanger)).BeginInit();
            this.spcont_AdminLoginChanger.Panel1.SuspendLayout();
            this.spcont_AdminLoginChanger.Panel2.SuspendLayout();
            this.spcont_AdminLoginChanger.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcont_AdminLoginChanger
            // 
            this.spcont_AdminLoginChanger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcont_AdminLoginChanger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcont_AdminLoginChanger.IsSplitterFixed = true;
            this.spcont_AdminLoginChanger.Location = new System.Drawing.Point(0, 0);
            this.spcont_AdminLoginChanger.Name = "spcont_AdminLoginChanger";
            this.spcont_AdminLoginChanger.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcont_AdminLoginChanger.Panel1
            // 
            this.spcont_AdminLoginChanger.Panel1.Controls.Add(this.lbl_AdminUserNameStatus);
            this.spcont_AdminLoginChanger.Panel1.Controls.Add(this.lbl_Update_UserName);
            this.spcont_AdminLoginChanger.Panel1.Controls.Add(this.btn_Update_UserName);
            this.spcont_AdminLoginChanger.Panel1.Controls.Add(this.tbox_AdminUserName);
            this.spcont_AdminLoginChanger.Panel1.Controls.Add(this.lbl_AdminUserName);
            // 
            // spcont_AdminLoginChanger.Panel2
            // 
            this.spcont_AdminLoginChanger.Panel2.Controls.Add(this.lbl_AdminConfirmPassword);
            this.spcont_AdminLoginChanger.Panel2.Controls.Add(this.lbl_AdminPassword);
            this.spcont_AdminLoginChanger.Panel2.Controls.Add(this.lbl_AdminPasswordStatus);
            this.spcont_AdminLoginChanger.Panel2.Controls.Add(this.btn_Update_Password);
            this.spcont_AdminLoginChanger.Panel2.Controls.Add(this.tbox_AdminConfirmPassword);
            this.spcont_AdminLoginChanger.Panel2.Controls.Add(this.tbox_AdminPassword);
            this.spcont_AdminLoginChanger.Panel2.Controls.Add(this.lbl_Update_Password);
            this.spcont_AdminLoginChanger.Size = new System.Drawing.Size(347, 237);
            this.spcont_AdminLoginChanger.SplitterDistance = 98;
            this.spcont_AdminLoginChanger.TabIndex = 0;
            // 
            // lbl_AdminUserNameStatus
            // 
            this.lbl_AdminUserNameStatus.AutoSize = true;
            this.lbl_AdminUserNameStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_AdminUserNameStatus.Location = new System.Drawing.Point(146, 20);
            this.lbl_AdminUserNameStatus.Name = "lbl_AdminUserNameStatus";
            this.lbl_AdminUserNameStatus.Size = new System.Drawing.Size(0, 13);
            this.lbl_AdminUserNameStatus.TabIndex = 4;
            // 
            // lbl_Update_UserName
            // 
            this.lbl_Update_UserName.AutoSize = true;
            this.lbl_Update_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_UserName.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Update_UserName.Location = new System.Drawing.Point(3, 3);
            this.lbl_Update_UserName.Name = "lbl_Update_UserName";
            this.lbl_Update_UserName.Size = new System.Drawing.Size(122, 16);
            this.lbl_Update_UserName.TabIndex = 3;
            this.lbl_Update_UserName.Text = "Update UserName";
            // 
            // btn_Update_UserName
            // 
            this.btn_Update_UserName.Enabled = false;
            this.btn_Update_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_UserName.Location = new System.Drawing.Point(260, 62);
            this.btn_Update_UserName.Name = "btn_Update_UserName";
            this.btn_Update_UserName.Size = new System.Drawing.Size(75, 23);
            this.btn_Update_UserName.TabIndex = 2;
            this.btn_Update_UserName.Text = "Update";
            this.btn_Update_UserName.UseVisualStyleBackColor = true;
            this.btn_Update_UserName.Click += new System.EventHandler(this.btn_Update_UserName_Click);
            // 
            // tbox_AdminUserName
            // 
            this.tbox_AdminUserName.Location = new System.Drawing.Point(149, 36);
            this.tbox_AdminUserName.Name = "tbox_AdminUserName";
            this.tbox_AdminUserName.Size = new System.Drawing.Size(186, 20);
            this.tbox_AdminUserName.TabIndex = 1;
            this.tbox_AdminUserName.TextChanged += new System.EventHandler(this.tbox_AdminUserName_TextChanged);
            // 
            // lbl_AdminUserName
            // 
            this.lbl_AdminUserName.AutoSize = true;
            this.lbl_AdminUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminUserName.Location = new System.Drawing.Point(22, 37);
            this.lbl_AdminUserName.Name = "lbl_AdminUserName";
            this.lbl_AdminUserName.Size = new System.Drawing.Size(125, 16);
            this.lbl_AdminUserName.TabIndex = 0;
            this.lbl_AdminUserName.Text = "New Username : ";
            // 
            // lbl_Update_Password
            // 
            this.lbl_Update_Password.AutoSize = true;
            this.lbl_Update_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_Password.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Update_Password.Location = new System.Drawing.Point(3, 2);
            this.lbl_Update_Password.Name = "lbl_Update_Password";
            this.lbl_Update_Password.Size = new System.Drawing.Size(116, 16);
            this.lbl_Update_Password.TabIndex = 5;
            this.lbl_Update_Password.Text = "Update Password";
            // 
            // tbox_AdminPassword
            // 
            this.tbox_AdminPassword.Location = new System.Drawing.Point(149, 41);
            this.tbox_AdminPassword.Name = "tbox_AdminPassword";
            this.tbox_AdminPassword.PasswordChar = '#';
            this.tbox_AdminPassword.Size = new System.Drawing.Size(186, 20);
            this.tbox_AdminPassword.TabIndex = 3;
            this.tbox_AdminPassword.TextChanged += new System.EventHandler(this.tbox_AdminPassword_TextChanged);
            // 
            // tbox_AdminConfirmPassword
            // 
            this.tbox_AdminConfirmPassword.Location = new System.Drawing.Point(149, 67);
            this.tbox_AdminConfirmPassword.Name = "tbox_AdminConfirmPassword";
            this.tbox_AdminConfirmPassword.PasswordChar = '#';
            this.tbox_AdminConfirmPassword.Size = new System.Drawing.Size(186, 20);
            this.tbox_AdminConfirmPassword.TabIndex = 4;
            this.tbox_AdminConfirmPassword.TextChanged += new System.EventHandler(this.tbox_AdminConfirmPassword_TextChanged);
            // 
            // btn_Update_Password
            // 
            this.btn_Update_Password.Enabled = false;
            this.btn_Update_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Password.Location = new System.Drawing.Point(260, 93);
            this.btn_Update_Password.Name = "btn_Update_Password";
            this.btn_Update_Password.Size = new System.Drawing.Size(75, 23);
            this.btn_Update_Password.TabIndex = 5;
            this.btn_Update_Password.Text = "Update";
            this.btn_Update_Password.UseVisualStyleBackColor = true;
            this.btn_Update_Password.Click += new System.EventHandler(this.btn_Update_Password_Click);
            // 
            // lbl_AdminPasswordStatus
            // 
            this.lbl_AdminPasswordStatus.AutoSize = true;
            this.lbl_AdminPasswordStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_AdminPasswordStatus.Location = new System.Drawing.Point(146, 25);
            this.lbl_AdminPasswordStatus.Name = "lbl_AdminPasswordStatus";
            this.lbl_AdminPasswordStatus.Size = new System.Drawing.Size(0, 13);
            this.lbl_AdminPasswordStatus.TabIndex = 5;
            // 
            // lbl_AdminPassword
            // 
            this.lbl_AdminPassword.AutoSize = true;
            this.lbl_AdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminPassword.Location = new System.Drawing.Point(25, 42);
            this.lbl_AdminPassword.Name = "lbl_AdminPassword";
            this.lbl_AdminPassword.Size = new System.Drawing.Size(122, 16);
            this.lbl_AdminPassword.TabIndex = 5;
            this.lbl_AdminPassword.Text = "New Password : ";
            // 
            // lbl_AdminConfirmPassword
            // 
            this.lbl_AdminConfirmPassword.AutoSize = true;
            this.lbl_AdminConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminConfirmPassword.Location = new System.Drawing.Point(3, 68);
            this.lbl_AdminConfirmPassword.Name = "lbl_AdminConfirmPassword";
            this.lbl_AdminConfirmPassword.Size = new System.Drawing.Size(144, 16);
            this.lbl_AdminConfirmPassword.TabIndex = 5;
            this.lbl_AdminConfirmPassword.Text = "Confirm Password : ";
            // 
            // frm_AdminLoginDetailsChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 237);
            this.Controls.Add(this.spcont_AdminLoginChanger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_AdminLoginDetailsChanger";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Manager";
            this.spcont_AdminLoginChanger.Panel1.ResumeLayout(false);
            this.spcont_AdminLoginChanger.Panel1.PerformLayout();
            this.spcont_AdminLoginChanger.Panel2.ResumeLayout(false);
            this.spcont_AdminLoginChanger.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcont_AdminLoginChanger)).EndInit();
            this.spcont_AdminLoginChanger.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcont_AdminLoginChanger;
        private System.Windows.Forms.Label lbl_Update_UserName;
        private System.Windows.Forms.Button btn_Update_UserName;
        private System.Windows.Forms.TextBox tbox_AdminUserName;
        private System.Windows.Forms.Label lbl_AdminUserName;
        private System.Windows.Forms.Label lbl_AdminUserNameStatus;
        private System.Windows.Forms.Label lbl_Update_Password;
        private System.Windows.Forms.Label lbl_AdminConfirmPassword;
        private System.Windows.Forms.Label lbl_AdminPassword;
        private System.Windows.Forms.Label lbl_AdminPasswordStatus;
        private System.Windows.Forms.Button btn_Update_Password;
        private System.Windows.Forms.TextBox tbox_AdminConfirmPassword;
        private System.Windows.Forms.TextBox tbox_AdminPassword;
    }
}
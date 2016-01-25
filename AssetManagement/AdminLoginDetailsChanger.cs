using AssetManagement.HelperClasses;
using System;
using System.Windows.Forms;

namespace AssetManagement
{
    public partial class frm_AdminLoginDetailsChanger : Form
    {
        #region Constructor

        public frm_AdminLoginDetailsChanger()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Event

        private void tbox_AdminUserName_TextChanged(object sender, EventArgs e)
        {
            if (tbox_AdminUserName.Text.Length > 0)
            {
                if (tbox_AdminUserName.Text == Encrypter.Decrypt(RegManager.getKey("AdminUserName"), true))
                {
                    btn_Update_UserName.Enabled = false;
                    lbl_AdminUserNameStatus.Text = "Same as existing username!!";
                }
                else
                {
                    lbl_AdminUserNameStatus.Text = string.Empty;
                    btn_Update_UserName.Enabled = true;
                }
            }
            else
            {
                lbl_AdminUserNameStatus.Text = string.Empty;
                btn_Update_UserName.Enabled = false;
            }
        }

        private void tbox_AdminPassword_TextChanged(object sender, EventArgs e)
        {
            btnDisaler();
        }

        private void tbox_AdminConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            btnDisaler();
        }

        private void btn_Update_UserName_Click(object sender, EventArgs e)
        {
            RegManager.updateKey("AdminUserName", tbox_AdminUserName.Text);
            lbl_AdminUserNameStatus.Text = "UserName Updated!!";
            tbox_AdminUserName.Text = string.Empty;
            var t = new Timer();
            t.Interval = 2000; // it will Tick in 2 seconds
            t.Tick += (s, evt) =>
            {
                lbl_AdminUserNameStatus.Text = string.Empty;
                t.Stop();
                t = null;
            };
            t.Start();
        }

        private void btn_Update_Password_Click(object sender, EventArgs e)
        {
            RegManager.updateKey("AdminPassword", tbox_AdminConfirmPassword.Text);
            tbox_AdminPassword.Text = string.Empty;
            tbox_AdminConfirmPassword.Text = string.Empty;
            lbl_AdminPasswordStatus.Text = "Password Updated!!";
            var t = new Timer();
            t.Interval = 2000; // it will Tick in 2 seconds
            t.Tick += (s, evt) =>
            {
                lbl_AdminPasswordStatus.Text = string.Empty;
                t.Stop();
                t = null;
            };
            t.Start();
        }

        #endregion Event

        #region Function

        private void btnDisaler()
        {
            if (tbox_AdminPassword.Text.Length > 0 && tbox_AdminConfirmPassword.Text.Length > 0)
            {
                if (tbox_AdminPassword.Text == tbox_AdminConfirmPassword.Text)
                {
                    if (tbox_AdminPassword.Text == Encrypter.Decrypt(RegManager.getKey("AdminPassword"), true) && tbox_AdminConfirmPassword.Text == Encrypter.Decrypt(RegManager.getKey("AdminPassword"), true))
                    {
                        btn_Update_Password.Enabled = false;
                        lbl_AdminPasswordStatus.Text = "Same as existing password!!";
                    }
                    else
                    {
                        lbl_AdminPasswordStatus.Text = string.Empty;
                        btn_Update_Password.Enabled = true;
                    }
                }
                else
                {
                    btn_Update_Password.Enabled = false;
                    lbl_AdminPasswordStatus.Text = "Password Mismatch!!";
                }
            }
            else
            {
                lbl_AdminPasswordStatus.Text = string.Empty;
                btn_Update_Password.Enabled = false;
            }
        }

        #endregion Function
    }
}
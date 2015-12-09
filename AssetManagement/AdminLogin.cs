using System;
using System.Windows.Forms;

namespace AssetManagement
{
    public partial class frm_AdminLogin : Form
    {
        #region constructor

        public frm_AdminLogin()
        {
            InitializeComponent();
        }

        #endregion constructor

        #region event

        private void btn_AdminLogin_Cancel_Click(object sender, EventArgs e)
        {
            frm_Main.addminLoginAllowed = false;
            this.Dispose();
        }

        private void btn_AdminLogin_Login_Click(object sender, EventArgs e)
        {
            if (tbox_AdminLogin_Id.Text == Encrypter.Decrypt(RegManager.getKey("AdminUserName"), true) && tbox_AdminLogin_Password.Text == Encrypter.Decrypt(RegManager.getKey("AdminPassword"), true))
            {
                frm_Main.addminLoginAllowed = true;
                this.Dispose();
            }
            else
            {
                frm_Main.addminLoginAllowed = false;
                MessageBox.Show("Username Or Password wrong!", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbox_AdminLogin_Id_TextChanged(object sender, EventArgs e)
        {
            if (tbox_AdminLogin_Id.Text.Length > 0 && tbox_AdminLogin_Password.Text.Length > 0)
            {
                btn_AdminLogin_Login.Enabled = true;
            }
            else
            {
                btn_AdminLogin_Login.Enabled = false;
            }
        }

        private void tbox_AdminLogin_Password_TextChanged(object sender, EventArgs e)
        {
            if (tbox_AdminLogin_Id.Text.Length > 0 && tbox_AdminLogin_Password.Text.Length > 0)
            {
                btn_AdminLogin_Login.Enabled = true;
            }
            else
            {
                btn_AdminLogin_Login.Enabled = false;
            }
        }

        #endregion event
    }
}
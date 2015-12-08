using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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

        #endregion

        #region event

        private void btn_AdminLogin_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_AdminLogin_Login_Click(object sender, EventArgs e)
        {

        }

        private void tbox_AdminLogin_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbox_AdminLogin_Password_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        
    
    }
}

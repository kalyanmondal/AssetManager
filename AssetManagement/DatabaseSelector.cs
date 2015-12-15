using System;
using System.Windows.Forms;

namespace AssetManagement
{
    public partial class frm_DatabaseSelector : Form
    {
        private int p;

        #region Constructor

        public frm_DatabaseSelector()
        {
            InitializeComponent();
        }

        public frm_DatabaseSelector(int p)
        {
            this.p = p;
            this.ControlBox = true;
        }

        #endregion Constructor

        #region Events

        private void btn_Browse_Database_Click(object sender, EventArgs e)
        {
            dlg_OpenFile_Database_Selector.Title = "Select the database";
            dlg_OpenFile_Database_Selector.Filter = "Access-2007 (*.accdb)|*.accdb|Access-2003 (*.mdb)|*.mdb|All files (*.*)|*.*";
            dlg_OpenFile_Database_Selector.ShowDialog();
            tbox_Select_The_Database.Text = dlg_OpenFile_Database_Selector.FileName.ToString();
        }

        private void btn_Ok_Database_Click(object sender, EventArgs e)
        {
            if (tbox_Select_The_Database.Text.Length > 0)
            {
                RegManager.updateKey("data source", tbox_Select_The_Database.Text);
                this.Dispose();
            }
            else
            {
                if (p != 1)
                {
                    MessageBox.Show("Please select the file.\nThis is one time process.", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Please select the file.", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void tbox_Select_The_Database_TextChanged(object sender, EventArgs e)
        {
            if (tbox_Select_The_Database.Text.Length > 0)
            {
                tbox_Select_The_Database.Enabled = false;
            }
            else
            {
                tbox_Select_The_Database.Enabled = true;
            }
        }

        #endregion Events
    }
}
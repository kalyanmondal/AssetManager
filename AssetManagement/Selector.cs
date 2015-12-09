using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AssetManagement
{
    public partial class frm_Selector : Form
    {
        #region constructor

        public frm_Selector(DataSet ds)
        {
            InitializeComponent();
            dtGrVw_Selector.DataSource = ds.Tables[0];
            frm_Main.serialNumber = null;
            sizesetter();
        }

        #endregion constructor

        #region Function

        public void sizesetter()
        {
            this.Size = new Size(dtGrVw_Selector.Width + 35, dtGrVw_Selector.Height + 70);
        }

        #endregion Function

        #region Event

        private void dtGrVw_Selector_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                dtGrVw_Selector.Rows[e.RowIndex].ReadOnly = true;
                if (dtGrVw_Selector.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    dtGrVw_Selector.Rows[e.RowIndex].ReadOnly = false;
                }
                dtGrVw_Selector.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dtGrVw_Selector_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                dtGrVw_Selector.Rows[e.RowIndex].ReadOnly = true;
                if (dtGrVw_Selector.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    dtGrVw_Selector.Rows[e.RowIndex].ReadOnly = false;
                }
                dtGrVw_Selector.Rows[e.RowIndex].Selected = true;
                frm_Main.serialNumber = dtGrVw_Selector.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.Dispose();
            }
        }

        #endregion Event
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement
{
    public partial class frm_SheetSelector : Form
    {
        #region Private Variable

            private List<string> sheetToPopulate;

        #endregion

        #region constructor

            public frm_SheetSelector(List<string> pSheetToPopulate)
            {
                InitializeComponent();
                this.sheetToPopulate = pSheetToPopulate;
                populateData(sheetToPopulate);
            }

        #endregion

        #region Function

            private void populateData(List<string> sheetToPopulate)
            {
                foreach(string data in sheetToPopulate)
                {
                    cbox_SheetSelect.Items.Add(data);
                }
            }

        #endregion

        #region Event

            private void cbox_SheetSelect_SelectedIndexChanged(object sender, EventArgs e)
            {
                frm_Main.sheetName = cbox_SheetSelect.SelectedItem.ToString();
                this.Dispose();
            }

        #endregion
    }
}

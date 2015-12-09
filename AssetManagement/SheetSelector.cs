using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AssetManagement
{
    public partial class frm_SheetSelector : Form
    {
        #region Private Variable

        private List<string> sheetToPopulate;

        #endregion Private Variable

        #region constructor

        public frm_SheetSelector(List<string> pSheetToPopulate)
        {
            InitializeComponent();
            this.sheetToPopulate = pSheetToPopulate;
            populateData(sheetToPopulate);
        }

        #endregion constructor

        #region Function

        private void populateData(List<string> sheetToPopulate)
        {
            foreach (string data in sheetToPopulate)
            {
                cbox_SheetSelect.Items.Add(data);
            }
        }

        #endregion Function

        #region Event

        private void cbox_SheetSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            frm_Main.sheetName = cbox_SheetSelect.SelectedItem.ToString();
            this.Dispose();
        }

        #endregion Event
    }
}
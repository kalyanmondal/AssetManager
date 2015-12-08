using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement
{
    public static class autoComplete
    {
        public static void autocompletedata(ref System.Windows.Forms.TextBox textControl, int from)
        {
            con = new OleDbConnection(@" provider=" + ConfigurationManager.AppSettings.Get("provider") + "; data source=" + ConfigurationManager.AppSettings.Get("data source"));
            var source = new AutoCompleteStringCollection();
            string strQuery = string.Empty;
            if (from == 0)
            {
                strQuery = "select Employee_Id from tbl_Employee_Details where Employee_Id LIKE '%" + textControl.Text + "%'";
            }
            if (from == 1)
            {
                strQuery = "select Employee_Name from tbl_Employee_Details where Employee_Name LIKE '%" + textControl.Text + "%'";
            }
            if (from == 2)
            {
                strQuery = "select Employee_Email from tbl_Employee_Details where Employee_Email LIKE '%" + textControl.Text + "%'";
            }
            if (from == 3)
            {
                strQuery = "select Extension from tbl_Employee_Details where Extension LIKE '%" + textControl.Text + "%'";
            }
            try
            {
                using (con)
                {
                    OleDbCommand query = new OleDbCommand(strQuery, con);
                    con.Open();
                    OleDbDataReader dr = query.ExecuteReader();
                    while (dr.Read())
                    {
                        source.Add(dr[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to the database failed", "Asset Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textControl.AutoCompleteCustomSource = source;
        }
    }
}

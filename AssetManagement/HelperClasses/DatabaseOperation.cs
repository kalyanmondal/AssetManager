using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.HelperClasses
{
    public static class DatabaseOperation
    {
        private static OleDbConnection con;
        private static OleDbCommand cmd;

        public static int updateData(string query)
        {
            try
            {
                con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
                cmd = new OleDbCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                con.Close();
                return n;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Failed due to : " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public static int insertDetails(string query)
        {
            try
            {
                con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
                cmd = new OleDbCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                con.Close();
                return n;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Failed due to : " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

    }
}

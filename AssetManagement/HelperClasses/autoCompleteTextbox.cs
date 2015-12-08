﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement
{
    public static class autoCompleteTextbox
    {
        static OleDbConnection con;
        public static void autocompletedata(ref System.Windows.Forms.TextBox textControl, string columnName, string tableName)
        {
            con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
            var source = new AutoCompleteStringCollection();
            string strQuery = string.Empty;
            strQuery = "SELECT " + columnName + " FROM " + tableName + " WHERE " + columnName + " LIKE '%" + textControl.Text + "%'";
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
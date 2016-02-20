using System;
using System.Windows.Forms;

namespace AssetManagement.HelperClasses
{
    public static class autoCompleteTextbox
    {

        public static void autoCompleteData(ref TextBox textControl, string columnName, string tableName)
        {
            var source = new AutoCompleteStringCollection();
            string strQuery = string.Empty;
            strQuery = "SELECT " + columnName + " FROM " + tableName + " WHERE " + columnName + " LIKE '%" + textControl.Text + "%'";
            source.AddRange(DatabaseOperation.selectData(strQuery).ToArray());
            textControl.AutoCompleteCustomSource = source;
        }

        public static void autoCompleteData(ref TextBox textControl, string columnName, string tableName, string secondFilterColumn, string Operator, string secondFilterConition)
        {
            var source = new AutoCompleteStringCollection();
            string strQuery = string.Empty;
            strQuery = "SELECT " + columnName + " FROM " + tableName + " WHERE " + columnName + " LIKE '%" + textControl.Text + "%' AND " + secondFilterColumn + Operator + secondFilterConition;
            source.AddRange(DatabaseOperation.selectData(strQuery).ToArray());
            textControl.AutoCompleteCustomSource = source;
        }

        public static bool autocompletedataValidator(ref TextBox textControl, string columnName, string tableName)
        {
            string strQuery = string.Empty;
            strQuery = "SELECT " + columnName + " FROM " + tableName + " WHERE " + columnName + " LIKE '%" + textControl.Text + "%'";
            if (DatabaseOperation.selectData(strQuery).Contains(textControl.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool autocompletedataValidator(ref TextBox textControl, string columnName, string tableName, string secondFilterColumn, string Operator, string secondFilterConition)
        {
            string strQuery = string.Empty;
            strQuery = "SELECT " + columnName + " FROM " + tableName + " WHERE " + columnName + " LIKE '%" + textControl.Text + "%' AND " + secondFilterColumn + Operator + secondFilterConition;
            if (DatabaseOperation.selectData(strQuery).Contains(textControl.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
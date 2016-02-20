using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing.Imaging;
using System.IO;
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
        private static MemoryStream ms;

        /// <summary>
        /// Updates the data.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Inserts the details.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Inserts the details with single picture.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="imageBox">The image box.</param>
        /// <param name="queryParameterName">Name of the query parameter.</param>
        /// <returns></returns>
        public static int insertDetailsWithSinglePicture(string query, ref PictureBox imageBox, string queryParameterName)
        {
            try
            {
                con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
                cmd = new OleDbCommand(query, con);
                convertPhotoType(ref imageBox, queryParameterName);
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

        /// <summary>
        /// Inserts the details with double picture.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="imageBox">The image box.</param>
        /// <param name="queryParameterName">Name of the query parameter.</param>
        /// <param name="imageBoxSecond">The image box second.</param>
        /// <param name="queryParameterNameSecond">The query parameter name second.</param>
        /// <returns></returns>
        public static int insertDetailsWithDoublePicture(string query, ref PictureBox imageBox, string queryParameterName, ref PictureBox imageBoxSecond, string queryParameterNameSecond)
        {
            try
            {
                con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
                cmd = new OleDbCommand(query, con);
                convertPhotoType(ref imageBox, queryParameterName);
                convertPhotoType(ref imageBoxSecond, queryParameterNameSecond);
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

        /// <summary>
        /// Inserts the details with transaction and single picture.
        /// </summary>
        /// <param name="firstQuery">The first query.</param>
        /// <param name="secondQuery">The second query.</param>
        /// <param name="imageBox">The image box.</param>
        /// <param name="queryParameterName">Name of the query parameter.</param>
        /// <returns></returns>
        public static int insertDetailsWithTransactionAndSinglePicture(string firstQuery, string secondQuery, ref PictureBox imageBox, string queryParameterName)
        {
            con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
            con.Open();
            OleDbTransaction transaction = con.BeginTransaction();
            try
            {
                cmd = new OleDbCommand(firstQuery, con,transaction);
                convertPhotoType(ref imageBox, queryParameterName);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand(secondQuery, con, transaction);
                cmd.ExecuteNonQuery();
                transaction.Commit();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Failed due to : " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transaction.Rollback();
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// Converts the type of the photo.
        /// </summary>
        /// <param name="imageBox">The image box.</param>
        /// <param name="queryParameterName">Name of the query parameter.</param>
        private static void convertPhotoType(ref PictureBox imageBox, string queryParameterName)
        {
            if (imageBox.Image != null)
            {
                ms = new MemoryStream();
                imageBox.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue(queryParameterName, photo_aray);
            }
        }

        /// <summary>
        /// Selects the data.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        public static List<string> selectData(string query)
        {
            List<string> result = new List<string>();
            try
            {
                con = new OleDbConnection(@" provider=" + Encrypter.Decrypt(RegManager.getKey("provider"), true) + "; data source=" + Encrypter.Decrypt(RegManager.getKey("data source"), true));
                cmd = new OleDbCommand(query, con);
                con.Open();
                OleDbDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    result.Add(data[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Failed due to : " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
    }
}

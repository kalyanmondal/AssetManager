using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AssetManagement
{
    internal class ExcelUtlity
    {
        public bool WriteDataTableToExcel(System.Data.DataTable dataTable, string worksheetName, string saveAsLocation, string ReporType, int from)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;
            try
            {
                // Start Excel and get Application object.
                excel = new Microsoft.Office.Interop.Excel.Application();

                // for making Excel visible
                excel.Visible = false;
                excel.DisplayAlerts = false;

                // Creation a new Workbook
                excelworkBook = excel.Workbooks.Add(Type.Missing);

                // Workk sheet
                excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.Worksheets[1];
                excelSheet.Delete();
                excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.Worksheets[2];
                excelSheet.Delete();
                excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
                excelSheet.Name = worksheetName;
                excelSheet.Cells[1, 1] = ReporType;
                excelSheet.Cells[1, 2] = "Extracted Date : " + DateTime.Now.ToShortDateString();

                // loop through each row and add values to our sheet
                int rowcount = 2;

                foreach (DataRow datarow in dataTable.Rows)
                {
                    rowcount += 1;
                    for (int i = 1; i <= dataTable.Columns.Count; i++)
                    {
                        // on the first iteration we add the column headers
                        if (rowcount == 3)
                        {
                            excelSheet.Cells[2, i] = dataTable.Columns[i - 1].ColumnName;
                            excelSheet.Cells.Font.Color = System.Drawing.Color.Black;
                        }
                        excelSheet.Cells[rowcount, i] = datarow[i - 1].ToString();
                        //Time
                        if ((from == 3 && i == 10) || (from == 3 && i == 13) || (from == 4 && i == 10) || (from == 4 && i == 13) || (from == 5 && i == 10) || (from == 5 && i == 13) || (from == 6 && i == 10) || (from == 6 && i == 13) || (from == 7 && i == 10) || (from == 7 && i == 13))
                        {
                            excelSheet.Cells[rowcount, i] = datarow[i - 1].ToString().Substring(datarow[i - 1].ToString().IndexOf(" ") + 1);
                        }
                        //Date
                        if ((from == 3 && i == 6) || (from == 3 && i == 12) || (from == 4 && i == 6) || (from == 4 && i == 12) || (from == 5 && i == 6) || (from == 5 && i == 12) || (from == 6 && i == 6) || (from == 6 && i == 12) || (from == 7 && i == 6) || (from == 7 && i == 12) || (from == 8 && i == 7) || (from == 9 && i == 7) || (from == 10 && i == 7) || (from == 11 && i == 7) || (from == 12 && i == 7))
                        {
                            excelSheet.Cells[rowcount, i] = datarow[i - 1].ToString().Substring(0, datarow[i - 1].ToString().IndexOf(" "));
                            excelSheet.Cells[rowcount, i].NumberFormat = "dd-MMMM-yyyy;@";
                        }

                        //for alternate rows
                        if (rowcount > 3)
                        {
                            if (i == dataTable.Columns.Count)
                            {
                                if (rowcount % 2 == 0)
                                {
                                    excelCellrange = excelSheet.Range[excelSheet.Cells[rowcount, 1], excelSheet.Cells[rowcount, dataTable.Columns.Count]];
                                    FormattingExcelCells(excelCellrange, "#CCCCFF", System.Drawing.Color.Black, false);
                                }
                            }
                        }
                    }
                }

                // now we resize the columns
                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[rowcount, dataTable.Columns.Count]];
                excelCellrange.EntireColumn.AutoFit();
                Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;

                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[2, dataTable.Columns.Count]];
                FormattingExcelCells(excelCellrange, "#000099", System.Drawing.Color.White, true);

                //now save the workbook and exit Excel

                excelworkBook.SaveAs(saveAsLocation); ;
                excelworkBook.Close();
                excel.Quit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                excelSheet = null;
                excelCellrange = null;
                excelworkBook = null;
            }
        }

        public void FormattingExcelCells(Microsoft.Office.Interop.Excel.Range range, string HTMLcolorCode, System.Drawing.Color fontColor, bool IsFontbool)
        {
            range.Interior.Color = System.Drawing.ColorTranslator.FromHtml(HTMLcolorCode);
            range.Font.Color = System.Drawing.ColorTranslator.ToOle(fontColor);
            if (IsFontbool == true)
            {
                range.Font.Bold = IsFontbool;
            }
        }

        public int noOfRowsCounter(string workWokbookName, string workSheetName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            object misValue = System.Reflection.Missing.Value;
            try
            {
                int noOfRows = 0;
                excel = new Microsoft.Office.Interop.Excel.Application();
                excelworkBook = excel.Workbooks.Open(workWokbookName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.Sheets[workSheetName];
                noOfRows = excelSheet.Rows.CurrentRegion.EntireRow.Count;
                excelworkBook.Close(true, misValue, misValue);
                excel.Quit();
                return noOfRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                excelSheet = null;
                excelworkBook = null;
            }
        }

        public int noOfSheetCounter(string workWokbookName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            try
            {
                int count = 0;
                object misValue = System.Reflection.Missing.Value;
                excel = new Microsoft.Office.Interop.Excel.Application();
                excelworkBook = excel.Workbooks.Open(workWokbookName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                foreach (Worksheet worksheet in excelworkBook.Worksheets)
                {
                    count++;
                }

                excelworkBook.Close(true, misValue, misValue);
                excel.Quit();
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                excelworkBook = null;
            }
        }

        public List<string> sheetNames(string workWokbookName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            object misValue = System.Reflection.Missing.Value;
            List<string> sheets = new List<string>();
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excelworkBook = excel.Workbooks.Open(workWokbookName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                foreach (Worksheet worksheet in excelworkBook.Worksheets)
                {
                    sheets.Add(worksheet.Name);
                }

                excelworkBook.Close(true, misValue, misValue);
                excel.Quit();
                return sheets;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return sheets;
            }
            finally
            {
                excelworkBook = null;
            }
        }
    }
}
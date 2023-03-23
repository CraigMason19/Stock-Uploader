using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Craig_Excel
{
    class Cell
    {
        #region Data

        public string Column { get; set; } = "A";
        public int Row { get; set; } = 1;

        #endregion

        #region Constructors

        public Cell()
        {

        }

        public Cell(string s)
        {
            // Excel style indexes, e.g, "B7"
            string[] indexes = Regex.Split(s, @"(?<=[a-zA-Z])(?=\d)");
            Column = indexes[0];
            Row = Int32.Parse(indexes[1]);
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return Column + Row.ToString();
        }

        #endregion
    }

    class ExcelFile
    {
        #region Data

        string Sheetname;
        OleDbConnection Connection;

        public int Rows { get; protected set; } = 0;
        public int Columns { get; protected set; } = 0;

        #endregion

        #region Constructors

        public ExcelFile()
        {

        }

        ~ExcelFile()
        {

        }

        #endregion

        #region Methods

        public void Open(string path)
        {
            try
            {
                // For 2003 .xls files
                string connString = "Provider=Microsoft.Jet.OleDb.4.0; data source=" + path + "; Extended Properties=\"Excel 8.0;HDR=No\";";
                Connection = new OleDbConnection(connString);
                Connection.Open();

                // No need to worry about Workbooks (multiple sheets) as the stock report only has one spreadsheet.
                DataTable dt = Connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                Sheetname = dt.Rows[0]["TABLE_NAME"].ToString();
                Sheetname = Sheetname.Replace("$", "");
                Sheetname = Sheetname.Replace("'", "");

                // Load all
                string query = "SELECT * FROM [" + Sheetname + "$]";
                dt = new DataTable();
                using (var da = new OleDbDataAdapter(query, Connection))
                {
                    da.Fill(dt);
                }

                Rows = dt.Rows.Count;
                Columns = dt.Columns.Count;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Close()
        {
            Connection.Close();
        }

        // Datatable is in [row, column]
        public string ReadCell(string cell)
        {
            Cell tmp = new Cell(cell);
            tmp.Row += 1;

            string query = "SELECT * FROM [" + Sheetname + "$" + cell + ":" + tmp.ToString() + "]";
            DataTable dt = new DataTable();
            using (var da = new OleDbDataAdapter(query, Connection))
            {
                da.Fill(dt);
            }

            return dt.Rows[0][0].ToString();
        }

        // Between cellStart and cellEnd inclusive, datatable is in [row, column]
        public List<string> ReadColumn(string cellStart, string cellEnd)
        {
            string query = "SELECT * FROM [" + Sheetname + "$" + cellStart + ":" + cellEnd + "]";
            DataTable dt = new DataTable();
            using (var da = new OleDbDataAdapter(query, Connection))
            {
                da.Fill(dt);
            }

            List<string> l = new List<string>();
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                l.Add(dt.Rows[x][0].ToString());
            }

            return l;
        }

        #endregion
    }
}

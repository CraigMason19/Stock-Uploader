using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Craig_Excel;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        #region Data

        List<Product> ActinicProducts;
        List<Product> SageProducts;
        List<Product> UpdatedProducts;

        #endregion

        #region FormConstructor

        public Form1()
        {
            // Form stuff
            InitializeComponent();
            ActinicPictureBox.AllowDrop = true;
            SagePictureBox.AllowDrop = true;

            // Program stuff
            ActinicProducts = new List<Product>();
            SageProducts = new List<Product>();
            UpdatedProducts = new List<Product>();
        }

        #endregion

        #region Methods

        private void ActinicPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ActinicPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                bool LoadedOk = false;
                ActinicProducts.Clear();

                try
                {
                    string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
                    FileInfo info = new FileInfo(filenames[0]);
                    
                    // File is .csv when exporting from the website. No need to support other formats.
                    string extension = info.Extension;
                    if (info.Extension == ".csv")
                    {
                        LoadedOk = true;
                    }

                    if (LoadedOk == false)
                    {
                        ActinicTextBox.Text = "Inappropriate file format " + info.Extension;
                        ActinicPictureBox.Image = null;
                        ActinicProducts.Clear();
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(filenames[0]);
                        sr.ReadLine(); // First row is the header file of the .csv

                        using (sr)
                        {
                            while (!sr.EndOfStream)
                            {
                                // Remove all quotation marks, then split at the comma (.csv files) 
                                string line = sr.ReadLine().Replace("\"", "");
                                string[] product_string = line.Split(',');
                                ActinicProducts.Add(new Product(product_string[0], product_string[1]));
                            }
                        }

                        ActinicTextBox.Text = "Imported:\n" + (ActinicProducts.Count).ToString() + " products";
                        ActinicPictureBox.Image = Properties.Resources.CSV;
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                    ActinicTextBox.Text = "";
                    ActinicPictureBox.Image = null;
                }
            }
        }

        private void SagePictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void SagePictureBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                bool LoadedOk = false;
                SageProducts.Clear();

                try
                {
                    string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
                    FileInfo info = new FileInfo(filenames[0]);

                    // Not currently supporting .xlsx files (2007)
                    string extension = info.Extension;
                    if (info.Extension == ".xls")
                    {
                        LoadedOk = true;
                    }
                    if (LoadedOk == false)
                    {
                        SageTextBox.Text = "Inappropriate file format " + info.Extension;
                        SagePictureBox.Image = null;
                        SageProducts.Clear();
                    }
                    else
                    {
                        // Load
                        ExcelFile xlFile = new ExcelFile();
                        xlFile.Open(filenames[0]);

                        // Last row is not data
                        string rows = (xlFile.Rows - 1).ToString(); 

                        List<string> xlProductCode = xlFile.ReadColumn("B7", "B" + rows);
                        List<string> xlProductStock = xlFile.ReadColumn("K7", "K" + rows);

                        xlFile.Close();

                        for (int x = 0; x < xlProductCode.Count; x++)
                        {
                            //string[] tmp = new string[] { "", xlProductCode[x], xlProductStock[x] };
                            SageProducts.Add(new Product(xlProductCode[x], xlProductStock[x]));
                        }

                        SageTextBox.Text = "Imported:\n" + xlProductCode.Count.ToString() + " Products";
                        SagePictureBox.Image = Properties.Resources.Excel;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                    SageTextBox.Text = "";
                    SagePictureBox.Image = null;
                }
            }
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            if (SageProducts.Count == 0 || ActinicProducts.Count == 0)
            {
                UpdatedProductsGrid.DataSource = null;
                TextBox.Text = "";
                SaveButton.Enabled = false;
                return;
            }
            try
            {
                UpdatedProducts.Clear();
                UpdatedProducts = (from a in ActinicProducts
                                   join s in SageProducts on a.Code equals s.Code
                                   select new Product(a.Code, s.Stock)).ToList();
                UpdatedProducts.Sort();

                UpdatedProductsGrid.AutoResizeColumns();
                UpdatedProductsGrid.DataSource = UpdatedProducts;
                UpdatedProductsGrid.AutoSize = false;

                TextBox.Text = UpdatedProducts.Count + " records to be updated";
                SaveButton.Enabled = true;
            }
            catch (Exception ex)
            {
                TextBox.Text = ex.ToString();
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +  "\\Updated Stock Levels.csv";

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Product Code,Stock");
                UpdatedProducts.ForEach(p => sw.WriteLine(p.ToString()));
            }
        }

        #endregion
    }
}

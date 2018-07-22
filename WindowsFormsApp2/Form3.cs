using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        string _connectionString = $"Server={Properties.Settings.Default.Server};Initial Catalog={Properties.Settings.Default.Database};Persist Security Info=False;User ID={Properties.Settings.Default.UserName};Password={Properties.Settings.Default.Password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private string[] loadedInput = null;
        public Form3()
        {
            InitializeComponent();

            

        }

        private void BrowseImportFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                ImportPath.Text = openFileDialog.FileName;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Parsing the text file
            string path = ImportPath.Text;
            DataTable tbl = new DataTable();
            string[] lines = File.ReadAllLines(path);
            DataTable dt = new DataTable();
            using (System.IO.TextReader tr = File.OpenText(path))
            {
                string line,s;
                //add new list of string arrey
                List<string[]> lststr = new List<string[]>();
                while ((line = tr.ReadLine()) != null)
                {
                    s = line.Replace("\",\"", "|").Replace("\"", null);

                    string[] items = s.Trim().Split('|');
                    lststr.Add(items);
                }
                int col = lststr.Max(x => x.Length);


                dt.Columns.Add("EnrolmentNo", typeof(string));
                dt.Columns.Add("ReceiptNo", typeof(string));
                dt.Columns.Add("VendorTag", typeof(string));
                dt.Columns.Add("VendorNo", typeof(string));
                dt.Columns.Add("VendorName", typeof(string));
                dt.Columns.Add("ReceiptDate", typeof(string));
                dt.Columns.Add("ItemNo", typeof(string));
                dt.Columns.Add("Desciption", typeof(string));
                dt.Columns.Add("ReceivedQty", typeof(string));

                // loop the list 
                string RNo = null;
                string CType = null;
                string qty = null;
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {

                    try
                    {
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                        foreach (string[] item in lststr)
                        { 
                            if ((item.Length) != 9)
                            {
                            MessageBox.Show("Invalid File Format");
                            return;
                            }
                        dt.Rows.Add(item);
                        RNo = item[2];
                        CType = item[6];
                        qty = item[8];
                        //push content to the database
                        //check if the record exists
                        String q = "SELECT COUNT(ID) FROM [dbo].[Receipts] WHERE ReceiptNo ='"+RNo+"'AND ItemNo ='"+CType+"'AND ReceivedQty='" + qty+"'";
                        using (SqlCommand cmd = new SqlCommand(q, conn))
                        {
                            try
                            {
                                if( (int)cmd.ExecuteScalar()>0)
                                    {
                                    continue;
                                }
                            }
                            catch (Exception ex)
                            {
                                throw new Exception(ex.Message);
                            }

                            
                        }
                        //insert the record
                         String q2 = "INSERT INTO [dbo].[Receipts] (EnrolmentNo,VendorTag, ReceiptNo, VendorNo,VendorName,ReceiptDate,ItemNo,Description,ReceivedQty,ImportTime,UserID)" +
                                    " VALUES ('"+item[0]+"','"
                                               +item[1]+"','"
                                               +item[2]+"','"
                                               +item[3]+"','"
                                               +item[4]+"','"
                                               +item[5]+"','"
                                               +item[6]+"','"
                                               +item[7]+"','"
                                               +item[8]+"','"
                                               +DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','"
                                               +Environment.UserName
                                               +"')";
                          using (SqlCommand cmd = new SqlCommand(q2, conn))
                          {
                            try
                            {
                               cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                throw new Exception(ex.Message);
                            }
                            
                          }
                    }
                    conn.Close();
                }

            }
            //show it in gridview 
            this.dataGridView1.DataSource = dt;
        }
    }
}

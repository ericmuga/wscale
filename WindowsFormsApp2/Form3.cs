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

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
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
                dt.Columns.Add("VendorNo", typeof(string));
                dt.Columns.Add("VendorName", typeof(string));
                dt.Columns.Add("ReceiptDate", typeof(string));
                dt.Columns.Add("ItemNo", typeof(string));
                dt.Columns.Add("Desciption", typeof(string));
                dt.Columns.Add("ReceivedQty", typeof(string));
               
                // loop the list 
                foreach (string[] item in lststr)
                { 
                    if ((item.Length) != 8) {
                        MessageBox.Show("Invalid File Format");
                        return;
                    }
                    dt.Rows.Add(item);
                }


            }
            //show it in gridview 
            this.dataGridView1.DataSource = dt;
            //this.dataGridView1.DataBind();




            /*
            string[] data_col = null;
            string s = null;

            foreach (string line in lines)

            {
               s=line.Replace("\",\"", "|").Replace("\"",null);
                
               data_col = s.Split('|');
                //MessageBox.Show(line.Replace("\",\"", "|").Replace("\"", null));
                //MessageBox.Show(dataGridView1.Columns[0].Name);
                //return;


                dataGridView1.Rows.Add(line);

            }
            //Console.ReadLine();
            dataGridView1.DataSource = tbl;
            */
        }

    }
}

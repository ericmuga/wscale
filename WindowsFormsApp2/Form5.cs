using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        string _connectionString = $"Server={Properties.Settings.Default.Server};Initial Catalog={Properties.Settings.Default.Database};Persist Security Info=False;User ID={Properties.Settings.Default.UserName};Password={Properties.Settings.Default.Password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_fcl_weighDataSet4.SlaughterData' table. You can move, or remove it, as needed.
            this.slaughterDataTableAdapter.Fill(this._fcl_weighDataSet4.SlaughterData);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.slaughterDataTableAdapter.FillBy(this._fcl_weighDataSet4.SlaughterData);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void SlaughterDate_ValueChanged(object sender, EventArgs e)
        {
            SlaughterDate.Format = DateTimePickerFormat.Custom;
            SlaughterDate.CustomFormat = "yyyy-MM-dd";

            DateTime endDate = Convert.ToDateTime(this.SlaughterDate.Text);
            endDate=endDate.AddDays(1);

            //MessageBox.Show(SlaughterDate.Text + "|" + endDate.ToString());
            

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {

                try
                {

                    conn.Open();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }

                String q = "SELECT SlaughterTime,ReceiptNo,ItemNo,StockWeight,MeatPercent,[Classification Code] FROM [dbo].[SlaughterData] where " +
                            "SlaughterTime >='" + SlaughterDate.Text + "'"
                            + " AND  SlaughterTime<'" + endDate + "'";

                var table = new DataTable();
                using (var da = new SqlDataAdapter(q, _connectionString))
                    {
                        try
                        {
                            da.Fill(table);
                        }
                        catch ( Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }
               
                conn.Close();

                this.dataGridView1.DataSource = table;

            }
            //MessageBox.Show(SlaughterDate.Text+" 00:00:00.000");
        }

        private void ExportTextFile_Click(object sender, EventArgs e)
        {
            string path = "",refine="";

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path=saveFileDialog.FileName;

            
            refine = (path + DateTime.Now.ToString("yyyy-MM-dd") + ".txt");

            TextWriter writer = new StreamWriter(refine);

            string input = ""; ; int index=0;
            string date,time="";
            DateTime sd;
            for (int i=0; i<dataGridView1.Rows.Count-1;i++)
            {
                for(int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    input = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        //truncate the weight and meat percent
                        input.Replace(@"G0110", @"G0101");
                        input.Replace(@"G0111", @"G0102");
                        input.Replace(@"G0113", @"G0104");
                   if (j == 0)
                    {

                        time = Convert.ToDateTime(input).ToString("HH:mm");
                        date = Convert.ToDateTime(input).ToString("dd-MM-yyyy");
                        input = date + "|" + time;
                    }
                    if (j==1)
                    {
                        input = input.Replace(" ", "");
                            input.Replace(@"G0110", @"G0101");
                            input.Replace(@"G0111", @"G0102");
                            input.Replace(@"G0113", @"G0104");
                        }

                    if (j == 3 || j == 4)
                    {
                        input = input.Remove(input.LastIndexOf(".") + 1).Replace(".", "");
                    }
                    
                  // if (j!=5)
                   writer.Write(input+"|");
                }
                writer.WriteLine("");

            }
            writer.Close();
            MessageBox.Show("Data Exported Successfully");
        }
        else
            { 
                MessageBox.Show("Invalid Export Location");
            }
        }



        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.slaughterDataTableAdapter.FillBy1(this._fcl_weighDataSet4.SlaughterData);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            string path = "", refine = "";

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = saveFileDialog.FileName;

                refine = (path + DateTime.Now.ToString("yyyy-MM-dd") + ".csv");

                TextWriter writer = new StreamWriter(refine);

                string input = ""; ; int index = 0;
                string date, time = "";
                //DateTime sd;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        input = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        //truncate the weight and meat percent
                        input.Replace(@"G0110", @"G0101");
                        input.Replace(@"G0111", @"G0102");
                        input.Replace(@"G0113", @"G0104");
                        if (j == 0)
                        {
                            time = Convert.ToDateTime(input).ToString("HH:mm");
                            date = Convert.ToDateTime(input).ToString("dd-MM-yyyy");
                            input = date + "," + time;
                        }
                        if (j == 1)
                        {
                            input = input.Replace(" ", "");
                            
                        }

                        if (j == 3 || j == 4)
                        {
                            input = input.Remove(input.LastIndexOf(".") + 1).Replace(".", "");
                        }

                        //if (j != 4)
                            writer.Write(input + ",");
                    }
                    writer.WriteLine("");

                }
                writer.Close();
                MessageBox.Show("Data Exported Successfully");
            }
            else
            {
                MessageBox.Show("Invalid Export Location");
            }
        }
    }
}

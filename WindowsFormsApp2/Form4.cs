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

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        string _connectionString = $"Server={Properties.Settings.Default.Server};Initial Catalog={Properties.Settings.Default.Database};Persist Security Info=False;User ID={Properties.Settings.Default.UserName};Password={Properties.Settings.Default.Password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_fcl_weighDataSet3.Receipts' table. You can move, or remove it, as needed.
            this.receiptsTableAdapter3.Fill(this._fcl_weighDataSet3.Receipts);
            // TODO: This line of code loads data into the '_fcl_weighDataSet2.Receipts' table. You can move, or remove it, as needed.
            this.receiptsTableAdapter2.Fill(this._fcl_weighDataSet2.Receipts);
            // TODO: This line of code loads data into the '_fcl_weighDataSet1.Receipts' table. You can move, or remove it, as needed.
            this.receiptsTableAdapter1.Fill(this._fcl_weighDataSet1.Receipts);
            // TODO: This line of code loads data into the '_fcl_weighDataSet.Receipts' table. You can move, or remove it, as needed.
            this.receiptsTableAdapter.Fill(this._fcl_weighDataSet.Receipts);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.receiptsTableAdapter.FillBy(this._fcl_weighDataSet.Receipts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.receiptsTableAdapter1.FillBy(this._fcl_weighDataSet1.Receipts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.receiptsTableAdapter1.FillBy2(this._fcl_weighDataSet1.Receipts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.receiptsTableAdapter2.FillBy3(this._fcl_weighDataSet2.Receipts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.receiptsTableAdapter2.FillBy(this._fcl_weighDataSet2.Receipts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.receiptsTableAdapter2.FillBy1(this._fcl_weighDataSet2.Receipts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ImportDate_ValueChanged(object sender, EventArgs e)
        {
            // Change the gridview to read only selected items

           ImportDate.Format = DateTimePickerFormat.Custom;
           ImportDate.CustomFormat = "yyyy-MM-dd";

            DateTime endDate = Convert.ToDateTime(this.ImportDate.Text);
            endDate = endDate.AddDays(1);

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
                /*
                 SELECT  [ReceiptNo],[VendorNo],[VendorName],[ReceiptDate],[ItemNo],[Description],[ReceivedQty],[ImportTime],[UserID],[Slaughtered]FROM [dbo].[Receipts]
                 
                 */
                String q = "SELECT  [ReceiptNo],[VendorNo],[VendorName],[ReceiptDate],[ItemNo],[Description],[ReceivedQty],[ImportTime],[UserID],[Slaughtered]FROM [dbo].[Receipts] where " +
                            "ImportTime >='" +ImportDate.Text + "'"
                            + " AND  ImportTime<'" + endDate + "'";

                var table = new DataTable();
                using (var da = new SqlDataAdapter(q, _connectionString))
                {
                    try
                    {
                        da.Fill(table);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }

                conn.Close();

                this.dataGridView1.DataSource = table;

            }

        }

        private void ReceiptNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change the gridview to show only selected items

            

        }

        private void VendorNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change the gridview to show only selected items


        }

    }
}

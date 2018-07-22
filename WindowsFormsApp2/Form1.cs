using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    

    public partial class  Form1 : Form
    {
        string _connectionString = $"Server={Properties.Settings.Default.Server};Initial Catalog={Properties.Settings.Default.Database};Persist Security Info=False;User ID={Properties.Settings.Default.UserName};Password={Properties.Settings.Default.Password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        double MPerc;
        string CType;
        double CR = 0.0; double WT = 0.0; double NT;
        public Form1()
        {


            InitializeComponent();
            {
                // initialize comboboxes

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

                    try
                    {
                        string query = " SELECT DISTINCT ReceiptNo FROM[dbo].[Receipts] ORDER BY ReceiptNo DESC";
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "ReceiptNo");
                        ReceiptNo.DisplayMember = "ReceiptNo";
                        ReceiptNo.ValueMember = "ReceiptNo";
                        ReceiptNo.DataSource = ds.Tables["ReceiptNo"];

                        string query2 = " SELECT DISTINCT VendorTag FROM[dbo].[Receipts]";
                        SqlDataAdapter db = new SqlDataAdapter(query2, conn);
                        DataSet ds2 = new DataSet();
                        db.Fill(ds2, "VendorTag");
                        SlapMark.DisplayMember = "VendorTag";
                        SlapMark.ValueMember = "VendorTag";
                        SlapMark.DataSource = ds2.Tables["VendorTag"];


                    }
                    catch (Exception ex)
                    {
                        // write exception info to log or anything else
                        MessageBox.Show("Error occured!" + ex.Message);
                    }
                    conn.Close();
                }

                User.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                // Initialize the screen items

                ScaleID.Text = Properties.Settings.Default.ScaleLID;

                //fake reading before connecting to the scale
                Weight.Text = "80.00";
                CrateWeight.Text = Properties.Settings.Default.CrateWeight;
                

                try
                {
                    CR = Convert.ToDouble(CrateWeight.Text);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Format in the crate weight");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("The crate weight is too large");
                }

                try
                {
                    WT = Convert.ToDouble(Weight.Text);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Format in the Scale reading");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("The scale reading is too large");
                }


                NT = WT - CR;

                NetWeight.Text = Convert.ToString(NT);



            }

        }

        private void ReceiptNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void configurationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // New up the condfig page
            Form2 Config = new Form2();
            Config.Show();
        }

        private void SlapMark_SelectedIndexChanged(object sender, EventArgs e)
        {

            // fetch selected Vendor
            string Slap = SlapMark.SelectedValue.ToString();

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
                String q = "SELECT * FROM [dbo].[Receipts] WHERE VendorTag ='" + Slap + "'";
                using (SqlCommand cmd = new SqlCommand(q, conn))
                {

                    cmd.CommandText = q;

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Invalid receipt number. Please confirm before proceeding");
                            // MeatPercent.Enabled = false;
                        }
                        else
                        {
                            VendorName.Text = reader["VendorName"].ToString();
                            VendorNo.Text = reader["VendorNo"].ToString();
                            ReceiptNo.Text = reader["ReceiptNo"].ToString();
                            //MeatPercent.Enabled = true;
                            // receiptDetails.Text = $"Receipt no: {receiptNumber.Text} Vendor Name: {vendorName} Animal Type: {CType}";                           
                        }
                    }

                }
                conn.Close();

            }

        }

       
        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void importDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // New up the condfig page
            Form3 ImportData = new Form3();
            ImportData.Show();
        }

        private void ReceiptNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fetch selected Vendor
            string RNo = ReceiptNo.SelectedValue.ToString();

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
                String q = "SELECT * FROM [dbo].[Receipts] WHERE ReceiptNo ='" + RNo + "'";
                using (SqlCommand cmd = new SqlCommand(q, conn))
                {

                    cmd.CommandText = q;

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Invalid receipt number. Please confirm before proceeding");
                            // MeatPercent.Enabled = false;
                        }
                        else
                        {
                            VendorName.Text = reader["VendorName"].ToString();
                            VendorNo.Text = reader["VendorNo"].ToString();
                            SlapMark.Text = reader["VendorTag"].ToString();
                            //MeatPercent.Enabled = true;
                            // receiptDetails.Text = $"Receipt no: {receiptNumber.Text} Vendor Name: {vendorName} Animal Type: {CType}";                           
                        }
                    }

                }
                conn.Close();

            }
        }
        private void ReceiptNo_Leave(object sender, EventArgs e)
        {
            // fetch selected Vendor

            if (ReceiptNo.Text == "")
            {
                MessageBox.Show("Please fill in Receipt");
            }
            string RNo = ReceiptNo.Text;

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
                String q = "SELECT * FROM [dbo].[Receipts] WHERE ReceiptNo ='" + RNo + "'";
                using (SqlCommand cmd = new SqlCommand(q, conn))
                {

                    cmd.CommandText = q;

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Invalid receipt number. Please confirm before proceeding");
                            // MeatPercent.Enabled = false;
                        }
                        else
                        {
                            VendorName.Text = reader["VendorName"].ToString();
                            VendorNo.Text = reader["VendorNo"].ToString();
                            SlapMark.Text = reader["VendorTag"].ToString();
                            //MeatPercent.Enabled = true;
                            // receiptDetails.Text = $"Receipt no: {receiptNumber.Text} Vendor Name: {vendorName} Animal Type: {CType}";                           
                        }
                    }

                }
                conn.Close();

            }
        }

        private void SlapMark_Leave(object sender, EventArgs e)
        {
            // fetch selected Vendor

            if (SlapMark.Text == "")
            {
                MessageBox.Show("Please fill in Slap Mark");
            }
            string Slap = SlapMark.Text;

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
                String q = "SELECT * FROM [dbo].[Receipts] WHERE VendorTag ='" + Slap + "'";
                using (SqlCommand cmd = new SqlCommand(q, conn))
                {

                    cmd.CommandText = q;

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Invalid Slap Mark Please confirm before proceeding");
                            // MeatPercent.Enabled = false;
                        }
                        else
                        {
                            VendorName.Text = reader["VendorName"].ToString();
                            VendorNo.Text = reader["VendorNo"].ToString();
                            //SlapMark.Text = reader["VendorTag"].ToString();
                           ReceiptNo.Text = reader["ReceiptNo"].ToString();
                            //MeatPercent.Enabled = true;
                            // receiptDetails.Text = $"Receipt no: {receiptNumber.Text} Vendor Name: {vendorName} Animal Type: {CType}";                           
                        }
                    }

                }
                conn.Close();

            }
        }

        private void CarcassType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CarcassType.Text) && CarcassType.Text.Length > 5)
            {
                CType= CarcassType.Text.Substring(0, 5);
               
            }

            MeatPercent.Enabled = true;
            MeatPercent.ReadOnly = false;


        }

        private void CarcassType_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CarcassType.Text) && CarcassType.Text.Length > 5)
            {
                CType = CarcassType.Text.Substring(0, 5);

            }
            if (CarcassType.Text == "")
            {
                MessageBox.Show("Invalid Slap Mark Please confirm before proceeding");
            }
            else
            {
                MeatPercent.Enabled = true;
                MeatPercent.ReadOnly = false;
            }


        }

        private void MeatPercent_TextChanged(object sender, EventArgs e)
        {
            // Get the Classification
            if (MeatPercent.Text != "")
            {
                string[] specialFarms = { "PF99901", "PF99902", "PF99903", "PF99904", "PF99905" };

                try
                {
                    MPerc = Convert.ToDouble(MeatPercent.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please key in an integer or decimal for the meat percent Value");
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show("MeatPercent is outside the range." + ex.Message);
                }
                if (specialFarms.Contains(VendorNo.Text))
                {
                    if (MPerc >= 0 && MPerc <= 20 && CType == "G0110" && NT < 40)
                    {
                        ClassificationCode.Text = "RMPK-SUB40";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 40 && NT <= 49)
                    {
                        ClassificationCode.Text = "RM-CLS05";
                    }
                    if (MPerc >= 8 && MPerc <= 10 && CType == "G0110" && NT >= 56 && NT <= 59)
                    {
                        ClassificationCode.Text = "RM-CLS02";
                    }
                    if (MPerc >= 0 && MPerc <= 7 && CType == "G0110" && NT >= 56 && NT <= 75)
                    {
                        ClassificationCode.Text = "RM-CLS02";
                    }
                    if (MPerc >= 11 && MPerc <= 100 && CType == "G0110" && NT >= 56 && NT <= 75)
                    {
                        ClassificationCode.Text = "RM-CLS02";
                    }
                    if (MPerc >= 8 && MPerc <= 10 && CType == "G0110" && NT >= 60 && NT <= 75)
                    {
                        ClassificationCode.Text = "RM-CLS01";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 76 && NT <= 85)
                    {
                        ClassificationCode.Text = "RM-CLS03";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 50 && NT <= 55)
                    {
                        ClassificationCode.Text = "RM-CLS04";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 86 && NT <= 100)
                    {
                        ClassificationCode.Text = "RM-CLS06";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 101 && NT <= 120)
                    {
                        ClassificationCode.Text = "RM-CLS07";
                    }

                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT > 120)
                    {
                        ClassificationCode.Text = "RM-CLS08";
                    }
                    if (CType == "G0111")
                    {
                        ClassificationCode.Text = "SOW-RM";
                    }
                    if (CType == "G0113" && NT >= 5 && NT <= 7)
                    {
                        ClassificationCode.Text = "RM-SK1";
                    }
                    if (CType == "G0113" && NT >= 7 && NT < 9)
                    {
                        ClassificationCode.Text = "RM-SK2";
                    }
                    if (CType == "G0113" && NT >= 9 && NT < 16)
                    {
                        ClassificationCode.Text = "RM-SK3";
                    }
                    if (CType == "G0113" && NT >= 17 && NT < 20)
                    {
                        ClassificationCode.Text = "RM-SK4";
                    }
                    if (CType == "G0113" && NT >= 9 && NT < 20)
                    {
                        ClassificationCode.Text = "RM-SK5";
                    }
                }
                else
                {
                    if (MPerc >= 0 && MPerc <= 20 && CType == "G0110" && NT < 40)
                    {
                        ClassificationCode.Text = "PK-SUB40";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 40 && NT <= 49)
                    {
                        ClassificationCode.Text = "CLS-05";
                    }
                    if (MPerc >= 8 && MPerc <= 10 && CType == "G0101" && NT >= 50 && NT <= 59)
                    {
                        ClassificationCode.Text = "CLS-02";
                    }
                    if (MPerc >= 0 && MPerc <= 7 && CType == "G0101" && NT >= 56 && NT <= 75)
                    {
                        ClassificationCode.Text = "CLS-02";
                    }
                    if (MPerc >= 11 && MPerc <= 100 && CType == "G0110" && NT >= 56 && NT <= 75)
                    {
                        ClassificationCode.Text = "CLS-02";
                    }
                    if (MPerc >= 8 && MPerc <= 10 && CType == "G0110" && NT >= 60 && NT <= 75)
                    {
                        ClassificationCode.Text = "CLS-01";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 76 && NT <= 85)
                    {
                        ClassificationCode.Text = "CLS-03";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 50 && NT <= 55)
                    {
                        ClassificationCode.Text = "CLS-04";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 86 && NT <= 100)
                    {
                        ClassificationCode.Text = "CLS-06";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 101 && NT <= 120)
                    {
                        ClassificationCode.Text = "CLS-07";
                    }

                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0101" && NT > 120)
                    {
                        ClassificationCode.Text = "CLS-08";
                    }
                    if (CType == "G0111")
                    {
                        ClassificationCode.Text = "SOW-3P";
                    }
                    if (CType == "G0113" && NT >= 5 && NT < 8)
                    {
                        ClassificationCode.Text = "3P-SK4";
                    }
                    if (CType == "G0113" && NT >= 9 && NT < 20)
                    {
                        ClassificationCode.Text = "3P-SK5";
                    }
                }
            }
            else
            {

            }
            ClassificationCode.Enabled = true;

        }

        private void MeatPercent_Leave(object sender, EventArgs e)
        {

            if (MeatPercent.Text != "")
            {
                string[] specialFarms = { "PF99901", "PF99902", "PF99903", "PF99904", "PF99905" };
 
                try
                {
                    MPerc = Convert.ToDouble(MeatPercent.Text);
                }
                catch (FormatException)
                {
                   MessageBox.Show("Please key in an integer or decimal for the meat percent Value");
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show("MeatPercent is outside the range."+ex.Message);
                }
                if (specialFarms.Contains(VendorNo.Text))
                {
                    if (MPerc >= 0 && MPerc <= 20 && CType == "G0110" && NT < 40)
                    {
                        ClassificationCode.Text = "RMPK-SUB40";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 40 && NT <= 49)
                    {
                        ClassificationCode.Text = "RM-CLS05";
                    }
                    if (MPerc >= 8 && MPerc <= 10 && CType == "G0110" && NT >= 56 && NT <= 59)
                    {
                        ClassificationCode.Text = "RM-CLS02";
                    }
                    if (MPerc >= 0 && MPerc <= 7 && CType == "G0110" && NT >= 56 && NT <= 75)
                    {
                        ClassificationCode.Text = "RM-CLS02";
                    }
                    if (MPerc >= 11 && MPerc <= 100 && CType == "G0110" && NT >= 56 && NT <= 75)
                    {
                        ClassificationCode.Text = "RM-CLS02";
                    }
                    if (MPerc >= 8 && MPerc <= 10 && CType == "G0110" && NT >= 60 && NT <= 75)
                    {
                        ClassificationCode.Text = "RM-CLS01";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 76 && NT <= 85)
                    {
                        ClassificationCode.Text = "RM-CLS03";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 50 && NT <= 55)
                    {
                        ClassificationCode.Text = "RM-CLS04";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 86 && NT <= 100)
                    {
                        ClassificationCode.Text = "RM-CLS06";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 101 && NT <= 120)
                    {
                        ClassificationCode.Text = "RM-CLS07";
                    }

                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT > 120)
                    {
                        ClassificationCode.Text = "RM-CLS08";
                    }
                    if (CType == "G0111")
                    {
                        ClassificationCode.Text = "SOW-RM";
                    }
                    if (CType == "G0113" && NT >= 5 && NT <= 7)
                    {
                        ClassificationCode.Text = "RM-SK1";
                    }
                    if (CType == "G0113" && NT >= 7 && NT < 9)
                    {
                        ClassificationCode.Text = "RM-SK2";
                    }
                    if (CType == "G0113" && NT >= 9 && NT < 16)
                    {
                        ClassificationCode.Text = "RM-SK3";
                    }
                    if (CType == "G0113" && NT >= 17 && NT < 20)
                    {
                        ClassificationCode.Text = "RM-SK4";
                    }
                    if (CType == "G0113" && NT >= 9 && NT < 20)
                    {
                        ClassificationCode.Text = "RM-SK5";
                    }
                }
                else
                {
                    if (MPerc >= 0 && MPerc <= 20 && CType == "G0110" && NT < 40)
                    {
                        ClassificationCode.Text = "PK-SUB40";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 40 && NT <= 49)
                    {
                        ClassificationCode.Text = "CLS-05";
                    }
                    if (MPerc >= 8 && MPerc <= 10 && CType == "G0101" && NT >= 50 && NT <= 59)
                    {
                        ClassificationCode.Text = "CLS-02";
                    }
                    if (MPerc >= 0 && MPerc <= 7 && CType == "G0101" && NT >= 56 && NT <= 75)
                    {
                        ClassificationCode.Text = "CLS-02";
                    }
                    if (MPerc >= 11 && MPerc <= 100 && CType == "G0110" && NT >= 56 && NT <= 75)
                    {
                        ClassificationCode.Text = "CLS-02";
                    }
                    if (MPerc >= 8 && MPerc <= 10 && CType == "G0110" && NT >= 60 && NT <= 75)
                    {
                        ClassificationCode.Text = "CLS-01";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 76 && NT <= 85)
                    {
                        ClassificationCode.Text = "CLS-03";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 50 && NT <= 55)
                    {
                        ClassificationCode.Text = "CLS-04";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 86 && NT <= 100)
                    {
                        ClassificationCode.Text = "CLS-06";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 101 && NT <= 120)
                    {
                        ClassificationCode.Text = "CLS-07";
                    }

                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0101" && NT > 120)
                    {
                        ClassificationCode.Text = "CLS-08";
                    }
                    if (CType == "G0111")
                    {
                        ClassificationCode.Text = "SOW-3P";
                    }
                    if (CType == "G0113" && NT >= 5 && NT < 8)
                    {
                        ClassificationCode.Text = "3P-SK4";
                    }
                    if (CType == "G0113" && NT >= 9 && NT < 20)
                    {
                        ClassificationCode.Text = "3P-SK5";
                    }
                }
            }
            else
            {

            }
            ClassificationCode.Enabled = true;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            // get scale readings


        }
    }
}
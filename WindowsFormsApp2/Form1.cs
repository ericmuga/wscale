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
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{


    public partial class Form1 : Form
    {

        string _connectionString = $"Server={Properties.Settings.Default.Server};Initial Catalog={Properties.Settings.Default.Database};Persist Security Info=False;User ID={Properties.Settings.Default.UserName};Password={Properties.Settings.Default.Password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";
        double MPerc;
        string CType;
        int Rqty, Sqty;
        int check = 0;
        //string RNo = ReceiptNo.Text;

        double CR = 0.0; double WT = 0.0; double NT;

       

        private void Weight_TextChanged(object sender, EventArgs e)
        {
            CarcassType.Text = "";
            MeatPercent.Text = "";
            MeatPercent.ReadOnly = true;
            //Weight.Text = "";
            try
            {
                if (Weight.Text == "") Weight.Text = "0";
                NetWeight.Text = (Convert.ToDouble(Weight.Text) - Convert.ToDouble(Properties.Settings.Default.CrateWeight)).ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error 1.1");
            }
        }

       private void Weight_Leave(object sender, EventArgs e)
        {
            
            CarcassType.Text = "";
            MeatPercent.Text = "";
            MeatPercent.ReadOnly = true;

            try
            {
                if (Weight.Text == "") Weight.Text = "0";

                NT=(Convert.ToDouble(Weight.Text) - Convert.ToDouble(Properties.Settings.Default.CrateWeight));
                var result = NT - Math.Truncate(NT);
                if (result > 0.54)
                    NT = Math.Ceiling(NT);
                else NT = Math.Floor(NT);
                NetWeight.Text = NT.ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error 1");
            }

        }

        public Form1()
        {

            InitializeComponent();
            {
                if (!this.readWeight())
                {
                    //focus on ReceiptNo
                    ReceiptNo.Focus();
                }
                else
                {
                    Weight.Text.Remove(0);
                    Weight.ReadOnly = false;
                    Weight.Focus();

                }
                User.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                // Initialize the screen items
                ScaleID.Text = Properties.Settings.Default.ScaleLID;
                CrateWeight.Text = Properties.Settings.Default.CrateWeight;
                // initialize comboboxes
                this.initComBo();
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
                //rounding

                
                var result = NT - Math.Truncate(NT);
                if (result > 0.54)
                    NT = Math.Ceiling(NT);
                else NT = Math.Floor(NT);

                NetWeight.Text = Convert.ToString(NT);
            }

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

                    MessageBox.Show(ex.Message);
                    return;
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
                    MessageBox.Show(ex.Message);
                    return;
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
                MessageBox.Show("Invalid Receipt Number!");
                VendorName.Text = "";
                VendorNo.Text = "";
                SlapMark.Text = "";
                return;
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
                    MessageBox.Show(ex.Message);
                    return;

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
                            return;
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
                MessageBox.Show("Invalid Slap Mark!");
                VendorName.Text = "";
                VendorNo.Text = "";
                ReceiptNo.Text = "";
                return;

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
                    MessageBox.Show(ex.Message);
                    return;
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
                CType = CarcassType.Text.Substring(0, 5);

            }
            if (CarcassType.Text == "")
            {
                MessageBox.Show("Invalid Carcass Type Please confirm before proceeding");
            }
            else
            {
                MeatPercent.Enabled = true;
                MeatPercent.ReadOnly = false;
            }
            MeatPercent.Enabled = true;
            MeatPercent.ReadOnly = false;
            CType = CarcassType.Text.Substring(0, 5);
            NT = Convert.ToDouble(NetWeight.Text);
            

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
                        ClassificationCode.Text = "CLS05";
                    }
                    if (MPerc >= 8 && MPerc <= 10 && CType == "G0110" && NT >= 50 && NT <= 59)
                    {
                        ClassificationCode.Text = "CLS02";
                    }
                    if (MPerc >= 0 && MPerc <= 7 && CType == "G0110" && NT >= 56 && NT <= 75)
                    {
                        ClassificationCode.Text = "CLS02";
                    }
                    if (MPerc >= 11 && MPerc <= 100 && CType == "G0110" && NT >= 56 && NT <= 75)
                    {
                        ClassificationCode.Text = "CLS02";
                    }
                    if (MPerc >= 8 && MPerc <= 10 && CType == "G0110" && NT >= 60 && NT <= 75)
                    {
                        ClassificationCode.Text = "CLS01";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 76 && NT <= 85)
                    {
                        ClassificationCode.Text = "CLS03";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 50 && NT <= 55)
                    {
                        ClassificationCode.Text = "CLS04";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 86 && NT <= 100)
                    {
                        ClassificationCode.Text = "CLS06";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 101 && NT <= 120)
                    {
                        ClassificationCode.Text = "CLS07";
                    }

                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT > 120)
                    {
                        ClassificationCode.Text = "CLS08";
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
                ClassificationCode.Text = "";
                ClassificationCode.Enabled = false;
            }
            ClassificationCode.Enabled = true;






        }

        private void CarcassType_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CarcassType.Text) && CarcassType.Text.Length > 5)
            {
                CType = CarcassType.Text.Substring(0, 5);

            }
            if (CarcassType.Text == "")
            {
                MessageBox.Show("Invalid Carcass Type Please confirm before proceeding");
                if (ReceiptNo.Text != "" && SlapMark.Text != "" && Weight.Text!="") CarcassType.Focus(); 
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
                        ClassificationCode.Text = "CLS05";
                    }
                    if (MPerc >= 8 && MPerc <= 10 && CType == "G0110" && NT >= 50 && NT <= 59)
                    {
                        ClassificationCode.Text = "CLS02";
                    }
                    if (MPerc >= 0 && MPerc <= 7 && CType == "G0110" && NT >= 56 && NT <= 75)
                    {
                        ClassificationCode.Text = "CLS02";
                    }
                    if (MPerc >= 11 && MPerc <= 100 && CType == "G0110" && NT >= 56 && NT <= 75)
                    {
                        ClassificationCode.Text = "CLS02";
                    }
                    if (MPerc >= 8 && MPerc <= 10 && CType == "G0110" && NT >= 60 && NT <= 75)
                    {
                        ClassificationCode.Text = "CLS01";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 76 && NT <= 85)
                    {
                        ClassificationCode.Text = "CLS03";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 50 && NT <= 55)
                    {
                        ClassificationCode.Text = "CLS04";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 86 && NT <= 100)
                    {
                        ClassificationCode.Text = "CLS06";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 101 && NT <= 120)
                    {
                        ClassificationCode.Text = "CLS07";
                    }

                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT > 120)
                    {
                        ClassificationCode.Text = "CLS08";
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
                ClassificationCode.Text = "";
                ClassificationCode.Enabled = true;

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
                        ClassificationCode.Text = "CLS05";
                    }
                    if (MPerc >= 8 && MPerc <= 10 && CType == "G0110" && NT >= 50 && NT <= 59)
                    {
                        ClassificationCode.Text = "CLS02";
                    }
                    if (MPerc >= 0 && MPerc <= 7 && CType == "G0110" && NT >= 56 && NT <= 75)
                    {
                        ClassificationCode.Text = "CLS02";
                    }
                    if (MPerc >= 11 && MPerc <= 100 && CType == "G0110" && NT >= 56 && NT <= 75)
                    {
                        ClassificationCode.Text = "CLS02";
                    }
                    if (MPerc >= 8 && MPerc <= 10 && CType == "G0110" && NT >= 60 && NT <= 75)
                    {
                        ClassificationCode.Text = "CLS01";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 76 && NT <= 85)
                    {
                        ClassificationCode.Text = "CLS03";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 50 && NT <= 55)
                    {
                        ClassificationCode.Text = "CLS04";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 86 && NT <= 100)
                    {
                        ClassificationCode.Text = "CLS06";
                    }
                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT >= 101 && NT <= 120)
                    {
                        ClassificationCode.Text = "CLS07";
                    }

                    if (MPerc >= 0 && MPerc <= 100 && CType == "G0110" && NT > 120)
                    {
                        ClassificationCode.Text = "CLS08";
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

            readWeight();

        }

        private void Post_Click(object sender, EventArgs e)
        {
            //check if all necessary fields are there, and valid.
            //username

            //ReceiptNo
            if (ReceiptNo.Text == "")
            {
                MessageBox.Show("Invalid Receipt Number!");
                ReceiptNo.Focus();

            }
            if (SlapMark.Text == "")
            {
                MessageBox.Show("Invalid Slap Mark!");
                SlapMark.Focus();

            }
            if (CarcassType.Text == "")
            {
                MessageBox.Show("Invalid Carcass Type!");
                CarcassType.Focus();

            }

            if (MeatPercent.Text == "")
            {
                MessageBox.Show("Invalid Meat Percent!");
                MeatPercent.Focus();
            }

            using (SqlConnection conn = new SqlConnection(_connectionString))

            {
                CType = new string(CarcassType.Text.Take(5).ToArray());
                String q3 = "SELECT COUNT (ID) FROM [dbo].[SlaughterData] WHERE ReceiptNo ='" + ReceiptNo.Text + "'AND ItemNo ='" + CType + "'";
                using (SqlCommand cmd = new SqlCommand(q3, conn))
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "Error 5");
                        return;
                    }
                    try
                    {
                        Sqty = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "Error 6");
                        return;
                    }

                }

                conn.Close();
            }
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                //transcoding from from carcass code to livestock code to look up in the receipt ledger


                if (CType == "G0110") CType = "G0101";
                if (CType == "G0111") CType = "G0102";
                if (CType == "G0113") CType = "G0104";
                


                String q = "SELECT sum(convert(int, ReceivedQty) )from dbo.Receipts where ReceiptNo ='"+ ReceiptNo.Text +"'AND ItemNo='"+CType+"'";
                //MessageBox.Show(q);
                using (SqlCommand cmd = new SqlCommand(q, conn))
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message+"Error7");
                        return;
                    }

                    try
                    {
                        Rqty = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "Error3");
                        return;
                    }
                   
                }
                conn.Close();
            }

            
            if (Rqty > Sqty)
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string Slap = SlapMark.Text;
                    string VNo = VendorNo.Text;
                    string VName = VendorName.Text;
                    string MPC = MeatPercent.Text;
                    string CCode = ClassificationCode.Text;
                    string RNo= ReceiptNo.Text;
                    CType =  new string(CarcassType.Text.Take(5).ToArray());
                    
                    //insert the record
                    String q5 = "INSERT INTO [dbo].[SlaughterData]([SlaughterTime],[UserID],[ReceiptNo],[ItemNo],[StockWeight],[MeatPercent],[Classification Code])" +
                              "VALUES ('" + DateTime.Now + "','"
                                + User.Text + "','"
                                + RNo + "','"
                                + CType + "','"
                                + NT + "','"
                                + MPC + "','"
                                + ClassificationCode.Text + "')";
                        using (SqlCommand cmd = new SqlCommand(q5, conn))
                        {
                        try
                        {
                            conn.Open();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message+"Error 8");
                            return;
                        }
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Posted");
                            
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message +"Error 11");
                        }
                        conn.Close();
                    }
                    

              if ((Rqty-Sqty)==1)
                      {
                        if (CType == "G0110") CType = "G0101";
                        if (CType == "G0111") CType = "G0102";
                        if (CType == "G0113") CType = "G0104";
                        //
                         String q6 = "UPDATE [dbo].[Receipts] SET [Slaughtered]='1'  WHERE ReceiptNo='" + RNo + "'AND ItemNo ='" + CType + "'";

                        using (SqlCommand cmd = new SqlCommand(q6, conn))
                        {
                            try
                            {
                                conn.Open();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message + "Error 12");
                                return;
                            }
                           try
                            {
                                cmd.ExecuteNonQuery();
                                this.initComBo();
                                ReceiptNo.Text = "";
                                SlapMark.Text = "";
                                ReceiptNo.SelectedText = "";
                                SlapMark.SelectedText = "";
                                VendorName.Text = "";
                                VendorNo.Text = "";
                                CarcassType.Text = "";
                                CarcassType.SelectedText = "";
                                MeatPercent.Text = "";
                                ClassificationCode.Text = "";
                            }
                            catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message + "Error 10");
                                }
                            }
                           
                    }

                }
                

            }
            else
            {
                
                MessageBox.Show("The record could not be posted. The slaughtered qty exceeds the received qty for that animal type");
              return;
            }
                
        }

        private void importedReceiptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ImportedData = new Form4();
            ImportedData.Show();


        }

        private void exportedSlaughterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SlaughterData = new Form5();
            SlaughterData.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.initComBo();

        }

        private void initComBo()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {

                try
                {

                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    string query = " SELECT DISTINCT ReceiptNo FROM [dbo].[Receipts] where Slaughtered IS NULL  ORDER BY ReceiptNo ASC";
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
            }

        private bool readWeight()
        {
            string port = Properties.Settings.Default.COMPort;    // Store the selected COM port name to "port" varaiable
            int baudRate = Convert.ToInt32(Properties.Settings.Default.BaudRate); // Convert the baud rate string "9600" to int32 9600
            SerialPort COMport = new SerialPort(port, baudRate);
            COMport.ReadTimeout = 10000; //Setting ReadTimeout =3500 ms or 3.5 seconds

            try
            {

                COMport.Open();
                string data = COMport.ReadLine().ToString();
                StringBuilder sb = new StringBuilder(data);
                Weight.Text = Regex.Replace(sb.ToString(), "[^0-9.]", "");
                Weight.ReadOnly = true;
                COMport.Close();
                return true;
                

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"Unable to read from COM port. Please make sure the weighing scale is connected to the computer and correct configuration set");
                Weight.ReadOnly = false;
                return false;


            }

            //If we managed to open port
            

            
        }
      }

    }
  //insert the record into the database.

      

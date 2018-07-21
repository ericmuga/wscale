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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            {

                User.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                // Initialize the screen items

                ScaleID.Text = Properties.Settings.Default.ScaleLID;

                //fake reading before connecting to the scale
                Weight.Text = "80.00";
                CrateWeight.Text = Properties.Settings.Default.CrateWeight;
                double CR = 0.0; double WT = 0.0; double NT;

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

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }

            
 
           

}

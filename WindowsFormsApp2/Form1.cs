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


            }

        }

        private void ReceiptNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void configurationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // New up the condfig page
            Form2 Config = new Form2();
        }
    }

            
 
           

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // initialize settings

            ScaleID.Text = Properties.Settings.Default.ScaleLID;
            BaudRate.Text = Properties.Settings.Default.BaudRate;
            COMPort.Text = Properties.Settings.Default.COMPort;
            Database.Text = Properties.Settings.Default.Database;
            Server.Text = Properties.Settings.Default.Server;
            UserName.Text = Properties.Settings.Default.UserName;
            Password.Text = Properties.Settings.Default.Password;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void SaveScaleSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ScaleLID = ScaleID.Text;
            Properties.Settings.Default.BaudRate = BaudRate.Text;
            Properties.Settings.Default.COMPort=COMPort.Text;
            MessageBox.Show("Scale Settings Saved Successfully");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Database = Database.Text;
            Properties.Settings.Default.Server= Server.Text;
            Properties.Settings.Default.UserName = UserName.Text;
            Properties.Settings.Default.Password = Password.Text;
            MessageBox.Show("Database Settings Saved Successfully");

        }
    }
}

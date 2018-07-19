namespace WindowsFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScaleSettings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScaleID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BaudRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.COMPort = new System.Windows.Forms.TextBox();
            this.SaveScaleSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Server = new System.Windows.Forms.TextBox();
            this.Database = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ScaleSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScaleSettings
            // 
            this.ScaleSettings.Controls.Add(this.SaveScaleSettings);
            this.ScaleSettings.Controls.Add(this.COMPort);
            this.ScaleSettings.Controls.Add(this.label3);
            this.ScaleSettings.Controls.Add(this.BaudRate);
            this.ScaleSettings.Controls.Add(this.label2);
            this.ScaleSettings.Controls.Add(this.ScaleID);
            this.ScaleSettings.Controls.Add(this.label1);
            this.ScaleSettings.Location = new System.Drawing.Point(25, 21);
            this.ScaleSettings.Name = "ScaleSettings";
            this.ScaleSettings.Size = new System.Drawing.Size(335, 220);
            this.ScaleSettings.TabIndex = 0;
            this.ScaleSettings.TabStop = false;
            this.ScaleSettings.Text = "Scale Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scale ID";
            // 
            // ScaleID
            // 
            this.ScaleID.Location = new System.Drawing.Point(114, 40);
            this.ScaleID.Name = "ScaleID";
            this.ScaleID.Size = new System.Drawing.Size(116, 20);
            this.ScaleID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // BaudRate
            // 
            this.BaudRate.Location = new System.Drawing.Point(114, 70);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(116, 20);
            this.BaudRate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "COM Port";
            // 
            // COMPort
            // 
            this.COMPort.Location = new System.Drawing.Point(114, 96);
            this.COMPort.Name = "COMPort";
            this.COMPort.Size = new System.Drawing.Size(116, 20);
            this.COMPort.TabIndex = 1;
            // 
            // SaveScaleSettings
            // 
            this.SaveScaleSettings.Location = new System.Drawing.Point(85, 162);
            this.SaveScaleSettings.Name = "SaveScaleSettings";
            this.SaveScaleSettings.Size = new System.Drawing.Size(169, 23);
            this.SaveScaleSettings.TabIndex = 5;
            this.SaveScaleSettings.Text = "Update Settings";
            this.SaveScaleSettings.UseVisualStyleBackColor = true;
            this.SaveScaleSettings.Click += new System.EventHandler(this.SaveScaleSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.UserName);
            this.groupBox1.Controls.Add(this.Database);
            this.groupBox1.Controls.Add(this.Server);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(415, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Server Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "UserName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Password";
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(161, 33);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(147, 20);
            this.Server.TabIndex = 4;
            // 
            // Database
            // 
            this.Database.Location = new System.Drawing.Point(161, 59);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(147, 20);
            this.Database.TabIndex = 5;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(161, 85);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(147, 20);
            this.UserName.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(161, 115);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '.';
            this.Password.Size = new System.Drawing.Size(147, 20);
            this.Password.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ScaleSettings);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ScaleSettings.ResumeLayout(false);
            this.ScaleSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ScaleSettings;
        private System.Windows.Forms.Button SaveScaleSettings;
        private System.Windows.Forms.TextBox COMPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ScaleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Database;
        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
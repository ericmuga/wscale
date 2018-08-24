﻿namespace WindowsFormsApp2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importedReceiptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportedSlaughterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveriesPerPeriodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveriesPerVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserDetails = new System.Windows.Forms.GroupBox();
            this.User = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.ScaleStatus = new System.Windows.Forms.GroupBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.CrateWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ScaleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MeatPercent = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CarcassType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Weighed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Received = new System.Windows.Forms.TextBox();
            this.Post = new System.Windows.Forms.Button();
            this.ClassificationCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NetWeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.VendorName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.VendorNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SlapMark = new System.Windows.Forms.ComboBox();
            this.ReceiptNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.UserDetails.SuspendLayout();
            this.ScaleStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataManagementToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // configurationsToolStripMenuItem
            // 
            this.configurationsToolStripMenuItem.Name = "configurationsToolStripMenuItem";
            this.configurationsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.configurationsToolStripMenuItem.Text = "Configurations";
            this.configurationsToolStripMenuItem.Click += new System.EventHandler(this.configurationsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // dataManagementToolStripMenuItem
            // 
            this.dataManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDataToolStripMenuItem,
            this.exportDataToolStripMenuItem,
            this.importedReceiptsToolStripMenuItem,
            this.exportedSlaughterToolStripMenuItem});
            this.dataManagementToolStripMenuItem.Name = "dataManagementToolStripMenuItem";
            this.dataManagementToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.dataManagementToolStripMenuItem.Text = "Data Management";
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importDataToolStripMenuItem.Text = "Import Data";
            this.importDataToolStripMenuItem.Click += new System.EventHandler(this.importDataToolStripMenuItem_Click);
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportDataToolStripMenuItem.Text = "Export Data";
            // 
            // importedReceiptsToolStripMenuItem
            // 
            this.importedReceiptsToolStripMenuItem.Name = "importedReceiptsToolStripMenuItem";
            this.importedReceiptsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importedReceiptsToolStripMenuItem.Text = "Imported Receipts";
            this.importedReceiptsToolStripMenuItem.Click += new System.EventHandler(this.importedReceiptsToolStripMenuItem_Click);
            // 
            // exportedSlaughterToolStripMenuItem
            // 
            this.exportedSlaughterToolStripMenuItem.Name = "exportedSlaughterToolStripMenuItem";
            this.exportedSlaughterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportedSlaughterToolStripMenuItem.Text = "Slaughter Data";
            this.exportedSlaughterToolStripMenuItem.Click += new System.EventHandler(this.exportedSlaughterToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deliveriesPerPeriodToolStripMenuItem,
            this.deliveriesPerVendorToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // deliveriesPerPeriodToolStripMenuItem
            // 
            this.deliveriesPerPeriodToolStripMenuItem.Name = "deliveriesPerPeriodToolStripMenuItem";
            this.deliveriesPerPeriodToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.deliveriesPerPeriodToolStripMenuItem.Text = "Deliveries Per Period";
            // 
            // deliveriesPerVendorToolStripMenuItem
            // 
            this.deliveriesPerVendorToolStripMenuItem.Name = "deliveriesPerVendorToolStripMenuItem";
            this.deliveriesPerVendorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.deliveriesPerVendorToolStripMenuItem.Text = "Deliveries Per Vendor";
            // 
            // UserDetails
            // 
            this.UserDetails.Controls.Add(this.User);
            this.UserDetails.Controls.Add(this.UserLabel);
            this.UserDetails.Location = new System.Drawing.Point(34, 40);
            this.UserDetails.Name = "UserDetails";
            this.UserDetails.Size = new System.Drawing.Size(254, 72);
            this.UserDetails.TabIndex = 1;
            this.UserDetails.TabStop = false;
            this.UserDetails.Text = "User Details";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(69, 23);
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Size = new System.Drawing.Size(165, 20);
            this.User.TabIndex = 2;
            this.User.TextChanged += new System.EventHandler(this.User_TextChanged);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(15, 26);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(29, 13);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "User";
            // 
            // ScaleStatus
            // 
            this.ScaleStatus.Controls.Add(this.Refresh);
            this.ScaleStatus.Controls.Add(this.CrateWeight);
            this.ScaleStatus.Controls.Add(this.label3);
            this.ScaleStatus.Controls.Add(this.Weight);
            this.ScaleStatus.Controls.Add(this.label2);
            this.ScaleStatus.Controls.Add(this.ScaleID);
            this.ScaleStatus.Controls.Add(this.label1);
            this.ScaleStatus.Location = new System.Drawing.Point(488, 27);
            this.ScaleStatus.Name = "ScaleStatus";
            this.ScaleStatus.Size = new System.Drawing.Size(298, 118);
            this.ScaleStatus.TabIndex = 2;
            this.ScaleStatus.TabStop = false;
            this.ScaleStatus.Text = "Scale Status";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(25, 44);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(58, 40);
            this.Refresh.TabIndex = 6;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // CrateWeight
            // 
            this.CrateWeight.Location = new System.Drawing.Point(173, 84);
            this.CrateWeight.Name = "CrateWeight";
            this.CrateWeight.ReadOnly = true;
            this.CrateWeight.Size = new System.Drawing.Size(109, 20);
            this.CrateWeight.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Crate Weight";
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(173, 53);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(109, 20);
            this.Weight.TabIndex = 3;
            this.Weight.TextChanged += new System.EventHandler(this.Weight_TextChanged);
            this.Weight.Leave += new System.EventHandler(this.Weight_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reading";
            // 
            // ScaleID
            // 
            this.ScaleID.Location = new System.Drawing.Point(172, 17);
            this.ScaleID.Name = "ScaleID";
            this.ScaleID.ReadOnly = true;
            this.ScaleID.Size = new System.Drawing.Size(111, 20);
            this.ScaleID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scale ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MeatPercent);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.CarcassType);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Weighed);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Received);
            this.groupBox1.Controls.Add(this.Post);
            this.groupBox1.Controls.Add(this.ClassificationCode);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.NetWeight);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.VendorName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.VendorNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SlapMark);
            this.groupBox1.Controls.Add(this.ReceiptNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 231);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // MeatPercent
            // 
            this.MeatPercent.Enabled = false;
            this.MeatPercent.Location = new System.Drawing.Point(585, 65);
            this.MeatPercent.Name = "MeatPercent";
            this.MeatPercent.Size = new System.Drawing.Size(126, 20);
            this.MeatPercent.TabIndex = 22;
            this.MeatPercent.TextChanged += new System.EventHandler(this.MeatPercent_TextChanged);
            this.MeatPercent.Leave += new System.EventHandler(this.MeatPercent_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(492, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Meat Percent";
            // 
            // CarcassType
            // 
            this.CarcassType.Items.AddRange(new object[] {
            "G0110, Pig, Carcass",
            "G0111, Sow, Carcass",
            "G0113, Suckling. Carcass",
            "G0114, Condemned Pig, Carcass",
            "G0118, Condemned Suckling, Carcass",
            "G0112, Casualty, Carcass",
            "G0116, Dead Pig - Rosemark",
            "G0117, Dead Sow - RM",
            "G0119, Dead Pig [Lairage] -3rdP Fmr",
            "G0120, Dead Pig [Self Trp] -3rdP Fmr",
            "G0121, Scrapped Pig, Carcass",
            "G0122, Dead Sow - Rosemark"});
            this.CarcassType.Location = new System.Drawing.Point(107, 87);
            this.CarcassType.Name = "CarcassType";
            this.CarcassType.Size = new System.Drawing.Size(258, 21);
            this.CarcassType.TabIndex = 20;
            this.CarcassType.SelectedIndexChanged += new System.EventHandler(this.CarcassType_SelectedIndexChanged);
            this.CarcassType.Leave += new System.EventHandler(this.CarcassType_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Carcass Type";
            // 
            // Weighed
            // 
            this.Weighed.Location = new System.Drawing.Point(211, 180);
            this.Weighed.Name = "Weighed";
            this.Weighed.ReadOnly = true;
            this.Weighed.Size = new System.Drawing.Size(91, 20);
            this.Weighed.TabIndex = 18;
            this.Weighed.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Weighed";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Received";
            this.label10.Visible = false;
            // 
            // Received
            // 
            this.Received.Location = new System.Drawing.Point(107, 180);
            this.Received.Name = "Received";
            this.Received.ReadOnly = true;
            this.Received.Size = new System.Drawing.Size(87, 20);
            this.Received.TabIndex = 15;
            this.Received.Visible = false;
            // 
            // Post
            // 
            this.Post.Location = new System.Drawing.Point(585, 128);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(126, 35);
            this.Post.TabIndex = 14;
            this.Post.Text = "Post";
            this.Post.UseVisualStyleBackColor = true;
            this.Post.Click += new System.EventHandler(this.Post_Click);
            // 
            // ClassificationCode
            // 
            this.ClassificationCode.Enabled = false;
            this.ClassificationCode.Location = new System.Drawing.Point(586, 99);
            this.ClassificationCode.Name = "ClassificationCode";
            this.ClassificationCode.ReadOnly = true;
            this.ClassificationCode.Size = new System.Drawing.Size(125, 20);
            this.ClassificationCode.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Classification Code";
            // 
            // NetWeight
            // 
            this.NetWeight.Location = new System.Drawing.Point(586, 36);
            this.NetWeight.Name = "NetWeight";
            this.NetWeight.ReadOnly = true;
            this.NetWeight.Size = new System.Drawing.Size(125, 20);
            this.NetWeight.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Net Weight";
            // 
            // VendorName
            // 
            this.VendorName.Location = new System.Drawing.Point(107, 137);
            this.VendorName.Name = "VendorName";
            this.VendorName.ReadOnly = true;
            this.VendorName.Size = new System.Drawing.Size(260, 20);
            this.VendorName.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Vendor Name";
            // 
            // VendorNo
            // 
            this.VendorNo.Location = new System.Drawing.Point(107, 113);
            this.VendorNo.Name = "VendorNo";
            this.VendorNo.ReadOnly = true;
            this.VendorNo.Size = new System.Drawing.Size(182, 20);
            this.VendorNo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vendor Number";
            // 
            // SlapMark
            // 
            this.SlapMark.FormattingEnabled = true;
            this.SlapMark.Location = new System.Drawing.Point(107, 61);
            this.SlapMark.Name = "SlapMark";
            this.SlapMark.Size = new System.Drawing.Size(182, 21);
            this.SlapMark.TabIndex = 5;
            this.SlapMark.SelectedIndexChanged += new System.EventHandler(this.SlapMark_SelectedIndexChanged);
            this.SlapMark.Leave += new System.EventHandler(this.SlapMark_Leave);
            // 
            // ReceiptNo
            // 
            this.ReceiptNo.FormattingEnabled = true;
            this.ReceiptNo.Location = new System.Drawing.Point(107, 33);
            this.ReceiptNo.Name = "ReceiptNo";
            this.ReceiptNo.Size = new System.Drawing.Size(182, 21);
            this.ReceiptNo.TabIndex = 4;
            this.ReceiptNo.SelectedIndexChanged += new System.EventHandler(this.ReceiptNo_SelectedIndexChanged);
            this.ReceiptNo.Leave += new System.EventHandler(this.ReceiptNo_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Slap Mark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Receipt Number";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ScaleStatus);
            this.Controls.Add(this.UserDetails);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Farmers Choice Pig Slaughter Weighing Station";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.UserDetails.ResumeLayout(false);
            this.UserDetails.PerformLayout();
            this.ScaleStatus.ResumeLayout(false);
            this.ScaleStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveriesPerPeriodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveriesPerVendorToolStripMenuItem;
        private System.Windows.Forms.GroupBox UserDetails;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.GroupBox ScaleStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ScaleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CrateWeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.TextBox Weighed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Received;
        private System.Windows.Forms.Button Post;
        private System.Windows.Forms.TextBox ClassificationCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NetWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox VendorName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VendorNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SlapMark;
        private System.Windows.Forms.ComboBox ReceiptNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CarcassType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox MeatPercent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem importedReceiptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportedSlaughterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}



namespace WindowsFormsApp2
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExportTextFile = new System.Windows.Forms.Button();
            this.SlaughterDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SlaughterTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meatPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slaughterDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._fcl_weighDataSet4 = new WindowsFormsApp2._fcl_weighDataSet4();
            this.slaughterDataTableAdapter = new WindowsFormsApp2._fcl_weighDataSet4TableAdapters.SlaughterDataTableAdapter();
            this.ExportExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaughterDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._fcl_weighDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExportExcel);
            this.groupBox1.Controls.Add(this.ExportTextFile);
            this.groupBox1.Controls.Add(this.SlaughterDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // ExportTextFile
            // 
            this.ExportTextFile.Location = new System.Drawing.Point(343, 21);
            this.ExportTextFile.Name = "ExportTextFile";
            this.ExportTextFile.Size = new System.Drawing.Size(108, 23);
            this.ExportTextFile.TabIndex = 2;
            this.ExportTextFile.Text = "ExportTextFile";
            this.ExportTextFile.UseVisualStyleBackColor = true;
            this.ExportTextFile.Click += new System.EventHandler(this.ExportTextFile_Click);
            // 
            // SlaughterDate
            // 
            this.SlaughterDate.Location = new System.Drawing.Point(90, 20);
            this.SlaughterDate.Name = "SlaughterDate";
            this.SlaughterDate.Size = new System.Drawing.Size(200, 20);
            this.SlaughterDate.TabIndex = 1;
            this.SlaughterDate.ValueChanged += new System.EventHandler(this.SlaughterDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slaughter Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlaughterTime,
            this.receiptNoDataGridViewTextBoxColumn,
            this.itemNoDataGridViewTextBoxColumn,
            this.stockWeightDataGridViewTextBoxColumn,
            this.meatPercentDataGridViewTextBoxColumn,
            this.classificationCodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.slaughterDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 361);
            this.dataGridView1.TabIndex = 1;
            // 
            // SlaughterTime
            // 
            this.SlaughterTime.DataPropertyName = "SlaughterTime";
            this.SlaughterTime.HeaderText = "SlaughterTime";
            this.SlaughterTime.Name = "SlaughterTime";
            // 
            // receiptNoDataGridViewTextBoxColumn
            // 
            this.receiptNoDataGridViewTextBoxColumn.DataPropertyName = "ReceiptNo";
            this.receiptNoDataGridViewTextBoxColumn.HeaderText = "ReceiptNo";
            this.receiptNoDataGridViewTextBoxColumn.Name = "receiptNoDataGridViewTextBoxColumn";
            // 
            // itemNoDataGridViewTextBoxColumn
            // 
            this.itemNoDataGridViewTextBoxColumn.DataPropertyName = "ItemNo";
            this.itemNoDataGridViewTextBoxColumn.HeaderText = "ItemNo";
            this.itemNoDataGridViewTextBoxColumn.Name = "itemNoDataGridViewTextBoxColumn";
            // 
            // stockWeightDataGridViewTextBoxColumn
            // 
            this.stockWeightDataGridViewTextBoxColumn.DataPropertyName = "StockWeight";
            this.stockWeightDataGridViewTextBoxColumn.HeaderText = "StockWeight";
            this.stockWeightDataGridViewTextBoxColumn.Name = "stockWeightDataGridViewTextBoxColumn";
            // 
            // meatPercentDataGridViewTextBoxColumn
            // 
            this.meatPercentDataGridViewTextBoxColumn.DataPropertyName = "MeatPercent";
            this.meatPercentDataGridViewTextBoxColumn.HeaderText = "MeatPercent";
            this.meatPercentDataGridViewTextBoxColumn.Name = "meatPercentDataGridViewTextBoxColumn";
            // 
            // classificationCodeDataGridViewTextBoxColumn
            // 
            this.classificationCodeDataGridViewTextBoxColumn.DataPropertyName = "Classification Code";
            this.classificationCodeDataGridViewTextBoxColumn.HeaderText = "Classification Code";
            this.classificationCodeDataGridViewTextBoxColumn.Name = "classificationCodeDataGridViewTextBoxColumn";
            // 
            // slaughterDataBindingSource
            // 
            this.slaughterDataBindingSource.DataMember = "SlaughterData";
            this.slaughterDataBindingSource.DataSource = this._fcl_weighDataSet4;
            // 
            // _fcl_weighDataSet4
            // 
            this._fcl_weighDataSet4.DataSetName = "_fcl_weighDataSet4";
            this._fcl_weighDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // slaughterDataTableAdapter
            // 
            this.slaughterDataTableAdapter.ClearBeforeFill = true;
            // 
            // ExportExcel
            // 
            this.ExportExcel.Location = new System.Drawing.Point(517, 21);
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.Size = new System.Drawing.Size(129, 23);
            this.ExportExcel.TabIndex = 3;
            this.ExportExcel.Text = "Export Excel";
            this.ExportExcel.UseVisualStyleBackColor = true;
            this.ExportExcel.Click += new System.EventHandler(this.ExportExcel_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 458);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Slaughter Data";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaughterDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._fcl_weighDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker SlaughterDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _fcl_weighDataSet4 _fcl_weighDataSet4;
        private System.Windows.Forms.BindingSource slaughterDataBindingSource;
        private _fcl_weighDataSet4TableAdapters.SlaughterDataTableAdapter slaughterDataTableAdapter;
        private System.Windows.Forms.Button ExportTextFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlaughterTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlaughterTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meatPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificationCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ExportExcel;
    }
}
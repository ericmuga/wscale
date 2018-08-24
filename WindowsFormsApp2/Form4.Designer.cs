namespace WindowsFormsApp2
{
    partial class Form4
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
            this.ReceiptNo = new System.Windows.Forms.ComboBox();
            this.receiptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._fcl_weighDataSet = new WindowsFormsApp2._fcl_weighDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.VendorNo = new System.Windows.Forms.ComboBox();
            this.receiptsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._fcl_weighDataSet1 = new WindowsFormsApp2._fcl_weighDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.ImportDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.receiptsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this._fcl_weighDataSet2 = new WindowsFormsApp2._fcl_weighDataSet2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receiptNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slaughteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this._fcl_weighDataSet3 = new WindowsFormsApp2._fcl_weighDataSet3();
            this.receiptsTableAdapter = new WindowsFormsApp2._fcl_weighDataSetTableAdapters.ReceiptsTableAdapter();
            this.receiptsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.receiptsTableAdapter1 = new WindowsFormsApp2._fcl_weighDataSet1TableAdapters.ReceiptsTableAdapter();
            this.receiptsTableAdapter2 = new WindowsFormsApp2._fcl_weighDataSet2TableAdapters.ReceiptsTableAdapter();
            this.receiptsTableAdapter3 = new WindowsFormsApp2._fcl_weighDataSet3TableAdapters.ReceiptsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._fcl_weighDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._fcl_weighDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._fcl_weighDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._fcl_weighDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReceiptNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.VendorNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ImportDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // ReceiptNo
            // 
            this.ReceiptNo.DataSource = this.receiptsBindingSource;
            this.ReceiptNo.DisplayMember = "ReceiptNo";
            this.ReceiptNo.FormattingEnabled = true;
            this.ReceiptNo.Location = new System.Drawing.Point(92, 43);
            this.ReceiptNo.Name = "ReceiptNo";
            this.ReceiptNo.Size = new System.Drawing.Size(200, 21);
            this.ReceiptNo.TabIndex = 7;
            this.ReceiptNo.ValueMember = "ReceiptNo";
            this.ReceiptNo.Visible = false;
            this.ReceiptNo.SelectedIndexChanged += new System.EventHandler(this.ReceiptNo_SelectedIndexChanged);
            // 
            // receiptsBindingSource
            // 
            this.receiptsBindingSource.DataMember = "Receipts";
            this.receiptsBindingSource.DataSource = this._fcl_weighDataSet;
            // 
            // _fcl_weighDataSet
            // 
            this._fcl_weighDataSet.DataSetName = "_fcl_weighDataSet";
            this._fcl_weighDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Receipt No";
            this.label4.Visible = false;
            // 
            // VendorNo
            // 
            this.VendorNo.DataSource = this.receiptsBindingSource2;
            this.VendorNo.DisplayMember = "VendorNo";
            this.VendorNo.FormattingEnabled = true;
            this.VendorNo.Location = new System.Drawing.Point(487, 40);
            this.VendorNo.Name = "VendorNo";
            this.VendorNo.Size = new System.Drawing.Size(221, 21);
            this.VendorNo.TabIndex = 5;
            this.VendorNo.ValueMember = "VendorNo";
            this.VendorNo.Visible = false;
            this.VendorNo.SelectedIndexChanged += new System.EventHandler(this.VendorNo_SelectedIndexChanged);
            // 
            // receiptsBindingSource2
            // 
            this.receiptsBindingSource2.DataMember = "Receipts";
            this.receiptsBindingSource2.DataSource = this._fcl_weighDataSet1;
            // 
            // _fcl_weighDataSet1
            // 
            this._fcl_weighDataSet1.DataSetName = "_fcl_weighDataSet1";
            this._fcl_weighDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vendor Number";
            this.label3.Visible = false;
            // 
            // ImportDate
            // 
            this.ImportDate.Location = new System.Drawing.Point(92, 10);
            this.ImportDate.Name = "ImportDate";
            this.ImportDate.Size = new System.Drawing.Size(200, 20);
            this.ImportDate.TabIndex = 1;
            this.ImportDate.ValueChanged += new System.EventHandler(this.ImportDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Import Date";
            // 
            // receiptsBindingSource3
            // 
            this.receiptsBindingSource3.DataMember = "Receipts";
            this.receiptsBindingSource3.DataSource = this._fcl_weighDataSet2;
            // 
            // _fcl_weighDataSet2
            // 
            this._fcl_weighDataSet2.DataSetName = "_fcl_weighDataSet2";
            this._fcl_weighDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receiptNoDataGridViewTextBoxColumn,
            this.vendorNoDataGridViewTextBoxColumn,
            this.vendorNameDataGridViewTextBoxColumn,
            this.receiptDateDataGridViewTextBoxColumn,
            this.itemNoDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.receivedQtyDataGridViewTextBoxColumn,
            this.importTimeDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.slaughteredDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.receiptsBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 349);
            this.dataGridView1.TabIndex = 1;
            // 
            // receiptNoDataGridViewTextBoxColumn
            // 
            this.receiptNoDataGridViewTextBoxColumn.DataPropertyName = "ReceiptNo";
            this.receiptNoDataGridViewTextBoxColumn.HeaderText = "ReceiptNo";
            this.receiptNoDataGridViewTextBoxColumn.Name = "receiptNoDataGridViewTextBoxColumn";
            // 
            // vendorNoDataGridViewTextBoxColumn
            // 
            this.vendorNoDataGridViewTextBoxColumn.DataPropertyName = "VendorNo";
            this.vendorNoDataGridViewTextBoxColumn.HeaderText = "VendorNo";
            this.vendorNoDataGridViewTextBoxColumn.Name = "vendorNoDataGridViewTextBoxColumn";
            // 
            // vendorNameDataGridViewTextBoxColumn
            // 
            this.vendorNameDataGridViewTextBoxColumn.DataPropertyName = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.HeaderText = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.Name = "vendorNameDataGridViewTextBoxColumn";
            // 
            // receiptDateDataGridViewTextBoxColumn
            // 
            this.receiptDateDataGridViewTextBoxColumn.DataPropertyName = "ReceiptDate";
            this.receiptDateDataGridViewTextBoxColumn.HeaderText = "ReceiptDate";
            this.receiptDateDataGridViewTextBoxColumn.Name = "receiptDateDataGridViewTextBoxColumn";
            // 
            // itemNoDataGridViewTextBoxColumn
            // 
            this.itemNoDataGridViewTextBoxColumn.DataPropertyName = "ItemNo";
            this.itemNoDataGridViewTextBoxColumn.HeaderText = "ItemNo";
            this.itemNoDataGridViewTextBoxColumn.Name = "itemNoDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // receivedQtyDataGridViewTextBoxColumn
            // 
            this.receivedQtyDataGridViewTextBoxColumn.DataPropertyName = "ReceivedQty";
            this.receivedQtyDataGridViewTextBoxColumn.HeaderText = "ReceivedQty";
            this.receivedQtyDataGridViewTextBoxColumn.Name = "receivedQtyDataGridViewTextBoxColumn";
            // 
            // importTimeDataGridViewTextBoxColumn
            // 
            this.importTimeDataGridViewTextBoxColumn.DataPropertyName = "ImportTime";
            this.importTimeDataGridViewTextBoxColumn.HeaderText = "ImportTime";
            this.importTimeDataGridViewTextBoxColumn.Name = "importTimeDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // slaughteredDataGridViewTextBoxColumn
            // 
            this.slaughteredDataGridViewTextBoxColumn.DataPropertyName = "Slaughtered";
            this.slaughteredDataGridViewTextBoxColumn.HeaderText = "Complete Slaughter";
            this.slaughteredDataGridViewTextBoxColumn.Name = "slaughteredDataGridViewTextBoxColumn";
            // 
            // receiptsBindingSource4
            // 
            this.receiptsBindingSource4.DataMember = "Receipts";
            this.receiptsBindingSource4.DataSource = this._fcl_weighDataSet3;
            // 
            // _fcl_weighDataSet3
            // 
            this._fcl_weighDataSet3.DataSetName = "_fcl_weighDataSet3";
            this._fcl_weighDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receiptsTableAdapter
            // 
            this.receiptsTableAdapter.ClearBeforeFill = true;
            // 
            // receiptsBindingSource1
            // 
            this.receiptsBindingSource1.DataMember = "Receipts";
            this.receiptsBindingSource1.DataSource = this._fcl_weighDataSet;
            // 
            // receiptsTableAdapter1
            // 
            this.receiptsTableAdapter1.ClearBeforeFill = true;
            // 
            // receiptsTableAdapter2
            // 
            this.receiptsTableAdapter2.ClearBeforeFill = true;
            // 
            // receiptsTableAdapter3
            // 
            this.receiptsTableAdapter3.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Imported Receipts";
            this.Text = "Imported Receipts";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._fcl_weighDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._fcl_weighDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._fcl_weighDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._fcl_weighDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ReceiptNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox VendorNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ImportDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _fcl_weighDataSet _fcl_weighDataSet;
        private System.Windows.Forms.BindingSource receiptsBindingSource;
        private _fcl_weighDataSetTableAdapters.ReceiptsTableAdapter receiptsTableAdapter;
        private System.Windows.Forms.BindingSource receiptsBindingSource1;
        private _fcl_weighDataSet1 _fcl_weighDataSet1;
        private System.Windows.Forms.BindingSource receiptsBindingSource2;
        private _fcl_weighDataSet1TableAdapters.ReceiptsTableAdapter receiptsTableAdapter1;
        private _fcl_weighDataSet2 _fcl_weighDataSet2;
        private System.Windows.Forms.BindingSource receiptsBindingSource3;
        private _fcl_weighDataSet2TableAdapters.ReceiptsTableAdapter receiptsTableAdapter2;
        private _fcl_weighDataSet3 _fcl_weighDataSet3;
        private System.Windows.Forms.BindingSource receiptsBindingSource4;
        private _fcl_weighDataSet3TableAdapters.ReceiptsTableAdapter receiptsTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slaughteredDataGridViewTextBoxColumn;
    }
}
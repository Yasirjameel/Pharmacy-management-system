namespace Pharmacy_Yasir
{
    partial class Dangerzone
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.didDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingpriceperunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingpriceperunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boughtdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmaDataSet9 = new Pharmacy_Yasir.pharmaDataSet9();
            this.stockTableAdapter = new Pharmacy_Yasir.pharmaDataSet9TableAdapters.stockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.didDataGridViewTextBoxColumn,
            this.batchnoDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.buyingpriceperunitDataGridViewTextBoxColumn,
            this.sellingpriceperunitDataGridViewTextBoxColumn,
            this.boughtdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(933, 511);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // didDataGridViewTextBoxColumn
            // 
            this.didDataGridViewTextBoxColumn.DataPropertyName = "d_id";
            this.didDataGridViewTextBoxColumn.HeaderText = "ID";
            this.didDataGridViewTextBoxColumn.Name = "didDataGridViewTextBoxColumn";
            this.didDataGridViewTextBoxColumn.ReadOnly = true;
            this.didDataGridViewTextBoxColumn.Width = 50;
            // 
            // batchnoDataGridViewTextBoxColumn
            // 
            this.batchnoDataGridViewTextBoxColumn.DataPropertyName = "Batch_no";
            this.batchnoDataGridViewTextBoxColumn.HeaderText = "Batch no";
            this.batchnoDataGridViewTextBoxColumn.Name = "batchnoDataGridViewTextBoxColumn";
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "Product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Product name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // buyingpriceperunitDataGridViewTextBoxColumn
            // 
            this.buyingpriceperunitDataGridViewTextBoxColumn.DataPropertyName = "Buying_price_perunit";
            this.buyingpriceperunitDataGridViewTextBoxColumn.HeaderText = "Buying price perunit";
            this.buyingpriceperunitDataGridViewTextBoxColumn.Name = "buyingpriceperunitDataGridViewTextBoxColumn";
            this.buyingpriceperunitDataGridViewTextBoxColumn.Width = 150;
            // 
            // sellingpriceperunitDataGridViewTextBoxColumn
            // 
            this.sellingpriceperunitDataGridViewTextBoxColumn.DataPropertyName = "Selling_price_perunit";
            this.sellingpriceperunitDataGridViewTextBoxColumn.HeaderText = "Selling price perunit";
            this.sellingpriceperunitDataGridViewTextBoxColumn.Name = "sellingpriceperunitDataGridViewTextBoxColumn";
            this.sellingpriceperunitDataGridViewTextBoxColumn.Width = 150;
            // 
            // boughtdateDataGridViewTextBoxColumn
            // 
            this.boughtdateDataGridViewTextBoxColumn.DataPropertyName = "Bought_date";
            this.boughtdateDataGridViewTextBoxColumn.HeaderText = "Bought date";
            this.boughtdateDataGridViewTextBoxColumn.Name = "boughtdateDataGridViewTextBoxColumn";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "stock";
            this.stockBindingSource.DataSource = this.pharmaDataSet9;
            // 
            // pharmaDataSet9
            // 
            this.pharmaDataSet9.DataSetName = "pharmaDataSet9";
            this.pharmaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // Dangerzone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 535);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dangerzone";
            this.Text = "Dangerzone";
            this.Load += new System.EventHandler(this.Dangerzone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private pharmaDataSet9 pharmaDataSet9;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private pharmaDataSet9TableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn didDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingpriceperunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingpriceperunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boughtdateDataGridViewTextBoxColumn;
    }
}
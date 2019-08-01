namespace Pharmacy_Yasir
{
    partial class Section
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
            this.tidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectiondetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmaDataSet6 = new Pharmacy_Yasir.pharmaDataSet6();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sectionTableAdapter = new Pharmacy_Yasir.pharmaDataSet6TableAdapters.sectionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tidDataGridViewTextBoxColumn,
            this.sectionnoDataGridViewTextBoxColumn,
            this.sectiondetailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sectionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(380, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 509);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            // 
            // tidDataGridViewTextBoxColumn
            // 
            this.tidDataGridViewTextBoxColumn.DataPropertyName = "t_id";
            this.tidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.tidDataGridViewTextBoxColumn.Name = "tidDataGridViewTextBoxColumn";
            this.tidDataGridViewTextBoxColumn.ReadOnly = true;
            this.tidDataGridViewTextBoxColumn.Width = 50;
            // 
            // sectionnoDataGridViewTextBoxColumn
            // 
            this.sectionnoDataGridViewTextBoxColumn.DataPropertyName = "Section_no";
            this.sectionnoDataGridViewTextBoxColumn.HeaderText = "Section number";
            this.sectionnoDataGridViewTextBoxColumn.Name = "sectionnoDataGridViewTextBoxColumn";
            this.sectionnoDataGridViewTextBoxColumn.Width = 150;
            // 
            // sectiondetailDataGridViewTextBoxColumn
            // 
            this.sectiondetailDataGridViewTextBoxColumn.DataPropertyName = "Section_detail";
            this.sectiondetailDataGridViewTextBoxColumn.HeaderText = "Section details";
            this.sectiondetailDataGridViewTextBoxColumn.Name = "sectiondetailDataGridViewTextBoxColumn";
            this.sectiondetailDataGridViewTextBoxColumn.Width = 150;
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataMember = "section";
            this.sectionBindingSource.DataSource = this.pharmaDataSet6;
            // 
            // pharmaDataSet6
            // 
            this.pharmaDataSet6.DataSetName = "pharmaDataSet6";
            this.pharmaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add/Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Section Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add Section details for Medicane Here";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Section Detail";
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 533);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Section";
            this.Text = "Section:";
            this.Load += new System.EventHandler(this.Section_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private pharmaDataSet6 pharmaDataSet6;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private pharmaDataSet6TableAdapters.sectionTableAdapter sectionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectiondetailDataGridViewTextBoxColumn;
    }
}
namespace Medosmotr
{
    partial class QueryForm
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
            this.comboBoxQuery = new System.Windows.Forms.ComboBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSpec = new System.Windows.Forms.ComboBox();
            this.dataGridQuery = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.медосмотрDataSet1 = new Medosmotr.МедосмотрDataSet();
            this.специалистBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.специалистTableAdapter1 = new Medosmotr.МедосмотрDataSetTableAdapters.СпециалистTableAdapter();
            this.кодспециалистаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номеркабинетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.медосмотрDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специалистBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxQuery
            // 
            this.comboBoxQuery.FormattingEnabled = true;
            this.comboBoxQuery.Items.AddRange(new object[] {
            "Список пациентов мужского пола",
            "Данные о специалистах определённого направления",
            "Информация о посещениях на определённую дату"});
            this.comboBoxQuery.Location = new System.Drawing.Point(20, 40);
            this.comboBoxQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxQuery.Name = "comboBoxQuery";
            this.comboBoxQuery.Size = new System.Drawing.Size(874, 28);
            this.comboBoxQuery.TabIndex = 40;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(904, 40);
            this.btnExec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(178, 35);
            this.btnExec.TabIndex = 39;
            this.btnExec.Text = "Выполнить";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1092, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1092, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Специальность";
            // 
            // comboBoxSpec
            // 
            this.comboBoxSpec.FormattingEnabled = true;
            this.comboBoxSpec.Location = new System.Drawing.Point(1096, 103);
            this.comboBoxSpec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSpec.Name = "comboBoxSpec";
            this.comboBoxSpec.Size = new System.Drawing.Size(298, 28);
            this.comboBoxSpec.TabIndex = 35;
            this.comboBoxSpec.ValueMember = "Код_специалиста";
            // 
            // dataGridQuery
            // 
            this.dataGridQuery.AutoGenerateColumns = false;
            this.dataGridQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодспециалистаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.номеркабинетаDataGridViewTextBoxColumn});
            this.dataGridQuery.DataSource = this.специалистBindingSource;
            this.dataGridQuery.Location = new System.Drawing.Point(20, 82);
            this.dataGridQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridQuery.Name = "dataGridQuery";
            this.dataGridQuery.Size = new System.Drawing.Size(1064, 575);
            this.dataGridQuery.TabIndex = 34;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(1096, 223);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker.TabIndex = 41;
            // 
            // медосмотрDataSet1
            // 
            this.медосмотрDataSet1.DataSetName = "МедосмотрDataSet";
            this.медосмотрDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // специалистBindingSource
            // 
            this.специалистBindingSource.DataMember = "Специалист";
            this.специалистBindingSource.DataSource = this.медосмотрDataSet1;
            // 
            // специалистTableAdapter1
            // 
            this.специалистTableAdapter1.ClearBeforeFill = true;
            // 
            // кодспециалистаDataGridViewTextBoxColumn
            // 
            this.кодспециалистаDataGridViewTextBoxColumn.DataPropertyName = "Код_специалиста";
            this.кодспециалистаDataGridViewTextBoxColumn.HeaderText = "Код_специалиста";
            this.кодспециалистаDataGridViewTextBoxColumn.Name = "кодспециалистаDataGridViewTextBoxColumn";
            this.кодспециалистаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // номеркабинетаDataGridViewTextBoxColumn
            // 
            this.номеркабинетаDataGridViewTextBoxColumn.DataPropertyName = "Номер_кабинета";
            this.номеркабинетаDataGridViewTextBoxColumn.HeaderText = "Номер_кабинета";
            this.номеркабинетаDataGridViewTextBoxColumn.Name = "номеркабинетаDataGridViewTextBoxColumn";
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 669);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxQuery);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSpec);
            this.Controls.Add(this.dataGridQuery);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QueryForm";
            this.Text = "Запросы";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.медосмотрDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специалистBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxQuery;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSpec;
        private System.Windows.Forms.DataGridView dataGridQuery;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private МедосмотрDataSet медосмотрDataSet;
        private МедосмотрDataSetTableAdapters.СпециалистTableAdapter специалистTableAdapter;
        private МедосмотрDataSet медосмотрDataSet1;
        private System.Windows.Forms.BindingSource специалистBindingSource;
        private МедосмотрDataSetTableAdapters.СпециалистTableAdapter специалистTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодспециалистаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номеркабинетаDataGridViewTextBoxColumn;
    }
}
namespace Medosmotr
{
    partial class SpecForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFIO = new System.Windows.Forms.TextBox();
            this.txtBoxCabinet = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridSpec = new System.Windows.Forms.DataGridView();
            this.медосмотрDataSet1 = new Medosmotr.МедосмотрDataSet();
            this.специалистBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.специалистTableAdapter1 = new Medosmotr.МедосмотрDataSetTableAdapters.СпециалистTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.медосмотрDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специалистBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1120, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1122, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Кабинет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1120, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Название специальности";
            // 
            // txtBoxFIO
            // 
            this.txtBoxFIO.Location = new System.Drawing.Point(1125, 163);
            this.txtBoxFIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxFIO.Name = "txtBoxFIO";
            this.txtBoxFIO.Size = new System.Drawing.Size(458, 26);
            this.txtBoxFIO.TabIndex = 27;
            // 
            // txtBoxCabinet
            // 
            this.txtBoxCabinet.Location = new System.Drawing.Point(1126, 312);
            this.txtBoxCabinet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxCabinet.Name = "txtBoxCabinet";
            this.txtBoxCabinet.Size = new System.Drawing.Size(457, 26);
            this.txtBoxCabinet.TabIndex = 25;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(1125, 42);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(457, 26);
            this.txtBoxName.TabIndex = 24;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1426, 458);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 35);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1270, 458);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 35);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1124, 458);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(138, 35);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridSpec
            // 
            this.dataGridSpec.AutoGenerateColumns = false;
            this.dataGridSpec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSpec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridSpec.DataSource = this.специалистBindingSource;
            this.dataGridSpec.Location = new System.Drawing.Point(34, 18);
            this.dataGridSpec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridSpec.Name = "dataGridSpec";
            this.dataGridSpec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSpec.Size = new System.Drawing.Size(1082, 475);
            this.dataGridSpec.TabIndex = 20;
            this.dataGridSpec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSpec_CellClick);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_специалиста";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_специалиста";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Номер_кабинета";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер_кабинета";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // SpecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 517);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxFIO);
            this.Controls.Add(this.txtBoxCabinet);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridSpec);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SpecForm";
            this.Text = "Специалисты";
            this.Load += new System.EventHandler(this.SpecForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.медосмотрDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специалистBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFIO;
        private System.Windows.Forms.TextBox txtBoxCabinet;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridSpec;
        private МедосмотрDataSet медосмотрDataSet;
        private МедосмотрDataSetTableAdapters.СпециалистTableAdapter специалистTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодспециалистаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номеркабинетаDataGridViewTextBoxColumn;
        private МедосмотрDataSet медосмотрDataSet1;
        private System.Windows.Forms.BindingSource специалистBindingSource;
        private МедосмотрDataSetTableAdapters.СпециалистTableAdapter специалистTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
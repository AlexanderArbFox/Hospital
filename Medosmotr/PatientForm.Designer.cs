namespace Medosmotr
{
    partial class PatientForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxFIO = new System.Windows.Forms.TextBox();
            this.dataGridPatient = new System.Windows.Forms.DataGridView();
            this.медосмотрDataSet = new Medosmotr.МедосмотрDataSet();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.txtBoxSerial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.медосмотрDataSet1 = new Medosmotr.МедосмотрDataSet();
            this.пациентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пациентTableAdapter = new Medosmotr.МедосмотрDataSetTableAdapters.ПациентTableAdapter();
            this.кодпациентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.медосмотрDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.медосмотрDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1252, 509);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 35);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1096, 509);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 35);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(936, 509);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(132, 35);
            this.btnInsert.TabIndex = 40;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(934, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Серия паспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(934, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(934, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "ФИО";
            // 
            // txtBoxFIO
            // 
            this.txtBoxFIO.Location = new System.Drawing.Point(939, 54);
            this.txtBoxFIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxFIO.Name = "txtBoxFIO";
            this.txtBoxFIO.Size = new System.Drawing.Size(434, 26);
            this.txtBoxFIO.TabIndex = 33;
            // 
            // dataGridPatient
            // 
            this.dataGridPatient.AutoGenerateColumns = false;
            this.dataGridPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпациентаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.серияDataGridViewTextBoxColumn,
            this.номерDataGridViewTextBoxColumn});
            this.dataGridPatient.DataSource = this.пациентBindingSource;
            this.dataGridPatient.Location = new System.Drawing.Point(21, 29);
            this.dataGridPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridPatient.Name = "dataGridPatient";
            this.dataGridPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPatient.Size = new System.Drawing.Size(909, 515);
            this.dataGridPatient.TabIndex = 31;
            this.dataGridPatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPatient_CellClick);
            // 
            // медосмотрDataSet
            // 
            this.медосмотрDataSet.DataSetName = "МедосмотрDataSet";
            this.медосмотрDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(939, 378);
            this.txtBoxNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxNumber.MaxLength = 6;
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(434, 26);
            this.txtBoxNumber.TabIndex = 43;
            // 
            // txtBoxSerial
            // 
            this.txtBoxSerial.Location = new System.Drawing.Point(939, 272);
            this.txtBoxSerial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxSerial.MaxLength = 4;
            this.txtBoxSerial.Name = "txtBoxSerial";
            this.txtBoxSerial.Size = new System.Drawing.Size(434, 26);
            this.txtBoxSerial.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(932, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Номер паспорта";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.comboBoxGender.Location = new System.Drawing.Point(939, 163);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(434, 28);
            this.comboBoxGender.TabIndex = 46;
            // 
            // медосмотрDataSet1
            // 
            this.медосмотрDataSet1.DataSetName = "МедосмотрDataSet";
            this.медосмотрDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пациентBindingSource
            // 
            this.пациентBindingSource.DataMember = "Пациент";
            this.пациентBindingSource.DataSource = this.медосмотрDataSet1;
            // 
            // пациентTableAdapter
            // 
            this.пациентTableAdapter.ClearBeforeFill = true;
            // 
            // кодпациентаDataGridViewTextBoxColumn
            // 
            this.кодпациентаDataGridViewTextBoxColumn.DataPropertyName = "Код_пациента";
            this.кодпациентаDataGridViewTextBoxColumn.HeaderText = "Код_пациента";
            this.кодпациентаDataGridViewTextBoxColumn.Name = "кодпациентаDataGridViewTextBoxColumn";
            this.кодпациентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            // 
            // серияDataGridViewTextBoxColumn
            // 
            this.серияDataGridViewTextBoxColumn.DataPropertyName = "Серия";
            this.серияDataGridViewTextBoxColumn.HeaderText = "Серия";
            this.серияDataGridViewTextBoxColumn.Name = "серияDataGridViewTextBoxColumn";
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 574);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxSerial);
            this.Controls.Add(this.txtBoxNumber);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxFIO);
            this.Controls.Add(this.dataGridPatient);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PatientForm";
            this.Text = "Пациенты";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.медосмотрDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.медосмотрDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxFIO;
        private System.Windows.Forms.DataGridView dataGridPatient;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.TextBox txtBoxSerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private МедосмотрDataSet медосмотрDataSet;
        private МедосмотрDataSet медосмотрDataSet1;
        private System.Windows.Forms.BindingSource пациентBindingSource;
        private МедосмотрDataSetTableAdapters.ПациентTableAdapter пациентTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпациентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
    }
}
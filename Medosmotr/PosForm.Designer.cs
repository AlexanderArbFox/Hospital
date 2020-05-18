namespace Medosmotr
{
    partial class PosForm
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
            this.comboBoxSpec = new System.Windows.Forms.ComboBox();
            this.comboBoxPac = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxZakl = new System.Windows.Forms.TextBox();
            this.dataGridPos = new System.Windows.Forms.DataGridView();
            this.Код_посещения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пациент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Специалист = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Заключение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.медосмотрDataSet1 = new Medosmotr.МедосмотрDataSet();
            this.посещениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.посещениеTableAdapter = new Medosmotr.МедосмотрDataSetTableAdapters.ПосещениеTableAdapter();
            this.кодпосещенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпациентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодспециалистаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заключениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.медосмотрDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1209, 511);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(297, 35);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1209, 466);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(297, 35);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1209, 422);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(297, 35);
            this.btnInsert.TabIndex = 40;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1204, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Специалист";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1204, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Пациент";
            // 
            // comboBoxSpec
            // 
            this.comboBoxSpec.FormattingEnabled = true;
            this.comboBoxSpec.Location = new System.Drawing.Point(1209, 162);
            this.comboBoxSpec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSpec.Name = "comboBoxSpec";
            this.comboBoxSpec.Size = new System.Drawing.Size(295, 28);
            this.comboBoxSpec.TabIndex = 37;
            this.comboBoxSpec.ValueMember = "Код_специалиста";
            // 
            // comboBoxPac
            // 
            this.comboBoxPac.FormattingEnabled = true;
            this.comboBoxPac.Location = new System.Drawing.Point(1209, 49);
            this.comboBoxPac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPac.Name = "comboBoxPac";
            this.comboBoxPac.Size = new System.Drawing.Size(295, 28);
            this.comboBoxPac.TabIndex = 36;
            this.comboBoxPac.ValueMember = "Код_пациента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1204, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1204, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Заключение";
            // 
            // txtBoxZakl
            // 
            this.txtBoxZakl.Location = new System.Drawing.Point(1209, 371);
            this.txtBoxZakl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxZakl.Name = "txtBoxZakl";
            this.txtBoxZakl.Size = new System.Drawing.Size(298, 26);
            this.txtBoxZakl.TabIndex = 32;
            // 
            // dataGridPos
            // 
            this.dataGridPos.AutoGenerateColumns = false;
            this.dataGridPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код_посещения,
            this.Пациент,
            this.Специалист,
            this.Дата,
            this.Заключение,
            this.кодпосещенияDataGridViewTextBoxColumn,
            this.кодпациентаDataGridViewTextBoxColumn,
            this.кодспециалистаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.заключениеDataGridViewTextBoxColumn});
            this.dataGridPos.DataSource = this.посещениеBindingSource;
            this.dataGridPos.Location = new System.Drawing.Point(21, 29);
            this.dataGridPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridPos.Name = "dataGridPos";
            this.dataGridPos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPos.Size = new System.Drawing.Size(1164, 515);
            this.dataGridPos.TabIndex = 31;
            this.dataGridPos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPos_CellClick);
            // 
            // Код_посещения
            // 
            this.Код_посещения.DataPropertyName = "Код_посещения";
            this.Код_посещения.Frozen = true;
            this.Код_посещения.HeaderText = "Код_посещения";
            this.Код_посещения.Name = "Код_посещения";
            this.Код_посещения.ReadOnly = true;
            this.Код_посещения.Visible = false;
            // 
            // Пациент
            // 
            this.Пациент.DataPropertyName = "Пациент";
            this.Пациент.Frozen = true;
            this.Пациент.HeaderText = "Пациент";
            this.Пациент.Name = "Пациент";
            this.Пациент.ReadOnly = true;
            this.Пациент.Width = 225;
            // 
            // Специалист
            // 
            this.Специалист.DataPropertyName = "Специалист";
            this.Специалист.HeaderText = "Специалист";
            this.Специалист.Name = "Специалист";
            this.Специалист.ReadOnly = true;
            this.Специалист.Width = 225;
            // 
            // Дата
            // 
            this.Дата.DataPropertyName = "Дата";
            this.Дата.HeaderText = "Дата";
            this.Дата.Name = "Дата";
            this.Дата.ReadOnly = true;
            this.Дата.Width = 80;
            // 
            // Заключение
            // 
            this.Заключение.DataPropertyName = "Заключение";
            this.Заключение.HeaderText = "Заключение";
            this.Заключение.Name = "Заключение";
            this.Заключение.ReadOnly = true;
            this.Заключение.Width = 200;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(1209, 275);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker.TabIndex = 43;
            // 
            // медосмотрDataSet1
            // 
            this.медосмотрDataSet1.DataSetName = "МедосмотрDataSet";
            this.медосмотрDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // посещениеBindingSource
            // 
            this.посещениеBindingSource.DataMember = "Посещение";
            this.посещениеBindingSource.DataSource = this.медосмотрDataSet1;
            // 
            // посещениеTableAdapter
            // 
            this.посещениеTableAdapter.ClearBeforeFill = true;
            // 
            // кодпосещенияDataGridViewTextBoxColumn
            // 
            this.кодпосещенияDataGridViewTextBoxColumn.DataPropertyName = "Код_посещения";
            this.кодпосещенияDataGridViewTextBoxColumn.HeaderText = "Код_посещения";
            this.кодпосещенияDataGridViewTextBoxColumn.Name = "кодпосещенияDataGridViewTextBoxColumn";
            this.кодпосещенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодпациентаDataGridViewTextBoxColumn
            // 
            this.кодпациентаDataGridViewTextBoxColumn.DataPropertyName = "Код_пациента";
            this.кодпациентаDataGridViewTextBoxColumn.HeaderText = "Код_пациента";
            this.кодпациентаDataGridViewTextBoxColumn.Name = "кодпациентаDataGridViewTextBoxColumn";
            // 
            // кодспециалистаDataGridViewTextBoxColumn
            // 
            this.кодспециалистаDataGridViewTextBoxColumn.DataPropertyName = "Код_специалиста";
            this.кодспециалистаDataGridViewTextBoxColumn.HeaderText = "Код_специалиста";
            this.кодспециалистаDataGridViewTextBoxColumn.Name = "кодспециалистаDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // заключениеDataGridViewTextBoxColumn
            // 
            this.заключениеDataGridViewTextBoxColumn.DataPropertyName = "Заключение";
            this.заключениеDataGridViewTextBoxColumn.HeaderText = "Заключение";
            this.заключениеDataGridViewTextBoxColumn.Name = "заключениеDataGridViewTextBoxColumn";
            // 
            // PosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 560);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSpec);
            this.Controls.Add(this.comboBoxPac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxZakl);
            this.Controls.Add(this.dataGridPos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PosForm";
            this.Text = "Посещения";
            this.Load += new System.EventHandler(this.PosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.медосмотрDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSpec;
        private System.Windows.Forms.ComboBox comboBoxPac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxZakl;
        private System.Windows.Forms.DataGridView dataGridPos;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private МедосмотрDataSet медосмотрDataSet;
        private МедосмотрDataSetTableAdapters.ПациентTableAdapter пациентTableAdapter;
        private МедосмотрDataSetTableAdapters.СпециалистTableAdapter специалистTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_посещения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пациент;
        private System.Windows.Forms.DataGridViewTextBoxColumn Специалист;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата;
        private System.Windows.Forms.DataGridViewTextBoxColumn Заключение;
        private МедосмотрDataSet медосмотрDataSet1;
        private System.Windows.Forms.BindingSource посещениеBindingSource;
        private МедосмотрDataSetTableAdapters.ПосещениеTableAdapter посещениеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпосещенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпациентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодспециалистаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заключениеDataGridViewTextBoxColumn;
    }
}
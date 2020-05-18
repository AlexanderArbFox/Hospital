namespace Medosmotr
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnSpec = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(24, 194);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(157, 23);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "Запросы";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnSpec
            // 
            this.btnSpec.Location = new System.Drawing.Point(24, 87);
            this.btnSpec.Name = "btnSpec";
            this.btnSpec.Size = new System.Drawing.Size(157, 23);
            this.btnSpec.TabIndex = 6;
            this.btnSpec.Text = "Специалисты";
            this.btnSpec.UseVisualStyleBackColor = true;
            this.btnSpec.Click += new System.EventHandler(this.btnSpec_Click);
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(24, 142);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(157, 23);
            this.btnPos.TabIndex = 5;
            this.btnPos.Text = "Посещения";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.Location = new System.Drawing.Point(24, 25);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(157, 23);
            this.btnPatient.TabIndex = 4;
            this.btnPatient.Text = "Пациенты";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 229);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnSpec);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.btnPatient);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnSpec;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnPatient;
    }
}


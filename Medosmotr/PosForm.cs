using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medosmotr
{
    public partial class PosForm : Form
    {
        int id;
        public PosForm()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                ExecQuery(db);
                comboBoxPac.DataSource = db.Пациент.ToList();
                comboBoxSpec.DataSource = db.Специалист.ToList();
                dateTimePicker.Value = DateTime.Today;
            }
        }

        void ExecQuery(Context db)
        {
            dataGridPos.DataSource = db.Посещение.Join(db.Пациент, po => po.Код_пациента, p => p.Код_пациента,
                (po, p) =>
                new
                {
                    po.Код_посещения,
                    Пациент = p.ФИО,
                    po.Код_специалиста,
                    po.Дата,
                    po.Заключение
                }
                ).Join(db.Специалист, pa => pa.Код_специалиста, s => s.Код_специалиста,
                (pa, s) =>
                new
                {
                    pa.Код_посещения,
                    pa.Пациент,
                    Специалист = s.ФИО,
                    pa.Дата,
                    pa.Заключение
                }).ToList();
        }
        private void reload(Context db)
        {
            try
            {
                db.SaveChanges();
                ExecQuery(db);
                dataGridPos.ClearSelection();
                Clear();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Запись данного пациента к специалисту на эту дату уже есть!");
            }
        }

        void Clear()
        {
            dateTimePicker.Value = DateTime.Today;
            txtBoxZakl.Clear();
        }

        private void PosForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "медосмотрDataSet1.Посещение". При необходимости она может быть перемещена или удалена.
            this.посещениеTableAdapter.Fill(this.медосмотрDataSet1.Посещение);
             dataGridPos.ClearSelection();
        }

        private void dataGridPos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridPos.SelectedRows[0].Index;
            id = (int)dataGridPos[0, row].Value;

            comboBoxPac.Text = dataGridPos[1, row].Value.ToString();
            comboBoxSpec.Text = dataGridPos[2, row].Value.ToString();
            dateTimePicker.Value = (DateTime)dataGridPos[3, row].Value;
            txtBoxZakl.Text = dataGridPos[4, row].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                db.Посещение.Add(new Посещение
                {
                    Код_пациента = (int)comboBoxPac.SelectedValue,
                    Код_специалиста = (int)comboBoxSpec.SelectedValue,
                    Дата = dateTimePicker.Value,
                    Заключение = txtBoxZakl.Text
                });
                reload(db);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                using (Context db = new Context())
                {
                    foreach (DataGridViewRow row in dataGridPos.SelectedRows)
                    {
                        int id = (int)dataGridPos[0, row.Index].Value;
                        DialogResult answer;
                        Посещение delete_pos = db.Посещение.Where(po => po.Код_посещения == id).FirstOrDefault();
                        Специалист delete_s = db.Специалист.Where(s => s.Код_специалиста == delete_pos.Код_специалиста).FirstOrDefault();
                        Пациент delete_p = db.Пациент.Where(p => p.Код_пациента == delete_pos.Код_пациента).FirstOrDefault();
                        answer = MessageBox.Show($"Удалить запись на {delete_pos.Дата.ToShortDateString()} " +
                            $"к {delete_s.ФИО} пациента {delete_p.ФИО}?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (answer == (DialogResult)6)
                        {
                            db.Посещение.Remove(delete_pos);
                        }
                    }
                    reload(db);
                }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                Посещение update_pos = db.Посещение.Where(po => po.Код_посещения == id).FirstOrDefault();
                update_pos.Код_пациента = (int)comboBoxPac.SelectedValue;
                update_pos.Код_специалиста = (int)comboBoxSpec.SelectedValue;
                update_pos.Дата = dateTimePicker.Value;
                update_pos.Заключение = txtBoxZakl.Text;
                reload(db);
            }
        }
    }
}

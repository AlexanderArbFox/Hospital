using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medosmotr
{
    public partial class SpecForm : Form
    {
        Regex regexFIO = new Regex(@"^[А-Я][а-я]{0,15}\s[А-Я][а-я]{0,15}\s[А-Я][а-я]{0,15}$");
        Regex regexCab = new Regex(@"[0-9]");
        public SpecForm()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                dataGridSpec.DataSource = db.Специалист.ToList();
            }
        }

        private void SpecForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "медосмотрDataSet1.Специалист". При необходимости она может быть перемещена или удалена.
            this.специалистTableAdapter1.Fill(this.медосмотрDataSet1.Специалист);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "медосмотрDataSet.Специалист". При необходимости она может быть перемещена или удалена.
            //this.специалистTableAdapter.Fill(this.медосмотрDataSet.Специалист);
            dataGridSpec.ClearSelection();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (Correct())
            {
                using (Context db = new Context())
                {
                    db.Специалист.Add(new Специалист
                    {
                        Название = txtBoxName.Text,
                        ФИО = txtBoxFIO.Text,
                        Номер_кабинета = Convert.ToInt32(txtBoxCabinet.Text)
                    });
                    reload(db);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Correct())
            {
                using (Context db = new Context())
                {
                    foreach (DataGridViewRow row in dataGridSpec.SelectedRows)
                    {
                        DialogResult answer;
                        int id = (int)dataGridSpec[0, row.Index].Value;

                        Специалист delete_spec = db.Специалист.Where(s => s.Код_специалиста == id).FirstOrDefault();
                        answer = MessageBox.Show($"Вы действительно хотите удалить специалиста {delete_spec.ФИО}?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (answer == (DialogResult)6)
                        {
                            db.Специалист.Remove(delete_spec);
                        }
                    }
                    reload(db);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Correct())
            {
                int id = (int)dataGridSpec[0, dataGridSpec.SelectedRows[0].Index].Value;

                using (Context db = new Context())
                {
                    Специалист update_spec = db.Специалист.Where(s => s.Код_специалиста == id).FirstOrDefault();
                    update_spec.Название = txtBoxName.Text;
                    update_spec.ФИО = txtBoxFIO.Text;
                    update_spec.Номер_кабинета = Convert.ToInt32(txtBoxCabinet.Text);
                    reload(db);
                }
            }
        }

        private bool Correct()
        {
            string fio = txtBoxFIO.Text;
            string cab = txtBoxCabinet.Text;
            if (!regexFIO.IsMatch(fio) || !regexCab.IsMatch(cab))
            {
                MessageBox.Show("Некорректные ФИО или номер кабинета!");
                return false;
            }
            else return true;
        }

        private void reload(Context db)
        {
            try
            {
                db.SaveChanges();
                dataGridSpec.DataSource = db.Специалист.ToList();
                dataGridSpec.ClearSelection();
                Clear();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Введены не все данные!");
            }
        }

        void Clear()
        {
            txtBoxFIO.Clear();
            txtBoxName.Clear();
            txtBoxCabinet.Clear();
        }

        private void dataGridSpec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridSpec.SelectedRows[0].Index;

            txtBoxName.Text = dataGridSpec[1, row].Value.ToString();
            txtBoxFIO.Text = dataGridSpec[2, row].Value.ToString();
            txtBoxCabinet.Text = dataGridSpec[3, row].Value.ToString();
        }
    }
}

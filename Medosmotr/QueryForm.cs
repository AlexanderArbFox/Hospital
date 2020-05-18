using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medosmotr
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                comboBoxSpec.DataSource = db.Специалист.Select(s => s.Название).Distinct().ToList();
            }
        }

        dynamic ExecQuery1(Context db)
        {
            //Вывести список пациентов мужского пола с указанием паспортных данных;
            return db.Пациент.Where(p => p.Пол == "М").Select(p =>
            new
            {
                ФИО_пациента = p.ФИО,
                p.Серия,
                p.Номер
            }).ToList();
        }


        dynamic ExecQuery2(Context db)
        {
            //Отобразить данные (ФИО, номер кабинета) о специалистах 
            //определенного направления (например, окулистах);
            string spec = comboBoxSpec.Text;
            return db.Специалист.Where(s => s.Название == spec).Select
                (s =>
                new
                {
                    ФИО_специалиста = s.ФИО,
                    s.Номер_кабинета
                }).ToList();
        }

        dynamic ExecQuery3(Context db)
        {
            //Вывести следующую информацию о посещениях на определенную дату: 
            //ФИО пациента, ФИО специалиста, название специалиста, заключение.
            return db.Посещение.Where(p => p.Дата == dateTimePicker.Value.Date)
                .Select(p =>
                new
                {
                    ФИО_пациента = p.Пациент.ФИО,
                    ФИО_специалиста = p.Специалист.ФИО,
                    Специальность = p.Специалист.Название,
                    p.Заключение
                }).ToList();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                switch (comboBoxQuery.SelectedIndex)
                {
                    case 0: dataGridQuery.DataSource = ExecQuery1(db); break;
                    case 1: dataGridQuery.DataSource = ExecQuery2(db); break;
                    case 2: dataGridQuery.DataSource = ExecQuery3(db); break;
                }
            }
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "медосмотрDataSet1.Специалист". При необходимости она может быть перемещена или удалена.
            this.специалистTableAdapter1.Fill(this.медосмотрDataSet1.Специалист);
         

        }
    }
}

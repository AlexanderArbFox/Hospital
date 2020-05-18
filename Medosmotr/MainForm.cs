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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            new PatientForm().Show();
        }

        private void btnSpec_Click(object sender, EventArgs e)
        {
            new SpecForm().Show();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            new PosForm().Show();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            new QueryForm().Show();
        }
    }
}

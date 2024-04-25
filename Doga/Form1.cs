using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UtazasRepo utazasRepo = new UtazasRepo();
            utazasRepo.ListaFeltoltese();
            dataGridView_base.DataSource = utazasRepo.ListaFeltoltese();
        }
    }
}

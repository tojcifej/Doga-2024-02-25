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
        UtazasRepo utazasRepo = new UtazasRepo();


        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                utazasRepo.path = openFileDialog1.FileName;
            }

            utazasRepo.FindAll();
            dataGridView_base.DataSource = utazasRepo.FindAll();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.0\nKrauter Ádám csodálatos művészete");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kereses_Click(object sender, EventArgs e)
        {
            dataGridView_base.DataSource = utazasRepo.FindByID(int.Parse(textBox_Kereses_ID.Text));
        }
    }
}

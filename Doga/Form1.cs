using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            if(textBox_Kereses_ID.Text != "")
                dataGridView_base.DataSource = utazasRepo.FindByID(int.Parse(textBox_Kereses_ID.Text));
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            List<Utazas> utazasok = new List<Utazas>();
            utazasok = utazasRepo.FindAll();

            utazasRepo.SaveList(utazasok, utazasRepo.path, textBox_save_ID.Text, textBox_save_orszag.Text, textBox_save_Honap.Text, textBox_save_nap.Text, textBox_save_hossz.Text, textBox_save_ar.Text, comboBox_save_ellatas.SelectedItem.ToString());

            utazasok = utazasRepo.FindAll();
            dataGridView_base.DataSource = utazasok;
        }
    }
}

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
            dataGridView_base.DataSource = utazasRepo.FindByID(int.Parse(textBox_Kereses_ID.Text));
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            List<Utazas> utazasok = new List<Utazas>();

            utazasok = utazasRepo.FindAll();

            if(textBox_save_ID.Text == "" && textBox_save_ID.Text == "0")
            { //új
                Utazas uj = new Utazas
                {
                    ID = utazasok.Last().ID + 1,
                    Orszag = textBox_save_orszag.Text,
                    Honap = int.Parse(textBox_save_Honap.Text),
                    Nap = int.Parse(textBox_save_nap.Text),
                    Hossz = int.Parse(textBox_save_hossz.Text),
                    Ar = int.Parse(textBox_save_ar.Text),
                    Ellatas = comboBox_save_ellatas.SelectedItem.ToString()
                };
                utazasok.Add(uj);
            }
            else
            { //firssítés
                for (int i = 0; i < utazasok.Count; i++)
                    if (utazasok[i].ID == int.Parse(textBox_save_ID.Text))
                    {
                        if(textBox_save_orszag.Text != "")
                            utazasok[i].Orszag = textBox_save_orszag.Text;
                        if (textBox_save_Honap.Text != "")
                            utazasok[i].Honap = int.Parse(textBox_save_Honap.Text);
                        if (textBox_save_nap.Text != "")
                            utazasok[i].Nap = int.Parse(textBox_save_nap.Text);
                        if (textBox_save_ar.Text != "")
                            utazasok[i].Hossz = int.Parse(textBox_save_ar.Text);
                        if (comboBox_save_ellatas.SelectedItem != null)
                            utazasok[i].Ellatas = comboBox_save_ellatas.SelectedItem.ToString();
                    }
            }

            dataGridView_base.DataSource = utazasok;
            utazasRepo.SaveList(utazasok, utazasRepo.path);
        }
    }
}

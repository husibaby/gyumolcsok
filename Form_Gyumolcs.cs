using gyumolcsok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyumolcsok 
{
    public partial class Form_Gyumolcs : Form 
    {
        string muvelet;
        public Form_Gyumolcs(string muvelet, Object param = null)
        {
            InitializeComponent();
            this.muvelet = muvelet;
            switch (muvelet)
            {
                case "insert":
                    button1.Text = "Rögzítés";
                    this.Text = button1.Text;
                    break;
                case "update":
                    button1.Text = "Módosít";
                    this.Text = "A gyümölcs adatainak a módosítása";
                    // Gyümölcs kiválasztásán ellenőrzése
                    //Gyumolcs gyumolcs = (Gyumolcs)Program.nyitoForm.listBox_Gyumolcsok.SelectedItem;
                    Gyumolcs gyumolcs = (Gyumolcs)param;
                    textBox_Termekkod.Text = gyumolcs.Termekkod.ToString();
                    textBox_Nev.Text = gyumolcs.Nev.ToString();
                    numericUpDown_Mennyiseg.Value = (int)gyumolcs.Mennyiseg;
                    break;
                default:
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "insert":
                    ujGyumolcs();
                    break;
                case "update":
                    modosit();
                    break;
                default:
                    break;
            }
        }
        private void modosit()
        {
            int termekkod = textBox_Termekkod.Text.Length;
            if (String.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Hiányzó név!");
                textBox_Nev.Focus();
                return;
            }
            string nev = textBox_Nev.Text;
            if (numericUpDown_Mennyiseg.Value <= 0)
            {
                MessageBox.Show("Nem lehet 1-nél kevesebb a mennyiség!");
                return;
            }
            Gyumolcs gyumolcs = new Gyumolcs(termekkod, nev, (int)numericUpDown_Mennyiseg.Value);

            Program.nyitoForm.listBox_Gyumolcsok.Items.Add(gyumolcs);
            this.Close();
        }

        void ujGyumolcs()
        {
            int termekkod = Program.nyitoForm.listBox_Gyumolcsok.Items.Count + 1;
            if (String.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Hiányzó név!");
                textBox_Nev.Focus();
                return;
            }
            string nev = textBox_Nev.Text;
            if (numericUpDown_Mennyiseg.Value <= 0)
            {
                MessageBox.Show("Nem lehet 1-nél kevesebb a mennyiség!");
                return;
            }
            Gyumolcs ujGyumolcs = new Gyumolcs(termekkod, nev, (int)numericUpDown_Mennyiseg.Value);
            Program.nyitoForm.listBox_Gyumolcsok.Items.Add(ujGyumolcs);
            this.Close();
        }
    }
}


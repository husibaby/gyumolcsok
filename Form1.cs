using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gyumolcsok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            Form_Gyumolcs form_Gyumolcs=new Form_Gyumolcs("insert");
            form_Gyumolcs.ShowDialog();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {

            if (listBox_Gyumolcsok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott gyümölcs!");
                return;
            }
            Gyumolcs gyumolcs = (Gyumolcs)listBox_Gyumolcsok.SelectedItem;
            listBox_Gyumolcsok.Items.Remove(gyumolcs);
            Form_Gyumolcs form_Gyumolcs = new Form_Gyumolcs("update", gyumolcs);
            form_Gyumolcs.ShowDialog();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Gyumolcsok.SelectedIndex < 0)
            {
                MessageBox.Show("Nem választot ki gyümölcsöt!");
                return;
            }
            Gyumolcs gyumolcs = (Gyumolcs)listBox_Gyumolcsok.SelectedItem;
            listBox_Gyumolcsok.Items.Remove(gyumolcs);
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Gyumolcs item in listBox_Gyumolcsok.Items)
                    {
                        writer.Write(item.toTxt() + "\n");
                    }
                    writer.Flush();
                }

            }
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string adatFile = openFileDialog.FileName;
                using (StreamReader reader = new StreamReader(adatFile))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] sor = reader.ReadLine().Split(';');
                        Gyumolcs ujGyumolcs = new Gyumolcs(int.Parse(sor[0]), sor[1], int.Parse(sor[2]));
                        listBox_Gyumolcsok.Items.Add(ujGyumolcs);
                    }
                }
            }
        }
    }
}

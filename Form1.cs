using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20240203_Fruit_KorteA
{
    public partial class Form_FruitList : Form
    {
        public Form_FruitList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string adatFile = openFileDialog.FileName;
                using (StreamReader sr = new StreamReader(adatFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(';');
                        Fruit newFruit = new Fruit(ulong.Parse(sor[0]), sor[1], Int32.Parse(sor[2]));
                        listbox_fruits.Items.Add(newFruit);
                    }
                }
            }        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Fruit form_Fruit = new Form_Fruit("insert");
            form_Fruit.ShowDialog();
        }

        private void Form_FruitList_Load(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                using (StreamWriter myStream = new StreamWriter(filename))
                {
                    foreach (Fruit item in listbox_fruits.Items)
                    {
                        myStream.Write(item.toTxt());
                    }
                    myStream.Flush();
                }


            }

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (listbox_fruits.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott gyümölcs");
                return;
            }
            Fruit fruit = (Fruit)listbox_fruits.SelectedItem;
            listbox_fruits.Items.Remove(fruit);
            Form_Fruit form_Fruit = new Form_Fruit("update",fruit);
            form_Fruit.ShowDialog();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listbox_fruits.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott gyümölcs");
                return;
            }
            Fruit fruit = (Fruit)listbox_fruits.SelectedItem;
            listbox_fruits.Items.Remove(fruit);
            Form_Fruit form_Fruit = new Form_Fruit("delete",fruit);            
        }
    }
}

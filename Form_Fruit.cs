using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace _20240203_Fruit_KorteA
{
    public partial class Form_Fruit : Form
    {
        string muvelet; 
        public Form_Fruit(string muvelet, Object param = null)
        {
            InitializeComponent();
            this.muvelet = muvelet;
            switch (muvelet)
            {
                case "insert":
                    button1.Text = "Rögzítés";
                    this.Text = "Új gyümölcs adatai";
                    break;
                case "update":
                    button1.Text = "Módosít";
                    this.Text = "Gyümölcs adatainak módosítás";
                    //Fruit fruit = (Fruit)Program.nyitoForm.listbox_fruits.SelectedItem;
                    Fruit fruit =(Fruit)param;
                    textBox_Id.Text = fruit.Id.ToString();
                    textBox_Nev.Text = fruit.Name.ToString();
                    textBox_Menny.Text= fruit.Amount.ToString();
                    break;
                case "delete":
                    button1.Text = "Törlés";
                    this.Text = "Gyümölcs adatainak törlése";
                    break;
                default:
                    break;
            }            
        }
        
        private void Form_Fruit_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(muvelet)
            {
                case "insert":
                    newFruit();
                    break;
                case "update":
                    modifyFruit();
                    break;
            }
        }

        private void modifyFruit()
        {
            ulong id = ulong.Parse(textBox_Id.Text);    
            if (String.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Üres a név");
                textBox_Nev.Focus();
                return;
            }
            string name = textBox_Nev.Text;
            if (String.IsNullOrEmpty(textBox_Menny.Text))
            {
                MessageBox.Show("Üres a mennyiség");
                textBox_Menny.Focus();
                return;
            }
            int amount = Int32.Parse(textBox_Menny.Text);
            Fruit fruit = new Fruit(id, name, amount);
            foreach (Fruit item in Program.nyitoForm.listbox_fruits.Items)
            {
                if (item.Id == id)
                {
                    Program.nyitoForm.listbox_fruits.Items.Remove(item);
                }
            }
            Program.nyitoForm.listbox_fruits.Items.Add(fruit);
            this.Close();
        }

        void newFruit() 
        {
            ulong id = (ulong)(Program.nyitoForm.listbox_fruits.Items.Count + 1);
            if (String.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Üres a név");
                textBox_Nev.Focus();
                return;
            }
            string name = textBox_Nev.Text;
            if (String.IsNullOrEmpty(textBox_Menny.Text))
            {
                MessageBox.Show("Üres a mennyiség");
                textBox_Menny.Focus();
                return;
            }
            int amount = Int32.Parse(textBox_Menny.Text);
            Fruit newFruit = new Fruit(id, name, amount);
            Program.nyitoForm.listbox_fruits.Items.Add(newFruit);
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

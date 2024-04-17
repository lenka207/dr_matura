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


namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        //refresh dugme u formi 1
        // smerovi opsti itd
        
        List<List<string>> templateovi;
        public string imedat = @"C:\\Users\Ucenik.PRVABEOGIM\Desktop\Lenka\OOP\oop.txt";
        
        public Form1()
        {
            InitializeComponent();

            //templateovi = CSVcitac.Ucitaj(imedat);
           //UT(templateovi);
        }
        private void UT(List<List<string>> r)
        {
            foreach (var red in r)
            {
                try
                {
                    cb1.Items.Add(red[0]);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ostecen fajl");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2(this);
            Form2.Show();
        }

        private void cb1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            comboBox2.Text = templateovi[cb.SelectedIndex][1];
            comboBox3.Text = templateovi[cb.SelectedIndex][2];
            comboBox1.Text = templateovi[cb.SelectedIndex][3];//



        }

        private void button2_Click(object sender, EventArgs e)
        {
            templateovi.Clear();
            File.Delete(imedat);
            cb1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cb1.Items.Clear();
            templateovi = CSVcitac.Ucitaj(imedat);
             UT(templateovi);
      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

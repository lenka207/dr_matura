using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        List<List<string>> templateovi;
        public Form1()
        {
            InitializeComponent();
            templateovi = CSVcitac.Ucitaj(@"C:\\Users\Ucenik.PRVABEOGIM\Desktop\Lenka\OOP\oop4.txt");
            UT(templateovi);
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
        }
    }
}

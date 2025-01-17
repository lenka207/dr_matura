﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public Form2(Form1 pocetnaForma)
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> podaci = UcitajUNiz();
            if (podaci.Count == 0)
                return;
            Form2.Snimi1(podaci, @"C:\Users\Ucenik.PRVABEOGIM\Desktop\Lenka\OOP\oop4.txt");
        }

        private List<string> UcitajUNiz()
        {
            List<string> r = new List<string>();
            r.Add(textBox1.Text);
            r.Add(comboBox1.Text);
            r.Add(comboBox2.Text);
            foreach (string elem in r)
            {
                if (string.IsNullOrWhiteSpace(elem))
                {
                    MessageBox.Show("Unesite tekst koji želite spremiti u Notepad.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return new List<string>();
                }
            }

            return r;
        }
        public static void Snimi1(List<string> tx, string imeDatoteke)
        {
            StringBuilder csv = new StringBuilder();
            // List: [ime1 nesto zdravo]
            foreach (string elem in tx)
            {
                csv.Append("\"");
                csv.Append(elem);
                csv.Append("\"");
                csv.Append(",");
            }
            // csv: "ime1","nesto","zdravo",
            csv.Replace(",", "\n", csv.Length - 1, 1);
            try
            {
                File.AppendAllText(imeDatoteke, csv.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom spremanja datoteke: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

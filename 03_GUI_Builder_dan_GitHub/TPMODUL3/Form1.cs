﻿using System;
using System.Windows.Forms;

namespace TPMODUL3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string sapaan = "Halo " + nama;

            listBox1.Items.Add(sapaan);

            textBox1.Clear();
        }
    }
}

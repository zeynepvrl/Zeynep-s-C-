﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace üçkod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "+", "-", "*", "/", "#" };

            Random x = new Random();
            int sayı1, sayı2, sayı3;
            sayı1 = x.Next(0, sembol1.Length);
            sayı2 = x.Next(0, sembol2.Length);
            sayı3 = x.Next(0, 10);
            label1.Text = sembol1[sayı1].ToString() + sembol2[sayı2].ToString() + sayı3.ToString();
        }
    }
}

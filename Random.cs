using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random zeyn = new Random();
            int sayı1, sayı2, sayı3; 
            sayı1 = zeyn.Next(1, 10);
            sayı2 = zeyn.Next(1, 10);
            sayı3 = zeyn.Next(1, 10);
            label1.Text = sayı1.ToString();
            label2.Text = sayı2.ToString();
            label3.Text = sayı3.ToString();
        }
    }
}

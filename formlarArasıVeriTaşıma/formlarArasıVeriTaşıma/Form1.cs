using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlarArasıVeriTaşıma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 zeyn = new Form2();
            zeyn.kimden = textBox1.Text;
            zeyn.mesaj = textBox2.Text;
            zeyn.Show();
            this.Hide();
        }
    }
}

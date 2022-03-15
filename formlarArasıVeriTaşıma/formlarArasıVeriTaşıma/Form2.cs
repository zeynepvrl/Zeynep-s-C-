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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string mesaj;
        public string kimden;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = kimden;
            label2.Text = mesaj;      //bunlar form 1 den çekilecek veriler.
        }
    }
}

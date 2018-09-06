using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AA_BB_CC_DD__FF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v = int.Parse(textBox1.Text);
            int f = int.Parse(textBox2.Text);
            int ort = 0;
            ort = (v + f) / 2;
            if (ort < 40)
            {
                MessageBox.Show(" FF " + ort.ToString());
            }
            else if (ort < 50)
            {
                MessageBox.Show(" DD " + ort.ToString());
            }
            else if (ort < 70)
            {
                MessageBox.Show(" CC " + ort.ToString());
            }
            else if (ort < 90)
            {
                MessageBox.Show(" BB " + ort.ToString());
            }
            else if (ort < 101)
            {
                MessageBox.Show(" AA " + ort.ToString());
            }
            else if (ort > 100)
            {
                MessageBox.Show("Adam Kekleme");
            }

        }
    }
}

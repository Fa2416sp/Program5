using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program5
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double L, d, d1, m, m1, m2, V1, V2, Sk, S1, S2, S;
            const double ro = 7.9;
            L = Convert.ToDouble(textBox1.Text);
            d = Convert.ToDouble(textBox2.Text);
            d1 = Convert.ToDouble(textBox3.Text);

            V1 = Math.PI * (double)((Math.Pow(d, 2)) / 4) * L;
            V2 = Math.PI * (double)((Math.Pow((d - 2 * d1), 2)) / 4) * L;
            m1 = ro * V1;
            m2 = ro * V2;
            m = m1 - m2;
            S1 = Math.PI * d * L;
            S2 = Math.PI * (d - 2 * d1) * L;
            Sk = Math.PI * (double)(Math.Pow((d - 2 * d1), 2)) / 4;
            S = 2 * Sk + S1 + S2;
            button1.Visible = false;
            textBox4.Text = Convert.ToString(S);
            textBox5.Text = Convert.ToString(m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}

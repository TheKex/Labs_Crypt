using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;


namespace RSA_Crypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BigInteger res = int.Parse(textBox1.Text);
            label1.Text = "кек " + RSA.IsPrime(res);
            //BigInteger[] res = RSA.Extended_Euclid(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            //label1.Text = "d =" + res[0].ToString() + " x = " + res[1].ToString() + " y = " + res[2].ToString();
        }
    }
}

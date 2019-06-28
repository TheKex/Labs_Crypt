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
        BigInteger p, q, num, res;
        RSA Crypt = new RSA();

        public Form1()
        {
            InitializeComponent();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Crypt.Refresh_E();
            Refresh_RSA_pass();

        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            res_textbox.Text = Crypt.Encrypt(BigInteger.Parse(msg_textbox.Text)).ToString();
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            res_textbox.Text = Crypt.Decrypt(BigInteger.Parse(msg_textbox.Text)).ToString();
        }

        private void Refresh_RSA_pass()
        {
            e_textbox.Text = Crypt.E.ToString();
            n_textbox.Text = Crypt.N.ToString();
            d_textbox.Text = Crypt.D.ToString();
        }

        private void Generation_Click(object sender, EventArgs e)
        {
            p = BigInteger.Parse(p_textbox.Text);
            q = BigInteger.Parse(q_textbox.Text);
            Crypt.Set_p_q(p, q);
            Refresh_RSA_pass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BigInteger res = int.Parse(textBox1.Text);
            //label1.Text = "кек " + RSA.IsPrime(res);


            BigInteger[] res = { int.Parse(e_textbox.Text), int.Parse(n_textbox.Text) };
            label1.Text = RSA.Power(res[0], res[1]).ToString();
        }
        
    }
}

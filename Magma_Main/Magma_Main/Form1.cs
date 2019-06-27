using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magma_Main
{
    

    public partial class Form1 : Form
    {
        Magma_Crypt _cypher = new Magma_Crypt();

        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    byte a = Convert.ToByte(textBox1.Text, 2);
        //    byte b = Convert.ToByte(textBox3.Text, 2);
        //    textBox2.Text = Convert.ToString((byte)(a ^ b), 2);
        //}

        private void cypher_Click(object sender, EventArgs e)
        {
            //Msg
            //fedcba9876543210

            //Key
            //ffeeddccbbaa99887766554433221100f0f1f2f3f4f5f6f7f8f9fafbfcfdfeff

            try
            {
                uint[] arr = new uint[8];
                for (int i = 0; i < 8; i++)
                {
                    string tmp = key_textbox.Text.Substring(i * 8, 8);
                    arr[i] = Convert.ToUInt32(tmp, 16);
                }
                _cypher.Set_key(arr);
            }
            catch (Exception)
            {

            }

            try
            {
                uint[] Msg = new uint[2];
                for (int i = 0; i < 2; i++)
                {
                    string tmp = msg_textbox.Text.Substring(i * 8, 8);
                    Msg[i] = Convert.ToUInt32(tmp, 16);
                }
                Array.Reverse(Msg);
                if(((Button)sender).Tag.ToString() == "1")
                {
                    uint[] res = _cypher.Crypt(Msg);
                    res_textbox.Text = Convert.ToString(res[0], 16) + Convert.ToString(res[1], 16);
                }
                else
                {
                    uint[] res = _cypher.Decrypt(Msg);
                    res_textbox.Text = Convert.ToString(res[0], 16) + Convert.ToString(res[1], 16);
                }
                
            }
            catch (Exception)
            {

            }            
        }

        private void key_textbox_TextChanged(object sender, EventArgs e)
        {
            int tmp1 = key_textbox.Text.Length;
            if(tmp1 < 64)
            {
                key_label.ForeColor = Color.Black;
                //= new Font(key_label.Font, new FontStyle());
            }
            if(tmp1 == 64)
            {
                key_label.ForeColor = Color.Green;
            }
            if (tmp1 > 64)
            {
                key_label.ForeColor = Color.Red;
            }
            key_label.Text = tmp1.ToString() + " из 64";
        }
        private void msg_textbox_TextChanged(object sender, EventArgs e)
        {
            int tmp1 = msg_textbox.Text.Length;
            if (tmp1 < 16)
            {
                msg_label.ForeColor = Color.Black;
                //= new Font(key_label.Font, new FontStyle());
            }
            if (tmp1 == 16)
            {
                msg_label.ForeColor = Color.Green;
            }
            if (tmp1 > 16)
            {
                msg_label.ForeColor = Color.Red;
            }
            msg_label.Text = tmp1.ToString() + " из 16";
        }

    }
}

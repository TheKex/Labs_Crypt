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

        private void cypher_Click(object sender, EventArgs e)
        {
            try
            {
                if (key_textbox.Text.Length < 64)
                    throw new Exception("Длина ключа слишком мала");
                if (key_textbox.Text.Length > 64)
                    throw new Exception("Длина ключа слишком велика");

                uint[] arr = new uint[8];
                for (int i = 0; i < 8; i++)
                {
                    string tmp = key_textbox.Text.Substring(i * 8, 8);
                    arr[i] = Convert.ToUInt32(tmp, 16);
                }
                _cypher.Set_key(arr);

                try
                {
                    if (msg_textbox.Text.Length < 16)
                        throw new Exception("Длина сообщения слишком мала");
                    if (msg_textbox.Text.Length > 16)
                        throw new Exception("Длина сообщения слишком велика");


                    uint[] Msg = new uint[2];
                    for (int i = 0; i < 2; i++)
                    {
                        string tmp = msg_textbox.Text.Substring(i * 8, 8);
                        Msg[i] = Convert.ToUInt32(tmp, 16);
                    }
                    Array.Reverse(Msg);
                    if (((Button)sender).Tag.ToString() == "1")
                    {
                        uint[] res = _cypher.Crypt(Msg);
                        res_textbox.Text = res[1].ToString("x8") + res[0].ToString("x8");
                    }
                    else
                    {
                        uint[] res = _cypher.Decrypt(Msg);
                        res_textbox.Text = res[1].ToString("x8") + res[0].ToString("x8");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

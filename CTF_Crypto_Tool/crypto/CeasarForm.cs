using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTF_Crypto_Tool.crypto
{
    public partial class CeasarForm : Form
    {
        public CeasarForm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            modeComboBox.Items.Add("ListAllResult");
            modeComboBox.SelectedIndex = 0;
            for(int i = 1; i <= 25; i++)
            {
                modeComboBox.Items.Add("Rot" + i);
            }
        }

        private void buttonExectute_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            string chipper = textBoxchipper.Text;
            int mode = modeComboBox.SelectedIndex;
            if(mode == 0)
            {
                for(int i = 1; i <= 25; i++)
                {
                    textBoxResult.Text += RotN(chipper, i) + '\r' + '\n';
                }
            }
            else
            {
                textBoxResult.Text += RotN(chipper, mode);
            }
        }

        private string RotN(string s ,int n)
        {
            string t = "";
            for(int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if(c < 65 || (c > 90 && c < 97) || c > 122)
                {
                    t += c;
                    continue;
                }
                else
                {
                    if(c >= 65 && c <= 90 && c + n > 90)
                    {
                        t += (char)((c + n) - 26);
                    }
                    else if(c >= 97 && c <= 122 && c + n > 122)
                    {
                        t += (char)((c + n) - 26);
                    }
                    else
                    {
                        t += (char)(c + n);
                    }
                }
                
            }
            return t;
        }

        private void buttonEnOrDeCrypto_Click(object sender, EventArgs e)
        {
            string chipper = textBox2.Text;
            string key = textBox4.Text;
            key = key.ToLower();
            int addOrSub = 1;
            textBox1.Text = "";
            int[] keyArray = new int[key.Length];
            for(int i = 0; i < key.Length; i++)
                keyArray[i] = key[i] - 97;
            if((sender as Button).Text == "加密")
                addOrSub = 1;
            if((sender as Button).Text == "解密")
                addOrSub = -1;
            int keyIndex = 0;
            string t = "";
            for(int i = 0; i < chipper.Length; i++)
            {
                int tc = 0;
                if (chipper[i] < 65 || (chipper[i] > 90 && chipper[i] < 97) || chipper[i] > 122)
                    tc = chipper[i];
                else if(chipper[i] >= 65 && chipper[i] <= 90)
                {
                    tc = (chipper[i] + addOrSub * keyArray[keyIndex++]);
                    if (tc > 90) tc -= 26;
                    if (tc < 65) tc += 26;
                }
                else if (chipper[i] >= 97 && chipper[i] <= 122)
                {
                    tc = (chipper[i] + addOrSub * keyArray[keyIndex++]);
                    if (tc > 122) tc -= 26;
                    if (tc < 97) tc += 26;
                }
                t += (char)tc;
                keyIndex %= keyArray.Length;
                //MessageBox.Show((keyArray[i].ToString()));
            }
            textBox1.Text = t;
        }
    }
}

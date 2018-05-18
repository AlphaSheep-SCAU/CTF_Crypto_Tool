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
    public partial class FenceForm : Form
    {
        private string message;
        private int groupNumber;
        private cryptocs.FenceCrypto cry;

        public FenceForm()
        {
            InitializeComponent();
            cry = new cryptocs.FenceCrypto("", 0);
        }

        private bool CheckBlank()
        {
            message = textBoxChiper.Text;
            message = message.Replace(" ", "");
            message = message.Replace("\r", "");
            message = message.Replace("\n", "");
            if (message == "")
            {
                MessageBox.Show("没有输入明文或密文！");
                return false;
            }
            return true;
        }

        private bool CheckGroup()
        {
            string group = textBoxGroup.Text;
            if(group == "")
            {
                MessageBox.Show("没有输入栏数！");
                return false;
            }
            return true;
        }

        private void buttonEncrypto_Click(object sender, EventArgs e)
        {
            if (!CheckBlank() || ! CheckGroup()) return;
            groupNumber = int.Parse(textBoxGroup.Text);
            cry.Message = message;
            cry.Group = groupNumber;
            cry.Encrypt();
            textBoxChiper.Text = cry.CipherText;
        }

        private void buttonDecrypto_Click(object sender, EventArgs e)
        {
            if (!CheckBlank() || !CheckGroup()) return;
            groupNumber = int.Parse(textBoxGroup.Text);
            cry.Message = message;
            cry.Group = groupNumber;
            cry.Decrypt();
            textBoxChiper.Text = cry.ClearText;
        }

        private void buttonEncryptoAll_Click(object sender, EventArgs e)
        {
            if (!CheckBlank()) return;
            cry.Message = message;
            textBoxChiper.Text = "";
            for(int i = 2; i <= message.Length / 2; i++)
            {
                if (checkBox.Checked && message.Length % i != 0)
                    continue;
                cry.Group = i;
                cry.Encrypt();
                textBoxChiper.Text += i.ToString() + "栏：\r\n" + cry.CipherText + "\r\n";
            }
        }

        private void buttonDecryptoAll_Click(object sender, EventArgs e)
        {
            if (!CheckBlank()) return;
            cry.Message = message;
            textBoxChiper.Text = "";
            for (int i = 2; i <= message.Length / 2; i++)
            {
                if (checkBox.Checked && message.Length % i != 0)
                    continue;
                cry.Group = i;
                cry.Decrypt();
                textBoxChiper.Text += i.ToString() + "栏：\r\n" + cry.ClearText + "\r\n";
            }
        }

        private void textBoxGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
    }
}

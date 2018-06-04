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
    public partial class PlayFairForm : Form
    {
        private string key;
        private string message;
        private cryptocs.PlayFairCrypto cry;

        public PlayFairForm()
        {
            InitializeComponent();
            cry = new cryptocs.PlayFairCrypto();
        }

        private void buttonShowTable_Click(object sender, EventArgs e)
        {
            key = textBoxKey.Text;
            key = key.Replace(" ", "");
            key = key.Replace("\t", "");
            key = key.ToUpper();
            if (key == "")
            {
                MessageBox.Show("请输入密钥！");
                return;
            }
            cry.Key = key;

            textBoxResult.Text = cry.PrintTable();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            key = textBoxKey.Text;
            key = key.Replace(" ", "");
            key = key.Replace("\t", "");
            key = key.ToUpper();
            if (key == "")
            {
                MessageBox.Show("请输入密钥！");
                return;
            }
            message = textBoxMessage.Text;
            message = message.Replace(" ", "");
            message = message.Replace("\t", "");
            message = message.ToUpper();
            if(message == "")
            {
                MessageBox.Show("请输入明文或密文！");
                return;
            }
            cry.Key = key;
            cry.Message = message;
            cry.Encrypt();

            textBoxResult.Text = cry.CipherText;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            key = textBoxKey.Text;
            key = key.Replace(" ", "");
            key = key.Replace("\t", "");
            key = key.ToUpper();
            if (key == "")
            {
                MessageBox.Show("请输入密钥！");
                return;
            }
            message = textBoxMessage.Text;
            message = message.Replace(" ", "");
            message = message.Replace("\t", "");
            message = message.ToUpper();
            if (message == "")
            {
                MessageBox.Show("请输入明文或密文！");
                return;
            }
            cry.Key = key;
            cry.Message = message;
            cry.Decrypt();

            textBoxResult.Text = cry.ClearText;
        }
    }
}

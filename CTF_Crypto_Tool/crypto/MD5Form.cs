using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CTF_Crypto_Tool.crypto
{
    public partial class MD5Form : Form
    {
        private MD5 md5;
        private string cipher;

        public MD5Form()
        {
            InitializeComponent();
            md5 = new MD5CryptoServiceProvider();
            cipher = "";
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            cipher = textBoxCipher.Text;
            if(cipher == "")
            {
                MessageBox.Show("请你输入需要加密的明文");
                return;
            }
            byte[] result = Encoding.Default.GetBytes(textBoxCipher.Text.Trim());
            byte[] output = md5.ComputeHash(result);
            textBoxResult.Text = BitConverter.ToString(output).Replace("-", "");
        }
    }
}

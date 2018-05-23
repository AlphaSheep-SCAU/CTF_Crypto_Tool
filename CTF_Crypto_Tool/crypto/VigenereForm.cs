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
    public partial class VigenereForm : Form
    {
        private cryptocs.VigenereCrypto cry;

        public VigenereForm()
        {
            InitializeComponent();
            cry = new cryptocs.VigenereCrypto("", "");
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            cry.Message = textBoxMessage.Text;
            cry.Key = textBoxKey.Text;
            cry.Encrypt();
            textBoxResult.Text = cry.CipherText;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            cry.Message = textBoxMessage.Text;
            cry.Key = textBoxKey.Text;
            cry.Decrypt();
            textBoxResult.Text = cry.ClearText;
        }
    }
}

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
    public partial class BaconForm : Form
    {
        private cryptocs.BaconCrypto cry;
        private string message;

        public BaconForm()
        {
            InitializeComponent();
            cry = new cryptocs.BaconCrypto();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            message = textBoxMessage.Text;
            message = message.ToLower();
            cry.Message = message;
            cry.Encrypt();
            textBoxResult.Text = cry.CipherText + Environment.NewLine;
            textBoxResult.Text += cry.CipherText.ToUpper();
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            message = textBoxMessage.Text;
            message = message.ToLower();
            cry.Message = message;
            cry.Decrypt();
            textBoxResult.Text = cry.ClearText + Environment.NewLine;
            textBoxResult.Text += cry.ClearText.ToUpper();
        }

        private void buttonShowTable_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = cry.ShowTable;
        }
    }
}

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
    public partial class MorseForm : Form
    {
        private cryptocs.MorseCrypto cry;
        private char dit;
        private char dah;
        private string message;

        public MorseForm()
        {
            InitializeComponent();
            dit = '.';
            dah = '-';
            message = "";
            cry = new cryptocs.MorseCrypto(message, dit, dah);
        }

        private void textBoxPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if((sender as TextBox).Text.Length < 1 || e.KeyChar == 8)
                e.Handled = false;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxDit.Text != "")
                dit = textBoxDit.Text[0];
            if (textBoxDah.Text != "")
                dah = textBoxDah.Text[0];
            message = textBoxMessage.Text;
            if (message == "")
            {
                MessageBox.Show("请输入明文或者密文！");
                return;
            }
            cry.Message = message;
            cry.Dit = dit;
            cry.Dah = dah;
            cry.Decrypt();
            textBoxResult.Text = cry.ClearText;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxDit.Text != "")
                dit = textBoxDit.Text[0];
            if (textBoxDah.Text != "")
                dah = textBoxDah.Text[0];
            message = textBoxMessage.Text;
            if (message == "")
            {
                MessageBox.Show("请输入明文或者密文！");
                return;
            }
            message = message.Replace(" ", "");
            message = message.Replace("\n", "");
            message = message.Replace("\t", "");
            message = message.ToUpper();
            cry.Message = message;
            cry.Dit = dit;
            cry.Dah = dah;
            cry.Encrypt();
            textBoxResult.Text = cry.CipherText;
        }

        private void buttonShowTable_Click(object sender, EventArgs e)
        {
            cry.Dit = dit;
            cry.Dah = dah;
            cry.ShowTable();
            textBoxResult.Text = cry.CryptoTable;
        }

        private void textBoxDit_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDit.Text == "")
                dit = '.';
            else
                dit = textBoxDit.Text[0];
        }

        private void textBoxDah_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDit.Text == "")
                dah = '-';
            else
                dah = textBoxDah.Text[0];
        }
    }
}

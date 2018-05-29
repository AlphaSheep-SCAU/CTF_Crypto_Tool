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
    public partial class BaseWhatForm : Form
    {
        private cryptocs.Base64Crypto cry64;
        private cryptocs.Base32Crypto cry32;
        private cryptocs.Base16Crypto cry16;
        private string message;
        private int mode;

        public BaseWhatForm()
        {
            InitializeComponent();
            message = "";
            cry64 = new cryptocs.Base64Crypto();
            cry32 = new cryptocs.Base32Crypto();
            cry16 = new cryptocs.Base16Crypto();
            rb64.Checked = true;
            mode = 0;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            message = textBoxMessage.Text;
            if (mode == 0)
            {
                cry64.Message = message;
                cry64.Encrypt();
                textBoxResult.Text = cry64.CipherText;
            }
            else if(mode == 1)
            {
                cry32.Message = message;
                cry32.Encrypt();
                textBoxResult.Text = cry32.CipherText;
            }
            else if(mode == 2)
            {
                cry16.Message = message;
                cry16.Encrypt();
                textBoxResult.Text = cry16.CipherText;
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            message = textBoxMessage.Text;
            if (mode == 0)
            {
                cry64.Message = message;
                cry64.Decrypt();
                textBoxResult.Text = cry64.ClearText;
            }
            else if(mode == 1)
            {
                cry32.Message = message;
                cry32.Decrypt();
                textBoxResult.Text = cry32.ClearText;
            }
            else if(mode == 2)
            {
                cry16.Message = message;
                cry16.Decrypt();
                textBoxResult.Text = cry16.ClearText;
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rb64.Checked)
                mode = 0;
            else if (rb32.Checked)
                mode = 1;
            else if (rb16.Checked)
                mode = 2;
        }
    }
}

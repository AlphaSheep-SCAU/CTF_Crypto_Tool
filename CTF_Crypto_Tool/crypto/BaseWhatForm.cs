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
        private cryptocs.Base64Crypto cry;
        private string message;
        private int mode;

        public BaseWhatForm()
        {
            InitializeComponent();
            message = "";
            cry = new cryptocs.Base64Crypto();
            rb64.Checked = true;
            mode = 0;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                message = textBoxMessage.Text;
                cry.Message = message;
                cry.Encrypt();
                textBoxResult.Text = cry.CipherText;
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                message = textBoxMessage.Text;
                cry.Message = message;
                cry.Decrypt();
                textBoxResult.Text = cry.ClearText;
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

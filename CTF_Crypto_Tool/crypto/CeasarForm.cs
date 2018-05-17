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
        private cryptocs.CeasarCrypto cry;

        public CeasarForm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            for(int i = 1; i <= 25; i++)
            {
                modeComboBox.Items.Add(i);
            }
            modeComboBox.SelectedIndex = 0;
            cry = new cryptocs.CeasarCrypto("", 0);
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            cry.Message = textBoxchipper.Text;
            cry.ShiftNumber = modeComboBox.SelectedIndex + 1;
            //cryptocs.CeasarCrypto cry = new cryptocs.CeasarCrypto(message, mode);
            cry.Encrypt();
            textBoxResult.Text += cry.CipherText;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            cry.Message = textBoxchipper.Text;
            cry.ShiftNumber = modeComboBox.SelectedIndex + 1;
            //cryptocs.CeasarCrypto cry = new cryptocs.CeasarCrypto(message, mode);
            cry.Decrypt();
            textBoxResult.Text += cry.ClearText;
        }

        private void buttonListAllResult_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            cry.Message = textBoxchipper.Text;
            for (int i = 1; i <= 25; i++)
            {
                //cryptocs.CeasarCrypto cry = new cryptocs.CeasarCrypto(cipher, i);
                cry.ShiftNumber = i;
                cry.Encrypt();
                textBoxResult.Text += cry.CipherText + '\r' + '\n';
            }
        }

        /* 
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

         //   textBox1.Text = t;
        }*/
    }
}

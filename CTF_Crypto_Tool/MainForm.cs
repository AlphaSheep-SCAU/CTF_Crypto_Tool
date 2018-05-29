using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTF_Crypto_Tool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCeasarForm_Click(object sender, EventArgs e)
        {
            crypto.CeasarForm cf = new crypto.CeasarForm();
            cf.ShowDialog();
        }

        private void buttonFenceForm_Click(object sender, EventArgs e)
        {
            crypto.FenceForm ff = new crypto.FenceForm();
            ff.ShowDialog();
        }

        private void buttonVigenereForm_Click(object sender, EventArgs e)
        {
            crypto.VigenereForm vf = new crypto.VigenereForm();
            vf.ShowDialog();
        }

        private void buttonMorseForm_Click(object sender, EventArgs e)
        {
            crypto.MorseForm mf = new crypto.MorseForm();
            mf.ShowDialog();
        }

        private void buttonMD5_Click(object sender, EventArgs e)
        {
            crypto.MD5Form md5f = new crypto.MD5Form();
            md5f.ShowDialog();
        }

        private void buttonBase_Click(object sender, EventArgs e)
        {
            crypto.BaseWhatForm bwf = new crypto.BaseWhatForm();
            bwf.ShowDialog();
        }

        private void buttonBaconForm_Click(object sender, EventArgs e)
        {
            crypto.BaconForm bf = new crypto.BaconForm();
            bf.ShowDialog();
        }
    }
}

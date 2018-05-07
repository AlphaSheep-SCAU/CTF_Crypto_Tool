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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}

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
    public partial class FenceForm : Form
    {
        private string chiper;
        private int group_num;

        public FenceForm()
        {
            InitializeComponent();
        }

        private void buttonEncrypto_Click(object sender, EventArgs e)
        {
            chiper = textBoxChiper.Text;
            string group = textBoxGroup.Text;
            chiper = chiper.Replace(" ","");
            if(chiper == "" || group == "")
            {
                MessageBox.Show("没有输入明文或密文！");
                return;
            }
            group_num = int.Parse(group);
            int chiper_length = chiper.Length;
            string[] temp = new string[chiper_length/group_num];
            for(int i = 0; i < chiper_length; i++)
            {
                
            }
            Console.Write(temp);
        }
    }
}

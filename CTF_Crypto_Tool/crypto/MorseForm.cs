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
        private datastruct.BinaryTree<char> bt;
        private char dit;
        private char dah;
        private string message;

        public MorseForm()
        {
            InitializeComponent();
            dit = '.';
            dah = '-';
            message = "";
            GenerateMorseTable();
        }

        #region 生成摩斯密码表
        private void GenerateMorseTable()
        {
            bt = new datastruct.BinaryTree<char>(' ');
            GenerateTreeNode(bt.Root, 'T', 'E');
            GenerateTreeNode(bt.Root.LChild, 'M', 'N');
            GenerateTreeNode(bt.Root.RChild, 'A', 'I');
            GenerateTreeNode(bt.Root.LChild.LChild, 'O', 'G');
            GenerateTreeNode(bt.Root.LChild.RChild, 'K', 'D');
            GenerateTreeNode(bt.Root.RChild.LChild, 'W', 'R');
            GenerateTreeNode(bt.Root.RChild.RChild, 'U', 'S');
            GenerateTreeNode(bt.Root.LChild.LChild.LChild, ' ', ' ');
            GenerateTreeNode(bt.Root.LChild.LChild.RChild, 'Q', 'Z');
            GenerateTreeNode(bt.Root.LChild.RChild.LChild, 'Y', 'C');
            GenerateTreeNode(bt.Root.LChild.RChild.RChild, 'X', 'B');
            GenerateTreeNode(bt.Root.RChild.LChild.LChild, 'J', 'P');
            GenerateTreeNode(bt.Root.RChild.LChild.RChild, '!', 'L');
            GenerateTreeNode(bt.Root.RChild.RChild.LChild, ' ', 'F');
            GenerateTreeNode(bt.Root.RChild.RChild.RChild, 'V', 'H');
            GenerateTreeNode(bt.Root.LChild.LChild.LChild.LChild, '0', '9');
            GenerateTreeNode(bt.Root.LChild.LChild.LChild.RChild, '!', '8');
            GenerateTreeNode(bt.Root.LChild.LChild.RChild.RChild, '!', '7');
            GenerateTreeNode(bt.Root.LChild.RChild.RChild.RChild, '!', '6');
            GenerateTreeNode(bt.Root.RChild.LChild.LChild.LChild, '1', '!');
            GenerateTreeNode(bt.Root.RChild.RChild.LChild.LChild, '2', '!');
            GenerateTreeNode(bt.Root.RChild.RChild.RChild.LChild, '3', '!');
            GenerateTreeNode(bt.Root.RChild.RChild.RChild.RChild, '4', '5');
            //bt.PreOrder(bt.Root);
        }
        

        private void GenerateTreeNode(datastruct.TreeNode<char> root, char left,char right)
        {
            if (left != '!')
            {
                datastruct.TreeNode<char> ltn_T = new datastruct.TreeNode<char>(left);
                root.LChild = ltn_T;
            }
            if (right != '!')
            {
                datastruct.TreeNode<char> rtn_E = new datastruct.TreeNode<char>(right);
                root.RChild = rtn_E;
            }
        }
        #endregion

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
            string result = "";
            string[] words = message.Split(' ');
            for(int i = 0; i < words.Length; i++)
            {
                try
                {
                    datastruct.TreeNode<char> tmp = bt.Root;
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (words[i][j] == dah)
                            tmp = tmp.LChild;
                        else if (words[i][j] == dit)
                            tmp = tmp.RChild;
                    }
                    result += tmp.Data;
                }
                catch
                {
                    result += '@';
                }
            }
            textBoxResult.Text = result;
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
            string result = "";
            for (int i = 0; i < message.Length; i++)
            {
                bt.FindData(bt.Root, message[i], "");
                result += bt.FindString + '/';
            }
            result = result.Replace('.', dit);
            result = result.Replace('-', dah);
            textBoxResult.Text = result;
        }

        private void buttonShowTable_Click(object sender, EventArgs e)
        {
            string result = "";
            for(char i = 'A'; i <= 'Z'; i++)
            {
                bt.FindData(bt.Root, i, "");
                result += i.ToString() + "\t" + bt.FindString + Environment.NewLine;
            }
            for(char i = '0'; i <= '9'; i++)
            {
                bt.FindData(bt.Root, i, "");
                result += i.ToString() + "\t" + bt.FindString + Environment.NewLine;
            }
            result = result.Replace('-', dah);
            result = result.Replace('.', dit);
            textBoxResult.Text = result;
            
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

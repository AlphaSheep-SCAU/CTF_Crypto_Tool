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

        public MorseForm()
        {
            InitializeComponent();
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTF_Crypto_Tool.crypto.cryptocs
{
    class MorseCrypto : Crypto
    {
        private datastruct.BinaryTree<char> bt;
        private char dit;
        private char dah;
        private string cryptoTable;

        public MorseCrypto(string message) : base(message)
        {
            GenerateMorseTable();
            dit = '.';
            dah = '-';
            cryptoTable = "";
        }

        public MorseCrypto(string message, char dit, char dah) : base(message)
        {
            GenerateMorseTable();
            this.dit = dit;
            this.dah = dah;
        }

        public char Dit
        {
            get { return dit; }
            set { dit = value; }
        }

        public char Dah
        {
            get { return dah; }
            set { dah = value; }
        }

        public string CryptoTable
        {
            get { return cryptoTable; }
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


        private void GenerateTreeNode(datastruct.TreeNode<char> root, char left, char right)
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

        public override void Decrypt()
        {
            clearText = "";
            string[] words = message.Split(' ');
            for (int i = 0; i < words.Length; i++)
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
                    clearText += tmp.Data;
                }
                catch
                {
                    clearText += '@';
                }
            }
        }

        public override void Encrypt()
        {
            cipherText = "";
            for (int i = 0; i < message.Length; i++)
            {
                bt.FindData(bt.Root, message[i], "");
                cipherText += bt.FindString + '/';
            }
            cipherText = cipherText.Replace('.', dit);
            cipherText = cipherText.Replace('-', dah);
        }

        public void ShowTable()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                bt.FindData(bt.Root, i, "");
                cryptoTable += i.ToString() + "\t" + bt.FindString + Environment.NewLine;
            }
            for (char i = '0'; i <= '9'; i++)
            {
                bt.FindData(bt.Root, i, "");
                cryptoTable += i.ToString() + "\t" + bt.FindString + Environment.NewLine;
            }
            cryptoTable = cryptoTable.Replace('-', dah);
            cryptoTable = cryptoTable.Replace('.', dit);
        }
    }
}

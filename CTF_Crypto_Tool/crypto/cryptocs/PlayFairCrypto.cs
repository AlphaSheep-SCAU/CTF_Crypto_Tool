using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTF_Crypto_Tool.crypto.cryptocs
{
    class PlayFairCrypto : Crypto
    {
        private char[,] cipherTable;
        private string key;
        
        public PlayFairCrypto() : base()
        {
            key = "";
            cipherTable = new char[5, 5];
        }

        private void GenerateCipherTable()
        {
            key = key.ToUpper();
            var set = new HashSet<char>();
            int x = 0;
            int y = 0;
            foreach (char i in key)
            {
                if (i == 'J')
                    continue;
                if (set.Add(i))
                {
                    cipherTable[x, y] = i;
                    y = (y + 1) % 5;
                    if (y == 0)
                        x++;
                }
            }
            for (char i = 'A'; i <= 'Z'; i++)
            {
                if (i == 'J')
                    continue;
                if (set.Add(i))
                {
                    cipherTable[x, y] = i;
                    y = (y + 1) % 5;
                    if (y == 0)
                        x++;
                }
            }
        }

        public string Key
        {
            get { return key; }
            set
            {
                key = value;
                GenerateCipherTable();
            }
        }

        public override void Encrypt()
        {
            cipherText = "";
            message = message.Replace('J', 'I');
            List<string> groupStr = Divide();
            for(int i = 0; i < groupStr.Count; i++)
            {
                //找出对应位置
                int i1 = -1, i2 = -1, j1 = -1, j2 = -1;
                for (int j = 0; j < 5; j++)
                {
                    for(int k = 0; k < 5; k++)
                    {
                        if(groupStr[i][0] == cipherTable[j, k])
                        {
                            i1 = j;
                            j1 = k;
                        }
                        if(groupStr[i][1] == cipherTable[j, k])
                        {
                            i2 = j;
                            j2 = k;
                        }
                    }
                    if (i1 != -1 && i2 != -1) break;
                }
                //if (i1 == -1 || i2 == -1 || j1 == -1 || j2 == -1) return;
                //不同行不同列
                if (i1 != i2 && j1 != j2)
                    cipherText += cipherTable[i1, j2].ToString() + cipherTable[i2, j1].ToString();
                //同行不同列
                else if (i1 == i2 && j1 != j2)
                    cipherText += cipherTable[i1, (j1 + 1) % 5].ToString() + cipherTable[i1, (j2 + 1) % 5].ToString();
                //不同行同列
                else if (i1 != i2 && j1 == j2)
                    cipherText += cipherTable[(i1 + 1) % 5, j1].ToString() + cipherTable[(i2 + 1) % 5, j1].ToString();
            }
        }

        private List<string> Divide()
        {
            List<string> groupStr = new List<string>();
            //将明文分成2个一组
            bool flag;
            while (true)
            {
                flag = true;
                groupStr.Clear();
                for (int i = 0; i < message.Length; i += 2)
                {
                    if (i == message.Length - 1) message += 'X';
                    string str = message.Substring(i, 2);
                    if (str[0] == str[1])
                    {
                        string t1 = message.Substring(0, i + 1);
                        string t2 = message.Substring(i + 1);
                        message = t1 + 'X' + t2;
                        flag = false;
                        break;
                    }
                    groupStr.Add(str);
                }
                if (flag) break;
            }
            return groupStr;
        }

        public override void Decrypt()
        {
            clearText = "";
            message = message.Replace('J', 'I');
            List<string> groupStr = Divide();
            for (int i = 0; i < groupStr.Count; i++)
            {
                //找出对应位置
                int i1 = -1, i2 = -1, j1 = -1, j2 = -1;
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (groupStr[i][0] == cipherTable[j, k])
                        {
                            i1 = j;
                            j1 = k;
                        }
                        if (groupStr[i][1] == cipherTable[j, k])
                        {
                            i2 = j;
                            j2 = k;
                        }
                    }
                    if (i1 != -1 && i2 != -1) break;
                }
                //if (i1 == -1 || i2 == -1 || j1 == -1 || j2 == -1) return;
                //不同行不同列
                if (i1 != i2 && j1 != j2)
                    clearText += cipherTable[i1, j2].ToString() + cipherTable[i2, j1].ToString();
                //同行不同列
                else if (i1 == i2 && j1 != j2)
                    clearText += cipherTable[i1, (j1 + 4) % 5].ToString() + cipherTable[i1, (j2 + 4) % 5].ToString();
                //不同行同列
                else if (i1 != i2 && j1 == j2)
                    clearText += cipherTable[(i1 + 4) % 5, j1].ToString() + cipherTable[(i2 + 4) % 5, j1].ToString();
            }
        }

        public string PrintTable()
        {
            string t = "";
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++) 
                {
                    t += cipherTable[i, j] + " ";
                }
                t += Environment.NewLine;
            }
            return t;
        }
    }
}

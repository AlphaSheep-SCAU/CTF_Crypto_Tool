using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTF_Crypto_Tool.crypto.cryptocs
{
    class BaconCrypto : Crypto
    {
        private Dictionary<char, string> BaconIndexTable;
        private List<char> alphabet;
        private List<string> encrytoArray;
        private string showTable;

        public BaconCrypto() : base()
        {
            encrytoArray = new List<string>();
            GenerateString("");
            alphabet = new List<char>();
            GenerateChar();
            GenerateTable();
            showTable = "";
            GenerateShowTable();
        }

        private void GenerateChar()
        {
            for (char i = 'a'; i <= 'z'; i++)
                alphabet.Add(i);
        }

        private void GenerateString(string str)
        {
            if (str.Length == 5)
            {
                encrytoArray.Add(str);
                return;
            }
            string str1 = str + 'a';
            GenerateString(str1);
            string str2 = str + 'b';
            GenerateString(str2);
        }

        private void GenerateShowTable()
        {
            foreach(KeyValuePair<char,string> kv in BaconIndexTable)
                showTable += Convert.ToChar(kv.Key) + "\t" + kv.Value + Environment.NewLine;
        }

        private void GenerateTable()
        {
            BaconIndexTable = new Dictionary<char, string>();
            for(int i = 0; i < alphabet.Count; i++)
                BaconIndexTable.Add(alphabet[i], encrytoArray[i]);
        }

        public string ShowTable
        {
            get { return showTable; }
        }

        public override void Encrypt()
        {
            cipherText = "";
            for (int i = 0; i < message.Length; i++)
            {
                if (BaconIndexTable.ContainsKey(message[i]))
                    cipherText += BaconIndexTable[message[i]];
                else
                    cipherText += message[i];
            }
                    
        }

        public override void Decrypt()
        {
            clearText = "";
            for (int i = 0; i < message.Length; i += 5)
            {
                try
                {
                    string str = message.Substring(i, 5);
                    bool flag = false;
                    foreach (KeyValuePair<char, string> dict in BaconIndexTable)
                    {
                        if (str.Equals(dict.Value))
                        {
                            clearText += dict.Key;
                            flag = true;
                        }
                    }
                    if (!flag)
                        clearText += '@';
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    for (int j = i; j < message.Length; j++)
                        clearText += '@';
                }
            }
        }

        
    }
}

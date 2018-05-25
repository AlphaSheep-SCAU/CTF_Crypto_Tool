using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTF_Crypto_Tool.crypto.cryptocs
{
    class Base64Crypto : Crypto
    {
        private List<char> Base64IndexTable;

        public Base64Crypto(string message) : base(message)
        {
            GenerateIndexTable();
        }

        public Base64Crypto() : base()
        {
            GenerateIndexTable();
        }

        private void GenerateIndexTable()
        {
            Base64IndexTable = new List<char>();
            for (char i = 'A'; i <= 'Z'; i++) 
                Base64IndexTable.Add(i);
            for (char i = 'a'; i <= 'z'; i++)
                Base64IndexTable.Add(i);
            for (char i = '0'; i <= '9'; i++)
                Base64IndexTable.Add(i);
            Base64IndexTable.Add('+');
            Base64IndexTable.Add('/');
        }

        private string Int2Bin8(int number)
        {
            string bin = Convert.ToString(number, 2);
            while (bin.Length < 8)
                bin = '0' + bin;
            return bin;
        }

        private string Int2Bin6(int number)
        {
            string bin = Convert.ToString(number, 2);
            while (bin.Length < 6)
                bin = '0' + bin;
            return bin;
        }

        public override void Encrypt()
        {
            cipherText = "";
            for (int i = 0; i < message.Length; i += 3)
            {
                string binString = "";
                try
                {
                    binString += Int2Bin8(message[i]);
                    binString += Int2Bin8(message[i + 1]);
                    binString += Int2Bin8(message[i + 2]);
                }
                catch{}
                while (binString.Length % 6 != 0)
                    binString += '0';
                for(int j = 0; j < binString.Length;j += 6)
                {
                    string t = binString.Substring(j, 6);
                    int index = Convert.ToInt32(t, 2);
                    cipherText += Base64IndexTable[index];
                }
            }
            while (cipherText.Length % 4 != 0)
                cipherText += '=';
        }

        public override void Decrypt()
        {
            clearText = "";
            for(int i = 0; i < message.Length; i += 4)
            {
                string binString = "";
                try
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (message[i + k] == '=')
                            continue;
                        binString += Int2Bin6(Base64IndexTable.IndexOf(message[i + k]));
                    }
                }
                catch { }
                binString = binString.Substring(0,binString.Length - binString.Length % 8);
                for(int j = 0; j < binString.Length; j += 8)
                {
                    string t = binString.Substring(j, 8);
                    int index = Convert.ToInt32(t, 2);
                    clearText += Convert.ToChar(index);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTF_Crypto_Tool.crypto.cryptocs
{
    class Base32Crypto : Crypto
    {
        private List<char> Base32IndexTable;

        public Base32Crypto() : base()
        {
            GenerateIndexTable();
        }

        private void GenerateIndexTable()
        {
            Base32IndexTable = new List<char>();
            for (char i = 'A'; i <= 'Z'; i++)
                Base32IndexTable.Add(i);
            for (char i = '2'; i <= '7'; i++)
                Base32IndexTable.Add(i);
        }

        private string Int2Bin8(int number)
        {
            string bin = Convert.ToString(number, 2);
            while (bin.Length < 8)
                bin = '0' + bin;
            return bin;
        }

        private string Int2Bin5(int number)
        {
            string bin = Convert.ToString(number, 2);
            while (bin.Length < 5)
                bin = '0' + bin;
            return bin;
        }

        public override void Encrypt()
        {
            cipherText = "";
            string binString = "";
            for (int i = 0; i < message.Length; i++)
                binString += Int2Bin8(message[i]);
            while (binString.Length % 5 != 0)
                binString += '0';
            for (int j = 0; j < binString.Length; j += 5)
            {
                string t = binString.Substring(j, 5);
                int index = Convert.ToInt32(t, 2);
                cipherText += Base32IndexTable[index];
            }
            while (cipherText.Length % 8 != 0)
                cipherText += '=';
        }

        public override void Decrypt()
        {
            clearText = "";
            string binString = "";
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == '=')
                    continue;
                binString += Int2Bin5(Base32IndexTable.IndexOf(message[i]));
            }
            while (binString.Length % 8 != 0)
                binString = binString.Substring(0, binString.Length - 1);
            for (int j = 0; j < binString.Length; j += 8)
            {
                string t = binString.Substring(j, 8);
                int index = Convert.ToInt32(t, 2);
                clearText += Convert.ToChar(index);
            }
        }
        
    }
}

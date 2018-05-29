using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTF_Crypto_Tool.crypto.cryptocs
{
    class Base16Crypto : Crypto
    {
        private List<char> Base16IndexTable;

        public Base16Crypto() : base()
        {
            GenerateIndexTable();
        }

        private void GenerateIndexTable()
        {
            Base16IndexTable = new List<char>();
            for (char i = '0'; i <= '9'; i++)
                Base16IndexTable.Add(i);
            for (char i = 'A'; i <= 'F'; i++)
                Base16IndexTable.Add(i);
        }

        private string Int2Bin8(int number)
        {
            string bin = Convert.ToString(number, 2);
            while (bin.Length < 8)
                bin = '0' + bin;
            return bin;
        }

        private string Int2Bin4(int number)
        {
            string bin = Convert.ToString(number, 2);
            while (bin.Length < 4)
                bin = '0' + bin;
            return bin;
        }

        public override void Encrypt()
        {
            cipherText = "";
            string binString = "";
            for (int i = 0; i < message.Length; i++)
                binString += Int2Bin8(message[i]);
            for (int j = 0; j < binString.Length; j += 4)
            {
                string t = binString.Substring(j, 4);
                int index = Convert.ToInt32(t, 2);
                cipherText += Base16IndexTable[index];
            }
        }

        public override void Decrypt()
        {
            clearText = "";
            string binString = "";
            for (int i = 0; i < message.Length; i++)
            {
                binString += Int2Bin4(Base16IndexTable.IndexOf(message[i]));
            }
            for (int j = 0; j < binString.Length; j += 8)
            {
                string t = binString.Substring(j, 8);
                int index = Convert.ToInt32(t, 2);
                clearText += Convert.ToChar(index);
            }
        }
    }
}

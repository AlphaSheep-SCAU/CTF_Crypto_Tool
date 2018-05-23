using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTF_Crypto_Tool.crypto.cryptocs
{
    class VigenereCrypto : Crypto
    {
        private string key;
        readonly string[] cryptoTable;

        public VigenereCrypto(string message, string key) : base(message)
        {
            this.key = key;
            cryptoTable = new string[26] {  "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                                            "BCDEFGHIJKLMNOPQRSTUVWXYZA",
                                            "CDEFGHIJKLMNOPQRSTUVWXYZAB",
                                            "DEFGHIJKLMNOPQRSTUVWXYZABC",
                                            "EFGHIJKLMNOPQRSTUVWXYZABCD",
                                            "FGHIJKLMNOPQRSTUVWXYZABCDE",
                                            "GHIJKLMNOPQRSTUVWXYZABCDEF",
                                            "HIJKLMNOPQRSTUVWXYZABCDEFG",
                                            "IJKLMNOPQRSTUVWXYZABCDEFGH",
                                            "JKLMNOPQRSTUVWXYZABCDEFGHI",
                                            "KLMNOPQRSTUVWXYZABCDEFGHIJ",
                                            "LMNOPQRSTUVWXYZABCDEFGHIJK",
                                            "MNOPQRSTUVWXYZABCDEFGHIJKL",
                                            "NOPQRSTUVWXYZABCDEFGHIJKLM",
                                            "OPQRSTUVWXYZABCDEFGHIJKLMN",
                                            "PQRSTUVWXYZABCDEFGHIJKLMNO",
                                            "QRSTUVWXYZABCDEFGHIJKLMNOP",
                                            "RSTUVWXYZABCDEFGHIJKLMNOPQ",
                                            "STUVWXYZABCDEFGHIJKLMNOPQR",
                                            "TUVWXYZABCDEFGHIJKLMNOPQRS",
                                            "UVWXYZABCDEFGHIJKLMNOPQRST",
                                            "VWXYZABCDEFGHIJKLMNOPQRSTU",
                                            "WXYZABCDEFGHIJKLMNOPQRSTUV",
                                            "XYZABCDEFGHIJKLMNOPQRSTUVW",
                                            "YZABCDEFGHIJKLMNOPQRSTUVWX",
                                            "ZABCDEFGHIJKLMNOPQRSTUVWXY"
                                          };
        }

        #region 访问器&&修改器
        public override string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        public override string CipherText
        {
            get { return cipherText; }
            //set { cipher = value; }
        }

        public override string ClearText
        {
            get { return clearText; }
        }
        #endregion

        public override void Encrypt()
        {
            if (key == "")
                return;
            int keyIndex = 0;
            cipherText = "";
            key = key.Replace(" ", "");
            key = key.Replace("\n", "");
            key = key.Replace("\r", "");
            key = key.ToUpper();
            string tMessage = string.Copy(message).ToUpper();
            for (int i = 0; i < message.Length; i++) 
            {
                char ct;
                try
                {
                    ct = cryptoTable[key[keyIndex] % 'A'][tMessage[i] % 'A'];
                    if(message[i] >= 'a' && message[i] <= 'z')
                        ct = ct.ToString().ToLower()[0];
                    cipherText += ct;
                    keyIndex++;
                    keyIndex %= key.Length;
                }
                catch
                {
                    cipherText += message[i];
                }
            }
        }

        public override void Decrypt()
        {
            if (key == "")
                return;
            int keyIndex = 0;
            clearText = "";
            key = key.Replace(" ", "");
            key = key.Replace("\n", "");
            key = key.Replace("\r", "");
            key = key.ToUpper();
            string tMessage = string.Copy(message).ToUpper();
            for (int i = 0; i < message.Length; i++)
            {
                char ct;
                try
                {
                    ct = cryptoTable[0][cryptoTable[key[keyIndex] % 'A'].IndexOf(message[i])];
                    if (message[i] >= 'a' && message[i] <= 'z')
                        ct = ct.ToString().ToLower()[0];
                    clearText += ct;
                    keyIndex++;
                    keyIndex %= key.Length;
                }
                catch
                {
                    clearText += message[i];
                }
            }
        }
    }
}

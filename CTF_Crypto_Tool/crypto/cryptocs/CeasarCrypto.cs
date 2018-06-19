using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTF_Crypto_Tool.crypto.cryptocs
{
    class CeasarCrypto : Crypto
    {
        private int shiftNumber;//偏移量

        public CeasarCrypto(string message,int shiftNumber) : base(message)
        {
            this.message = message;
            this.shiftNumber = shiftNumber;
        }

        #region 访问器&&修改器
        public override string Message
        {
            get { return message; }
            set { message = value; }
        }

        public int ShiftNumber
        {
            get { return shiftNumber; }
            set { shiftNumber = value; }
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

        //凯撒加密
        public override void Encrypt()
        {
            cipherText = "";
            for(int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                if (c < 65 || (c > 90 && c < 97) || c > 122)
                {
                    cipherText += c;
                    continue;
                }
                else
                {
                    if (c >= 65 && c <= 90 && c + shiftNumber > 90)
                    {
                        cipherText += (char)((c + shiftNumber) - 26);
                    }
                    else if (c >= 97 && c <= 122 && c + shiftNumber > 122)
                    {
                        cipherText += (char)((c + shiftNumber) - 26);
                    }
                    else
                    {
                        cipherText += (char)(c + shiftNumber);
                    }
                }
            }
        }

        //凯撒解密
        public override void Decrypt()
        {
            clearText = "";
            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                if (c < 65 || (c > 90 && c < 97) || c > 122)
                {
                    clearText += c;
                    continue;
                }
                else
                {
                    if (c >= 65 && c <= 90 && c - shiftNumber < 65)
                    {
                        clearText += (char)((c - shiftNumber) + 26);
                    }
                    else if (c >= 97 && c <= 122 && c - shiftNumber < 97)
                    {
                        clearText += (char)((c - shiftNumber) + 26);
                    }
                    else
                    {
                        clearText += (char)(c - shiftNumber);
                    }
                }
            }
        }
        
        /* 基于密钥的加解密 不常用
        public void keyEncrypt()
        {
            int keyIndex = 0;
            string t = "";
            for (int i = 0; i < chipper.Length; i++)
            {
                int tc = 0;
                if (chipper[i] < 65 || (chipper[i] > 90 && chipper[i] < 97) || chipper[i] > 122)
                    tc = chipper[i];
                else if (chipper[i] >= 65 && chipper[i] <= 90)
                {
                    tc = (chipper[i] + addOrSub * keyArray[keyIndex++]);
                    if (tc > 90) tc -= 26;
                    if (tc < 65) tc += 26;
                }
                else if (chipper[i] >= 97 && chipper[i] <= 122)
                {
                    tc = (chipper[i] + addOrSub * keyArray[keyIndex++]);
                    if (tc > 122) tc -= 26;
                    if (tc < 97) tc += 26;
                }
                t += (char)tc;
                keyIndex %= keyArray.Length;
            }
        }*/
    }
}

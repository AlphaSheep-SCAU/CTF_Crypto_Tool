using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTF_Crypto_Tool.crypto.cryptocs
{
    class FenceCrypto : Crypto
    {
        private int group;
        private int lenMessage;

        public FenceCrypto(string message,int group) : base(message)
        {
            this.message = message;
            this.group = group;
            lenMessage = message.Length;
        }

        #region 访问器&&修改器
        public override string Message
        {
            get { return message; }
            set
            {
                message = value;
                lenMessage = message.Length;
            }
        }

        public int Group
        {
            get { return group; }
            set { group = value; }
        }

        public override string CipherText
        {
            get { return cipherText; }
        }

        public override string ClearText
        {
            get { return clearText; }
        }
        #endregion

        private static string[] ClearZero(string[] strArr)
        {
            for(int i = 0; i < strArr.Length; i++)
                strArr[i] = "";
            return strArr;
        }

        public override void Encrypt()
        {
            cipherText = "";
            int lenTArr = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(lenMessage) / group));
            string tMessage = message;
            for(int i = 0; i < lenTArr * group - lenMessage; i++)
                tMessage += "@";
            string[] tArr = new string[lenTArr];
            tArr = ClearZero(tArr);
            for (int i = 0; i < lenTArr; i++)
            {
                tArr[i] = tMessage.Substring(i * group, group);
            }
            for (int i = 0; i < group; i++)
                for(int j = 0; j < lenTArr; j++)
                    cipherText += tArr[j][i];
        }

        public override void Decrypt()
        {
            clearText = "";
            string[] tArr = new string[group];
            int lenSub = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(lenMessage) / group));
            tArr = ClearZero(tArr);
            string tMessage = message;
            for (int i = 0; i < lenSub * group - lenMessage; i++)
                tMessage += "@";
            for (int i = 0; i < group; i++)
            {
                tArr[i] = tMessage.Substring(i * lenSub, lenSub);
            }
            for (int i = 0; i < lenSub; i++)
                for (int j = 0; j < group; j++)
                    clearText += tArr[j][i];
        }
    }
}

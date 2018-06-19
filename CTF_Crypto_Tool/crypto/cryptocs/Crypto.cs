using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTF_Crypto_Tool.crypto.cryptocs
{
    class Crypto
    {
        protected string message;//用户需要加密或解密的信息
        protected string clearText;//明文
        protected string cipherText;//密文

        public virtual string Message
        {
            get { return message; }
            set { message = value; }
        }

        public virtual string CipherText
        {
            get { return cipherText; }
        }

        public virtual string ClearText
        {
            get { return clearText; }
        }

        public Crypto()
        {
            message = "";
            cipherText = "";
            clearText = "";
        }

        public Crypto(string message)
        {
            this.message = message;
            cipherText = "";
            clearText = "";
        }

        public virtual void Encrypt()
        {
            cipherText = message;
        }

        public virtual void Decrypt()
        {
            clearText = message;
        }
    }
}

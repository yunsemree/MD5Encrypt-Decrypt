using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD5Encrypt_Decrypt.Encryptions.Abstract
{
    internal interface IEncryptionProvider
    {

        string Encrypt(string input);
        string Decrypt(string cypherText);

    }
}

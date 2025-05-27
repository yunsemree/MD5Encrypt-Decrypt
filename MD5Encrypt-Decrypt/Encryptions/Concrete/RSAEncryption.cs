using MD5Encrypt_Decrypt.Encryptions.Abstract;
using System.Security.Cryptography;
using System.Text;

namespace MD5Encrypt_Decrypt.Encryptions.Concrete
{
    internal class RSAEncryption : IEncryptionProvider
    {
        private readonly string PublicKey = "";
        private readonly string PrivateKey = "";

        public bool IsDefault { get; set; }

        #region Methods

        public string Encrypt(string input)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.FromXmlString(PublicKey);
                byte[] data = Encoding.Unicode.GetBytes(input);

                byte[] cypher = rsa.Encrypt(data, RSAEncryptionPadding.OaepSHA512);

                return Convert.ToBase64String(cypher);
            }
        }

        public string Decrypt(string cypherText)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.FromXmlString(PrivateKey);

                byte[] dataBytes = Convert.FromBase64String(cypherText);

                byte[] plainText = rsa.Decrypt(dataBytes, RSAEncryptionPadding.OaepSHA512);

                return Encoding.Unicode.GetString(plainText);
            }
        }

        #endregion
    }
}


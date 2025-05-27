using MD5Encrypt_Decrypt.Encryptions.Abstract;
using System.Security.Cryptography;
using System.Text;

namespace MD5Encrypt_Decrypt.Encryptions.Concrete
{
    public class MD5EncrytpionNet5 : IEncryptionProvider
    {
        public byte[] _key { get; set; } = Encoding.UTF8.GetBytes("b4ac5a7c06a6326ad774941a5eef5d65");
        public MD5EncrytpionNet5()
        {
            
        }
        /// <summary>
        /// Gelen string değeri MD5 e çevirir.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }

        public string Decrypt(string cypherText)
        {
            byte[] passBytes = Convert.FromBase64String(cypherText);

            MD5CryptoServiceProvider mD5Crypto = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();

            tripleDES.Key = mD5Crypto.ComputeHash(_key);
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(passBytes, 0, passBytes.Length);
            return Encoding.UTF8.GetString(result);
        }

        public string Encrypt(string input)
        {
            byte[] passBytes = Encoding.UTF8.GetBytes(input);

            MD5CryptoServiceProvider mD5Crypto = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();

            tripleDES.Key = mD5Crypto.ComputeHash(_key);
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(passBytes, 0, passBytes.Length);
            return Convert.ToBase64String(result);
        }
        
    }
}

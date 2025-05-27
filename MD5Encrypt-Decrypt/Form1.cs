using MD5Encrypt_Decrypt.Encryptions.Concrete;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;

namespace MD5Encrypt_Decrypt
{
    public partial class Form1 : Form
    {
        private MD5EncrytpionNet5 _md5EncryptionProvider = new();
        private RSAEncryption _rsaEncryptionProvider = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckItemText();
            if (button1.Text == "Þifrele")
            {
                button1.Text = "Çöz";
            }
            else
            {
                button1.Text = "Þifrele";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Lütfen þifrelenecek/Çözülecek metni giriniz.");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text) && !checkBox1.Checked)
            {
                MessageBox.Show("Lütfen anahter deðeri girin");
                return;
            }
            if (checkBox3.Checked)
            {
                string decryptedData = "";
                //TODO: Decrypt
                if (checkBox2.Checked)
                {
                    decryptedData = _rsaEncryptionProvider.Decrypt(richTextBox2.Text);
                }
                else
                {
                    if (!checkBox1.Checked)
                        _md5EncryptionProvider._key = Encoding.UTF8.GetBytes(textBox2.Text);
                    decryptedData = _md5EncryptionProvider.Decrypt(ReadFile(@"C:\Users\P2710\Desktop\2000 - smart - iþ bankasý banka logu.txt"));
                }
                richTextBox1.Text = decryptedData;
                MessageBox.Show(decryptedData, "Veri Çözüldü", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string ecryptedData = "";
                if (checkBox4.Checked)
                {
                    if (!checkBox1.Checked)
                        _md5EncryptionProvider._key = Encoding.UTF8.GetBytes(textBox2.Text);
                    ecryptedData = _md5EncryptionProvider.Encrypt(textBox1.Text);

                    var md5 = _md5EncryptionProvider.CreateMD5(textBox1.Text);
                    richTextBox1.Text = ecryptedData;
                    MessageBox.Show(md5, "Veri Þifrelendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    string encryptedData = _rsaEncryptionProvider.Encrypt(textBox1.Text);
                    richTextBox1.Text = ecryptedData;
                    MessageBox.Show(encryptedData, "Veri Þifrelendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
            button1.Text = "Çöz";
            CheckItemText();
        }
        string ReadFile(string path)
        {
            var fileBytes = File.ReadAllBytes(path);
            string trxt = Encoding.UTF8.GetString(fileBytes);
            trxt = trxt.Replace("\"", "");

            byte[] passBytes = Convert.FromBase64String(trxt);

            MD5CryptoServiceProvider mD5Crypto = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();

            tripleDES.Key = mD5Crypto.ComputeHash(Encoding.UTF8.GetBytes("97e4b4044d6e53c9b963549db3b41d6d"));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(passBytes, 0, passBytes.Length);
            return Encoding.UTF8.GetString(result);

            trxt = trxt.Replace("\"", "");
            return trxt;

        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
        void CheckItemText()
        {
            if (checkBox3.Checked)
            {
                checkBox3.Text = "Çöz";
            }
            else
            {
                checkBox3.Text = "Þifrele";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var path = @"C:\Users\P2710\Desktop\2000 - smart - iþ bankasý banka logu.txt";
            richTextBox2.Text = ReadFile(path);
        }
    }
}

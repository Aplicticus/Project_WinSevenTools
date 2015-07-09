using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace WinSevenTools.Libraries
{
    public class Rijndael
    {
        #region Properties
        private string _firstPassword = "ABCDEFGH";
        private string _secondPassword = "HGFECBA";
        #endregion
        #region Methods
        public string Encrypt(string Secret)
        {
            if (string.IsNullOrEmpty(Secret))
                throw new ArgumentNullException("There is no key to encrypt!");

            RijndaelManaged aesAlg = RijndaelManaged(_firstPassword, _secondPassword);
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            MemoryStream msEncrypt = new MemoryStream();
            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            {
                using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                {
                    swEncrypt.Write(Secret);
                }
                return Convert.ToBase64String(msEncrypt.ToArray());
            }
        }
        public string Decrypt(string Secret)
        {              
                string result = string.Empty;

                if (String.IsNullOrEmpty(Secret))
                {
                  
                }

                RijndaelManaged aesAlg = RijndaelManaged(_firstPassword, _secondPassword);

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                byte[] cipher = Convert.FromBase64String(Secret);

                using (MemoryStream msDecrypt = new MemoryStream(cipher))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            result = srDecrypt.ReadToEnd();
                        }
                    }
                }
                return result;            
        }        
        private RijndaelManaged RijndaelManaged(string FirstPassword, string SecondPassword)
        {
            byte[] saltBytes = Encoding.ASCII.GetBytes(FirstPassword);
            Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(SecondPassword, saltBytes);
            RijndaelManaged aesAlg = new RijndaelManaged();
            aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
            aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);
            return aesAlg;
        }
        #endregion
    }
}

using CS.CryptoServiceProvider.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CS.CryptoServiceProvider.Services
{
    public class CryptoService : ICryptoService
    {
        #region Symmetric Key

        /// <summary>
        /// Encrypt String
        /// </summary>
        /// <param name="key">The key for using to Encrypt String</param>
        /// <param name="plainText">The Tesxt need to Encrypt</param>
        /// <returns>string that contains the hashed Value</returns>
        public string EncryptString(string key, string plainText)
        {
            try
            {
                byte[] iv = new byte[16];
                byte[] array;

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(key);
                    aes.IV = iv;

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                            {
                                streamWriter.Write(plainText);
                            }

                            array = memoryStream.ToArray();
                        }
                    }
                }

                return Convert.ToBase64String(array);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Decrypt String
        /// </summary>
        /// <param name="key">The key for using to Encrypt String</param>
        /// <param name="cipherText">The Encrypted ciper text need to Decode</param>
        /// <returns>string that contains the hashed Value</returns>
        public string DecryptString(string key, string cipherText)
        {
            try
            {
                byte[] iv = new byte[16];
                byte[] buffer = Convert.FromBase64String(cipherText);

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(key);
                    aes.IV = iv;
                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    using (MemoryStream memoryStream = new MemoryStream(buffer))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                            {
                                return streamReader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        /// <summary>
        /// Encode String into hash 
        /// </summary>
        /// <param name="password">Value that need to encode</param>
        /// <returns>string that contains the hashed Value</returns>
        public string EncodePassword(string password)
        {
            try
            {
                //Generate salt
                byte[] salt = new byte[16];
                new RNGCryptoServiceProvider().GetBytes(salt);

                //Hash and Salt the password using PBKDF2
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
                //Place the hashed string in the byte array
                byte[] hash = pbkdf2.GetBytes(20);

                //Store the hashed (password + salt)
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);
                //Convert byte array to a string
                string savedPasswordHash = Convert.ToBase64String(hashBytes);
                return savedPasswordHash;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Compare the input password with the saved password in db
        /// </summary>
        /// <param name="inputPassword"></param>
        /// <param name="passwordHash"></param>
        /// <returns>true or false</returns>
        public bool VerifyPassword(string inputPassword, string passwordHash)
        {
            try
            {
                //Convert savedPasswordHash into bytes
                byte[] hashBytes = Convert.FromBase64String(passwordHash);

                //Take the salt out of the string
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);

                //Hash the input password with the salt
                var pbkdf2 = new Rfc2898DeriveBytes(inputPassword, salt, 10000);

                //Put the hashed input in a byte array so we can compare it byte-by-byte
                byte[] hash = pbkdf2.GetBytes(20);

                //Compare the results starting from the 16 in the stored array because 0-15 are the salt there
                bool isValid = true;

                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                    {
                        isValid = false;
                        break;
                    }
                }
                return isValid;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

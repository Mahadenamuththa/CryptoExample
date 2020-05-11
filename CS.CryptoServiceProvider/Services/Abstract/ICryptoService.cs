using System;
using System.Collections.Generic;
using System.Text;

namespace CS.CryptoServiceProvider.Abstract
{
    public interface ICryptoService
    {
        #region Symmetric Key

        /// <summary>
        /// Encrypt String
        /// </summary>
        /// <param name="key">The key for using to Encrypt String</param>
        /// <param name="plainText">The Tesxt need to Encrypt</param>
        /// <returns>string that contains the hashed Value</returns>
        string EncryptString(string key, string plainText);

        /// <summary>
        /// Decrypt String
        /// </summary>
        /// <param name="key">The key for using to Encrypt String</param>
        /// <param name="cipherText">The Encrypted ciper text need to Decode</param>
        /// <returns>string that contains the hashed Value</returns>
        string DecryptString(string key, string cipherText);

        #endregion

        /// <summary>
        /// Encode String into hash 
        /// </summary>
        /// <param name="password">Value that need to encode</param>
        /// <returns>string that contains the hashed Value</returns>
        string EncodePassword(string value);

        /// <summary>
        /// Compare the input password with the saved passwordHash
        /// </summary>
        /// <param name="inputPassword"></param>
        /// <param name="passwordHash"></param>
        /// <returns>true or false</returns>
        bool VerifyPassword(string inputPassword, string passwordHash);
    }
}

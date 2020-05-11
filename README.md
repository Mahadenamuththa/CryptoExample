![hashing (1)](https://user-images.githubusercontent.com/21302583/81175185-b61bf600-8fc0-11ea-8a72-a1856684139a.png)


# Cryptography

Now, I’m going to take help of an example or a scenario to explain what is cryptography?

Let’s say there’s a person named Andy. Now suppose Andy sends a message to his friend Sam who is on the other side of the world. Now obviously he wants this message to be private and nobody else should have access to the message. He uses a public forum, for example, WhatsApp for sending this message. The main goal is to secure this communication.

![sending-message-over-network-what-is-cryptography-edureka-1](https://user-images.githubusercontent.com/21302583/81175919-f6c83f00-8fc1-11ea-8d0b-f4c16d1059d7.png)

Let’s say there is a smart guy called Eaves who secretly got access to your communication channel. Since this guy has access to your communication, he can do much more than just eavesdropping, for example, he can try to change the message.  Now, this is just a small example. What if Eave gets access to your private information? The result could be catastrophic.

So how can Andy be sure that nobody in the middle could access the message sent to Sam? That’s where Encryption or Cryptography comes in.

### What is Cryptography

**Definition**: Cryptography is associated with the process of converting ordinary plain text into unintelligible text and vice-versa. It is a method of storing and transmitting data in a particular form so that only those for whom it is intended can read and process it. Cryptography not only protects data from theft or alteration, but can also be used for user authentication.

![encryption-meaning-what-is-cryptography-edureka](https://user-images.githubusercontent.com/21302583/81176468-d2b92d80-8fc2-11ea-8fa4-02560404607c.png)

*Alright, now that you know ” what is cryptography ” let’s see how cryptography can help secure the connection between Andy and Sam.*

So, to protect his message, _Andy_ first convert his readable message to unreadable form. Here, he converts the message to some random numbers. After that, he uses a key to encrypt his message, in Cryptography, we call this **_ciphertext_**. 

_Andy_ sends this ciphertext or encrypted message over the communication channel, he won’t have to worry about somebody in the middle of discovering his private messages. Suppose, Eaves here discover the message and he somehow manages to alter it before it reaches _Sam_.

![encryption-what-is-cryptography-edureka](https://user-images.githubusercontent.com/21302583/81178349-b10d7580-8fc5-11ea-9bb2-32758f766e7e.png)

Now, _Sam_ would need a key to decrypt the message to recover the original plaintext. In order to convert the ciphertext into plain text, _Sam_ would need to use the decryption key. Using the key he would convert the ciphertext or the numerical value to the corresponding plain text.

### Encryption Algorithms

Cryptography is broadly classified into two categories: **Symmetric key Cryptography** and **Asymmetric key Cryptography** (popularly known as public key cryptography).

![encryption-algorithms-what-is-cryptography-edureka-768x352](https://user-images.githubusercontent.com/21302583/81176205-7229f080-8fc2-11ea-903d-800d216dc548.png)

### Symmetric Key Cryptography

![symmetric-key-what-is-cryptography-edureka (1)](https://user-images.githubusercontent.com/21302583/81179211-f7af9f80-8fc6-11ea-9376-c00fcb15f0a3.png)

This is the simplest kind of encryption that involves only one secret key to cipher and decipher information. Symmetrical encryption is an old and best-known technique. It uses a secret key that can either be a number, a word or a string of random letters. It is a blended with the plain text of a message to change the content in a particular way. The sender and the recipient should know the secret key that is used to encrypt and decrypt all the messages. Blowfish, AES, RC4, DES, RC5, and RC6 are examples of symmetric encryption. The most widely used symmetric algorithm is AES-128, AES-192, and AES-256.

The main disadvantage of the symmetric key encryption is that all parties involved have to exchange the key used to encrypt the data before they can decrypt it.

### Asymmetric Key Encryption (or Public Key Cryptography)

![public-key-encryption-what-is-cryptography-edureka-1-768x373](https://user-images.githubusercontent.com/21302583/81179356-2d548880-8fc7-11ea-9df1-5978329411cd.png)

Asymmetrical encryption is also known as public key cryptography, which is a relatively new method, compared to symmetric encryption. Asymmetric encryption uses two keys to encrypt a plain text. Secret keys are exchanged over the Internet or a large network. It ensures that malicious persons do not misuse the keys. It is important to note that anyone with a secret key can decrypt the message and this is why asymmetrical encryption uses two related keys to boosting security. A public key is made freely available to anyone who might want to send you a message. The second private key is kept a secret so that you can only know.

A message that is encrypted using a public key can only be decrypted using a private key, while also, a message encrypted using a private key can be decrypted using a public key. Security of the public key is not required because it is publicly available and can be passed over the internet. Asymmetric key has a far better power in ensuring the security of information transmitted during communication.

Asymmetric encryption is mostly used in day-to-day communication channels, especially over the Internet. Popular asymmetric key encryption algorithm includes EIGamal, RSA, DSA, Elliptic curve techniques, PKCS.

RSA is the most widely used form of public key encryption, 

**RSA Algorithm**
- RSA stands for _Rivest_, _Shamir_, and _Adelman_, inventors of this technique
- Both public and private key are interchangeable
- Variable Key Size (512, 1024, or 2048 bits)

Here’s how keys are generated in RSA algorithm

![RSA-encryption-what-is-cryptography-edureka](https://user-images.githubusercontent.com/21302583/81181693-765a0c00-8fca-11ea-9bf0-2e7f8583c0b1.png)

## Create Sample Project for Encryption And Decryption Using A Symmetric Key

01. First Create Project File->New->Project Named `CryptoSample`
02. Select ASP.NET Core Web Aplication Named `CS.Api`

![createProject](https://user-images.githubusercontent.com/21302583/81184387-fc2b8680-8fcd-11ea-9f10-7aae20394c80.png)

03. Select Api (Remind to remove tick for Configure for Https)

![selectapi](https://user-images.githubusercontent.com/21302583/81184666-4b71b700-8fce-11ea-8691-c636546c4161.png)

04. Add new project Class libarary(.NET Core) as `CS.CryptoServiceProvider`

![cryptoclasslibarary](https://user-images.githubusercontent.com/21302583/81185434-35182b00-8fcf-11ea-91fa-d61159dc7b34.PNG)

05. Create New Folder inside CS.CryptoServiceProvider->`Services`
06. Create New Folder inside Services->`Abstract`
07. Create New interface inside Abstract->`ICryptoService.cs` and inside Services->`CryptoService.cs`

**Interface**
![interface](https://user-images.githubusercontent.com/21302583/81185935-d99a6d00-8fcf-11ea-9d45-7251c5072cec.PNG)

**Class**
![class](https://user-images.githubusercontent.com/21302583/81186284-40b82180-8fd0-11ea-88c1-21d45fb4c9fa.PNG)

08. Inside interface Create 2 Methods `EncryptString` and `DecryptString`

```csharp
public interface ICryptoService 
{
    #region Symmetric Key

    /// <summary>
    /// Encrypt String
    /// </summary>
    /// <param name="key">The key for using to Encrypt String</param>
    /// <param name="plainText">The Tesxt need to Encrypt</param>
    /// <returns>string that contains the hashed Value</returns>
    string EncryptString (string key, string plainText);

    /// <summary>
    /// Decrypt String
    /// </summary>
    /// <param name="key">The key for using to Encrypt String</param>
    /// <param name="cipherText">The Encrypted ciper text need to Decode</param>
    /// <returns>string that contains the hashed Value</returns>
    string DecryptString (string key, string cipherText);

    #endregion
}
```
09. Now implement these two methods inside Services->`CryptoService.cs`

```csharp
    public class CryptoService : ICryptoService {
        #region Symmetric Key

        /// <summary>
        /// Encrypt String
        /// </summary>
        /// <param name="key">The key for using to Encrypt String</param>
        /// <param name="plainText">The Tesxt need to Encrypt</param>
        /// <returns>string that contains the hashed Value</returns>
        public string EncryptString (string key, string plainText) 
        {
            try 
            {
                byte[] iv = new byte[16];
                byte[] array;

                using (Aes aes = Aes.Create ()) 
                {
                    aes.Key = Encoding.UTF8.GetBytes (key);
                    aes.IV = iv;

                    ICryptoTransform encryptor = aes.CreateEncryptor (aes.Key, aes.IV);

                    using (MemoryStream memoryStream = new MemoryStream ()) 
                    {
                        using (CryptoStream cryptoStream = new CryptoStream ((Stream) memoryStream, encryptor, CryptoStreamMode.Write)) 
                        {
                            using (StreamWriter streamWriter = new StreamWriter ((Stream) cryptoStream)) 
                            {
                                streamWriter.Write (plainText);
                            }

                            array = memoryStream.ToArray ();
                        }
                    }
                }

                return Convert.ToBase64String (array);
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
        public string DecryptString (string key, string cipherText) 
        {
            try 
            {
                byte[] iv = new byte[16];
                byte[] buffer = Convert.FromBase64String (cipherText);

                using (Aes aes = Aes.Create ()) 
                {
                    aes.Key = Encoding.UTF8.GetBytes (key);
                    aes.IV = iv;
                    ICryptoTransform decryptor = aes.CreateDecryptor (aes.Key, aes.IV);

                    using (MemoryStream memoryStream = new MemoryStream (buffer)) 
                    {
                        using (CryptoStream cryptoStream = new CryptoStream ((Stream) memoryStream, decryptor, CryptoStreamMode.Read)) 
                        {
                            using (StreamReader streamReader = new StreamReader ((Stream) cryptoStream)) 
                            {
                                return streamReader.ReadToEnd ();
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
    }
```

10.Now Map These Interfaces and Implementation Using .NetCore `**Add Scoped**`

Goto CS.Api->StartUp and map inside 

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
    //Map Interface and Implementation
    services.AddScoped<ICryptoService, CryptoService>();
}
```

11. Inside CS.Api->`appsettings.json` create property for keep your secret key `MySecretKey`

```Json
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "MySecretKey": "MySup3rS3cr3tk3y"
}
```
12. Create New Controller inside CS.Api->Controller->`Cryptography`
13. Now create 2 JsonResult `SymmetricKeyEncrypt` and `SymmetricKeyDecrypt`

```csharp
[Route ("api/Cryptography")]
public class CryptographyController : Controller 
{
    private readonly ICryptoService _cryptoService;
    private readonly string secretKey;
    private readonly IConfiguration _iConfiguration;

    public CryptographyController (ICryptoService cryptoService, IConfiguration iConfiguration) 
    {
        this._cryptoService = cryptoService;
        this._iConfiguration = iConfiguration;
        this.secretKey = _iConfiguration["MySecretKey"].ToString ();
    }

    #region Symmetric Key

    [HttpGet ("SymmetricKeyEncrypt/{password}")]
    public JsonResult SymmetricKeyEncrypt (string password) 
    {
        try 
        {
            return Json (_cryptoService.EncryptString (secretKey, password));
        } 
        catch (Exception) 
        {
            throw;
        }
    }

    [HttpGet ("SymmetricKeyDecrypt/{ciperText}")]
    public JsonResult SymmetricKeyDecrypt (string ciperText) 
    {
        try 
        {
            return Json (_cryptoService.DecryptString (secretKey, ciperText));
        } 
        catch (Exception) 
        {
            throw;
        }
    }

    #endregion
}
```

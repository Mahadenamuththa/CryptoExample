using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS.CryptoServiceProvider.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CS.Api.Controllers
{
    [Route("api/Cryptography")]
    public class CryptographyController : Controller
    {
        private readonly ICryptoService _cryptoService;
        private readonly string secretKey;
        private readonly IConfiguration _iConfiguration;

        public CryptographyController(ICryptoService cryptoService, IConfiguration iConfiguration)
        {
            this._cryptoService = cryptoService;
            this._iConfiguration = iConfiguration;
            this.secretKey = _iConfiguration["MySecretKey"].ToString();
        }

        #region Symmetric Key

        [HttpGet("SymmetricKeyEncrypt/{password}")]
        public JsonResult SymmetricKeyEncrypt(string password)
        {
            try
            {
                return Json(_cryptoService.EncryptString(secretKey,password));
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpGet("SymmetricKeyDecrypt/{ciperText}")]
        public JsonResult SymmetricKeyDecrypt(string ciperText)
        {
            try
            {
                return Json(_cryptoService.DecryptString(secretKey, ciperText));
            }
            catch (Exception)
            {
                throw;
            }

        }

        #endregion

        [HttpGet("EncodedPassword/{password}")]
        public JsonResult EncodedPassword(string password)
        {
            try
            {
                return Json(_cryptoService.EncodePassword(password));
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
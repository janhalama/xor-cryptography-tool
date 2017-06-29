using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ValeoInterviewChallengeUnitTests
{
    [TestClass]
    public class XorCryptographyServiceTests
    {
        /// <summary>
        /// Simple test of XorCryptographyService file encryption and decryption methods.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task TestFileEncryptionAndDecryption()
        {
            string sourceText = "01234567989";
            using (MemoryStream sourceStream = new MemoryStream(Encoding.UTF8.GetBytes(sourceText)))
            {
                using (MemoryStream targetStream = new MemoryStream())
                {
                    using (MemoryStream targetValidationStream = new MemoryStream())
                    {
                        string passPhrase = "01234567";
                        ValeoInterviewChallenge.CryptographyService.XorCryptographyService xorCryptographyService = new ValeoInterviewChallenge.CryptographyService.XorCryptographyService();
                        await xorCryptographyService.EncryptStreamAsync(sourceStream, targetStream, passPhrase, null);
                        Assert.AreEqual(sourceStream.Length, targetStream.Length);
                        targetStream.Position = 0;
                        await xorCryptographyService.DecryptStreamAsync(targetStream, targetValidationStream, passPhrase, null);
                        Assert.AreEqual(sourceStream.Length, targetValidationStream.Length);
                        targetValidationStream.Position = 0;
                        StreamReader streamReader = new StreamReader(targetValidationStream);
                        Assert.AreEqual(sourceText, streamReader.ReadToEnd());
                    }
                }
            }
        }
        /// <summary>
        /// Tests that EncryptStreamAsync method validates source stream is not null and throws exception.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public void TestEncryptStreamAsyncValidatesSourceStreamNotNull()
        {
            ValeoInterviewChallenge.CryptographyService.XorCryptographyService xorCryptographyService = new ValeoInterviewChallenge.CryptographyService.XorCryptographyService();
            using (var target = new MemoryStream())
            {
                //unfortunately this test is failing, because async methods are not supported by Assert.ThrowsException
                Assert.ThrowsException<ArgumentNullException>(async () => await xorCryptographyService.EncryptStreamAsync(null, target, "aaa", null));
            }
        }
    }
}

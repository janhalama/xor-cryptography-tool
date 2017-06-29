using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValeoInterviewChallenge.CryptographyService.Interface;

namespace ValeoInterviewChallenge.CryptographyService
{
    public class XorCryptographyService : ICryptographyService
    {
        /// <summary>
        /// Encrypts or decrypt file using xor algorithm asynchronously.
        /// </summary>
        /// <param name="source">The source stream.</param>
        /// <param name="target">The target stream.</param>
        /// <param name="passPhrase">The pass phrase.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// Source parameter is null
        /// or
        /// Target parameter is null
        /// or
        /// Pass phrase is null or empty string
        /// </exception>
        private async Task encryptOrDecryptStreamAsync(Stream source, Stream target, string passPhrase, IProgress<double> progressHandler)
        {
            const int BUFFER_LENGHT = 1024;
            if (source == null)
                throw new ArgumentNullException("Source parameter is null");
            if (source == null)
                throw new ArgumentNullException("Target parameter is null");
            if (string.IsNullOrEmpty(passPhrase))
                throw new ArgumentNullException("Pass phrase is null or empty string");

            byte[] passPhraseByteArray = Encoding.UTF8.GetBytes(passPhrase);
            byte[] sourceBuffer = new byte[BUFFER_LENGHT];
            int readBytesCount;
            while ((readBytesCount = await source.ReadAsync(sourceBuffer, 0, BUFFER_LENGHT)) > 0)
            {
                for(int i = 0; i < readBytesCount; i++)
                {
                    sourceBuffer[i] = (byte)(sourceBuffer[i] ^ passPhraseByteArray[i % passPhraseByteArray.Length]);
                }
                await target.WriteAsync(sourceBuffer, 0, readBytesCount);
                if(progressHandler != null)
                    progressHandler.Report(100.0 * target.Length / source.Length);
            }
        }

        /// <summary>
        /// Encrypts the or decrypt stream asynchronously using xor algorithm.
        /// 
        /// in case of XOR algorithm we use the same method for encryption and decryption
        /// 
        /// </summary>
        /// <param name="source">The source stream.</param>
        /// <param name="target">The target stream.</param>
        /// <param name="passPhrase">The pass phrase.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// Source parameter is null
        /// or
        /// Target parameter is null
        /// or
        /// Pass phrase is null or empty string
        /// </exception>
        public async Task EncryptStreamAsync(Stream source, Stream target, string passPhrase, IProgress<double> progressHandler)
        {
            await encryptOrDecryptStreamAsync(source, target, passPhrase, progressHandler);
        }

        /// <summary>
        /// Decrypts the or decrypt stream asynchronously using xor algorithm.
        /// 
        /// in case of XOR algorithm we use the same method for encryption and decryption
        /// </summary>
        /// <param name="source">The source stream.</param>
        /// <param name="target">The target stream.</param>
        /// <param name="passPhrase">The pass phrase.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// Source parameter is null
        /// or
        /// Target parameter is null
        /// or
        /// Pass phrase is null or empty string
        /// </exception>
        public async Task DecryptStreamAsync(Stream source, Stream target, string passPhrase, IProgress<double> progressHandler)
        {
            await encryptOrDecryptStreamAsync(source, target, passPhrase, progressHandler);
        }
    }
}

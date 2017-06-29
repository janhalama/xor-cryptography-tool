using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValeoInterviewChallenge.CryptographyService.Interface
{
    public interface ICryptographyService
    {
        /// <summary>
        /// Encrypts the stream asynchronously.
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
        Task EncryptStreamAsync(Stream source, Stream target, string passPhrase, IProgress<double> progressHandler);
        /// <summary>
        /// Decrypts the stream asynchronously.
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
        Task DecryptStreamAsync(Stream source, Stream target, string passPhrase, IProgress<double> progressHandler);
    }
}

using System;
using System.IO;
using System.Security.Cryptography;

namespace Encrypter.Services
{
    public abstract class SymmetricStreamEncrypter : IStreamEncrypter, IDisposable
    {
        protected SymmetricStreamEncrypter(SymmetricAlgorithm encrypter)
        {
            Encrypter = encrypter;
            Encrypter.Padding = PaddingMode.Zeros;
        }

        protected SymmetricAlgorithm Encrypter;

        public void Encrypt(Stream input, Stream output, EncrypterInit init)
        {
            if (init.Key is null || init.IV is null || input is null || output is null)
                throw new ArgumentNullException();
            if (input.Equals(output))
                throw new ArgumentException("Arguments input and output is the same object.");

            using (var transform = Encrypter.CreateEncryptor(init.Key, init.IV))
                Transform(input, output, Encrypter.BlockSize, transform);
        }

        public void Decrypt(Stream input, Stream output, EncrypterInit init)
        {
            if (init.Key is null || init.IV is null || input is null || output is null)
                throw new ArgumentNullException();
            if (input.Equals(output))
                throw new ArgumentException("Arguments input and output is the same object");

            using (var transform = Encrypter.CreateDecryptor(init.Key, init.IV))
                Transform(input, output, Encrypter.BlockSize, transform);
        }

        private void Transform(Stream input, Stream output, int blockSize, ICryptoTransform transform)
        {
            using (var outputEncrypted = new CryptoStream(output, transform, CryptoStreamMode.Write))
            {
                blockSize /= 8;
                var buffer = new byte[blockSize];
                int bytesRead = 0;
                do
                {
                    bytesRead = input.Read(buffer, 0, blockSize);
                    outputEncrypted.Write(buffer, 0, bytesRead);
                }
                while (bytesRead > 0);
            }
        }

        public void Dispose()
        {
            Encrypter.Dispose();
        }
    }
}

using System;
using System.IO;
using System.Security.Cryptography;

namespace Encrypter.Services
{
    public class StreamEncrypterAes : IStreamEncrypter
    {
        public EncrypterInit Encrypt(Stream input, Stream output)
        {
            if (input is null || output is null)
                throw new ArgumentNullException();
            if (input.Equals(output))
                throw new ArgumentException("Arguments input and output is the same object.");       

            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Padding = PaddingMode.Zeros;
                var transform = aes.CreateEncryptor(aes.Key, aes.IV);
                Transform(input, output, aes, transform);
                return new EncrypterInit
                {
                    Key = aes.Key,
                    IV = aes.IV
                };
            }
        }

        public void Decrypt(Stream input, Stream output, EncrypterInit init)
        {
            if (init.Key is null || init.IV is null || input is null || output is null)
                throw new ArgumentNullException();
            if (input.Equals(output))
                throw new ArgumentException("Arguments input and output is the same object.");
            if (init.Key.Length != 32 || init.IV.Length != 16)
                throw new ArgumentException("Init is not valid, key size != 256b");

            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Padding = PaddingMode.Zeros;
                var transform = aes.CreateDecryptor(init.Key, init.IV);
                Transform(input, output, aes, transform);
            }
        }

        private void Transform(Stream input, Stream output, Aes aes, ICryptoTransform transform)
        {
            using (var outputEncrypted = new CryptoStream(output, transform, CryptoStreamMode.Write))
            {
                int blockSize = aes.BlockSize;
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
    }
}

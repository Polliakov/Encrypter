using System;
using System.IO;

namespace Encrypter.Services
{
    interface IStreamEncrypter : IDisposable
    {
        void Encrypt(Stream input, Stream output, EncrypterInit init);
        void Decrypt(Stream input, Stream output, EncrypterInit init);
    }
}

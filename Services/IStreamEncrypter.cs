using System.IO;

namespace Encrypter.Services
{
    interface IStreamEncrypter
    {
        EncrypterInit Encrypt(Stream input, Stream output);
        void Decrypt(Stream input, Stream output, EncrypterInit init);
    }
}

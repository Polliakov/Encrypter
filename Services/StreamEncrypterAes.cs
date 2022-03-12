using System.Security.Cryptography;

namespace Encrypter.Services
{
    public class StreamEncrypterAes : SymmetricStreamEncrypter
    {
        public StreamEncrypterAes() : base(Aes.Create()) { }
    }
}

using System.Security.Cryptography;

namespace Encrypter.Services
{
    public class StreamEncrypterAes : SymmetricStreamEncrypter
    {
        public StreamEncrypterAes() : base(new AesCryptoServiceProvider()) { }
    }
}

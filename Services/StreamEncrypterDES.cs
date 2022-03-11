using DESImplementation;

namespace Encrypter.Services
{
    class StreamEncrypterDES : SymmetricStreamEncrypter
    {
        public StreamEncrypterDES() : base(new DESCbc()) { }
    }
}

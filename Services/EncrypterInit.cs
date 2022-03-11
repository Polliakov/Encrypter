using System;

namespace Encrypter.Services
{
    public struct EncrypterInit
    {
        public byte[] Key { get; set; }
        public byte[] IV { get; set; }

        public override string ToString()
        {
            return Convert.ToBase64String(Key) + ":" +
                   Convert.ToBase64String(IV);
        }
    }
}

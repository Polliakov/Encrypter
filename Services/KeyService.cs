using System;
using System.Security.Cryptography;

namespace Encrypter.Services
{
    class KeyService
    {
        private KeyService() { }
        public static KeyService Instance => instance;
        private static readonly KeyService instance = new KeyService();

        public EncryptionAlgorithm Algorithm { get; set; }
        public bool ParseAnyKey { get; set; }
        public int KeyLength
        {
            get
            {
                switch (Algorithm)
                {
                    case EncryptionAlgorithm.Aes: return 256;
                    case EncryptionAlgorithm.DES: return 64;
                    default: throw new NotImplementedException(Algorithm.ToString() + " is not implemented");
                }
            }
        }
        public int IVLength

        {
            get
            {
                switch (Algorithm)
                {
                    case EncryptionAlgorithm.Aes: return 128;
                    case EncryptionAlgorithm.DES: return 64;
                    default: throw new NotImplementedException(Algorithm.ToString() + " is not implemented");
                }
            }
        }
        private static readonly RandomNumberGenerator random = RandomNumberGenerator.Create();

        public EncrypterInit ParseInit(string keyIV)
        {
            if (keyIV is null)
                throw new ArgumentNullException(nameof(keyIV));
            if (keyIV.Length == 0)
                throw new KeyException("Введите ключ");

            EncrypterInit init;
            if (TryParseKey(keyIV, out init))
                return init;
            if (!ParseAnyKey)
                throw new KeyException("Некорректный ключ");

            throw new NotImplementedException();
        }

        public EncrypterInit GenerateInit()
        {
            var key = new byte[KeyLength / 8];
            var iv = new byte[IVLength / 8];
            random.GetBytes(key);
            random.GetBytes(iv);
            return new EncrypterInit { Key = key, IV = iv };
        }

        private bool TryParseKey(string keyIV, out EncrypterInit init)
        {
            try
            {
                var splited = keyIV.Split(':');
                var key = Convert.FromBase64String(splited[0]);
                var iv = Convert.FromBase64String(splited[1]);
                if (key.Length != KeyLength / 8 || iv.Length != IVLength / 8)
                    throw new Exception();
                init = new EncrypterInit { Key = key, IV = iv };
                return true;
            }
            catch
            {
                init = new EncrypterInit();
                return false;
            }
        }
    }
}

using System;
using System.Security.Cryptography;
using System.Text;

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
                    case EncryptionAlgorithm.Aes: return 32;
                    case EncryptionAlgorithm.DES: return 8;
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
                    case EncryptionAlgorithm.Aes: return 16;
                    case EncryptionAlgorithm.DES: return 8;
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

            return GenerateInit(keyIV);
        }

        public EncrypterInit GenerateInit()
        {
            var key = new byte[KeyLength];
            var iv = new byte[IVLength];
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
                if (key.Length != KeyLength || iv.Length != IVLength)
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

        private EncrypterInit GenerateInit(string str)
        {
            var strBytes = Encoding.UTF8.GetBytes(str);
            var expanded = new SHA512Managed().ComputeHash(strBytes);

            var key = new byte[KeyLength];
            var iv = new byte[IVLength];
            Buffer.BlockCopy(expanded, 0, key, 0, key.Length);
            Buffer.BlockCopy(expanded, key.Length, iv, 0, iv.Length);

            return new EncrypterInit { Key = key, IV = iv };
        }
    }
}

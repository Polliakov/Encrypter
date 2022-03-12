using System;
using System.IO;
using System.IO.Compression;
using Encrypter.Properties;
using Encrypter.Services;

namespace Encrypter.Controllers
{
    public class EncrypterController
    {
        private EncrypterController() 
        {
            string fileExt = Resources.FileExt;
            this.fileExt = fileExt;

            zipper = new Zipper(fileExt, CompressionLevel.NoCompression);
            encrypter = new FileEncrypter(new StreamEncrypterAes());

            keyService = KeyService.Instance;
            keyService.Algorithm = EncryptionAlgorithm.Aes;
            keyService.ParseAnyKey = false;
            UseUserKey = false;
        }
        public static EncrypterController Instance => instance; 
        private static readonly EncrypterController instance = new EncrypterController();

        public event Action<string> ShowKey;
        public bool UseUserKey { get; set; }

        private readonly string fileExt;
        private readonly FileEncrypter encrypter;
        private readonly Zipper zipper;
        private readonly KeyService keyService;

        public void EncryptFolder(string path, string keyIV)
        {
            var init = GetInit(keyIV);

            string zipPath = zipper.ZipFolder(path);
            encrypter.Encrypt(zipPath, init);
            Directory.Delete(path, true);
        }

        public void EncryptFile(string path, string keyIV)
        {
            var init = GetInit(keyIV);

            string zipPath = zipper.Zip(path);
            encrypter.Encrypt(zipPath, init);
            File.Delete(path);
        }

        public void Decrypt(string path, string keyIV)
        {
            if (Path.GetExtension(path) != '.' + fileExt)
                throw new FormatException(nameof(path));

            var init = keyService.ParseInit(keyIV);
            string tmpFile = encrypter.Decrypt(path, init);

            try     { zipper.Unzip(tmpFile); }
            catch   { throw new Exception("Не удалось расшифровать"); }
            finally { File.Delete(tmpFile); }

            File.Delete(path);
        }

        public void SetCompressionLevel(CompressionLevel level)
        {
            zipper.CompressionLevel = level;
        }

        public void SetEncryptionAlgorithm(EncryptionAlgorithm algorithm)
        {
            IStreamEncrypter encrypter;
            switch (algorithm)
            {
                case EncryptionAlgorithm.Aes: encrypter = new StreamEncrypterAes(); break;
                case EncryptionAlgorithm.DES: encrypter = new StreamEncrypterDES(); break;
                default: throw new NotImplementedException(algorithm.ToString() + " is not implemented");
            }
            this.encrypter.Encrypter = encrypter;
            keyService.Algorithm = algorithm;
        }

        public void SetParseAnyKey(bool parseAnyKey)
        {
            keyService.ParseAnyKey = parseAnyKey;
        }

        private EncrypterInit GetInit(string keyIV)
        {
            EncrypterInit init;
            if (UseUserKey)
            {
                init = keyService.ParseInit(keyIV);
            }
            else
            {
                init = keyService.GenerateInit();
                ShowKey(init.ToString());
            }
            return init;
        }
    }
}
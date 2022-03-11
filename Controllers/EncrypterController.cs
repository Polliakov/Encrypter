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
        }
        public static EncrypterController Instance => instance; 
        private static readonly EncrypterController instance = new EncrypterController();

        public event Action<string> ShowKey;

        private readonly string fileExt;
        private readonly FileEncrypter encrypter;
        private readonly Zipper zipper;
        private readonly KeyService keyService;

        public void EncryptFolder(string path, string keyIV)
        {
            var init = keyService.GenerateInit();
            ShowKey?.Invoke(init.ToString());

            string zipPath = zipper.ZipFolder(path);
            encrypter.Encrypt(zipPath, init);
            Directory.Delete(path, true);
        }

        public void EncryptFile(string path, string keyIV)
        {
            var init = keyService.GenerateInit();
            ShowKey?.Invoke(init.ToString());

            string zipPath = zipper.Zip(path);
            encrypter.Encrypt(zipPath, init);
            File.Delete(path);
        }

        public void Decrypt(string path, string keyIV)
        {
            if (Path.GetExtension(path) != '.' + fileExt)
                throw new ArgumentException(nameof(path));

            var init = keyService.ParseInit(keyIV);
            encrypter.Decrypt(path, init);
            zipper.Unzip(path);
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
    }
}
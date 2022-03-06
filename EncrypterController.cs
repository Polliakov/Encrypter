using System;
using System.IO;
using System.IO.Compression;
using Encrypter.Properties;
using Encrypter.Services;

namespace Encrypter
{
    public class EncrypterController
    {
        // Singleton section.
        private EncrypterController() 
        {
            string fileExt = Resources.FileExt;
            this.fileExt = fileExt;
            zipper = new Zipper(fileExt);
            encrypter = new FileEncrypter(new StreamEncrypterAes());
        }
        public static EncrypterController Instance { get => instance; }
        private static readonly EncrypterController instance = new EncrypterController();

        public readonly string fileExt;
        private readonly FileEncrypter encrypter;
        private readonly Zipper zipper;

        public EncrypterInit EncryptFolder(string path)
        {
            string zipPath = zipper.ZipFolder(path);
            var init = encrypter.Encrypt(zipPath);
            Directory.Delete(path, true);
            return init; 
        }

        public EncrypterInit EncryptFile(string path)
        {
            string zipPath = zipper.Zip(path);
            var init = encrypter.Encrypt(zipPath);
            File.Delete(path);
            return init;
        }

        public void Decrypt(string path, EncrypterInit init)
        {
            if (Path.GetExtension(path) != '.' + fileExt)
                throw new ArgumentException(nameof(path));

            encrypter.Decrypt(path, init);
            zipper.Unzip(path);
            File.Delete(path);
        }

        public void SetCompressionLevel(CompressionLevel level)
        {
            zipper.compressionLevel = level;
        }
    }
}

using Encrypter.Properties;
using System;
using System.IO;
using System.IO.Compression;

namespace Encrypter
{
    public class EncrypterController
    {
        // Singleton section.
        private EncrypterController() { }
        public static EncrypterController Instance { get => instance; }
        private static readonly EncrypterController instance = new EncrypterController();

        public readonly string fileExt = Resources.FileExt;
        private readonly FileEncrypter encrypter = new FileEncrypter(new StreamEncrypterAes());       

        public EncrypterInit EncryptFolder(string path)
        {
            string zipPath = $"{path}.{fileExt}";
            ZipFile.CreateFromDirectory(path, zipPath, CompressionLevel.NoCompression, false);

            var init = encrypter.Encrypt(zipPath);

            Directory.Delete(path, true);

            return init; 
        }

        public void DecryptFolder(string path, EncrypterInit init)
        {
            if (Path.GetExtension(path) != '.' + fileExt)
                throw new ArgumentException(nameof(path));

            encrypter.Decrypt(path, init);

            string unzipPath = DeleteExt(path);
            ZipFile.ExtractToDirectory(path, unzipPath);
        }

        public EncrypterInit EncryptFile(string path)
        {
            var init = encrypter.Encrypt(path);
            File.Move(path, $"{path}.{fileExt}");
            return init;
        }

        public void DecryptFile(string path, EncrypterInit init)
        {
            encrypter.Decrypt(path, init);
            File.Move(path, DeleteExt(path));
        }

        private string DeleteExt(string path)
        {
            return path.Remove(path.Length - (fileExt.Length + 1));
        }
    }
}

using System.IO;

namespace Encrypter.Services
{
    class FileEncrypter
    {
        public FileEncrypter(IStreamEncrypter streamEncrypter)
        {
            encrypter = streamEncrypter;
        }

        public IStreamEncrypter Encrypter
        {
            get => encrypter;
            set
            {
                encrypter?.Dispose();
                encrypter = value;
            }
        }
        private IStreamEncrypter encrypter;

        public void Encrypt(string path, EncrypterInit init)
        {
            using (var input = OpenFile(path, FileAccess.Read))
            using (var output = OpenFile(path, FileAccess.Write))
                encrypter.Encrypt(input, output, init);
        }

        public void Decrypt(string path, EncrypterInit init)
        {
            using (var input = OpenFile(path, FileAccess.Read))
            using (var output = OpenFile(path, FileAccess.Write))
                encrypter.Decrypt(input, output, init);
        }

        private FileStream OpenFile(string path, FileAccess access)
        {
            long fileSize = new FileInfo(path).Length;
            int bufferSize = fileSize > 1 << 22 ? 1 << 16 : 1 << 12;
            return new FileStream(
                path,
                FileMode.Open,
                access,
                FileShare.ReadWrite,
                bufferSize,
                false);
        }
    }
}

using System.IO;

namespace Encrypter.Services
{
    class FileEncrypter
    {
        public FileEncrypter(IStreamEncrypter streamEncrypter)
        {
            encrypter = streamEncrypter;
        }

        public readonly IStreamEncrypter encrypter;

        public EncrypterInit Encrypt(string path)
        {
            using (var input = OpenFile(path, FileAccess.Read))
            using (var output = OpenFile(path, FileAccess.Write))
                return encrypter.Encrypt(input, output);
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

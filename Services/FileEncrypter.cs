using System;
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
            int bufferSize = BufferSize(path);

            using (var input = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, bufferSize))
            using (var output = new FileStream(path, FileMode.Open, FileAccess.Write, FileShare.ReadWrite, bufferSize))
                encrypter.Encrypt(input, output, init);
        }

        public string Decrypt(string path, EncrypterInit init)
        {
            string pathTmp = path + "tmp";
            int bufferSize = BufferSize(path);

            try
            {
                using (var input = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize))
                using (var output = new FileStream(pathTmp, FileMode.Create, FileAccess.Write, FileShare.Read, bufferSize))
                    encrypter.Decrypt(input, output, init);
            }
            catch
            {
                File.Delete(pathTmp);
                throw new Exception("Внутренняя ошибка дешифровки");
            }

            return pathTmp;
        }

    private int BufferSize(string path)
    {
        long fileSize = new FileInfo(path).Length;
        return fileSize > 1 << 22 ? 1 << 16 : 1 << 12;
    }
}
}

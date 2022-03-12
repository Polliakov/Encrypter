using System;
using System.IO;
using System.IO.Compression;

namespace Encrypter.Services
{
    class Zipper
    {
        public Zipper(string fileExt, CompressionLevel compression)
        {
            this.fileExt = fileExt;
            CompressionLevel = compression;
        }

        public CompressionLevel CompressionLevel { get; set; }
        private readonly string fileExt;

        public string ZipFolder(string path)
        {
            string zipPath = $"{path}.{fileExt}";
            ZipFile.CreateFromDirectory(path, zipPath, CompressionLevel, false);
            return zipPath;
        }

        public string Zip(string path)
        {
            string zipPath = $"{path}.{fileExt}";
            using (FileStream output = new FileStream(zipPath, FileMode.Create))
            using (ZipArchive zip = new ZipArchive(output, ZipArchiveMode.Create))
            {
                zip.CreateEntryFromFile(path, Path.GetFileName(path), CompressionLevel);
            }
            return zipPath;
        }

        public string Unzip(string path)
        {
            if (Path.GetExtension(path) != $".{fileExt}tmp")
                throw new FormatException("Invalid extension");

            string unzipPath = DeleteExt(path);
            ZipFile.ExtractToDirectory(path, unzipPath);
            return unzipPath;
        }

        private string DeleteExt(string path)
        {
            return path.Remove(path.Length - (fileExt.Length + 4)); // 4 for "." and "tmp"
        }
    }
}

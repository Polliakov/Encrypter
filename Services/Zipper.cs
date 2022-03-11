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
            string unzipPath = DeleteExt(path);
            ZipFile.ExtractToDirectory(path, unzipPath);
            return unzipPath;
        }

        // TODO: GetNotExistsPath() like f.txt => f 1.txt.
        private string GetNotExistsFilePath(string path)
        {
            if (!File.Exists(path)) return path;

            int copyNumber = 1;
            string fileNameOrig = Path.GetFileName(path);
            do
            {
                string fileName = Path.GetFileName(path);
                int fileNameI = path.LastIndexOf(fileName);
                path = path.Remove(fileNameI, fileName.Length);
                path = path.Insert(fileNameI, $"{fileNameOrig} {copyNumber}");
            }
            while(File.Exists(path));
            return path;
        }

        private string DeleteExt(string path)
        {
            return path.Remove(path.Length - (fileExt.Length + 1));
        }
    }
}

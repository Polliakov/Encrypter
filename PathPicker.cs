using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Forms;

namespace Encrypter
{
    public class PathPicker
    {
        public string FolderDialog()
        {
            using (var folderDialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                Title = "Выбoр каталога",
                DefaultFileName = "Выберите каталог...",
            })
            {
                if (folderDialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    return folderDialog.FileName;
                }
                return null;
            }
        }

        public string FileDialog(string filterExt = "*")
        {
            using (var fileDialog = new OpenFileDialog
            {
                Title = "Выбор файла",
                FileName = "Выберите файл...",
                Filter = $"Files (*.{filterExt})|*.{filterExt}",
            })
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    return fileDialog.FileName;
                }
                return null;
            }          
        }
    }
}

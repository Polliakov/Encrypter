using Encrypter.Properties;
using System;
using System.Windows.Forms;

namespace Encrypter
{
    public partial class MainForm : Form
    {
        private readonly PathPicker pathPicker = new PathPicker();
        private readonly EncrypterController controller = EncrypterController.Instance;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtEncryptFolder_Click(object sender, EventArgs e)
        {
            string path = pathPicker.FolderDialog();
            if (path is null) return;
            try
            {
                var init = controller.EncryptFolder(path);
                ShowKey(init);
            }
            catch 
            {
                MessageBox.Show("Что-то пошло не так :(", "Ошибка");
            }
        }

        private void BtDecryptFolder_Click(object sender, EventArgs e)
        {
            if (!TryParseKey(out EncrypterInit init))
            {
                MessageBox.Show("Некорректный ключ.", "Ошибка");
                return;
            }
            string path = pathPicker.FileDialog(controller.fileExt);
            if (path is null) return;
            try
            {
                controller.DecryptFolder(path, init);
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так :(", "Ошибка");
            }
        }

        private void BtEncryptFile_Click(object sender, EventArgs e)
        {
            string path = pathPicker.FileDialog();
            if (path is null) return;
            try
            {
                var init = controller.EncryptFile(path);
                ShowKey(init);
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так :(", "Ошибка");
            }          
        }

        private void BtDecryptFile_Click(object sender, EventArgs e)
        {
            if (!TryParseKey(out EncrypterInit init))
            {
                MessageBox.Show("Некорректный ключ.", "Ошибка");
                return;
            }
            string path = pathPicker.FileDialog(controller.fileExt);
            if (path is null) return;
            try
            {
                controller.DecryptFile(path, init);
                
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так :(", "Ошибка");
            }
        }

        private void ShowKey(EncrypterInit init)
        {
            tbKey.Text = Convert.ToBase64String(init.Key) +
                ":" + Convert.ToBase64String(init.IV);
        }

        private bool TryParseKey(out EncrypterInit init)
        {
            try
            {
                var keyIv = tbKey.Text.Split(':');
                var key = Convert.FromBase64String(keyIv[0]);
                var iv = Convert.FromBase64String(keyIv[1]);
                if (key.Length != 32 || iv.Length != 16)
                    throw new Exception();
                init = new EncrypterInit { Key = key, IV = iv };
                return true;
            }
            catch
            {
                init = new EncrypterInit();
                return false;
            }         
        }
    }
}

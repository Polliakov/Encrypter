using Encrypter.Controllers;
using Encrypter.Properties;
using System;
using System.Drawing;
using System.IO.Compression;
using System.Windows.Forms;

namespace Encrypter.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            optionsHeightShift = pnlOptions.Height - 32;
            cbCompressionLevel.SelectedIndex = 0;
            cbEncryptionAlgorithm.SelectedIndex = 0;
            btDecrypt.Text += fileExt;

            controller.ShowKey += ShowKeyHandler;
        }

        private readonly PathPicker pathPicker = new PathPicker();
        private readonly EncrypterController controller = EncrypterController.Instance;
        private readonly string fileExt = Resources.FileExt;

        private readonly int optionsHeightShift;
        private bool isOptionsExpanded = true;


        private void BtEncryptFolder_Click(object sender, EventArgs e)
        {
            string path = pathPicker.FolderDialog();
            if (path is null) return;

            OperationStatusHandle(() =>
            {
                controller.EncryptFolder(path, tbKey.Text);
            });
        }

        private void BtEncryptFile_Click(object sender, EventArgs e)
        {
            string path = pathPicker.FileDialog();
            if (path is null) return;

            OperationStatusHandle(() =>
            {
                controller.EncryptFile(path, tbKey.Text);
            });
        }

        private void BtDecrypt_Click(object sender, EventArgs e)
        {
            string path = pathPicker.FileDialog(fileExt);
            if (path is null) return;

            OperationStatusHandle(() =>
            {
                controller.Decrypt(path, tbKey.Text);
            });
        }

        private void CbEncryptionAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            EncryptionAlgorithm algorithm;
            switch (cbEncryptionAlgorithm.SelectedIndex)
            {
                case 0: algorithm = EncryptionAlgorithm.Aes; break;
                case 1: algorithm = EncryptionAlgorithm.DES; break;
                default: throw new ApplicationException("Incorrect encryption algorithm");
            }
            controller.SetEncryptionAlgorithm(algorithm);
        }

        private void CbCompressionLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompressionLevel level;
            switch (cbCompressionLevel.SelectedIndex)
            {
                case 0: level = CompressionLevel.NoCompression; break;
                case 1: level = CompressionLevel.Fastest; break;
                case 2: level = CompressionLevel.Optimal; break;
                default: throw new ApplicationException("Incorrect compression level.");
            }
            controller.SetCompressionLevel(level);
        }

        private void BtExpandOptions_Click(object sender, EventArgs e)
        {
            ToggleOptionsExpand();
        }

        private void ToggleOptionsExpand()
        {
            btExpandOptions.Text = isOptionsExpanded ? "v" : "ʌ";
            int shift = isOptionsExpanded ? -optionsHeightShift : optionsHeightShift;

            pnlOptions.Height += shift;
            MinimumSize = new Size(Width, Height + shift);
            MaximumSize = MinimumSize;

            isOptionsExpanded = !isOptionsExpanded;
        }

        private void OperationStatusHandle(Action action)
        {
            try
            {
                action.Invoke();
                MessageBox.Show("Операция успешно выполнена", "Успех", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
            }
        }

        private void ShowKeyHandler(string init) => tbKey.Text = init;
    }
}

using Encrypter.Controllers;
using System;
using System.IO;
using System.Windows.Forms;

namespace Encrypter.UI
{
    public partial class DecryptForm : Form
    {
        public DecryptForm(string path)
        {
            if (!File.Exists(path))
                Application.Exit();
            this.path = path;

            InitializeComponent();
            cbEncryptionAlgorithm.SelectedIndex = 0;
            lblPath.Text = path;
        }

        private readonly EncrypterController controller = EncrypterController.Instance;
        private readonly string path;

        private void BtDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                controller.Decrypt(path, tbKey.Text);
                MessageBox.Show("Файл расшифрован", "Выполнение завершено", MessageBoxButtons.OK);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
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

        private void ChbFreeKey_CheckedChanged(object sender, EventArgs e)
        {
            controller.SetParseAnyKey(chbFreeKey.Checked);
        }
    }
}


namespace Encrypter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btEncryptFile = new System.Windows.Forms.Button();
            this.btDecryptFile = new System.Windows.Forms.Button();
            this.btEncryptFolder = new System.Windows.Forms.Button();
            this.btDecryptFolder = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btEncryptFile
            // 
            this.btEncryptFile.BackColor = System.Drawing.Color.AliceBlue;
            this.btEncryptFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btEncryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEncryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEncryptFile.Location = new System.Drawing.Point(5, 5);
            this.btEncryptFile.Margin = new System.Windows.Forms.Padding(5);
            this.btEncryptFile.Name = "btEncryptFile";
            this.btEncryptFile.Size = new System.Drawing.Size(233, 39);
            this.btEncryptFile.TabIndex = 0;
            this.btEncryptFile.Text = "Зашифровать файл";
            this.btEncryptFile.UseVisualStyleBackColor = false;
            this.btEncryptFile.Click += new System.EventHandler(this.BtEncryptFile_Click);
            // 
            // btDecryptFile
            // 
            this.btDecryptFile.BackColor = System.Drawing.Color.AliceBlue;
            this.btDecryptFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDecryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDecryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDecryptFile.Location = new System.Drawing.Point(5, 54);
            this.btDecryptFile.Margin = new System.Windows.Forms.Padding(5);
            this.btDecryptFile.Name = "btDecryptFile";
            this.btDecryptFile.Size = new System.Drawing.Size(233, 39);
            this.btDecryptFile.TabIndex = 1;
            this.btDecryptFile.Text = "Расшифровать файл";
            this.btDecryptFile.UseVisualStyleBackColor = false;
            this.btDecryptFile.Click += new System.EventHandler(this.BtDecryptFile_Click);
            // 
            // btEncryptFolder
            // 
            this.btEncryptFolder.BackColor = System.Drawing.Color.Ivory;
            this.btEncryptFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btEncryptFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEncryptFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEncryptFolder.Location = new System.Drawing.Point(248, 5);
            this.btEncryptFolder.Margin = new System.Windows.Forms.Padding(5);
            this.btEncryptFolder.Name = "btEncryptFolder";
            this.btEncryptFolder.Size = new System.Drawing.Size(233, 39);
            this.btEncryptFolder.TabIndex = 2;
            this.btEncryptFolder.Text = "Зашифровать каталог";
            this.btEncryptFolder.UseVisualStyleBackColor = false;
            this.btEncryptFolder.Click += new System.EventHandler(this.BtEncryptFolder_Click);
            // 
            // btDecryptFolder
            // 
            this.btDecryptFolder.BackColor = System.Drawing.Color.Ivory;
            this.btDecryptFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDecryptFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDecryptFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDecryptFolder.Location = new System.Drawing.Point(248, 54);
            this.btDecryptFolder.Margin = new System.Windows.Forms.Padding(5);
            this.btDecryptFolder.Name = "btDecryptFolder";
            this.btDecryptFolder.Size = new System.Drawing.Size(233, 39);
            this.btDecryptFolder.TabIndex = 3;
            this.btDecryptFolder.Text = "Расшифровать каталог";
            this.btDecryptFolder.UseVisualStyleBackColor = false;
            this.btDecryptFolder.Click += new System.EventHandler(this.BtDecryptFolder_Click);
            // 
            // tbKey
            // 
            this.tbKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKey.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKey.Location = new System.Drawing.Point(9, 151);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(486, 19);
            this.tbKey.TabIndex = 4;
            this.tbKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btDecryptFile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btEncryptFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btEncryptFolder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btDecryptFolder, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 98);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ключ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 121);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(486, 24);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 181);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 220);
            this.Name = "MainForm";
            this.Text = "Encrypter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btEncryptFile;
        private System.Windows.Forms.Button btDecryptFile;
        private System.Windows.Forms.Button btEncryptFolder;
        private System.Windows.Forms.Button btDecryptFolder;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
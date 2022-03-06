
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
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btDecrypt = new System.Windows.Forms.Button();
            this.btEncryptFolder = new System.Windows.Forms.Button();
            this.btEncryptFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCompressionLevel = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEncryptAlgorithm = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chbFreeKey = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbKey
            // 
            this.tbKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbKey.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKey.Location = new System.Drawing.Point(8, 241);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(563, 20);
            this.tbKey.TabIndex = 4;
            this.tbKey.Text = "0n5hA6IkmLlu3M8AcQ2p7qUguzFj1l9QG6hmEjLMMPs=:akiGBOYk3fXgScFKw0iAww==";
            this.tbKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btDecrypt
            // 
            this.btDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDecrypt.BackColor = System.Drawing.Color.Ivory;
            this.btDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDecrypt.Location = new System.Drawing.Point(5, 34);
            this.btDecrypt.Margin = new System.Windows.Forms.Padding(5);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(273, 39);
            this.btDecrypt.TabIndex = 3;
            this.btDecrypt.Text = "Архив ";
            this.btDecrypt.UseVisualStyleBackColor = false;
            this.btDecrypt.Click += new System.EventHandler(this.BtDecrypt_Click);
            // 
            // btEncryptFolder
            // 
            this.btEncryptFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEncryptFolder.BackColor = System.Drawing.Color.Ivory;
            this.btEncryptFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEncryptFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEncryptFolder.Location = new System.Drawing.Point(146, 34);
            this.btEncryptFolder.Margin = new System.Windows.Forms.Padding(5);
            this.btEncryptFolder.Name = "btEncryptFolder";
            this.btEncryptFolder.Size = new System.Drawing.Size(132, 39);
            this.btEncryptFolder.TabIndex = 2;
            this.btEncryptFolder.Text = "Каталог";
            this.btEncryptFolder.UseVisualStyleBackColor = false;
            this.btEncryptFolder.Click += new System.EventHandler(this.BtEncryptFolder_Click);
            // 
            // btEncryptFile
            // 
            this.btEncryptFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEncryptFile.BackColor = System.Drawing.Color.AliceBlue;
            this.btEncryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEncryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEncryptFile.Location = new System.Drawing.Point(5, 34);
            this.btEncryptFile.Margin = new System.Windows.Forms.Padding(5);
            this.btEncryptFile.Name = "btEncryptFile";
            this.btEncryptFile.Size = new System.Drawing.Size(132, 39);
            this.btEncryptFile.TabIndex = 0;
            this.btEncryptFile.Text = "Файл";
            this.btEncryptFile.UseVisualStyleBackColor = false;
            this.btEncryptFile.Click += new System.EventHandler(this.BtEncryptFile_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Зашифровать";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 124);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 84);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btEncryptFolder);
            this.panel1.Controls.Add(this.btEncryptFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 78);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btDecrypt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(292, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 78);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Расшифровать";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(561, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Настройки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCompressionLevel
            // 
            this.cbCompressionLevel.BackColor = System.Drawing.SystemColors.Window;
            this.cbCompressionLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompressionLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCompressionLevel.FormattingEnabled = true;
            this.cbCompressionLevel.Items.AddRange(new object[] {
            "Без сжатия",
            "Быстрое",
            "Оптимальное"});
            this.cbCompressionLevel.Location = new System.Drawing.Point(404, 37);
            this.cbCompressionLevel.Name = "cbCompressionLevel";
            this.cbCompressionLevel.Size = new System.Drawing.Size(139, 26);
            this.cbCompressionLevel.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.chbFreeKey);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cbCompressionLevel);
            this.panel3.Controls.Add(this.cbEncryptAlgorithm);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(8, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 104);
            this.panel3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(331, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Сжатие";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Алгритм шифрования";
            // 
            // cbEncryptAlgorithm
            // 
            this.cbEncryptAlgorithm.BackColor = System.Drawing.SystemColors.Window;
            this.cbEncryptAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncryptAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbEncryptAlgorithm.FormattingEnabled = true;
            this.cbEncryptAlgorithm.Items.AddRange(new object[] {
            "AES"});
            this.cbEncryptAlgorithm.Location = new System.Drawing.Point(197, 37);
            this.cbEncryptAlgorithm.Name = "cbEncryptAlgorithm";
            this.cbEncryptAlgorithm.Size = new System.Drawing.Size(128, 26);
            this.cbEncryptAlgorithm.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(26, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Произвольный ключ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chbFreeKey
            // 
            this.chbFreeKey.AutoSize = true;
            this.chbFreeKey.Location = new System.Drawing.Point(197, 77);
            this.chbFreeKey.Name = "chbFreeKey";
            this.chbFreeKey.Size = new System.Drawing.Size(15, 14);
            this.chbFreeKey.TabIndex = 16;
            this.chbFreeKey.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ключ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 214);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(555, 24);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(579, 272);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(500, 220);
            this.Name = "MainForm";
            this.Text = "Encrypter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btDecrypt;
        private System.Windows.Forms.Button btEncryptFolder;
        private System.Windows.Forms.Button btEncryptFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCompressionLevel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEncryptAlgorithm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbFreeKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

namespace Encrypter.UI
{
    partial class DecryptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecryptForm));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.chbFreeKey = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEncryptionAlgorithm = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.btDecrypt = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 80);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(555, 24);
            this.tableLayoutPanel2.TabIndex = 9;
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
            // tbKey
            // 
            this.tbKey.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKey.Location = new System.Drawing.Point(8, 107);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(563, 20);
            this.tbKey.TabIndex = 8;
            this.tbKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chbFreeKey
            // 
            this.chbFreeKey.AutoSize = true;
            this.chbFreeKey.Location = new System.Drawing.Point(528, 50);
            this.chbFreeKey.Name = "chbFreeKey";
            this.chbFreeKey.Size = new System.Drawing.Size(15, 14);
            this.chbFreeKey.TabIndex = 20;
            this.chbFreeKey.UseVisualStyleBackColor = true;
            this.chbFreeKey.CheckedChanged += new System.EventHandler(this.ChbFreeKey_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(357, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Произвольный ключ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbEncryptionAlgorithm
            // 
            this.cbEncryptionAlgorithm.BackColor = System.Drawing.SystemColors.Window;
            this.cbEncryptionAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncryptionAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbEncryptionAlgorithm.FormattingEnabled = true;
            this.cbEncryptionAlgorithm.Items.AddRange(new object[] {
            "AES",
            "DES"});
            this.cbEncryptionAlgorithm.Location = new System.Drawing.Point(215, 43);
            this.cbEncryptionAlgorithm.Name = "cbEncryptionAlgorithm";
            this.cbEncryptionAlgorithm.Size = new System.Drawing.Size(128, 26);
            this.cbEncryptionAlgorithm.TabIndex = 18;
            this.cbEncryptionAlgorithm.SelectedIndexChanged += new System.EventHandler(this.CbEncryptionAlgorithm_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Алгритм шифрования";
            // 
            // lblPath
            // 
            this.lblPath.AutoEllipsis = true;
            this.lblPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPath.Location = new System.Drawing.Point(8, 9);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(563, 23);
            this.lblPath.TabIndex = 21;
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDecrypt
            // 
            this.btDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(231)))), ((int)(((byte)(207)))));
            this.btDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDecrypt.Location = new System.Drawing.Point(405, 139);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(162, 32);
            this.btDecrypt.TabIndex = 22;
            this.btDecrypt.Text = "Расшифровать";
            this.btDecrypt.UseVisualStyleBackColor = false;
            this.btDecrypt.Click += new System.EventHandler(this.BtDecrypt_Click);
            // 
            // DecryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(579, 183);
            this.Controls.Add(this.btDecrypt);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.chbFreeKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbEncryptionAlgorithm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tbKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(595, 222);
            this.MinimumSize = new System.Drawing.Size(595, 222);
            this.Name = "DecryptForm";
            this.Text = "Encrypter";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.CheckBox chbFreeKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEncryptionAlgorithm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btDecrypt;
    }
}
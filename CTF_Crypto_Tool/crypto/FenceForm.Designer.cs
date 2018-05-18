namespace CTF_Crypto_Tool.crypto
{
    partial class FenceForm
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
            this.buttonEncrypto = new System.Windows.Forms.Button();
            this.buttonDecrypto = new System.Windows.Forms.Button();
            this.buttonEncryptoAll = new System.Windows.Forms.Button();
            this.buttonDecryptoAll = new System.Windows.Forms.Button();
            this.labelGroup = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.textBoxChiper = new System.Windows.Forms.TextBox();
            this.labelCryptoText = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEncrypto
            // 
            this.buttonEncrypto.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEncrypto.Location = new System.Drawing.Point(26, 85);
            this.buttonEncrypto.Name = "buttonEncrypto";
            this.buttonEncrypto.Size = new System.Drawing.Size(59, 26);
            this.buttonEncrypto.TabIndex = 0;
            this.buttonEncrypto.Text = "加密";
            this.buttonEncrypto.UseVisualStyleBackColor = true;
            this.buttonEncrypto.Click += new System.EventHandler(this.buttonEncrypto_Click);
            // 
            // buttonDecrypto
            // 
            this.buttonDecrypto.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDecrypto.Location = new System.Drawing.Point(91, 85);
            this.buttonDecrypto.Name = "buttonDecrypto";
            this.buttonDecrypto.Size = new System.Drawing.Size(59, 26);
            this.buttonDecrypto.TabIndex = 1;
            this.buttonDecrypto.Text = "解密";
            this.buttonDecrypto.UseVisualStyleBackColor = true;
            this.buttonDecrypto.Click += new System.EventHandler(this.buttonDecrypto_Click);
            // 
            // buttonEncryptoAll
            // 
            this.buttonEncryptoAll.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEncryptoAll.Location = new System.Drawing.Point(156, 85);
            this.buttonEncryptoAll.Name = "buttonEncryptoAll";
            this.buttonEncryptoAll.Size = new System.Drawing.Size(82, 26);
            this.buttonEncryptoAll.TabIndex = 2;
            this.buttonEncryptoAll.Text = "列举加密";
            this.buttonEncryptoAll.UseVisualStyleBackColor = true;
            this.buttonEncryptoAll.Click += new System.EventHandler(this.buttonEncryptoAll_Click);
            // 
            // buttonDecryptoAll
            // 
            this.buttonDecryptoAll.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDecryptoAll.Location = new System.Drawing.Point(244, 85);
            this.buttonDecryptoAll.Name = "buttonDecryptoAll";
            this.buttonDecryptoAll.Size = new System.Drawing.Size(82, 26);
            this.buttonDecryptoAll.TabIndex = 3;
            this.buttonDecryptoAll.Text = "列举解密";
            this.buttonDecryptoAll.UseVisualStyleBackColor = true;
            this.buttonDecryptoAll.Click += new System.EventHandler(this.buttonDecryptoAll_Click);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("宋体", 10F);
            this.labelGroup.Location = new System.Drawing.Point(332, 89);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(59, 17);
            this.labelGroup.TabIndex = 6;
            this.labelGroup.Text = "栏数：";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGroup.Font = new System.Drawing.Font("宋体", 10F);
            this.textBoxGroup.Location = new System.Drawing.Point(381, 85);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(100, 27);
            this.textBoxGroup.TabIndex = 7;
            this.textBoxGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGroup_KeyPress);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox.Font = new System.Drawing.Font("宋体", 10F);
            this.checkBox.Location = new System.Drawing.Point(499, 88);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(145, 21);
            this.checkBox.TabIndex = 8;
            this.checkBox.Text = "只列举完整匹配";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // textBoxChiper
            // 
            this.textBoxChiper.Location = new System.Drawing.Point(26, 144);
            this.textBoxChiper.Multiline = true;
            this.textBoxChiper.Name = "textBoxChiper";
            this.textBoxChiper.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChiper.Size = new System.Drawing.Size(618, 334);
            this.textBoxChiper.TabIndex = 9;
            // 
            // labelCryptoText
            // 
            this.labelCryptoText.AutoSize = true;
            this.labelCryptoText.Font = new System.Drawing.Font("宋体", 10F);
            this.labelCryptoText.Location = new System.Drawing.Point(26, 124);
            this.labelCryptoText.Name = "labelCryptoText";
            this.labelCryptoText.Size = new System.Drawing.Size(59, 17);
            this.labelCryptoText.TabIndex = 10;
            this.labelCryptoText.Text = "密文框";
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("宋体", 10F);
            this.labelTip.Location = new System.Drawing.Point(26, 59);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(586, 17);
            this.labelTip.TabIndex = 11;
            this.labelTip.Text = "在下面的文本框输入明文或密文，点加密或解密，文本框中即可出现所得结果";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(26, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(115, 33);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "栅栏密码";
            // 
            // FenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 506);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelCryptoText);
            this.Controls.Add(this.textBoxChiper);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.buttonDecryptoAll);
            this.Controls.Add(this.buttonEncryptoAll);
            this.Controls.Add(this.buttonDecrypto);
            this.Controls.Add(this.buttonEncrypto);
            this.MaximizeBox = false;
            this.Name = "FenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FenceForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncrypto;
        private System.Windows.Forms.Button buttonDecrypto;
        private System.Windows.Forms.Button buttonEncryptoAll;
        private System.Windows.Forms.Button buttonDecryptoAll;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox textBoxChiper;
        private System.Windows.Forms.Label labelCryptoText;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelTitle;
    }
}
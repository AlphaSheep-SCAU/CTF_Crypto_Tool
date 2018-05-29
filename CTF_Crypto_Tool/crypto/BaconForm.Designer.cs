namespace CTF_Crypto_Tool.crypto
{
    partial class BaconForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonShowTable = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(12, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(89, 20);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "培根加密";
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("宋体", 10F);
            this.labelTip.Location = new System.Drawing.Point(12, 51);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(586, 17);
            this.labelTip.TabIndex = 12;
            this.labelTip.Text = "在下面的文本框输入明文或密文，点加密或解密，文本框中即可出现所得结果";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Font = new System.Drawing.Font("幼圆", 10.8F);
            this.buttonDecrypt.Location = new System.Drawing.Point(84, 102);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(65, 30);
            this.buttonDecrypt.TabIndex = 14;
            this.buttonDecrypt.Text = "解密";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("幼圆", 10.8F);
            this.buttonEncrypt.Location = new System.Drawing.Point(13, 102);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(65, 30);
            this.buttonEncrypt.TabIndex = 13;
            this.buttonEncrypt.Text = "加密";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonShowTable
            // 
            this.buttonShowTable.Font = new System.Drawing.Font("幼圆", 10.8F);
            this.buttonShowTable.Location = new System.Drawing.Point(155, 102);
            this.buttonShowTable.Name = "buttonShowTable";
            this.buttonShowTable.Size = new System.Drawing.Size(107, 30);
            this.buttonShowTable.TabIndex = 15;
            this.buttonShowTable.Text = "显示码表";
            this.buttonShowTable.UseVisualStyleBackColor = true;
            this.buttonShowTable.Click += new System.EventHandler(this.buttonShowTable_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(15, 71);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(583, 25);
            this.textBoxMessage.TabIndex = 16;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(12, 138);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(583, 296);
            this.textBoxResult.TabIndex = 17;
            // 
            // BaconForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 460);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonShowTable);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelTitle);
            this.MaximizeBox = false;
            this.Name = "BaconForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BaconForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonShowTable;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}
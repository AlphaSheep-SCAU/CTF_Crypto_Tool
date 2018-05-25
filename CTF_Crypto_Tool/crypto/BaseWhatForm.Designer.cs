namespace CTF_Crypto_Tool.crypto
{
    partial class BaseWhatForm
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
            this.labelTip1 = new System.Windows.Forms.Label();
            this.labelTip2 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.panelMode = new System.Windows.Forms.Panel();
            this.rb64 = new System.Windows.Forms.RadioButton();
            this.rb32 = new System.Windows.Forms.RadioButton();
            this.rb16 = new System.Windows.Forms.RadioButton();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.panelMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(24, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(109, 20);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Base??加密";
            // 
            // labelTip1
            // 
            this.labelTip1.AutoSize = true;
            this.labelTip1.Font = new System.Drawing.Font("宋体", 10F);
            this.labelTip1.Location = new System.Drawing.Point(25, 64);
            this.labelTip1.Name = "labelTip1";
            this.labelTip1.Size = new System.Drawing.Size(450, 17);
            this.labelTip1.TabIndex = 3;
            this.labelTip1.Text = "在下面的文本框输入明文或密文，并选择加密或解密方式，";
            // 
            // labelTip2
            // 
            this.labelTip2.AutoSize = true;
            this.labelTip2.Font = new System.Drawing.Font("宋体", 10F);
            this.labelTip2.Location = new System.Drawing.Point(25, 93);
            this.labelTip2.Name = "labelTip2";
            this.labelTip2.Size = new System.Drawing.Size(331, 17);
            this.labelTip2.TabIndex = 4;
            this.labelTip2.Text = "点加密或解密，文本框中即可出现所得结果";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(28, 114);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(509, 130);
            this.textBoxMessage.TabIndex = 5;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Font = new System.Drawing.Font("幼圆", 10.8F);
            this.buttonDecrypt.Location = new System.Drawing.Point(99, 250);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(65, 30);
            this.buttonDecrypt.TabIndex = 10;
            this.buttonDecrypt.Text = "解密";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("幼圆", 10.8F);
            this.buttonEncrypt.Location = new System.Drawing.Point(28, 250);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(65, 30);
            this.buttonEncrypt.TabIndex = 9;
            this.buttonEncrypt.Text = "加密";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // panelMode
            // 
            this.panelMode.Controls.Add(this.rb16);
            this.panelMode.Controls.Add(this.rb32);
            this.panelMode.Controls.Add(this.rb64);
            this.panelMode.Location = new System.Drawing.Point(180, 250);
            this.panelMode.Name = "panelMode";
            this.panelMode.Size = new System.Drawing.Size(357, 30);
            this.panelMode.TabIndex = 11;
            // 
            // rb64
            // 
            this.rb64.AutoSize = true;
            this.rb64.Location = new System.Drawing.Point(19, 5);
            this.rb64.Name = "rb64";
            this.rb64.Size = new System.Drawing.Size(76, 19);
            this.rb64.TabIndex = 0;
            this.rb64.TabStop = true;
            this.rb64.Text = "Base64";
            this.rb64.UseVisualStyleBackColor = true;
            // 
            // rb32
            // 
            this.rb32.AutoSize = true;
            this.rb32.Location = new System.Drawing.Point(134, 5);
            this.rb32.Name = "rb32";
            this.rb32.Size = new System.Drawing.Size(76, 19);
            this.rb32.TabIndex = 1;
            this.rb32.TabStop = true;
            this.rb32.Text = "Base32";
            this.rb32.UseVisualStyleBackColor = true;
            // 
            // rb16
            // 
            this.rb16.AutoSize = true;
            this.rb16.Location = new System.Drawing.Point(249, 5);
            this.rb16.Name = "rb16";
            this.rb16.Size = new System.Drawing.Size(76, 19);
            this.rb16.TabIndex = 2;
            this.rb16.TabStop = true;
            this.rb16.Text = "Base16";
            this.rb16.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(28, 286);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(509, 158);
            this.textBoxResult.TabIndex = 12;
            // 
            // BaseWhatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 466);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.panelMode);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.labelTip2);
            this.Controls.Add(this.labelTip1);
            this.Controls.Add(this.labelTitle);
            this.Name = "BaseWhatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Base??Form";
            this.panelMode.ResumeLayout(false);
            this.panelMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTip1;
        private System.Windows.Forms.Label labelTip2;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Panel panelMode;
        private System.Windows.Forms.RadioButton rb16;
        private System.Windows.Forms.RadioButton rb32;
        private System.Windows.Forms.RadioButton rb64;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}
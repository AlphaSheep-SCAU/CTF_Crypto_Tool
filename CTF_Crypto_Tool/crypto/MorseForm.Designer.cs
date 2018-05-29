namespace CTF_Crypto_Tool.crypto
{
    partial class MorseForm
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
            this.labelPoint = new System.Windows.Forms.Label();
            this.textBoxDit = new System.Windows.Forms.TextBox();
            this.textBoxDah = new System.Windows.Forms.TextBox();
            this.labelLine = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelTip2 = new System.Windows.Forms.Label();
            this.buttonShowTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(28, 29);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(89, 20);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "摩斯密码";
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("宋体", 10F);
            this.labelTip.Location = new System.Drawing.Point(29, 72);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(586, 17);
            this.labelTip.TabIndex = 2;
            this.labelTip.Text = "在下面的文本框输入明文或密文，点加密或解密，文本框中即可出现所得结果";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Font = new System.Drawing.Font("幼圆", 10.8F);
            this.buttonDecrypt.Location = new System.Drawing.Point(103, 129);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(65, 30);
            this.buttonDecrypt.TabIndex = 8;
            this.buttonDecrypt.Text = "解密";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("幼圆", 10.8F);
            this.buttonEncrypt.Location = new System.Drawing.Point(32, 129);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(65, 30);
            this.buttonEncrypt.TabIndex = 7;
            this.buttonEncrypt.Text = "加密";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Font = new System.Drawing.Font("宋体", 10F);
            this.labelPoint.Location = new System.Drawing.Point(36, 170);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(42, 17);
            this.labelPoint.TabIndex = 10;
            this.labelPoint.Text = "点：";
            // 
            // textBoxDit
            // 
            this.textBoxDit.Location = new System.Drawing.Point(74, 165);
            this.textBoxDit.Name = "textBoxDit";
            this.textBoxDit.Size = new System.Drawing.Size(39, 25);
            this.textBoxDit.TabIndex = 11;
            this.textBoxDit.TextChanged += new System.EventHandler(this.textBoxDit_TextChanged);
            this.textBoxDit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPoint_KeyPress);
            // 
            // textBoxDah
            // 
            this.textBoxDah.Location = new System.Drawing.Point(157, 165);
            this.textBoxDah.Name = "textBoxDah";
            this.textBoxDah.Size = new System.Drawing.Size(39, 25);
            this.textBoxDah.TabIndex = 13;
            this.textBoxDah.TextChanged += new System.EventHandler(this.textBoxDah_TextChanged);
            this.textBoxDah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPoint_KeyPress);
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Font = new System.Drawing.Font("宋体", 10F);
            this.labelLine.Location = new System.Drawing.Point(119, 170);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(42, 17);
            this.labelLine.TabIndex = 12;
            this.labelLine.Text = "划：";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(32, 93);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(583, 25);
            this.textBoxMessage.TabIndex = 14;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(32, 196);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(583, 296);
            this.textBoxResult.TabIndex = 15;
            // 
            // labelTip2
            // 
            this.labelTip2.AutoSize = true;
            this.labelTip2.Font = new System.Drawing.Font("宋体", 10F);
            this.labelTip2.Location = new System.Drawing.Point(232, 170);
            this.labelTip2.Name = "labelTip2";
            this.labelTip2.Size = new System.Drawing.Size(324, 17);
            this.labelTip2.TabIndex = 16;
            this.labelTip2.Text = "解密时密码之间用/隔开,若出现@表示出错";
            // 
            // buttonShowTable
            // 
            this.buttonShowTable.Font = new System.Drawing.Font("幼圆", 10.8F);
            this.buttonShowTable.Location = new System.Drawing.Point(174, 129);
            this.buttonShowTable.Name = "buttonShowTable";
            this.buttonShowTable.Size = new System.Drawing.Size(107, 30);
            this.buttonShowTable.TabIndex = 9;
            this.buttonShowTable.Text = "显示码表";
            this.buttonShowTable.UseVisualStyleBackColor = true;
            this.buttonShowTable.Click += new System.EventHandler(this.buttonShowTable_Click);
            // 
            // MorseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 526);
            this.Controls.Add(this.labelTip2);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxDah);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.textBoxDit);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.buttonShowTable);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelTitle);
            this.Name = "MorseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MorseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.TextBox textBoxDit;
        private System.Windows.Forms.TextBox textBoxDah;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelTip2;
        private System.Windows.Forms.Button buttonShowTable;
    }
}
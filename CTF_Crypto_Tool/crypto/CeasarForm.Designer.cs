namespace CTF_Crypto_Tool.crypto
{
    partial class CeasarForm
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
            this.groupBoxCeasar = new System.Windows.Forms.GroupBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonListAllResult = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxchipper = new System.Windows.Forms.TextBox();
            this.labelChipper = new System.Windows.Forms.Label();
            this.groupBoxCeasar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCeasar
            // 
            this.groupBoxCeasar.Controls.Add(this.labelMode);
            this.groupBoxCeasar.Controls.Add(this.textBoxResult);
            this.groupBoxCeasar.Controls.Add(this.buttonListAllResult);
            this.groupBoxCeasar.Controls.Add(this.buttonDecrypt);
            this.groupBoxCeasar.Controls.Add(this.labelTitle);
            this.groupBoxCeasar.Controls.Add(this.buttonEncrypt);
            this.groupBoxCeasar.Controls.Add(this.modeComboBox);
            this.groupBoxCeasar.Controls.Add(this.textBoxchipper);
            this.groupBoxCeasar.Controls.Add(this.labelChipper);
            this.groupBoxCeasar.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCeasar.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCeasar.Name = "groupBoxCeasar";
            this.groupBoxCeasar.Size = new System.Drawing.Size(721, 511);
            this.groupBoxCeasar.TabIndex = 0;
            this.groupBoxCeasar.TabStop = false;
            this.groupBoxCeasar.Text = "一般凯撒加解密";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMode.Location = new System.Drawing.Point(373, 155);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(129, 20);
            this.labelMode.TabIndex = 8;
            this.labelMode.Text = "选择位移数：";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(16, 199);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(684, 278);
            this.textBoxResult.TabIndex = 2;
            // 
            // buttonListAllResult
            // 
            this.buttonListAllResult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonListAllResult.Font = new System.Drawing.Font("幼圆", 11F);
            this.buttonListAllResult.Location = new System.Drawing.Point(158, 151);
            this.buttonListAllResult.Name = "buttonListAllResult";
            this.buttonListAllResult.Size = new System.Drawing.Size(154, 28);
            this.buttonListAllResult.TabIndex = 7;
            this.buttonListAllResult.Text = "列出所有结果";
            this.buttonListAllResult.UseVisualStyleBackColor = true;
            this.buttonListAllResult.Click += new System.EventHandler(this.buttonListAllResult_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDecrypt.Font = new System.Drawing.Font("幼圆", 11F);
            this.buttonDecrypt.Location = new System.Drawing.Point(87, 151);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(65, 28);
            this.buttonDecrypt.TabIndex = 6;
            this.buttonDecrypt.Text = "解密";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(12, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(89, 20);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "凯撒加密";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEncrypt.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEncrypt.Location = new System.Drawing.Point(16, 151);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(65, 28);
            this.buttonEncrypt.TabIndex = 4;
            this.buttonEncrypt.Text = "加密";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // modeComboBox
            // 
            this.modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeComboBox.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Location = new System.Drawing.Point(523, 151);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(177, 28);
            this.modeComboBox.TabIndex = 3;
            // 
            // textBoxchipper
            // 
            this.textBoxchipper.Location = new System.Drawing.Point(16, 102);
            this.textBoxchipper.Multiline = true;
            this.textBoxchipper.Name = "textBoxchipper";
            this.textBoxchipper.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxchipper.Size = new System.Drawing.Size(684, 43);
            this.textBoxchipper.TabIndex = 1;
            // 
            // labelChipper
            // 
            this.labelChipper.AutoSize = true;
            this.labelChipper.Font = new System.Drawing.Font("宋体", 11F);
            this.labelChipper.Location = new System.Drawing.Point(12, 79);
            this.labelChipper.Name = "labelChipper";
            this.labelChipper.Size = new System.Drawing.Size(655, 19);
            this.labelChipper.TabIndex = 0;
            this.labelChipper.Text = "在下面的文本框输入明文或密文，点加密或解密，文本框中即可出现所得结果";
            // 
            // CeasarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 523);
            this.Controls.Add(this.groupBoxCeasar);
            this.MaximizeBox = false;
            this.Name = "CeasarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CeasarForm";
            this.groupBoxCeasar.ResumeLayout(false);
            this.groupBoxCeasar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCeasar;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.TextBox textBoxchipper;
        private System.Windows.Forms.Label labelChipper;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonListAllResult;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}
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
            this.buttonExectute = new System.Windows.Forms.Button();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxchipper = new System.Windows.Forms.TextBox();
            this.labelChipper = new System.Windows.Forms.Label();
            this.groupBoxKeyCeasar = new System.Windows.Forms.GroupBox();
            this.buttonKeyDecrypto = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonKeyEncrypto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCeasar.SuspendLayout();
            this.groupBoxKeyCeasar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCeasar
            // 
            this.groupBoxCeasar.Controls.Add(this.buttonExectute);
            this.groupBoxCeasar.Controls.Add(this.modeComboBox);
            this.groupBoxCeasar.Controls.Add(this.textBoxResult);
            this.groupBoxCeasar.Controls.Add(this.textBoxchipper);
            this.groupBoxCeasar.Controls.Add(this.labelChipper);
            this.groupBoxCeasar.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCeasar.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCeasar.Name = "groupBoxCeasar";
            this.groupBoxCeasar.Size = new System.Drawing.Size(729, 342);
            this.groupBoxCeasar.TabIndex = 0;
            this.groupBoxCeasar.TabStop = false;
            this.groupBoxCeasar.Text = "一般凯撒加解密";
            // 
            // buttonExectute
            // 
            this.buttonExectute.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonExectute.Font = new System.Drawing.Font("宋体", 60F);
            this.buttonExectute.Location = new System.Drawing.Point(524, 109);
            this.buttonExectute.Name = "buttonExectute";
            this.buttonExectute.Size = new System.Drawing.Size(102, 109);
            this.buttonExectute.TabIndex = 4;
            this.buttonExectute.Text = "↓";
            this.buttonExectute.UseVisualStyleBackColor = true;
            this.buttonExectute.Click += new System.EventHandler(this.buttonExectute_Click);
            // 
            // modeComboBox
            // 
            this.modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeComboBox.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Location = new System.Drawing.Point(285, 154);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(177, 28);
            this.modeComboBox.TabIndex = 3;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(81, 224);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(596, 76);
            this.textBoxResult.TabIndex = 2;
            // 
            // textBoxchipper
            // 
            this.textBoxchipper.Location = new System.Drawing.Point(81, 43);
            this.textBoxchipper.Multiline = true;
            this.textBoxchipper.Name = "textBoxchipper";
            this.textBoxchipper.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxchipper.Size = new System.Drawing.Size(596, 49);
            this.textBoxchipper.TabIndex = 1;
            // 
            // labelChipper
            // 
            this.labelChipper.AutoSize = true;
            this.labelChipper.Font = new System.Drawing.Font("宋体", 12F);
            this.labelChipper.Location = new System.Drawing.Point(12, 56);
            this.labelChipper.Name = "labelChipper";
            this.labelChipper.Size = new System.Drawing.Size(69, 20);
            this.labelChipper.TabIndex = 0;
            this.labelChipper.Text = "密文：";
            // 
            // groupBoxKeyCeasar
            // 
            this.groupBoxKeyCeasar.Controls.Add(this.buttonKeyDecrypto);
            this.groupBoxKeyCeasar.Controls.Add(this.textBox4);
            this.groupBoxKeyCeasar.Controls.Add(this.label3);
            this.groupBoxKeyCeasar.Controls.Add(this.buttonKeyEncrypto);
            this.groupBoxKeyCeasar.Controls.Add(this.textBox1);
            this.groupBoxKeyCeasar.Controls.Add(this.textBox2);
            this.groupBoxKeyCeasar.Controls.Add(this.label1);
            this.groupBoxKeyCeasar.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxKeyCeasar.Location = new System.Drawing.Point(0, 342);
            this.groupBoxKeyCeasar.Name = "groupBoxKeyCeasar";
            this.groupBoxKeyCeasar.Size = new System.Drawing.Size(729, 342);
            this.groupBoxKeyCeasar.TabIndex = 1;
            this.groupBoxKeyCeasar.TabStop = false;
            this.groupBoxKeyCeasar.Text = "基于密钥凯撒加解密";
            // 
            // buttonKeyDecrypto
            // 
            this.buttonKeyDecrypto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonKeyDecrypto.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonKeyDecrypto.Location = new System.Drawing.Point(575, 168);
            this.buttonKeyDecrypto.Name = "buttonKeyDecrypto";
            this.buttonKeyDecrypto.Size = new System.Drawing.Size(102, 35);
            this.buttonKeyDecrypto.TabIndex = 7;
            this.buttonKeyDecrypto.Text = "解密";
            this.buttonKeyDecrypto.UseVisualStyleBackColor = true;
            this.buttonKeyDecrypto.Click += new System.EventHandler(this.buttonEnOrDeCrypto_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(87, 136);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(467, 49);
            this.textBox4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "密钥：";
            // 
            // buttonKeyEncrypto
            // 
            this.buttonKeyEncrypto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonKeyEncrypto.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonKeyEncrypto.Location = new System.Drawing.Point(575, 118);
            this.buttonKeyEncrypto.Name = "buttonKeyEncrypto";
            this.buttonKeyEncrypto.Size = new System.Drawing.Size(102, 35);
            this.buttonKeyEncrypto.TabIndex = 4;
            this.buttonKeyEncrypto.Text = "加密";
            this.buttonKeyEncrypto.UseVisualStyleBackColor = true;
            this.buttonKeyEncrypto.Click += new System.EventHandler(this.buttonEnOrDeCrypto_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 224);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(596, 76);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 43);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(596, 49);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "密文：";
            // 
            // CeasarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 715);
            this.Controls.Add(this.groupBoxKeyCeasar);
            this.Controls.Add(this.groupBoxCeasar);
            this.MaximizeBox = false;
            this.Name = "CeasarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CeasarForm";
            this.groupBoxCeasar.ResumeLayout(false);
            this.groupBoxCeasar.PerformLayout();
            this.groupBoxKeyCeasar.ResumeLayout(false);
            this.groupBoxKeyCeasar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCeasar;
        private System.Windows.Forms.Button buttonExectute;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxchipper;
        private System.Windows.Forms.Label labelChipper;
        private System.Windows.Forms.GroupBox groupBoxKeyCeasar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonKeyEncrypto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeyDecrypto;
    }
}
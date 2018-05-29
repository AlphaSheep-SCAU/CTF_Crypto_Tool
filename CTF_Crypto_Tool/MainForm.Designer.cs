namespace CTF_Crypto_Tool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCeasarForm = new System.Windows.Forms.Button();
            this.buttonFenceForm = new System.Windows.Forms.Button();
            this.buttonVigenereForm = new System.Windows.Forms.Button();
            this.buttonMorseForm = new System.Windows.Forms.Button();
            this.buttonMD5Form = new System.Windows.Forms.Button();
            this.buttonBaseForm = new System.Windows.Forms.Button();
            this.buttonBaconForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCeasarForm
            // 
            this.buttonCeasarForm.Location = new System.Drawing.Point(34, 62);
            this.buttonCeasarForm.Name = "buttonCeasarForm";
            this.buttonCeasarForm.Size = new System.Drawing.Size(120, 34);
            this.buttonCeasarForm.TabIndex = 0;
            this.buttonCeasarForm.Text = "凯撒密码";
            this.buttonCeasarForm.UseVisualStyleBackColor = true;
            this.buttonCeasarForm.Click += new System.EventHandler(this.buttonCeasarForm_Click);
            // 
            // buttonFenceForm
            // 
            this.buttonFenceForm.Location = new System.Drawing.Point(160, 62);
            this.buttonFenceForm.Name = "buttonFenceForm";
            this.buttonFenceForm.Size = new System.Drawing.Size(120, 34);
            this.buttonFenceForm.TabIndex = 1;
            this.buttonFenceForm.Text = "栅栏密码";
            this.buttonFenceForm.UseVisualStyleBackColor = true;
            this.buttonFenceForm.Click += new System.EventHandler(this.buttonFenceForm_Click);
            // 
            // buttonVigenereForm
            // 
            this.buttonVigenereForm.Location = new System.Drawing.Point(286, 62);
            this.buttonVigenereForm.Name = "buttonVigenereForm";
            this.buttonVigenereForm.Size = new System.Drawing.Size(120, 34);
            this.buttonVigenereForm.TabIndex = 2;
            this.buttonVigenereForm.Text = "维吉利亚密码";
            this.buttonVigenereForm.UseVisualStyleBackColor = true;
            this.buttonVigenereForm.Click += new System.EventHandler(this.buttonVigenereForm_Click);
            // 
            // buttonMorseForm
            // 
            this.buttonMorseForm.Location = new System.Drawing.Point(412, 62);
            this.buttonMorseForm.Name = "buttonMorseForm";
            this.buttonMorseForm.Size = new System.Drawing.Size(120, 34);
            this.buttonMorseForm.TabIndex = 3;
            this.buttonMorseForm.Text = "摩斯密码";
            this.buttonMorseForm.UseVisualStyleBackColor = true;
            this.buttonMorseForm.Click += new System.EventHandler(this.buttonMorseForm_Click);
            // 
            // buttonMD5Form
            // 
            this.buttonMD5Form.Location = new System.Drawing.Point(34, 102);
            this.buttonMD5Form.Name = "buttonMD5Form";
            this.buttonMD5Form.Size = new System.Drawing.Size(120, 34);
            this.buttonMD5Form.TabIndex = 4;
            this.buttonMD5Form.Text = "MD5加密";
            this.buttonMD5Form.UseVisualStyleBackColor = true;
            this.buttonMD5Form.Click += new System.EventHandler(this.buttonMD5_Click);
            // 
            // buttonBaseForm
            // 
            this.buttonBaseForm.Location = new System.Drawing.Point(160, 102);
            this.buttonBaseForm.Name = "buttonBaseForm";
            this.buttonBaseForm.Size = new System.Drawing.Size(120, 34);
            this.buttonBaseForm.TabIndex = 5;
            this.buttonBaseForm.Text = "Base加密";
            this.buttonBaseForm.UseVisualStyleBackColor = true;
            this.buttonBaseForm.Click += new System.EventHandler(this.buttonBase_Click);
            // 
            // buttonBaconForm
            // 
            this.buttonBaconForm.Location = new System.Drawing.Point(286, 102);
            this.buttonBaconForm.Name = "buttonBaconForm";
            this.buttonBaconForm.Size = new System.Drawing.Size(120, 34);
            this.buttonBaconForm.TabIndex = 6;
            this.buttonBaconForm.Text = "培根加密";
            this.buttonBaconForm.UseVisualStyleBackColor = true;
            this.buttonBaconForm.Click += new System.EventHandler(this.buttonBaconForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 554);
            this.Controls.Add(this.buttonBaconForm);
            this.Controls.Add(this.buttonBaseForm);
            this.Controls.Add(this.buttonMD5Form);
            this.Controls.Add(this.buttonMorseForm);
            this.Controls.Add(this.buttonVigenereForm);
            this.Controls.Add(this.buttonFenceForm);
            this.Controls.Add(this.buttonCeasarForm);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCeasarForm;
        private System.Windows.Forms.Button buttonFenceForm;
        private System.Windows.Forms.Button buttonVigenereForm;
        private System.Windows.Forms.Button buttonMorseForm;
        private System.Windows.Forms.Button buttonMD5Form;
        private System.Windows.Forms.Button buttonBaseForm;
        private System.Windows.Forms.Button buttonBaconForm;
    }
}


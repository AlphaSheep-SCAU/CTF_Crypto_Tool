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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 554);
            this.Controls.Add(this.buttonFenceForm);
            this.Controls.Add(this.buttonCeasarForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCeasarForm;
        private System.Windows.Forms.Button buttonFenceForm;
    }
}


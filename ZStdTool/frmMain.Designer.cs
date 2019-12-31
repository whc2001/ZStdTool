namespace ZStdTool
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.optCompress = new System.Windows.Forms.RadioButton();
            this.optDecompress = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drag file inside this window to operate...";
            // 
            // optCompress
            // 
            this.optCompress.AutoSize = true;
            this.optCompress.Location = new System.Drawing.Point(28, 35);
            this.optCompress.Name = "optCompress";
            this.optCompress.Size = new System.Drawing.Size(71, 16);
            this.optCompress.TabIndex = 1;
            this.optCompress.Text = "Compress";
            this.optCompress.UseVisualStyleBackColor = true;
            // 
            // optDecompress
            // 
            this.optDecompress.AutoSize = true;
            this.optDecompress.Checked = true;
            this.optDecompress.Location = new System.Drawing.Point(148, 35);
            this.optDecompress.Name = "optDecompress";
            this.optDecompress.Size = new System.Drawing.Size(83, 16);
            this.optDecompress.TabIndex = 2;
            this.optDecompress.TabStop = true;
            this.optDecompress.Text = "Decompress";
            this.optDecompress.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 68);
            this.Controls.Add(this.optDecompress);
            this.Controls.Add(this.optCompress);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "ZstdTool";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optCompress;
        private System.Windows.Forms.RadioButton optDecompress;
    }
}


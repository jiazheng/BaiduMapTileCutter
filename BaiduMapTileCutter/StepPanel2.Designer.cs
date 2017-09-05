namespace BaiduMapTileCutter
{
    partial class StepPanel2
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbx2 = new System.Windows.Forms.GroupBox();
            this.btnChooseOutputPath = new System.Windows.Forms.Button();
            this.tbxOutputPath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gbx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx2
            // 
            this.gbx2.Controls.Add(this.btnChooseOutputPath);
            this.gbx2.Controls.Add(this.tbxOutputPath);
            this.gbx2.Controls.Add(this.label12);
            this.gbx2.Controls.Add(this.label11);
            this.gbx2.Location = new System.Drawing.Point(3, 3);
            this.gbx2.Name = "gbx2";
            this.gbx2.Size = new System.Drawing.Size(519, 390);
            this.gbx2.TabIndex = 7;
            this.gbx2.TabStop = false;
            // 
            // btnChooseOutputPath
            // 
            this.btnChooseOutputPath.Location = new System.Drawing.Point(432, 106);
            this.btnChooseOutputPath.Name = "btnChooseOutputPath";
            this.btnChooseOutputPath.Size = new System.Drawing.Size(75, 21);
            this.btnChooseOutputPath.TabIndex = 3;
            this.btnChooseOutputPath.Text = "选择...";
            this.btnChooseOutputPath.UseVisualStyleBackColor = true;
            this.btnChooseOutputPath.Click += new System.EventHandler(this.btnChooseOutputPath_Click);
            // 
            // tbxOutputPath
            // 
            this.tbxOutputPath.Location = new System.Drawing.Point(15, 106);
            this.tbxOutputPath.Name = "tbxOutputPath";
            this.tbxOutputPath.Size = new System.Drawing.Size(411, 21);
            this.tbxOutputPath.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "设置输出目录";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.Location = new System.Drawing.Point(10, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "输出路径";
            // 
            // StepPanel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbx2);
            this.Name = "StepPanel2";
            this.Size = new System.Drawing.Size(530, 400);
            this.gbx2.ResumeLayout(false);
            this.gbx2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx2;
        private System.Windows.Forms.Button btnChooseOutputPath;
        private System.Windows.Forms.TextBox tbxOutputPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

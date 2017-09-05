namespace BaiduMapTileCutter
{
    partial class StepPanel1
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
            this.gbx1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pbxImageToCut = new System.Windows.Forms.PictureBox();
            this.txtImageFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.gbx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageToCut)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx1
            // 
            this.gbx1.Controls.Add(this.label10);
            this.gbx1.Controls.Add(this.pbxImageToCut);
            this.gbx1.Controls.Add(this.txtImageFilePath);
            this.gbx1.Controls.Add(this.btnBrowseImage);
            this.gbx1.Controls.Add(this.label9);
            this.gbx1.Controls.Add(this.label8);
            this.gbx1.Location = new System.Drawing.Point(3, 3);
            this.gbx1.Name = "gbx1";
            this.gbx1.Size = new System.Drawing.Size(519, 390);
            this.gbx1.TabIndex = 8;
            this.gbx1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "图片预览";
            // 
            // pbxImageToCut
            // 
            this.pbxImageToCut.Location = new System.Drawing.Point(12, 179);
            this.pbxImageToCut.Name = "pbxImageToCut";
            this.pbxImageToCut.Size = new System.Drawing.Size(256, 197);
            this.pbxImageToCut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImageToCut.TabIndex = 4;
            this.pbxImageToCut.TabStop = false;
            // 
            // txtImageFilePath
            // 
            this.txtImageFilePath.Location = new System.Drawing.Point(15, 106);
            this.txtImageFilePath.Name = "txtImageFilePath";
            this.txtImageFilePath.Size = new System.Drawing.Size(411, 21);
            this.txtImageFilePath.TabIndex = 3;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(432, 106);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(75, 21);
            this.btnBrowseImage.TabIndex = 2;
            this.btnBrowseImage.Text = "浏览...";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "选择所切图片的路径";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(10, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "选择图片";
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            this.ofdImage.Filter = "图像文件|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            this.ofdImage.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdImage_FileOk);
            // 
            // StepPanel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbx1);
            this.Name = "StepPanel1";
            this.Size = new System.Drawing.Size(530, 400);
            this.gbx1.ResumeLayout(false);
            this.gbx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageToCut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbxImageToCut;
        private System.Windows.Forms.TextBox txtImageFilePath;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog ofdImage;
    }
}

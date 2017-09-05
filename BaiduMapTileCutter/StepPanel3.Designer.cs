namespace BaiduMapTileCutter
{
    partial class StepPanel3
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
            this.gbx3 = new System.Windows.Forms.GroupBox();
            this.rdbOutputTileOnly = new System.Windows.Forms.RadioButton();
            this.rdbOutputAll = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx3
            // 
            this.gbx3.Controls.Add(this.rdbOutputTileOnly);
            this.gbx3.Controls.Add(this.rdbOutputAll);
            this.gbx3.Controls.Add(this.label14);
            this.gbx3.Controls.Add(this.label13);
            this.gbx3.Location = new System.Drawing.Point(3, 3);
            this.gbx3.Name = "gbx3";
            this.gbx3.Size = new System.Drawing.Size(519, 390);
            this.gbx3.TabIndex = 5;
            this.gbx3.TabStop = false;
            // 
            // rdbOutputTileOnly
            // 
            this.rdbOutputTileOnly.AutoSize = true;
            this.rdbOutputTileOnly.Location = new System.Drawing.Point(17, 127);
            this.rdbOutputTileOnly.Name = "rdbOutputTileOnly";
            this.rdbOutputTileOnly.Size = new System.Drawing.Size(59, 16);
            this.rdbOutputTileOnly.TabIndex = 3;
            this.rdbOutputTileOnly.Text = "仅图块";
            this.rdbOutputTileOnly.UseVisualStyleBackColor = true;
            // 
            // rdbOutputAll
            // 
            this.rdbOutputAll.AutoSize = true;
            this.rdbOutputAll.Checked = true;
            this.rdbOutputAll.Location = new System.Drawing.Point(17, 104);
            this.rdbOutputAll.Name = "rdbOutputAll";
            this.rdbOutputAll.Size = new System.Drawing.Size(95, 16);
            this.rdbOutputAll.TabIndex = 2;
            this.rdbOutputAll.TabStop = true;
            this.rdbOutputAll.Text = "图块以及代码";
            this.rdbOutputAll.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "设置输出类型";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F);
            this.label13.Location = new System.Drawing.Point(12, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "输出类型";
            // 
            // StepPanel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbx3);
            this.Name = "StepPanel3";
            this.Size = new System.Drawing.Size(530, 400);
            this.gbx3.ResumeLayout(false);
            this.gbx3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx3;
        private System.Windows.Forms.RadioButton rdbOutputTileOnly;
        private System.Windows.Forms.RadioButton rdbOutputAll;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

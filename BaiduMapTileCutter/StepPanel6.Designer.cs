namespace BaiduMapTileCutter
{
    partial class StepPanel6
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
            this.gbx6 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbxMapTypeName = new System.Windows.Forms.TextBox();
            this.rdbLayer = new System.Windows.Forms.RadioButton();
            this.rdbMapType = new System.Windows.Forms.RadioButton();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.gbx6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx6
            // 
            this.gbx6.Controls.Add(this.label27);
            this.gbx6.Controls.Add(this.tbxMapTypeName);
            this.gbx6.Controls.Add(this.rdbLayer);
            this.gbx6.Controls.Add(this.rdbMapType);
            this.gbx6.Controls.Add(this.label26);
            this.gbx6.Controls.Add(this.label25);
            this.gbx6.Location = new System.Drawing.Point(3, 3);
            this.gbx6.Name = "gbx6";
            this.gbx6.Size = new System.Drawing.Size(519, 390);
            this.gbx6.TabIndex = 11;
            this.gbx6.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(288, 110);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(137, 12);
            this.label27.TabIndex = 5;
            this.label27.Text = "如果不生成代码可不设置";
            // 
            // tbxMapTypeName
            // 
            this.tbxMapTypeName.Location = new System.Drawing.Point(191, 106);
            this.tbxMapTypeName.Name = "tbxMapTypeName";
            this.tbxMapTypeName.Size = new System.Drawing.Size(91, 21);
            this.tbxMapTypeName.TabIndex = 4;
            this.tbxMapTypeName.Text = "MyMap";
            // 
            // rdbLayer
            // 
            this.rdbLayer.AutoSize = true;
            this.rdbLayer.Location = new System.Drawing.Point(12, 130);
            this.rdbLayer.Name = "rdbLayer";
            this.rdbLayer.Size = new System.Drawing.Size(71, 16);
            this.rdbLayer.TabIndex = 3;
            this.rdbLayer.Text = "做为图层";
            this.rdbLayer.UseVisualStyleBackColor = true;
            // 
            // rdbMapType
            // 
            this.rdbMapType.AutoSize = true;
            this.rdbMapType.Checked = true;
            this.rdbMapType.Location = new System.Drawing.Point(12, 108);
            this.rdbMapType.Name = "rdbMapType";
            this.rdbMapType.Size = new System.Drawing.Size(179, 16);
            this.rdbMapType.TabIndex = 2;
            this.rdbMapType.TabStop = true;
            this.rdbMapType.Text = "做为地图类型，地图类型名称";
            this.rdbMapType.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(10, 70);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 12);
            this.label26.TabIndex = 1;
            this.label26.Text = "设置图层信息";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("宋体", 11F);
            this.label25.Location = new System.Drawing.Point(3, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 15);
            this.label25.TabIndex = 0;
            this.label25.Text = "图层设置";
            // 
            // StepPanel6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbx6);
            this.Name = "StepPanel6";
            this.Size = new System.Drawing.Size(530, 400);
            this.gbx6.ResumeLayout(false);
            this.gbx6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx6;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbxMapTypeName;
        private System.Windows.Forms.RadioButton rdbLayer;
        private System.Windows.Forms.RadioButton rdbMapType;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
    }
}

namespace BaiduMapTileCutter
{
    partial class StepPanel5
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
            this.gbx5 = new System.Windows.Forms.GroupBox();
            this.cbxImageOriginZoom = new System.Windows.Forms.ComboBox();
            this.cbxMaxZoom = new System.Windows.Forms.ComboBox();
            this.cbxMinZoom = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.rdbCustom = new System.Windows.Forms.RadioButton();
            this.rdbAuto = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.gbx5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx5
            // 
            this.gbx5.Controls.Add(this.cbxImageOriginZoom);
            this.gbx5.Controls.Add(this.cbxMaxZoom);
            this.gbx5.Controls.Add(this.cbxMinZoom);
            this.gbx5.Controls.Add(this.label24);
            this.gbx5.Controls.Add(this.label23);
            this.gbx5.Controls.Add(this.label22);
            this.gbx5.Controls.Add(this.rdbCustom);
            this.gbx5.Controls.Add(this.rdbAuto);
            this.gbx5.Controls.Add(this.label21);
            this.gbx5.Controls.Add(this.label20);
            this.gbx5.Location = new System.Drawing.Point(3, 3);
            this.gbx5.Name = "gbx5";
            this.gbx5.Size = new System.Drawing.Size(519, 390);
            this.gbx5.TabIndex = 9;
            this.gbx5.TabStop = false;
            // 
            // cbxImageOriginZoom
            // 
            this.cbxImageOriginZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxImageOriginZoom.Enabled = false;
            this.cbxImageOriginZoom.FormattingEnabled = true;
            this.cbxImageOriginZoom.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.cbxImageOriginZoom.Location = new System.Drawing.Point(182, 181);
            this.cbxImageOriginZoom.Name = "cbxImageOriginZoom";
            this.cbxImageOriginZoom.Size = new System.Drawing.Size(86, 20);
            this.cbxImageOriginZoom.TabIndex = 9;
            this.cbxImageOriginZoom.SelectedIndexChanged += new System.EventHandler(this.cbxImageOriginZoom_SelectedIndexChanged);
            // 
            // cbxMaxZoom
            // 
            this.cbxMaxZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaxZoom.Enabled = false;
            this.cbxMaxZoom.FormattingEnabled = true;
            this.cbxMaxZoom.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.cbxMaxZoom.Location = new System.Drawing.Point(182, 155);
            this.cbxMaxZoom.Name = "cbxMaxZoom";
            this.cbxMaxZoom.Size = new System.Drawing.Size(86, 20);
            this.cbxMaxZoom.TabIndex = 8;
            this.cbxMaxZoom.SelectedIndexChanged += new System.EventHandler(this.cbxMaxZoom_SelectedIndexChanged);
            // 
            // cbxMinZoom
            // 
            this.cbxMinZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinZoom.Enabled = false;
            this.cbxMinZoom.FormattingEnabled = true;
            this.cbxMinZoom.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.cbxMinZoom.Location = new System.Drawing.Point(182, 129);
            this.cbxMinZoom.Name = "cbxMinZoom";
            this.cbxMinZoom.Size = new System.Drawing.Size(86, 20);
            this.cbxMinZoom.TabIndex = 7;
            this.cbxMinZoom.SelectedIndexChanged += new System.EventHandler(this.cbxMinZoom_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(99, 184);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 12);
            this.label24.TabIndex = 6;
            this.label24.Text = "原图所在级别";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(123, 158);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 5;
            this.label23.Text = "最大级别";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(123, 132);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 4;
            this.label22.Text = "最小级别";
            // 
            // rdbCustom
            // 
            this.rdbCustom.AutoSize = true;
            this.rdbCustom.Location = new System.Drawing.Point(12, 128);
            this.rdbCustom.Name = "rdbCustom";
            this.rdbCustom.Size = new System.Drawing.Size(59, 16);
            this.rdbCustom.TabIndex = 3;
            this.rdbCustom.Text = "自定义";
            this.rdbCustom.UseVisualStyleBackColor = true;
            this.rdbCustom.CheckedChanged += new System.EventHandler(this.rdbCustom_CheckedChanged);
            // 
            // rdbAuto
            // 
            this.rdbAuto.AutoSize = true;
            this.rdbAuto.Checked = true;
            this.rdbAuto.Location = new System.Drawing.Point(12, 106);
            this.rdbAuto.Name = "rdbAuto";
            this.rdbAuto.Size = new System.Drawing.Size(71, 16);
            this.rdbAuto.TabIndex = 2;
            this.rdbAuto.TabStop = true;
            this.rdbAuto.Text = "自动控制";
            this.rdbAuto.UseVisualStyleBackColor = true;
            this.rdbAuto.CheckedChanged += new System.EventHandler(this.rdbAuto_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 12);
            this.label21.TabIndex = 1;
            this.label21.Text = "设置级别范围";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 11F);
            this.label20.Location = new System.Drawing.Point(3, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "级别设置";
            // 
            // StepPanel5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbx5);
            this.Name = "StepPanel5";
            this.Size = new System.Drawing.Size(530, 400);
            this.gbx5.ResumeLayout(false);
            this.gbx5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx5;
        private System.Windows.Forms.ComboBox cbxImageOriginZoom;
        private System.Windows.Forms.ComboBox cbxMaxZoom;
        private System.Windows.Forms.ComboBox cbxMinZoom;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RadioButton rdbCustom;
        private System.Windows.Forms.RadioButton rdbAuto;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
    }
}

namespace BaiduMapTileCutter
{
    partial class StepPanel4
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
            this.gbx4 = new System.Windows.Forms.GroupBox();
            this.webviewMap = new System.Windows.Forms.WebBrowser();
            this.label19 = new System.Windows.Forms.Label();
            this.tbxLat = new System.Windows.Forms.TextBox();
            this.tbxLng = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gbx4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx4
            // 
            this.gbx4.Controls.Add(this.webviewMap);
            this.gbx4.Controls.Add(this.label19);
            this.gbx4.Controls.Add(this.tbxLat);
            this.gbx4.Controls.Add(this.tbxLng);
            this.gbx4.Controls.Add(this.label18);
            this.gbx4.Controls.Add(this.label17);
            this.gbx4.Controls.Add(this.label16);
            this.gbx4.Controls.Add(this.label15);
            this.gbx4.Location = new System.Drawing.Point(3, 3);
            this.gbx4.Name = "gbx4";
            this.gbx4.Size = new System.Drawing.Size(519, 390);
            this.gbx4.TabIndex = 11;
            this.gbx4.TabStop = false;
            // 
            // webviewMap
            // 
            this.webviewMap.IsWebBrowserContextMenuEnabled = false;
            this.webviewMap.Location = new System.Drawing.Point(15, 140);
            this.webviewMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webviewMap.Name = "webviewMap";
            this.webviewMap.ScrollBarsEnabled = false;
            this.webviewMap.Size = new System.Drawing.Size(492, 236);
            this.webviewMap.TabIndex = 7;
            this.webviewMap.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(302, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(161, 12);
            this.label19.TabIndex = 6;
            this.label19.Text = "在地图中通过右键可选择坐标";
            // 
            // tbxLat
            // 
            this.tbxLat.Location = new System.Drawing.Point(197, 103);
            this.tbxLat.Name = "tbxLat";
            this.tbxLat.Size = new System.Drawing.Size(94, 21);
            this.tbxLat.TabIndex = 5;
            this.tbxLat.Text = "0";
            // 
            // tbxLng
            // 
            this.tbxLng.Location = new System.Drawing.Point(52, 103);
            this.tbxLng.Name = "tbxLng";
            this.tbxLng.Size = new System.Drawing.Size(94, 21);
            this.tbxLng.TabIndex = 4;
            this.tbxLng.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(162, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 3;
            this.label18.Text = "纬度";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "经度";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(341, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "设置图片的中心位置坐标（经度：-180到180，纬度：-90到90）";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 11F);
            this.label15.Location = new System.Drawing.Point(9, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "坐标设置";
            // 
            // StepPanel4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbx4);
            this.Name = "StepPanel4";
            this.Size = new System.Drawing.Size(530, 400);
            this.gbx4.ResumeLayout(false);
            this.gbx4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx4;
        private System.Windows.Forms.WebBrowser webviewMap;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbxLat;
        private System.Windows.Forms.TextBox tbxLng;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}

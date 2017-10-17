using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BaiduMapTileCutter
{
    // A delegate type for hooking up change notifications.
    public delegate void CutStartEventHandler(object sender, EventArgs e);
    public delegate void CutEndEventHandler(object sender, EventArgs e);

    public partial class StepPanel7 : UserControl
    {
        private string imgPath;
        private string outputPath;
        private OutputFileTypes outputFileType;
        private LatLng center;
        private ZoomInfo zoomInfo;
        private OutputLayerTypes outputLayerType;
        private string mapTypeName;

        private TileCutter cutter = new TileCutter();

        public event CutStartEventHandler CutStart;
        public event CutEndEventHandler CutEnd;

        protected virtual void OnCutStart(EventArgs e)
        {
            if (CutStart != null)
            {
                CutStart(this, e);
            }
        }

        protected virtual void OnCutEnd(EventArgs e)
        {
            if (CutEnd != null)
            {
                CutEnd(this, e);
            }
        }

        public StepPanel7()
        {
            InitializeComponent();
        }

        public void SetInfo(string imgPath, string outputPath, OutputFileTypes outputFileType, LatLng center,
            ZoomInfo zoomInfo, OutputLayerTypes outputLayerType, string mapTypeName)
        {
            this.imgPath = imgPath;
            this.outputPath = outputPath;
            this.outputFileType = outputFileType;
            this.center = center;
            this.zoomInfo = zoomInfo;
            this.outputLayerType = outputLayerType;
            this.mapTypeName = mapTypeName;
            
            tbxImagePath.Text = imgPath;
            tbxOutputPath.Text = outputPath;
            if (outputFileType == OutputFileTypes.TileAndCode)
            {
                lblOutputType.Text = "图块和代码";
            }
            else if (outputFileType == OutputFileTypes.TileOnly)
            {
                lblOutputType.Text = "仅图块";
            }
            lblCenter.Text = center.Lat + ", " + center.Lng;
            lblLevelInfoConfirm.Text = "最小级别：" + zoomInfo.MinZoom.ToString()
                + "，最大级别：" + zoomInfo.MaxZoom.ToString()
                + "，原图级别：" + zoomInfo.ImageZoom.ToString();
            if (outputLayerType == OutputLayerTypes.MapType)
            {
                lblLayerConfigConfirm.Text = "独立地图类型";
            }
            else if (outputLayerType == OutputLayerTypes.NormalLayer)
            {
                lblLayerConfigConfirm.Text = "叠加图层";
            }
        }

        /// <summary>
        /// 开始切图
        /// </summary>
        public void StartCut()
        {
            lblCutHint.Text = "正在切图";
            progressTimer.Start();
            cutter.SetInfo(imgPath, outputPath, outputFileType, center, zoomInfo, outputLayerType, mapTypeName);
            Thread task = new Thread(new ThreadStart(cutter.StartCut));
            task.Start();
            OnCutStart(EventArgs.Empty);
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if (cutter.GetTotalCount() == 0)
            {
                return;
            }
            progressBar.Value = (int)Math.Round((double)cutter.GetFinishCount() * 100 / (double)cutter.GetTotalCount());
            // Console.WriteLine(cutter.GetFinishCount() + ", " + cutter.GetTotalCount());
            if (cutter.GetFinishCount() == cutter.GetTotalCount())
            {
                progressTimer.Stop();
                progressBar.Value = 0;
                lblCutHint.Text = "准备就绪";
                MessageBox.Show("切图完成", "提示", MessageBoxButtons.OK);
                OnCutEnd(EventArgs.Empty);
            }
        }
    }
}

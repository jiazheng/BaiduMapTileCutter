using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiduMapTileCutter
{
    public partial class StepPanel5 : UserControl
    {
        private string imgPath = "";
        private ZoomInfo zoomInfo = new ZoomInfo();

        public StepPanel5()
        {
            InitializeComponent();
        }

        public void SetImagePath(string imgPath)
        {
            this.imgPath = imgPath;
        }

        public void CalcZoomInfo()
        {
            if (rdbAuto.Checked == true)
            {
                CalcImageZoom();
            }
            else
            {
                zoomInfo.MinZoom = Int32.Parse((string)cbxMinZoom.SelectedItem);
                zoomInfo.MaxZoom = Int32.Parse((string)cbxMaxZoom.SelectedItem);
                zoomInfo.ImageZoom = Int32.Parse((string)cbxImageOriginZoom.SelectedItem);
            }
        }

        public ZoomInfo GetZoomInfo()
        {
            return zoomInfo;
        }

        public bool CheckZoomValidation()
        {
            CalcZoomInfo();
            if (zoomInfo.MinZoom == 0 || zoomInfo.MaxZoom == 0 || zoomInfo.ImageZoom == 0)
            {
                return false;
            }
            if (zoomInfo.MaxZoom < zoomInfo.MinZoom)
            {
                return false;
            }
            if (zoomInfo.ImageZoom > zoomInfo.MaxZoom)
            {
                return false;
            }
            if (zoomInfo.ImageZoom < zoomInfo.MinZoom)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 根据图片宽度和高度自动计算适合的级别
        /// </summary>
        private void CalcImageZoom()
        {
            if (imgPath == "")
            {
                return;
            }
            Bitmap bitmap = new Bitmap(imgPath);
            int imgHeight = bitmap.Height;
            int imgWidth = bitmap.Width;
            Console.WriteLine(imgHeight + ", " + imgWidth);
            int imgZoom = 3;
            while (imgHeight > 256 && imgWidth > 256)
            {
                imgHeight /= 2;
                imgWidth /= 2;
                imgZoom++;
            }
            zoomInfo.ImageZoom = imgZoom;
            zoomInfo.MaxZoom = imgZoom;
            zoomInfo.MinZoom = 3;
            Console.WriteLine(zoomInfo.MinZoom + ", " + zoomInfo.MaxZoom + ", " + zoomInfo.ImageZoom);
        }

        private void rdbCustom_CheckedChanged(object sender, EventArgs e)
        {
            updateUI();
        }

        private void rdbAuto_CheckedChanged(object sender, EventArgs e)
        {
            updateUI();
        }

        private void updateUI()
        {
            bool zoomTbxEnable = true;
            if (rdbAuto.Checked == true)
            {
                zoomTbxEnable = false;
            }
            else if ( rdbCustom.Checked == true)
            {
                zoomTbxEnable = true;
            }
            cbxImageOriginZoom.Enabled = zoomTbxEnable;
            cbxMaxZoom.Enabled = zoomTbxEnable;
            cbxMinZoom.Enabled = zoomTbxEnable;
        }

        private void cbxMinZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMinZoom.SelectedItem == null)
            {
                return;
            }
            zoomInfo.MinZoom = Int32.Parse((string)cbxMinZoom.SelectedItem);
        }

        private void cbxMaxZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaxZoom.SelectedItem == null)
            {
                return;
            }
            zoomInfo.MaxZoom = Int32.Parse((string)cbxMaxZoom.SelectedItem);
        }

        private void cbxImageOriginZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxImageOriginZoom.SelectedItem == null)
            {
                return;
            }
            zoomInfo.ImageZoom = Int32.Parse((string)cbxImageOriginZoom.SelectedItem);
        }
    }
}

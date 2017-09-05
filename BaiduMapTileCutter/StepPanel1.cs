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
    public partial class StepPanel1 : UserControl
    {
        private string imageFilePath = "";
        public StepPanel1()
        {
            InitializeComponent();
        }

        public string GetImageFilePath() => imageFilePath;

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            ofdImage.ShowDialog();
        }

        private void ofdImage_FileOk(object sender, CancelEventArgs e)
        {
            txtImageFilePath.Text = ofdImage.FileName;
            pbxImageToCut.ImageLocation = ofdImage.FileName;
            imageFilePath = ofdImage.FileName;
        }
    }
}

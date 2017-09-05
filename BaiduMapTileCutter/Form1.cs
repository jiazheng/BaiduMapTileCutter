using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiduMapTileCutter
{
    // 输出文件类型的枚举
    public enum OutputFileTypes : byte
    {
        TileAndCode,
        TileOnly
    }

    // 独立地图类型还是叠加图层
    public enum OutputLayerTypes : byte
    {
        MapType,
        NormalLayer
    }

    // 级别信息结构体
    public struct ZoomInfo
    {
        public int MinZoom;
        public int MaxZoom;
        public int ImageZoom;
    }

    public partial class mainForm : Form
    {
   
        // 当前执行的步骤
        private short currentStep = 0;
        private string imageFilePath = "";
        private string outputPath = "";
        private OutputFileTypes outputFileType = OutputFileTypes.TileAndCode;
        private LatLng center = new LatLng();
        private ZoomInfo zoomInfo;
        private OutputLayerTypes outputLayerType = OutputLayerTypes.MapType;
        private string mapTypeName = "MyMap";
        private UserControl[] stepPanels = new UserControl[7];

        private StepPanel1 stepPanel1 = new StepPanel1();
        private StepPanel2 stepPanel2 = new StepPanel2();
        private StepPanel3 stepPanel3 = new StepPanel3();
        private StepPanel4 stepPanel4 = new StepPanel4();
        private StepPanel5 stepPanel5 = new StepPanel5();
        private StepPanel6 stepPanel6 = new StepPanel6();
        private StepPanel7 stepPanel7 = new StepPanel7();

        public mainForm()
        {
            InitializeComponent();
        }

        private void updateUI()
        {
            if (currentStep == 0)
            {
                btnPrev.Enabled = false;
            }
            else if (currentStep == 1)
            {
                btnPrev.Enabled = true;
            }
            if (currentStep == 3)
            {
                stepPanel4.LoadPage();
            }
            if (currentStep == 6)
            {
                btnNext.Text = "开始切图";
                stepPanel7.SetInfo(imageFilePath, outputPath, outputFileType, center, zoomInfo, outputLayerType, mapTypeName);
            }
            else
            {
                btnNext.Text = "下一步";
            }
            for (int i = 0; i < stepPanels.Length; i++)
            {
                if (i == currentStep)
                {
                    stepPanels[i].Visible = true;
                }
                else
                {
                    stepPanels[i].Visible = false;
                }
            }
        }

        private void OnCutStart(object sender, EventArgs e)
        {
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
        }

        private void OnCutEnd(object sender, EventArgs e)
        {
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            stepPanels[0] = stepPanel1;
            stepPanels[1] = stepPanel2;
            stepPanels[2] = stepPanel3;
            stepPanels[3] = stepPanel4;
            stepPanels[4] = stepPanel5;
            stepPanels[5] = stepPanel6;
            stepPanels[6] = stepPanel7;

            stepPanel7.CutStart += new CutStartEventHandler(OnCutStart);
            stepPanel7.CutEnd += new CutEndEventHandler(OnCutEnd);

            for (int i = 0; i < stepPanels.Length; i++)
            {
                this.Controls.Add(stepPanels[i]);
                stepPanels[i].Location = new System.Drawing.Point(120, 3);
            }
            updateUI();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (currentStep)
            {
                case 0:
                    // 检查图片路径是否有效
                    if (stepPanel1.GetImageFilePath() == "")
                    {
                        showErrorInfo("请选择图片");
                        return;
                    }
                    imageFilePath = stepPanel1.GetImageFilePath();
                    break;
                case 1:
                    if (stepPanel2.getOutputPath() == "")
                    {
                        showErrorInfo("请设置输出路径");
                        return;
                    }
                    outputPath = stepPanel2.getOutputPath();
                    break;
                case 2:
                    outputFileType = stepPanel3.getOutputFileType();
                    break;
                case 3:
                    center = stepPanel4.getCenter();
                    break;
                case 4:
                    stepPanel5.SetImagePath(imageFilePath);
                    if (stepPanel5.CheckZoomValidation() == false)
                    {
                        showErrorInfo("级别设置不正确，请检查");
                        return;
                    }
                    zoomInfo = stepPanel5.GetZoomInfo();
                    break;
                case 5:
                    outputLayerType = stepPanel6.GetOutputLayerType();
                    mapTypeName = stepPanel6.GetMapTypeName();
                    if (outputLayerType == OutputLayerTypes.MapType && mapTypeName == "")
                    {
                        showErrorInfo("请填写地图类型名称");
                        return;
                    }
                    break;
                case 6:
                    stepPanel7.StartCut();
                    break;
            }
            if (currentStep < 6)
            {
                currentStep++;
            }
            updateUI();
        }

        private void showErrorInfo(string errorInfo)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            MessageBox.Show(errorInfo, "错误", button, icon);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentStep > 0)
            {
                currentStep--;
            }
            updateUI();
        }
    }
}

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
    public partial class StepPanel2 : UserControl
    {
        private string outputPath = "";
        public StepPanel2()
        {
            InitializeComponent();
        }

        private void btnChooseOutputPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbxOutputPath.Text = folderBrowserDialog.SelectedPath;
                outputPath = folderBrowserDialog.SelectedPath;
            }
        }

        public string getOutputPath() => outputPath;
    }
}

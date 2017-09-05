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
    public partial class StepPanel3 : UserControl
    {
        public StepPanel3()
        {
            InitializeComponent();
        }

        public OutputFileTypes getOutputFileType()
        {
            if (rdbOutputAll.Checked == true)
            {
                return OutputFileTypes.TileAndCode;
            }
            else if (rdbOutputTileOnly.Checked == true)
            {
                return OutputFileTypes.TileOnly;
            }
            return OutputFileTypes.TileAndCode;
        }
    }
}

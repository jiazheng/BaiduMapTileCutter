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
    public partial class StepPanel6 : UserControl
    {
        public StepPanel6()
        {
            InitializeComponent();
        }

        public OutputLayerTypes GetOutputLayerType()
        {
            if (rdbMapType.Checked == true)
            {
                return OutputLayerTypes.MapType;
            }
            if (rdbLayer.Checked)
            {
                return OutputLayerTypes.NormalLayer;
            }
            return OutputLayerTypes.MapType;
        }

        public string GetMapTypeName()
        {
            return tbxMapTypeName.Text;
        }
    }
}

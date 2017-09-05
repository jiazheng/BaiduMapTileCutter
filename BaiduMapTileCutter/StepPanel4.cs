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
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class StepPanel4 : UserControl
    {
        public StepPanel4()
        {
            InitializeComponent();
        }

        public void LoadPage()
        {
            string htmlString = "<!DOCTYPE html>"
                + "<html>"
                + "<head>"
                + "<meta charset=\"utf-8\">"
                + "<title>Get Point</title>"
                + "<script type=\"text/javascript\" src=\"http://api.map.baidu.com/api?v=1.2\"></script>"
                + "<style>"
                + "html, body {margin: 0;padding: 0;}"
                + "</style>"
                + "</head>"
                + "<body>"
                + "<div id=\"map\" style=\"width:492px;height:236px;background:#000;\"></div>"
                + "<script type=\"text/javascript\">"
                + "var map = new BMap.Map('map');"
                + "map.centerAndZoom(new BMap.Point(116.404, 39.915), 11);"
                + "map.addEventListener('rightclick', function (e) {"
                + "    window.external.SetCenter(e.point.lng, e.point.lat);"
                + "});"
                + "</script>"
                + "</body>"
                + "</html>";
            webviewMap.DocumentText = htmlString;
            webviewMap.ObjectForScripting = this;
        }

        public void SetCenter(string lng, string lat)
        {
            tbxLng.Text = lng;
            tbxLat.Text = lat;
        }

        public LatLng getCenter()
        {
            float lat = Convert.ToSingle(tbxLat.Text);
            float lng = Convert.ToSingle(tbxLng.Text);
            return new LatLng(lat, lng);
        }
    }
}

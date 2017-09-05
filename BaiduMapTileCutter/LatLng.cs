namespace BaiduMapTileCutter
{
    public class LatLng
    {
        private double lat = 0;
        private double lng = 0;

        public LatLng()
        {

        }

        public LatLng(double lat, double lng)
        {
            this.lat = lat;
            this.lng = lng;
        }

        public double Lat
        {
            get => lat;
            set
            {
                if (value < -90)
                {
                    value = -90;
                } else if (value > 90)
                {
                    value = 90;
                }
                lat = value;
            }
        }

        public double Lng
        {
            get => lng;
            set
            {
                if (value < -180)
                {
                    value = -180;
                }
                else if (value > 180)
                {
                    value = 180;
                }
                lng = value;
            }
        }

        public override string ToString()
        {
            return lng + ", " + lat;
        }

    }
}

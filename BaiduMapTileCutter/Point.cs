using System;

namespace BaiduMapTileCutter
{
    public class Point
    {
        private double x = 0;
        private double y = 0;

        public Point()
        {

        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get => x;
            set
            {
                x = value;
            }
        }

        public double Y
        {
            get => y;
            set
            {
                y = value;
            }
        }

        public Point Multiply(double factor)
        {
            return new Point(this.x * factor, this.y * factor);
        }

        public Point Divide(double factor)
        {
            return new Point(this.x / factor, this.y / factor);
        }

        public void Round()
        {
            this.x = Math.Round(this.x);
            this.y = Math.Round(this.y);
        }

        public void Floor()
        {
            this.x = Math.Floor(this.x);
            this.y = Math.Floor(this.y);
        }
    }
}

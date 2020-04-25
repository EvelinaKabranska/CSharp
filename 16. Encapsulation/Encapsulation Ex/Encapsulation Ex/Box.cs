using System;

namespace EncapsExe
{
    
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public double Length
        {
            get => this.length;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;

            }
        }
        public double Width
        {
            get => this.width;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;

            }
        }
        public double Height
        {
            get => this.height;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;

            }
        }

        public Box(double length,double width,double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double GetSerfaceArea()
        {
            var reult = 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            return reult;
        }
        public double GetLateralSerfaceArea()
        {
            var reult = 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            return reult;
        }
        public double GetVoliume()
        {
            var reult = this.Width * this.Length  * this.Height;
            return reult;
        }

    }
}

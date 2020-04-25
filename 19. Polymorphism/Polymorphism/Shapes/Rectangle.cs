using System;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public double Height{get; set;}
        public double Width { get; set; }

        public Rectangle (double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * this.Height + 2 * this.Width;
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override void Draw()
        {
            DrawLine(this.Width, '*', '*');

            for (int i = 1; i < this.Height - 1; ++i)
            {
                DrawLine(this.Width, '*', ' ');
            }

            DrawLine(this.Width, '*', '*');
        }

        void DrawLine(double width, char end, char mid)
        {
            Console.Write(end);

            for (int i = 1; i < width - 1; ++i)
            {
                Console.Write(mid);
            }

            Console.WriteLine(end);
        }
    
    }
}

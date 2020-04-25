namespace PointInRectangle
{
    public class Rectangle
    {
        public Point TopLeft;
        public Point BottomRight;

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.TopLeft = topLeft;
            this.BottomRight = bottomRight;
        }

        public bool Contains(Point point)
        {
            bool IsInHorizontal = this.TopLeft.x <= point.x && this.BottomRight.x >= point.x;
            bool IsVertical = this.TopLeft.y <= point.y && this.BottomRight.y >= point.y;

            bool isInRectangle = IsInHorizontal && IsVertical;

            return isInRectangle;
        }
    }
}

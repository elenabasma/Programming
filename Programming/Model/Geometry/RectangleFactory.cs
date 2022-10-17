using Programming.Model.Enums;
using System;

namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {
        private const int Margin = 15;
        private const int MinWidth = 30;
        private const int MaxWidth = 101;
        private const int MinLenght = 30;
        private const int MaxLenght = 101;
        private static Random random;
        static RectangleFactory()
        {
            random = new Random();
        }

        public static Rectangle Randomize(int widthCanvas, int lenghtCanvas)
        {
            var colors = Enum.GetValues(typeof(Colors));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = random.Next(MinWidth, MaxWidth);
            rectangle.Lenght = random.Next(MinLenght, MaxLenght);
            rectangle.Center = new Point2D(random.Next(Margin, widthCanvas - rectangle.Width - Margin),
            random.Next(Margin, lenghtCanvas - rectangle.Lenght - Margin));
            rectangle.Color = colors.GetValue(random.Next(0, colors.Length)).ToString();
            return rectangle;
        }
    }
}
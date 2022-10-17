namespace Programming.Model.Geometry
{
    public class Rectangle
    {
        private static int _allRectanglesCount;
        private int _lenght;
        private int _width;
        private int _id;

        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangle(int lenght, int width, string color, Point2D center)
        {
            Lenght = lenght;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public int Id { get { return _id; } }

        public static int AllRectanglesCount { get { return _allRectanglesCount; } }


        public int Lenght
        {
            get { return _lenght; }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Lenght), value);
                _lenght = value;
            }
        }

        public int Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);
                _width = value;
            }
        }
    }
}
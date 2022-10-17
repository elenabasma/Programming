using System;

namespace Programming.Model.Geometry
{
    public class Ring
    {
        private double _outerRadius;
        private double _innerRadius;

        public Ring() { }

        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }
        
        public double InnerRadius
        {
            get { return _innerRadius; }
            private set
            {
                Validator.AssertOnPositiveValue(nameof(InnerRadius), value);
                Validator.AssertValueInRange(nameof(InnerRadius), value, 0, _outerRadius);
                _innerRadius = value;
            }
        }

        public Point2D Center { get; set; }
        public double OuterRadius
        {
            get { return _outerRadius; }
            private set
            {
                Validator.AssertOnPositiveValue(nameof(OuterRadius), value);
                Validator.AssertValueInRange(nameof(OuterRadius), value, _innerRadius, double.MaxValue);
                _outerRadius = value;
            }
        }

        public double Area => Math.PI * (_outerRadius * _outerRadius - _innerRadius * _innerRadius);
    }
}

using System;

namespace sda_csharp_exercises
{
    public class MyPoint
    {
        public double X { get; }
        public double Y { get; }

        public MyPoint(double x = 0.0, double y = 0.0)
        {
            X = x;
            Y = y;
        }

        public virtual double GetDistanceFromPoint(MyPoint point)
        {
            return Math.Sqrt(Math.Pow((X - point.X), 2) + Math.Pow((Y - point.Y), 2));
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}

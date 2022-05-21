using System;

namespace sda_csharp_exercises
{
    public class MyPoint3D : MyPoint
    {
        public double Z { get; }

        public MyPoint3D(double x = 0.0, double y = 0.0, double z = 0.0)
            : base(x, y)
        {
            Z = z;
        }

        public override double GetDistanceFromPoint(MyPoint point)
        {
            if (point is MyPoint3D tmp)
            {
                return Math.Sqrt(
                    Math.Pow((X - tmp.X), 2)
                    + Math.Pow((Y - tmp.Y), 2)
                    + Math.Pow((Z - tmp.Z), 2)
            );
            }
            else
            {
                throw new ArgumentException(nameof(point));
            }
        }

        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }
    }
}

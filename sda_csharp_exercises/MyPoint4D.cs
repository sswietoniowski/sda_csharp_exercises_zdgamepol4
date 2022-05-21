using System;

namespace sda_csharp_exercises
{
    public class MyPoint4D : MyPoint3D
    {
        public double T { get; set; }

        public MyPoint4D(double x = 0.0, double y = 0.0, double z = 0.0, double t = 0.0)
            : base(x, y, z)
        {
            T = t;
        }

        public override double GetDistanceFromPoint(MyPoint point)
        {
            if (point is MyPoint4D tmp)
            {
                return Math.Sqrt(
                    Math.Pow((X - tmp.X), 2)
                    + Math.Pow((Y - tmp.Y), 2)
                    + Math.Pow((Z - tmp.Z), 2)
                    + Math.Pow((T - tmp.T), 2)
                );
            }
            else
            {
                throw new ArgumentException(nameof(point));
            }
        }

        public override string ToString()
        {
            return $"({X},{Y},{Z},{T})";
        }
    }
}

using System;

namespace sda_csharp_exercises
{
    public class LineSegment
    {
        private MyPoint start;
        private MyPoint end;

        public LineSegment(MyPoint start, MyPoint end)
        {
            this.start = start;
            this.end = end;
        }

        public LineSegment(double startX, double startY, double endX, double endY)
        {
            start = new MyPoint(startX, startY);
            end = new MyPoint(endX, endY);
        }

        public double GetLength()
        {
            return Math.Sqrt(Math.Pow((end.X - start.X), 2) + Math.Pow((end.Y - start.Y), 2));
        }

        public double Length => GetLength();

        public override string ToString()
        {
            return $"{start} -> {end}: {Length}";
        }
    }
}

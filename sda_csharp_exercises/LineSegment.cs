using System;

namespace sda_csharp_exercises
{
    public class LineSegment
    {
        protected MyPoint start;
        protected MyPoint end;

        public LineSegment(MyPoint start, MyPoint end)
        {
            this.start = start;
            this.end = end;
        }

        //public LineSegment(double startX, double startY, double endX, double endY)
        //{
        //    start = new MyPoint(startX, startY);
        //    end = new MyPoint(endX, endY);
        //}

        public double GetLength()
        {
            return start.GetDistanceFromPoint(end);
        }

        public double Length => GetLength();

        public override string ToString()
        {
            return $"{start} -> {end}: {Length}";
        }
    }
}

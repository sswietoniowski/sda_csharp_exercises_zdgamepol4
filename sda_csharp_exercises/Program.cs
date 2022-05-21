using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint point = new();
            Console.WriteLine(point);

            MyPoint anotherPoint = new(5, 10);
            Console.WriteLine(anotherPoint);

            LineSegment firstLine = new(point, anotherPoint);
            Console.WriteLine(firstLine); ;

            LineSegment secondLine = new(0, 0, 5, 10);
            Console.WriteLine(secondLine);
        }
    }
}

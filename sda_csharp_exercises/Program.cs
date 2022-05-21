using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2D ->");
            MyPoint point = new();
            MyPoint anotherPoint = new(5, 10);
            LineSegment firstLine = new(point, anotherPoint);
            Console.WriteLine(firstLine);
            //LineSegment secondLine = new(0, 0, 5, 10);
            //Console.WriteLine(secondLine);

            Console.WriteLine("3D ->");
            MyPoint3D point3D = new();
            Console.WriteLine(point3D);
            MyPoint3D anotherPoint3D = new(5, 10, 20);
            Console.WriteLine(anotherPoint3D);

            LineSegment firstLine3D = new(point3D, anotherPoint3D);
            Console.WriteLine(firstLine3D);

            Console.WriteLine("4D ->");
            MyPoint4D start4D = new();
            MyPoint4D end4D = new(5, 10, 20, 30);

            LineSegment firstLine4D = new(start4D, end4D);
            Console.WriteLine(firstLine4D);
        }
    }
}

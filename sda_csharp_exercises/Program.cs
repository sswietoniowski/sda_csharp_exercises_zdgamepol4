using System;

namespace sda_csharp_exercises
{
    class Program
    {
        private const int MAX_SHAPES = 4;

        static void Main(string[] args)
        {
            //GetTotalAreaWithoutInheritance();
            //GetTotalAreaWithInheritance();
            GetTotalAreaWithInterfaces();
        }

        private static void GetTotalAreaWithInterfaces()
        {
            // tablica kształtów
            IShape[] shapes = new IShape[MAX_SHAPES];
            shapes[0] = new Square(5);
            shapes[1] = new Square(4);
            shapes[2] = new Circle(5);
            shapes[3] = new Circle(4);

            double totalArea = 0.0;

            for (int i = 0; i < shapes.Length; i++)
            {
                totalArea += shapes[i].GetArea();
            }

            Console.WriteLine($"Łączne pole powierzchni: {totalArea}");
        }

        private static void GetTotalAreaWithInheritance()
        {
            // tablica kształtów
            Shape[] shapes = new Shape[MAX_SHAPES];
            shapes[0] = new Square(5);
            shapes[1] = new Square(4);
            shapes[2] = new Circle(5);
            shapes[3] = new Circle(4);

            double totalArea = 0.0;

            for (int i = 0; i < shapes.Length; i++)
            {                
                totalArea += shapes[i].GetArea();
            }

            Console.WriteLine($"Łączne pole powierzchni: {totalArea}");
        }

        private static void GetTotalAreaWithoutInheritance()
        {
            // tablica kształtów
            object[] shapes = new object[MAX_SHAPES];
            shapes[0] = new Square(5);
            shapes[1] = new Square(4);
            shapes[2] = new Circle(5);
            shapes[3] = new Circle(4);

            double totalArea = 0.0;

            for (int i = 0; i < shapes.Length; i++)
            {
                double shapeArea = 0.0;

                object shape = shapes[i];
                if (shape is Square)
                {
                    Square tmp = (Square)shape;
                    shapeArea = tmp.GetArea();
                }
                else if (shape is Circle)
                {
                    Circle tmp = (Circle)shape;
                    shapeArea += tmp.GetArea();
                }

                totalArea += shapeArea;
            }

            Console.WriteLine($"Łączne pole powierzchni: {totalArea}");
        }
    }
}

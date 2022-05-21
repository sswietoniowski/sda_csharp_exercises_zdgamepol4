namespace sda_csharp_exercises
{
    public class Square : Shape
    {
        private readonly double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double GetArea()
        {
            return side * side;
        }
    }
}

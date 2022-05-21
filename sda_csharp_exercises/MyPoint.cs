namespace sda_csharp_exercises
{
    public class MyPoint
    {
        //private double x;
        //private double y;

        //public double X 
        //{
        //    get
        //    {
        //        return x;
        //    }
        //    set
        //    {
        //        x = value;
        //    }
        //}

        //public double Y { get => y; set => y = value; }

        //public double X { get; set; }
        //public double Y { get; set; }

        public double X { get; }
        public double Y { get; }

        public MyPoint(double x = 0.0, double y = 0.0)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}

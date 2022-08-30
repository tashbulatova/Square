namespace SquareLib
{
    public class Сircle : Figure
    {
        public double radius { get; set; }

        public Сircle(double r)
        {
            radius = r;
        }
        public override double GetArea()
        {
            Area = Math.PI * Math.Pow(radius, 2);
            return Area;
        }
    }
}
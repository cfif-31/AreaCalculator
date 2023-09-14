namespace SquareCalculator.Figures
{
    internal class Circle : Figure
    {
        private double Radius { get; }

        public override double Square => 2 * Math.PI * Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}

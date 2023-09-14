namespace SquareCalculator.Figures
{
    internal class Circle : Figure
    {
        private double Radius { get; }

        public override double Square => 2 * Math.PI * Radius;

        public Circle(double radius)
        {
            if(radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius));

            Radius = radius;
        }
    }
}

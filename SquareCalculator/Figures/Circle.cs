namespace SquareCalculator.Figures
{
    public class Circle : Figure
    {
        /// <summary>
        /// Сircle radius
        /// </summary>
        private double Radius { get; }

        /// <summary>
        /// Constructor of Circle
        /// </summary>
        /// <param name="radius">Сircle radius</param>
        /// <exception cref="ArgumentOutOfRangeException">When radius less than or equal 0</exception>
        public Circle(double radius)
        {
            Radius = GetCheckGreeterZeroValue(radius, nameof(radius));
        }

        public override double Square => Math.PI * Math.Pow(Radius, 2);
    }
}
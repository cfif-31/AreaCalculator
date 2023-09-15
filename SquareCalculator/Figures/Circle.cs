namespace SquareCalculator.Figures
{
    public class Circle : Figure
    {
        /// <summary>
        /// Сircle radius
        /// </summary>
        private double Radius { get; }

        public override double Square => 2 * Math.PI * Radius;

        /// <summary>
        /// Constructor of Circle
        /// </summary>
        /// <param name="radius">Сircle radius</param>
        /// <exception cref="ArgumentOutOfRangeException">When radius less than or equal 0</exception>
        public Circle(double radius)
        {
            Radius = GetCheckGreeterZeroValue(radius, nameof(radius));
        }
    }
}
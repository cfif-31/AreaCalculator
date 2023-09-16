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

        /// <summary>
        /// Calculation square of circle
        /// </summary>
        /// <returns>Square of circle</returns>
        protected override double CalculateSquare() => Math.PI * Math.Pow(Radius, 2);
    }
}
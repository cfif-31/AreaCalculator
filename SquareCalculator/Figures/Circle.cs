namespace SquareCalculator.Figures
{
    /// <summary>
    /// Implementation of circle figure
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Circle radius
        /// </summary>
        private double Radius { get; }

        /// <summary>
        /// Validate input data
        /// </summary>
        /// <param name="radius">Circle radius</param>
        /// <exception cref="ArgumentOutOfRangeException">When radius less than or equal 0</exception>
        private void Validate(double radius)
        {
            ValidateGreeterZeroValue(radius, nameof(radius));
        }

        /// <summary>
        /// Constructor of Circle
        /// </summary>
        /// <param name="radius">Circle radius</param>
        /// <exception cref="ArgumentOutOfRangeException">When radius less than or equal 0</exception>
        public Circle(double radius) : base()
        {
            Validate(radius);
            Radius = radius;
        }

        /// <summary>
        /// Calculation square of circle
        /// </summary>
        /// <returns>Square of circle</returns>
        protected override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
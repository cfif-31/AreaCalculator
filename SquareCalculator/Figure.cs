using SquareCalculator.Base;

namespace SquareCalculator
{
    /// <summary>
    /// Base figure
    /// </summary>
    public abstract class Figure : IArea
    {
        private readonly Lazy<double> _area;

        /// <summary>
        /// Square of figure
        /// </summary>
        public double Area => _area.Value;

        /// <summary>
        /// Base figure constructor
        /// </summary>
        public Figure()
        {
            _area = new Lazy<double>(CalculateArea);
        }

        /// <summary>
        /// Calculation figure square
        /// </summary>
        /// <returns>Square of figure</returns>
        protected abstract double CalculateArea();

        /// <summary>
        /// Check side value
        /// </summary>
        /// <param name="value">Side length</param>
        /// <param name="valueName">Side name for exception</param>
        /// <exception cref="ArgumentOutOfRangeException">When value less than or equal to 0</exception>
        protected void ValidateGreeterZeroValue(double value, string valueName)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(valueName, $"Value ({value}) most be greater 0");
        }
    }
}
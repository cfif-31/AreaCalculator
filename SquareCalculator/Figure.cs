namespace SquareCalculator
{
    public abstract class Figure
    {
        private readonly Lazy<double> _square;

        /// <summary>
        /// Square of figure
        /// </summary>
        public double Square => _square.Value;

        /// <summary>
        /// Base figure constructor
        /// </summary>
        public Figure()
        {
            _square = new Lazy<double>(CalculateSquare);
        }

        /// <summary>
        /// Calculation figure square
        /// </summary>
        /// <returns>Square of figure</returns>
        protected abstract double CalculateSquare();

        /// <summary>
        /// Check side value
        /// </summary>
        /// <param name="value">Side length</param>
        /// <param name="valueName">Side name for exception</param>
        /// <returns>Value</returns>
        /// <exception cref="ArgumentOutOfRangeException">When value less than or equal to 0</exception>
        protected virtual double GetCheckGreeterZeroValue(double value, string valueName)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(valueName, $"Value ({value}) most be greather 0");

            return value;
        }
    }
}
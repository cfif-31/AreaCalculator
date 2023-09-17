namespace AreaCalculator.Base
{
    /// <summary>
    /// Provides the ability to check squareness
    /// </summary>
    public interface IRectangular
    {
        /// <summary>
        /// Returns true or false depending on rectangularity
        /// </summary>
        public bool IsRectangular { get; }
    }
}

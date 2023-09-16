namespace SquareCalculator.Figures
{
    public class Triangle : Figure
    {
        /// <summary>
        /// IsRectangular Lazzy field
        /// </summary>
        private readonly Lazy<bool> _IsRectangular;

        /// <summary>
        /// Check triangle is rectangular
        /// </summary>
        public bool IsRectangular => _IsRectangular.Value;

        //Sides
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        /// <summary>
        /// Constructor of Triangle
        /// </summary>
        /// <param name="sideA">Side A value</param>
        /// <param name="sideB">Side B value</param>
        /// <param name="sideC">Side C value</param>
        /// <exception cref="ArgumentException">When uncorrect triangle one or more value less than or equal to 0</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA >= sideB + sideC || sideB >= sideC + sideA || sideC >= sideA + sideB)
                throw new ArgumentException($"Triangle {sideA} {sideB} {sideC} does not exist!");

            SideA = GetCheckGreeterZeroValue(sideA, nameof(sideA));
            SideB = GetCheckGreeterZeroValue(sideB, nameof(sideB));
            SideC = GetCheckGreeterZeroValue(sideC, nameof(sideC));

            _IsRectangular = new Lazy<bool>(CalculateIsRectangular);
        }

        /// <summary>
        /// Check triangle is rectangular 
        /// </summary>
        /// <returns>When triangle is rectangular, return true, or false</returns>
        protected bool CalculateIsRectangular()
        {
            double sideASquare = Math.Pow(SideA, 2);
            double sideBSquare = Math.Pow(SideB, 2);
            double sideCSquare = Math.Pow(SideC, 2);

            bool checkA = CheckPythagorasSides(sideASquare, sideBSquare, sideCSquare);
            bool checkB = CheckPythagorasSides(sideBSquare, sideASquare, sideCSquare);
            bool checkC = CheckPythagorasSides(sideCSquare, sideASquare, sideBSquare);

            return checkA || checkB || checkC;
        }

        /// <summary>
        /// Check rectangular sides using Pythagoras formula
        /// </summary>
        /// <param name="hypotenuseSq">Square of the hypotenuse</param>
        /// <param name="cathetus1Sq">Square of the cathetus1</param>
        /// <param name="cathetus2Sq">Square of the cathetus2</param>
        /// <returns></returns>
        protected bool CheckPythagorasSides(double hypotenuseSq, double cathetus1Sq, double cathetus2Sq)
        {
            return cathetus1Sq + cathetus2Sq == hypotenuseSq;
        }

        /// <summary>
        /// Calculation square of triangle
        /// </summary>
        /// <returns>Square of triangle</returns>
        protected override double CalculateSquare()
        {
            double halfPerimeter = (SideA + SideB + SideC) / 2;

            double halfPerSubSideA = halfPerimeter - SideA;
            double halfPerSubSideB = halfPerimeter - SideB;
            double halfPerSubSideC = halfPerimeter - SideC;

            double square = Math.Sqrt(halfPerimeter * halfPerSubSideA * halfPerSubSideB * halfPerSubSideC);

            return square;
        }
    }
}
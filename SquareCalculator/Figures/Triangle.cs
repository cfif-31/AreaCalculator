﻿namespace SquareCalculator.Figures
{
    public class Triangle : Figure
    {
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
        /// <exception cref="ArgumentException">When one or more value less than or equal to 0</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = GetCheckGreeterZeroValue(sideA, nameof(sideA));
            SideB = GetCheckGreeterZeroValue(sideB, nameof(sideB));
            SideC = GetCheckGreeterZeroValue(sideC, nameof(sideC));
        }

        public override double Square
        {
            get
            {
                double halfPerimeter = (SideA + SideB + SideC) / 2;
                double square = Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));

                return square;
            }
        }
    }
}
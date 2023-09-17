using SquareCalculator.Figures;

namespace SquareCalculator.Test.Figures
{
    /// <summary>
    /// Test triangle implementation of figure
    /// </summary>
    public class TriangleTest
    {
        [Test]
        [TestCase(0.433, 1, 1, 1)]
        [TestCase(10.392, 3, 8, 7)]
        [TestCase(453.493, 35, 43, 74)]
        [TestCase(947.271, 52, 38, 55)]
        public void SquareTest(double exceptedResult, double sideA, double sideB, double sideC)
        {
            var figure = new Triangle(sideA, sideB, sideC);
            Assert.That(figure.Area, Is.EqualTo(exceptedResult).Within(0.05));
        }

        [Test]
        [TestCase(3, 5, 8)]
        [TestCase(7, 5, 2)]
        [TestCase(4, 9, 5)]
        public void NotExistTest(double sideA, double sideB, double sideC)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
            Assert.That(ex.Message, Is.EqualTo($"Triangle {sideA} {sideB} {sideC} does not exist!"));
        }

        [Test]
        //SideA
        [TestCase(0, 1, 1)]
        [TestCase(-10, 1, 1)]
        [TestCase(-20, 1, 1)]
        [TestCase(-4, 1, 1)]
        //SideB
        [TestCase(1, 0, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(1, -20, 1)]
        [TestCase(1, -4, 1)]
        //SideC
        [TestCase(1, 1, 0)]
        [TestCase(1, 1, -10)]
        [TestCase(1, 1, -20)]
        [TestCase(1, 1, -4)]
        public void NegativeTest(double sideA, double sideB, double sideC)
        {
            try
            {
                new Triangle(sideA, sideB, sideC);
                Assert.Fail("Construct Triangle With incorrect value!");
            }
            catch (ArgumentOutOfRangeException argumentRangeEx)
            {
                Assert.That(argumentRangeEx.Message, Does.Contain("most be greater 0 (Parameter"));
            }
            catch (ArgumentException argumentEx)
            {
                Assert.That(argumentEx.Message, Is.EqualTo($"Triangle {sideA} {sideB} {sideC} does not exist!"));
            }
        }

        [Test]
        [TestCase(88, 105, 137)]
        [TestCase(17, 145, 144)]
        [TestCase(173, 52, 165)]
        public void RectangularTest(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            Assert.That(triangle.IsRectangular, Is.True);
        }

        [Test]
        [TestCase(15, 10, 8)]
        [TestCase(14, 7, 19)]
        [TestCase(18, 23, 15)]
        public void NotRectangularTest(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            Assert.That(triangle.IsRectangular, Is.False);
        }
    }
}

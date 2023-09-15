using SquareCalculator.Figures;

namespace SquareCalculator.Test.Figures
{
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
            Assert.That(figure.Square, Is.EqualTo(exceptedResult).Within(0.05));
        }

        [Test]
        [TestCase(3,5,8)]
        [TestCase(7,5,2)]
        [TestCase(4,9,5)]
        public void NotExistTest(double sideA, double sideB, double sideC)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
            Assert.That(ex.Message, Is.EqualTo($"Triangle {sideA} {sideB} {sideC} does not exist!"));
        }
    }
}

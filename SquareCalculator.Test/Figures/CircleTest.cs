using SquareCalculator.Figures;

namespace SquareCalculator.Test.Figures
{
    /// <summary>
    /// Test circle implementation of figure
    /// </summary>
    public class CircleTest
    {

        [Test]
        [TestCase(78.5, 5)]
        [TestCase(201.061888, 8)]
        [TestCase(452.389248, 12)]
        [TestCase(615.752032, 14)]
        public void SquareTest(double exceptedResult, double radius)
        {
            var figure = new Circle(radius);
            Assert.That(figure.Square, Is.EqualTo(exceptedResult).Within(0.05));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-2)]
        [TestCase(-4)]
        [TestCase(-5)]
        [TestCase(-15)]
        [TestCase(-35)]
        public void NegativeTest(double radius)
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
            Assert.That(ex.Message, Is.EqualTo($"Value ({radius}) most be greater 0 (Parameter 'radius')"));
        }
    }
}

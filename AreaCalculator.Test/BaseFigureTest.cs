using AreaCalculator.Figures;

namespace AreaCalculator.Test
{
    /// <summary>
    /// Test base figure type
    /// </summary>
    public class BaseFigureTest
    {
        public static IEnumerable<TestCaseData> FigureTestCase
        {
            get
            {
                yield return new TestCaseData(120, new Triangle(26, 24, 10));
                yield return new TestCaseData(17.412, new Triangle(5, 7, 9));
                yield return new TestCaseData(6, new Triangle(3, 4, 5));

                yield return new TestCaseData(28.26, new Circle(3));
                yield return new TestCaseData(78.5, new Circle(5));
            }
        }

        [Test]
        [TestCaseSource(nameof(FigureTestCase))]
        public void FigureTest(double exceptedResult, Figure figure)
        {
            Assert.That(figure.Area, Is.EqualTo(exceptedResult).Within(0.05));
        }
    }
}
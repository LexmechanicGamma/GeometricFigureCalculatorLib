using GeometricFigureCalculator.Figures;
namespace GeometricFigureCalculator.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(Math.PI, 31.006276680299816)]
        [InlineData(6, 113.09733552923255)]
        [InlineData(0, 0)]
        public static void CalculateAreaShould(double radius, double result)
        {
            Circle figure = new(radius);
            Assert.Equal(figure.CalculateArea(), result);
        }
        [Fact]
        public static void CircleNegativeRadiusConstruction() 
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}
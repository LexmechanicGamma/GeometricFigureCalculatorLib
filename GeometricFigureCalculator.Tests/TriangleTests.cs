using GeometricFigureCalculator.Figures;

namespace GeometricFigureCalculator.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(1, 1, 1, 0.433012702)]      
        public static void CalculateAreaShould(double edge,
                                               double edge2,
                                               double edge3,
                                               decimal result)
        {
            Triangle figure = new(edge, edge2, edge3);
            Assert.Equal((decimal)figure.CalculateArea(), result);
        }

        [Fact]
        public static void Triangle_InvalidArguments_ShouldFail()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, -1, -1));
        }

        [Theory]
        [InlineData(5, 3, 4, true)]
        public static void Triangle_IsRectungular_ShouldBeRectungular(double edge,
                                                                      double edge2,
                                                                      double edge3,
                                                                      bool result)
        {
            Assert.Equal(Triangle.IsRectangular(edge, edge2, edge3), result);
        }
    }
}
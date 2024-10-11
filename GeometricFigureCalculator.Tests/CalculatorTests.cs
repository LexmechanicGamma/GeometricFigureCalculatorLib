using GeometricFigureCalculator.Figures;

namespace GeometricFigureCalculator.Tests
{
    
    public class CalculatorTests
    {
        [Theory]
        [InlineData(6, 113.09733552923255,
                    1, 1, 1, 0.433012702)]
        public static void Calculator_TestCircle(double radius, double resultCircle,
                                                 double sideA, double sideB, double sideC, double resultTriangle)
        {
            Circle circle = new(radius);
            Assert.Equal(Calculator.CalculateArea(circle), resultCircle);

            Triangle triangle = new(sideA, sideB, sideC);
            Assert.Equal(Calculator.CalculateArea(triangle), resultTriangle);
        }
    }
}
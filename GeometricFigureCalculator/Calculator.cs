namespace GeometricFigureCalculator
{
    public static class Calculator
    {
        public static double CalculateArea(IFigureArea figure)
        {           
            return figure.CalculateArea();
        }
    }
}
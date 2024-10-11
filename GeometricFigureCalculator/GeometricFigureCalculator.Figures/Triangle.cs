namespace GeometricFigureCalculator.Figures
{
    public class Triangle : Figure
    {
        private double _edge1, _edge2, _edge3;
        public Triangle(double a, double b, double c)
        {
            if(!IsValid(a, b, c)) 
                throw new ArgumentException("Invalid triangle.");

            _edge1 = a;
            _edge2 = b;
            _edge3 = c;
        }
        public override double CalculateArea()
        {
            double p = (_edge1 + _edge2 + _edge3) / 2; 
            double S = Math.Sqrt((p - _edge1) * (p - _edge2) * (p - _edge3) * p);

            return Math.Round(S,9);
        }

        public static bool IsRectangular(double a, double b, double c)/////////
        {
            var aSquare = Math.Pow(a, 2);
            var bSquare = Math.Pow(b, 2);
            var cSquare = Math.Pow(c, 2);

            return (aSquare + bSquare == cSquare) || 
                   (bSquare + cSquare == aSquare) || 
                   (aSquare + cSquare == bSquare);
        }

        public static bool IsValid(double a, double b, double c)
        {
            bool allPositive = a > 0 || b > 0 || c > 0;
            bool validTriangle = a + b > c || b + c > a || a + c > b;
            
            return allPositive && validTriangle;
        }
    }
}
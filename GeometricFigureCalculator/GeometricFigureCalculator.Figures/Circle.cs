namespace GeometricFigureCalculator.Figures
{
    public class Circle : Figure
    {
        private double _radius;

        public Circle(double Radius)
        {
            if (Radius < 0)
                throw new ArgumentException("Radius value must be positive.");

            _radius = Radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
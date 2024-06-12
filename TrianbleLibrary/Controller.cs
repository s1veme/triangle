namespace TriangleLibrary
{
    public class Triangle
    {
        public double AB { get; set; }
        public double BC { get; set; }
        public double AC { get; set; }

        public Triangle(double a, double b, double c)
        {
            AB = a;
            BC = b;
            AC = c;
        }
    }

    public class TriangleValidator
    {
        private Triangle triangle;
        private List<double> slidesOfTriangle;

        public TriangleValidator(Triangle triangle)
        {
            this.triangle = triangle;
            slidesOfTriangle = new List<double> { this.triangle.AB, this.triangle.BC, this.triangle.AC };
            slidesOfTriangle.Sort();
        }

        public bool IsValidTriangle()
        {
            return !(triangle.AB >= triangle.BC + triangle.AC ||
                        triangle.BC >= triangle.AB + triangle.AC ||
                        triangle.AC >= triangle.BC + triangle.AB);
        }

        public string DetermineSideType()
        {
            if (triangle.AB == triangle.BC && triangle.AB == triangle.AC)
            {
                return "Равносторонний";
            }
            if (triangle.AB == triangle.BC || triangle.AB == triangle.AC || triangle.BC == triangle.AC)
            {
                return "Равнобедренный";
            }
            return "Разносторонний";
        }

        public string DetermineAngleType()
        {
            double aSquared = Math.Pow(slidesOfTriangle[0], 2);
            double bSquared = Math.Pow(slidesOfTriangle[1], 2);
            double cSquared = Math.Pow(slidesOfTriangle[2], 2);

            if (cSquared == aSquared + bSquared)
            {
                return "Прямоугольный";
            }

            if (cSquared < aSquared + bSquared)
            {
                return "Остроугольный";
            }

            return "Тупоугольный";
        }

        public override string ToString()
        {
            if (!IsValidTriangle())
            {
                return "Треугольник не существует";
            }

            return $"{DetermineSideType()}\r\n{DetermineAngleType()}";
        }
    }
}
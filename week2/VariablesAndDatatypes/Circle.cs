namespace VariablesAndDatatypes
{
    public class Circle
    {
        public const double PI = 3.14;

        public static double Area(double radius)
        {
            return PI * radius * radius;
        }

        public static double Perimeter(double radius)
        {
            return 2 * PI * radius;
        }
    }
}

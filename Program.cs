namespace review
{
    public class Program

    {
        public static double GetCircleArea(double radius)
        {
            const float PI = 3.14159265358979323846f;
            double area = PI * radius * radius;
            return area;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = GetCircleArea(radius);
            Console.WriteLine("The area of the circle is: {0}", area);
            Console.ReadKey();
        }
    }
}

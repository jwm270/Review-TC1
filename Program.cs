using System.ComponentModel.DataAnnotations;

namespace review
{
    public class Program

    {
        static void Main(string[] args)
        {
            double circleArea = Circle();
            
            double calculateArea = Triangle();
            
            double rectangleArea = Rectangle();
            
            double squareArea = Square();
        }
        public static double GetCircleArea(double radius)
        {
            const float PI = 3.14159265358979323846f; //How do I know to use const float PI = 3.14...?
            
            double area = PI * radius * radius;
            
            return area;
        }

        static double Circle()
        {
            Console.WriteLine("Enter the radius of the circle:");
            
            double radius = Convert.ToDouble(Console.ReadLine());
            
            double area = GetCircleArea(radius);
            
            Console.WriteLine($"The area of the circle is {area}");
            
           return area;
           
        }

        public static double calculateArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        static double Triangle()
        {
            Console.WriteLine("Enter the length of the triangle:");
            
            double baseLength = Convert.ToDouble(Console.ReadLine()); //How do I know to use ToDouble?
            
            Console.WriteLine("Enter the height of the triangle:");
            
            double height = Convert.ToDouble(Console.ReadLine());
            
            double area = calculateArea(baseLength, height);
            
            Console.WriteLine("The area of the triangle is: {0}", area);
            
            return area;
        }
        
        //Area of rectangle a = l * w
        
        static double Rectangle()
        {
            Console.WriteLine("Enter the width of the rectangle:");
            
            double width = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the length of the rectangle:");
            
            double length = Convert.ToDouble(Console.ReadLine()); //How do I know to use ToDouble?
            
            double area = width * length;
            
            Console.WriteLine("The area of the rectangle is: {0}", area); //Why is this not extrapolated? "$"
            
            return length;
            
            return width;
        }
        
        //Area of a square A = S * S

        static double Square()
        {
            Console.WriteLine("Enter the Side of the square:");
            
            double side = Convert.ToDouble(Console.ReadLine());
            
            double area = side * side;
            
            Console.WriteLine($"Area of Square with side {side} is: {area}"); //Why does this have to be $ extrapolated? When rectangle didn't have to be?
            
            return area;
            
        }
        //public can be used anywhere "access modifier"
        //static a type of member of the class
        //(parameter list) tools to get the job done
        
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
      
    }
}

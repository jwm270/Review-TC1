using System.ComponentModel.DataAnnotations;

namespace review
{
    public class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The area of the circle is:" + Circle());
            
            Console.WriteLine($"The area of the triangle is:" + Triangle());
            
            Console.WriteLine("The area of the rectangle is:" + Rectangle());
            
            Console.WriteLine("The area of Square is:" + Square());
            
            Console.WriteLine($"You must interpolate and not extrapolate!");
            
            Console.WriteLine($"https://learn.microsoft.com/en-us/dotnet/api/system.convert.todouble?view=net-9.0");
            
            Console.WriteLine($"ToDouble is literally To Double...don't overthink it. Converting to DOUBLE or to INT for INTEGER...etc");
            
            Console.WriteLine($"make repo - cd into folder - git init - git remote add origin codeSSHURL - git add . - git commit -m (message in quotes) - git push origin main ");
        }
       
        static double Circle()
        {
            Console.WriteLine("Enter the radius of the circle:");
            
            double radius = Convert.ToDouble(Console.ReadLine());
            
            double area = Math.PI * radius * radius;
            
            return area;
        }

        static double Triangle()
        {
            Console.WriteLine("Enter the length of the triangle:");
            
            double baseLength = Convert.ToDouble(Console.ReadLine()); //How do I know to use ToDouble?
            
            Console.WriteLine("Enter the height of the triangle:");
            
            double height = Convert.ToDouble(Console.ReadLine());

            double area = (baseLength * height) / 2;
            
            return area;
        }
        
        //Area of rectangle a = l * w
        
        static double Rectangle()
        {
            Console.WriteLine("Enter the width of the rectangle:");
            
            double width = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the length of the rectangle:");
            
            double length = Convert.ToDouble(Console.ReadLine()); //How do I know to use ToDouble?
            
            double area = width * length; //return width * length
            
            return area;
        }
        
        //Area of a square A = S * S

        static double Square()
        {
            Console.WriteLine("Enter the Side of the square:");
            
            double side = Convert.ToDouble(Console.ReadLine());
            
            double area = side * side;
            
            return area;
            
        }
        //public can be used anywhere "access modifier"
        //static a type of member of the class
        //(parameter list) tools to get the job done
        
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        //       /* make repo
        // cd into folder
        // git init
        // git remote add origin codeSSHURL
        // git add .
        // git commit -m "message"
        // git push origin main */
    }
}

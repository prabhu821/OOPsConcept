using System.Drawing;

namespace PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOPs Concept - Practice Problem !");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect option \n1.Class and Object \n2.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        ObjectAndClass objectAndClass = new ObjectAndClass(5.0, 3.0);
                        double area = objectAndClass.CalculateArea();
                        double perimeter = objectAndClass.CalculatePerimeter();
                        Console.WriteLine("Area: " + area);
                        Console.WriteLine("Perimeter: " + perimeter);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
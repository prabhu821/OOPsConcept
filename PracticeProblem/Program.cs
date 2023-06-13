﻿using System.Drawing;

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
                Console.WriteLine("\nSelect option \n1.Class and Object \n2.Inheritance \n3.Exit");
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
                    case 2:
                        Rectangle rectangle = new Rectangle("Rectangle", 5.0, 3.0);
                        double area1 = rectangle.CalculateArea();
                        rectangle.DisplayInfo();
                        Console.WriteLine("Area: " + area1);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
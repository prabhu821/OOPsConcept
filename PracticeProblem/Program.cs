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
                Console.WriteLine("\nSelect option \n1.Class and Object \n2.Inheritance \n3.Polymorphism \n4.Encapsulation " +
                    "\n5.Abstraction \n6.Exit");
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
                    case 3:
                        Animal animal1 = new Animal();
                        Animal animal2 = new Dog();
                        Animal animal3 = new Cat();
                        animal1.MakeSound(); 
                        animal2.MakeSound(); 
                        animal3.MakeSound(); 
                        break;
                    case 4:
                        Employee employee = new Employee();
                        employee.Name = "John Doe";
                        employee.Age = 30;
                        employee.Salary = 500000.00;
                        employee.DisplayEmployeeInfo();
                        break;
                    case 5:
                        Shape1 shape1 = new Circle1();
                        Shape1 shape2 = new Rectangle1();
                        shape1.Draw();
                        shape1.Display();
                        shape2.Draw();
                        shape2.Display();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
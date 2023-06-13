using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem;

public class Shape
{
    protected string name;

    public Shape(string name)
    {
        this.name = name;
    }

    public virtual double CalculateArea()
    {
        return 0;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Name: " + name);
    }
}

public class Rectangle : Shape
{
    protected double length;
    protected double width;

    public Rectangle(string name, double length, double width) : base(name)
    {
        this.length = length;
        this.width = width;
    }

    public override double CalculateArea()
    {
        return length * width;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
    }
}

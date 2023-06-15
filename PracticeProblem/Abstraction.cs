using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    abstract class Shape1
    {
        // Abstract method
        public abstract void Draw();

        // Concrete method
        public void Display()
        {
            Console.WriteLine("Displaying shape...");
        }
    }

    // Derived class 1
    class Circle1 : Shape1
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle...");
        }
    }

    // Derived class 2
    class Rectangle1 : Shape1
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle...");
        }
    }
}

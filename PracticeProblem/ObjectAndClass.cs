﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class ObjectAndClass
    {
        private double length;
        private double width;

        public ObjectAndClass(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }
}
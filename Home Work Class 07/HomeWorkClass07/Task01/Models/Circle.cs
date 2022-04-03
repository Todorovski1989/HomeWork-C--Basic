using System;
using System.Collections.Generic;
using System.Text;

namespace Task01.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override void GetArea()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"The area of the circle is {area}");
        }
        public override void GetPeremeter()
        {
            double peremeter = Math.PI * Radius * 2;
            Console.WriteLine($"The perimeter of the cicle is {peremeter}");
        }
    }
}

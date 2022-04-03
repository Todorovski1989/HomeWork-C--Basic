using System;
using System.Collections.Generic;
using System.Text;

namespace Task01.Models
{
    public class Rectangle : Shape
    {
        
        public int SideA { get; set; }
        public int SideB { get; set; }

        public override void GetArea()
        {
            int area = SideA * SideB;
            Console.WriteLine($"The area of the rectangle is {area}");
            
        }

        public override void GetPeremeter()
        {
            int peremeter = 2 * SideA * SideB;
            Console.WriteLine($"The perimeter of the rectangle is {peremeter}");
        }
    }
}

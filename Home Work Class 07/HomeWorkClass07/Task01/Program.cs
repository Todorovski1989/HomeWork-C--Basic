using System;
using Task01.Models;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Position = new int[] { 12, 222 };
            rectangle.SideA = 5;
            rectangle.SideB = 55;
            rectangle.Name = "Rectangle";
            rectangle.Color = "Green";

            rectangle.GetArea();
            rectangle.GetPeremeter();

            Console.WriteLine("-----------------------------------------");

            Circle circle = new Circle();
            circle.Position = new int[] { 48, 291 };
            circle.Radius = 12;
            circle.Name = "Circle";
            circle.Color = "Black";

            circle.GetArea();
            circle.GetPeremeter();

            Console.WriteLine("-----------------------------------------");
        }
    }
}

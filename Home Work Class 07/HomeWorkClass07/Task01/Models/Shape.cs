using System;
using System.Collections.Generic;
using System.Text;

namespace Task01.Models
{
    public class Shape
    {
        public string name;
        public string color;
        public Shape()
        {

        }

        public Shape(string name, string color)
        {
            Name = name;
            Color = color;
        }
        
        public string Name 
        {
            get { return name; }
            set
            {
                if (value == "Rectangle" || value == "Circle")
                {
                    name = value;
                    Console.WriteLine($"Name: {name}");
                }
                else
                {
                    name = null;
                }

            }
        }
        public string Color
        {
            get { return color; }
            set 
            {
                if (value == "Orange" || value == "Blue" || value == "Black" || value == "White" || value == "Green")
                {
                    color = value;
                    Console.WriteLine($"Color: {color}");
                }
                else
                {
                    color = null;
                }
            }
        }
        public int[] Position { get; set; }

        public virtual void GetArea()
        {
            Console.WriteLine("There is no special implementation for area!");
        }
        public virtual void GetPeremeter()
        {
            Console.WriteLine("There is no special implementation for perimeter!");
        }

        

    }
}

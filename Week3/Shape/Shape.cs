using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Shape(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }

    public class Triangle: Shape
    {
        public Triangle(int width, int height): base(width, height){}

        public double Area()
        {
            return (Width * Height) / 2;
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(int width, int height) : base(width, height) { }

        public double Area()
        {
            return Width * Height;
        }
    }
}

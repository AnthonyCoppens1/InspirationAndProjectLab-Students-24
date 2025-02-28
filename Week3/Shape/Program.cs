using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(18, 7);
            Console.WriteLine("Triangle area: " + triangle.Area());

            Rectangle rectangle = new Rectangle(15, 31);
            Console.WriteLine("Rectangle area: " + rectangle.Area());
        }
    }
}

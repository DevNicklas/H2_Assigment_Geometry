using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_Geometry
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>
            {
                new Square(6),
                new Rectangle(8, 4),
                new Parallelogram(3, 5, 20),
                new Trapeze(10, 9, 8, 9),
                new Triangle(3, 4, 5)
            };

            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"Area: {shape.CalculateArea()}");
                Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
            }

            Console.ReadLine();
        }
    }
}

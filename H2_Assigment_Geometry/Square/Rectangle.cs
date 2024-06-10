using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_Geometry
{
    internal class Rectangle : Square
    {
        public Rectangle(double sideA, double sideB) : base(sideA, sideB)
        {

        }

        public override double CalculateArea() => SideA * SideB;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_Geometry
{
    internal class Trapeze : Square
    {
        private double _sideC;
        private double _sideD;

        public Trapeze(double sideA, double sideB, double sideC, double sideD) : base(sideA, sideB)
        {
            _sideC = sideC;
            _sideD = sideD;
        }

        public override double CalculateArea()
        {
            double s = (SideA + SideB - _sideC + _sideD) / 2;
            double height = 2 / (SideA - _sideC) * Math.Sqrt(s*(s - SideA + _sideC) * (s - SideB) * (s - _sideD));

            return 0.5 * (SideA + _sideC) * height;
        }
    }
}

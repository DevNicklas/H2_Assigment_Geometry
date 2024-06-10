using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_Geometry
{
    public class Parallelogram : Square
    {
        private double _angleV;

        public Parallelogram(double sideA, double sideB, double angleV) : base(sideA, sideB)
        {
            _angleV = angleV;
        }

        public double AngleV
        {
            get 
            {
                return _angleV;
            }
        }

        public override double CalculateArea()
        {
            // Calculate angle in radians
            double angleVInRadians = _angleV * (Math.PI / 180);

            return SideA * SideB * Math.Sin(angleVInRadians);
        }
    }
}

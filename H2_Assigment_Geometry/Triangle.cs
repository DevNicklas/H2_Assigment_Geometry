using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_Geometry
{
    public class Triangle : IShape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle (double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double SideA
        {
            get
            {
                return _sideA;
            }

            set
            {
                _sideA = value;
            }
        }

        public double SideB
        {
            get
            {
                return _sideB;
            }

            set
            {
                _sideB = value;
            }
        }

        public double SideC
        {
            get
            {
                return _sideC;
            }

            set
            {
                _sideC = value;
            }
        }

        public double CalculatePerimeter() => _sideA + _sideB + _sideC;

        public double CalculateArea() => 0.5 * _sideA * _sideB;
    }
}

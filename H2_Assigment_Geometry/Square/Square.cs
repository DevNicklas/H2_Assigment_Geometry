using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_Geometry
{
    public class Square : IShape
    {
        private double _sideA;
        private double _sideB;

        public Square(double sideA)
        {
            _sideA = sideA;
        }

        public Square(double sideA, double sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
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
        }

        public double CalculatePerimeter() => _sideA * 4;

        public virtual double CalculateArea() => Math.Pow(_sideA, 2);
    }
}

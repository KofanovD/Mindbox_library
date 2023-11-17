using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox_library
{
    public class Triangle : Shape
    {
        private double _sideA { get; set; }
        private double _sideB { get; set; }
        private double _sideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValidTriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("Неверные стороны для треугольника!");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            // check if parameters is valid
            return a + b > c && a + c > b && b + c > a;
        }

        public override double GetArea()
        {
            double s = (_sideA + _sideB + _sideC) / 2; // semiperimeter
            return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
        }

        public bool IsRightAngled()
        {
            // sort the sides so that the hypotenuse is first.
            List<double> sides = new List<double>() { _sideA, _sideB, _sideC }.OrderByDescending(s => s).ToList();
            return Math.Pow(sides[0], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[1], 2);
        }

        public override string GetType()
        {
            return "triangle";
        }
    }
}

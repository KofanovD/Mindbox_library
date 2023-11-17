﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox_library
{
    public class Circle : Shape
    {
        private double _radius { get; set; }
        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public override string GetType()
        {
            return "circle";
        }
    }
}

using Geometry.Calculator.ConcreteBuilder.Square;
using Geometry.Calculator.Creator;
using Geometry.Calculator.Enums;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Calculator.Helper
{
    public static class SemicircleFormulas
    {
        public static double GetPerimeter(double radius)
        {
            return Math.PI * radius + 2 * radius;
        }
        public static double GetDiametar(double radius)
        {
            return 2 * radius;
        }
        public static double GetArea(double radius)
        {
            return (Math.PI * Math.Pow(radius, 2)) / 2;
        }
    }
}

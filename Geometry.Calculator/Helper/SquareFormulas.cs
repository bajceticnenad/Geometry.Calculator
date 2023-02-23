using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Calculator.Helper
{
    public static class SquareFormulas
    {
        public static double GetArea(double side)
        {
            return side * side;
        }
        public static double GetDiagonal(double side)
        {
            return Math.Round(side * Math.Sqrt(2), 4);
        }
        public static double GetPerimeter(double side)
        {
            return 4 * side;
        }
    }
}

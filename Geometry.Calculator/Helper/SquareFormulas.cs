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
    public static class SquareFormulas
    {
        public static double GetArea(double side)
        {
            return Math.Round(side * side, 4);
        }
        public static double GetDiagonal(double side)
        {
            return Math.Round(side * Math.Sqrt(2), 4);
        }
        public static double GetPerimeter(double side)
        {
            return Math.Round(4 * side, 4);
        }
        public static double GetSide(SquareCalculationType squareCalculationType, double value)
        {
            switch (squareCalculationType)
            {
                case SquareCalculationType.Side:
                    return value;
                case SquareCalculationType.Area:
                    return Math.Round(Math.Sqrt(value), 4);
                case SquareCalculationType.Diagonal:
                    return Math.Round(value / Math.Sqrt(2), 4);
                case SquareCalculationType.Perimeter:
                    return Math.Round(value / 4, 4);
                default:
                    throw new Exception("Unknown Calculation Type!");
            }      
        }

    }
}

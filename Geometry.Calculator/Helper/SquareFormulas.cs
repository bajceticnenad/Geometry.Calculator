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
            double side;

            try
            {
                switch (squareCalculationType)
                {
                    case SquareCalculationType.Side:
                        side = value;
                        break;
                    case SquareCalculationType.Area:
                        side = Math.Sqrt(value);
                        break;
                    case SquareCalculationType.Diagonal:
                        side = value / Math.Sqrt(2);
                        break;
                    case SquareCalculationType.Perimeter:
                        side = value / 4;
                        break;
                    default:
                        throw new Exception("Unknown Calculation Type!");
                }
            }
            catch
            {
                throw;            
            }

                return Math.Round(side, 4);
        }

    }
}

using Geometry.Calculator.Enums;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Calculator.Helper
{
    public static class RectangleFormulas
    {
        public static double GetArea(double width, double length)
        {
            try
            {
                return Math.Round(width * length, 4);
            }
            catch
            {
                throw;
            }
        }
        public static double GetDiagonal(double width, double length)
        {
            try
            {
                return Math.Round(Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2)), 4);
            }
            catch
            {
                throw;
            }
        }
        public static double GetPerimeter(double width, double length)
        {
            try
            {
                return Math.Round(2 * width + 2 * length, 4);
            }
            catch
            {
                throw;
            }
        }
        public static double GetWidth(RectangleCalculationType rectangleCalculationType, double a, double b)
        {
            try
            {
                switch (rectangleCalculationType)
                {
                    case RectangleCalculationType.BothSides:
                        return a > b ? b : a;
                    case RectangleCalculationType.SideAndArea:
                        var side = GetSideFromArea(a, b);
                        return a > side ? side : a;
                    case RectangleCalculationType.SideAndDiagonal:
                        var sideD = GetSideFromDiagonal(a, b);
                        return a > sideD ? sideD : a;
                    case RectangleCalculationType.SideAndPerimeter:
                        var sideP = GetSideFromPerimeter(a, b);
                        return a > sideP ? sideP : a;
                    default:
                        throw new Exception("Unknown Calculation Type!");
                }
            }
            catch
            {
                throw;
            }
        }
        public static double GetLength(RectangleCalculationType rectangleCalculationType, double a, double b)
        {
            try
            {
                switch (rectangleCalculationType)
                {
                    case RectangleCalculationType.BothSides:
                        return a > b ? a : b;
                    case RectangleCalculationType.SideAndArea:
                        var side = GetSideFromArea(a, b);
                        return a > side ? a : side;
                    case RectangleCalculationType.SideAndDiagonal:
                        var sideD = GetSideFromDiagonal(a, b);
                        return a > sideD ? a : sideD;
                    case RectangleCalculationType.SideAndPerimeter:
                        var sideP = GetSideFromPerimeter(a, b);
                        return a > sideP ? a : sideP;
                    default:
                        throw new Exception("Unknown Calculation Type!");
                }
            }
            catch
            {
                throw;
            }
        }

        private static double GetSideFromArea(double side, double area)
        {
            return area / side;
        }
        private static double GetSideFromPerimeter(double side, double perimeter)
        {
            return (perimeter / 2) - side;
        }
        private static double GetSideFromDiagonal(double side, double perimeter)
        {
            return Math.Round(Math.Sqrt(Math.Pow(perimeter, 2) - Math.Pow(side, 2)), 4);
        }
    }
}

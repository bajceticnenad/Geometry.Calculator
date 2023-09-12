using Geometry.Calculator.Enums;

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
            double width;
            try
            {
                switch (rectangleCalculationType)
                {
                    case RectangleCalculationType.BothSides:
                        width = a > b ? b : a;
                        break;
                    case RectangleCalculationType.SideAndArea:
                        var side = GetSideFromArea(a, b);
                        width = a > side ? side : a;
                        break;
                    case RectangleCalculationType.SideAndDiagonal:
                        var sideD = GetSideFromDiagonal(a, b);
                        width = a > sideD ? sideD : a;
                        break;
                    case RectangleCalculationType.SideAndPerimeter:
                        var sideP = GetSideFromPerimeter(a, b);
                        width = a > sideP ? sideP : a;
                        break;
                    default:
                        throw new Exception("Unknown Calculation Type!");
                }
            }
            catch
            {
                throw;
            }

            return Math.Round(width, 4);
        }
        public static double GetLength(RectangleCalculationType rectangleCalculationType, double a, double b)
        {
            double length;
            try
            {
                switch (rectangleCalculationType)
                {
                    case RectangleCalculationType.BothSides:
                        length = a > b ? a : b;
                        break;
                    case RectangleCalculationType.SideAndArea:
                        var side = GetSideFromArea(a, b);
                        length = a > side ? a : side;
                        break;
                    case RectangleCalculationType.SideAndDiagonal:
                        var sideD = GetSideFromDiagonal(a, b);
                        length = a > sideD ? a : sideD;
                        break;
                    case RectangleCalculationType.SideAndPerimeter:
                        var sideP = GetSideFromPerimeter(a, b);
                        length = a > sideP ? a : sideP;
                        break;
                    default:
                        throw new Exception("Unknown Calculation Type!");
                }
            }
            catch
            {
                throw;
            }

            return Math.Round(length, 4);
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

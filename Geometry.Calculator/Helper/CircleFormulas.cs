using Geometry.Calculator.Enums;

namespace Geometry.Calculator.Helper
{
    public static class CircleFormulas
    {
        public static double GetArea(CircleCalculationType circleCalculationType, double value)
        {
            double result;

            try
            {
                switch (circleCalculationType)
                {
                    case CircleCalculationType.Area:
                        result = value;
                        break;
                    case CircleCalculationType.Radius:
                        result = Math.PI * Math.Pow(value, 2);
                        break;
                    case CircleCalculationType.Circumference:
                        result = Math.Pow(value, 2) / (4 * Math.PI);
                        break;
                    case CircleCalculationType.Diameter:
                        result = Math.PI * Math.Pow(value / 2, 2);
                        break;
                    default:
                        throw new Exception("Unknown Calculation Type!");
                }
            }
            catch
            {
                throw;
            }

            return Math.Round(result, 4);
        }
        public static double GetCircumference(CircleCalculationType circleCalculationType, double value)
        {
            double result;

            try
            {
                switch (circleCalculationType)
                {
                    case CircleCalculationType.Area:
                        result = 2 * Math.Sqrt(value * Math.PI);
                        break;
                    case CircleCalculationType.Radius:
                        result = 2 * Math.PI * value;
                        break;
                    case CircleCalculationType.Circumference:
                        result = value;
                        break;
                    case CircleCalculationType.Diameter:
                        result = Math.PI * value;
                        break;
                    default:
                        throw new Exception("Unknown Calculation Type!");
                }
            }
            catch
            {
                throw;
            }

            return Math.Round(result, 4);
        }
        public static double GetDiametar(CircleCalculationType circleCalculationType, double value)
        {
            double result;

            try
            {
                switch (circleCalculationType)
                {
                    case CircleCalculationType.Area:
                        result = 2 * Math.Sqrt(value / Math.PI);
                        break;
                    case CircleCalculationType.Radius:
                        result = 2 * value;
                        break;
                    case CircleCalculationType.Circumference:
                        result = value / Math.PI;
                        break;
                    case CircleCalculationType.Diameter:
                        result = value;
                        break;
                    default:
                        throw new Exception("Unknown Calculation Type!");
                }
            }
            catch
            {
                throw;
            }

            return Math.Round(result, 4);
        }

        public static double GetRadius(CircleCalculationType circleCalculationType, double value)
        {
            double result;

            try
            {
                switch (circleCalculationType)
                {
                    case CircleCalculationType.Area:
                        result = Math.Sqrt(value / Math.PI);
                        break;
                    case CircleCalculationType.Radius:
                        result = value;
                        break;
                    case CircleCalculationType.Circumference:
                        result = value / (2 * Math.PI);
                        break;
                    case CircleCalculationType.Diameter:
                        result = value / 2;
                        break;
                    default:
                        throw new Exception("Unknown Calculation Type!");
                }
            }
            catch
            {
                throw;
            }

            return Math.Round(result, 4);
        }
    }
}

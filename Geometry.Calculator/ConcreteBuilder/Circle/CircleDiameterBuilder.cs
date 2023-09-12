using Geometry.Calculator.Builder;
using Geometry.Calculator.Product;

namespace Geometry.Calculator.ConcreteBuilder.Square
{
    public class CircleDiameterBuilder : ICircleBuilder
    {
        #region "PrivateFields"
        CircleProduct circle = new CircleProduct();
        #endregion "PrivateFields"

        #region "PublicMethods"
        public CircleProduct GetCircle()
        {
            return circle;
        }

        public void SetArea(double value)
        {
            try
            {
                circle.Area = Math.Round(Math.PI * Math.Pow(value / 2, 2), 4);
            }
            catch
            {
                throw;
            }
        }

        public void SetCircumference(double value)
        {
            try
            {
                circle.Circumference = Math.Round(Math.PI * value, 4);
            }
            catch
            {
                throw;
            }
        }

        public void SetDiameter(double value)
        {

            try
            {
                circle.Diameter = Math.Round(value);
            }
            catch
            {
                throw;
            }
        }

        public void SetRadius(double value)
        {
            try
            {
                circle.Radius = Math.Round(value / 2, 4);
            }
            catch
            {
                throw;
            }
        }
        #endregion "PublicMethods"

    }
}

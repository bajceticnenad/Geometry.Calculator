using Geometry.Calculator.Builder;
using Geometry.Calculator.Helper;
using Geometry.Calculator.Product;

namespace Geometry.Calculator.ConcreteBuilder.Square
{
    public class SemicircleDiameterBuilder : ISemicircleBuilder
    {
        #region "PrivateFields"
        SemicircleProduct semicircle = new SemicircleProduct();
        #endregion "PrivateFields"

        #region "PublicMethods"
        public SemicircleProduct GetSemicircle()
        {
            return semicircle;
        }

        public void SetArea(double value)
        {
            try
            {
                semicircle.Area = Math.Round(SemicircleFormulas.GetArea(value / 2), 4);
            }
            catch
            {
                throw;
            }
        }

        public void SetPerimeter(double value)
        {
            try
            {
                semicircle.Perimeter = Math.Round(SemicircleFormulas.GetPerimeter(value / 2), 4);
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
                try
                {
                    semicircle.Diameter = Math.Round(value, 4);
                }
                catch
                {
                    throw;
                }
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
                semicircle.Radius = Math.Round(Math.Sqrt(value / 2), 4);
            }
            catch
            {
                throw;
            }
        }
        #endregion "PublicMethods"

    }
}

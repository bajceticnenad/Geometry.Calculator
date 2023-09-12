using Geometry.Calculator.Builder;
using Geometry.Calculator.Helper;
using Geometry.Calculator.Product;

namespace Geometry.Calculator.ConcreteBuilder.Square
{
    public class SemicirclePerimeterBuilder : ISemicircleBuilder
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
                if (semicircle.Radius == null || semicircle.Radius == 0)
                {
                    SetRadius(value);
                }
                semicircle.Area = Math.Round(SemicircleFormulas.GetArea(semicircle.Radius), 4);
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
                semicircle.Perimeter = Math.Round(value, 4);
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
                    if (semicircle.Radius == null || semicircle.Radius == 0)
                    {
                        SetRadius(value);
                    }
                    semicircle.Diameter = Math.Round(SemicircleFormulas.GetDiametar(semicircle.Radius), 4);
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
                semicircle.Radius = Math.Round(value / (Math.PI + 2), 4);
            }
            catch
            {
                throw;
            }
        }
        #endregion "PublicMethods"

    }
}

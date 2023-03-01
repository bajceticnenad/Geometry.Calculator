using Geometry.Calculator.Builder;
using Geometry.Calculator.Enums;
using Geometry.Calculator.Helper;
using Geometry.Calculator.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Calculator.ConcreteBuilder.Square
{
    public class SemicircleAreaBuilder : ISemicircleBuilder
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
                semicircle.Area = Math.Round(value, 4);
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
                if (semicircle.Radius == null || semicircle.Radius == 0)
                {
                    SetRadius(value);
                }
                semicircle.Perimeter = Math.Round(SemicircleFormulas.GetPerimeter(semicircle.Radius), 4);
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
                semicircle.Radius = Math.Round(Math.Sqrt(2 * value / Math.PI), 4);
            }
            catch
            {
                throw;
            }
        }
        #endregion "PublicMethods"

    }
}

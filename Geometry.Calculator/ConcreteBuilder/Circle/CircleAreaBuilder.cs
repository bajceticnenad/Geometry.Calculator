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
    public class CircleAreaBuilder : ICircleBuilder
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
                circle.Area = Math.Round(value, 4);
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
                circle.Circumference = Math.Round(2 * Math.Sqrt(value * Math.PI), 4);
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
                    circle.Diameter = Math.Round(2 * Math.Sqrt(value / Math.PI), 4);
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
                circle.Radius = Math.Round(Math.Sqrt(value / Math.PI), 4);
            }
            catch
            {
                throw;
            }
        }
        #endregion "PublicMethods"

    }
}

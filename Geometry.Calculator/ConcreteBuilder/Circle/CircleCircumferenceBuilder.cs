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
    public class CircleCircumferenceBuilder : ICircleBuilder
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
                circle.Area = Math.Round(Math.Pow(value, 2) / (4 * Math.PI), 4);
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
                circle.Circumference = Math.Round(value, 4);
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
                circle.Diameter = Math.Round(value / Math.PI, 4);
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
                circle.Radius = Math.Round(value / (2 * Math.PI), 4);
            }
            catch
            {
                throw;
            }
        }
        #endregion "PublicMethods"

    }
}

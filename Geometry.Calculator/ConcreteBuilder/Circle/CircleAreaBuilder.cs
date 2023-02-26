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
            circle.Area = CircleFormulas.GetArea(CircleCalculationType.Area, value);
        }

        public void SetCircumference(double value)
        {
            circle.Circumference = CircleFormulas.GetCircumference(CircleCalculationType.Area, value);
        }

        public void SetDiameter(double value)
        {
            circle.Diameter = CircleFormulas.GetDiametar(CircleCalculationType.Area, value);
        }

        public void SetRadius(double value)
        {

            circle.Radius = CircleFormulas.GetRadius(CircleCalculationType.Area, value);
        }
        #endregion "PublicMethods"

    }
}

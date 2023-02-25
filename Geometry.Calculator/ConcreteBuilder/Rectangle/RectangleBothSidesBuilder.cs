using Geometry.Calculator.Builder;
using Geometry.Calculator.Enums;
using Geometry.Calculator.Helper;
using Geometry.Calculator.Product;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Calculator.ConcreteBuilder.Rectangle
{
    public class RectangleBothSidesBuilder : IRectangleBuilder
    {
        #region "PrivateFields"
        RectangleProduct rectangle = new RectangleProduct();
        #endregion "PrivateFields"

        #region "PublicMethods"
        public RectangleProduct GetRectangle()
        {
            return rectangle;
        }

        public void SetArea(double side, double otherValue)
        {
            try
            {
                rectangle.Area = RectangleFormulas.GetArea(side, otherValue);
            }
            catch
            {
                throw;
            }
        }

        public void SetDiagonal(double side, double otherValue)
        {
            try
            {
                rectangle.Diagonal = RectangleFormulas.GetDiagonal(side, otherValue);
            }
            catch
            {
                throw;
            }
        }

        public void SetLength(double side, double otherValue)
        {
            try
            {
                rectangle.Length = RectangleFormulas.GetLength(RectangleCalculationType.BothSides, side, otherValue);
            }
            catch
            {
                throw;
            }
        }

        public void SetPerimeter(double side, double otherValue)
        {
            try
            {
                rectangle.Perimeter = RectangleFormulas.GetPerimeter(side, otherValue);
            }
            catch
            {
                throw;
            }
        }

        public void SetWidth(double side, double otherValue)
        {
            try
            {
                rectangle.Width = RectangleFormulas.GetWidth(RectangleCalculationType.BothSides, side, otherValue);
            }
            catch
            {
                throw;
            }
        }
        #endregion "PublicMethods"

    }
}

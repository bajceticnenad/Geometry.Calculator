﻿using Geometry.Calculator.Builder;
using Geometry.Calculator.Enums;
using Geometry.Calculator.Helper;
using Geometry.Calculator.Product;

namespace Geometry.Calculator.ConcreteBuilder.Rectangle
{
    public class RectangleSideAndDiagonalBuilder : IRectangleBuilder
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
                if (rectangle.Width == null || rectangle.Width == 0)
                {
                    rectangle.Width = RectangleFormulas.GetWidth(RectangleCalculationType.SideAndDiagonal, side, otherValue);
                }
                if (rectangle.Length == null || rectangle.Length == 0)
                {
                    rectangle.Length = RectangleFormulas.GetLength(RectangleCalculationType.SideAndDiagonal, side, otherValue);
                }
                rectangle.Area = RectangleFormulas.GetArea(rectangle.Width, rectangle.Length);
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
                rectangle.Diagonal = Math.Round(otherValue, 4);
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
                if (rectangle.Width == null || rectangle.Width == 0)
                {
                    rectangle.Width = RectangleFormulas.GetWidth(RectangleCalculationType.SideAndDiagonal, side, otherValue);
                }
                if (rectangle.Length == null || rectangle.Length == 0)
                {
                    rectangle.Length = RectangleFormulas.GetLength(RectangleCalculationType.SideAndDiagonal, side, otherValue);
                }
                rectangle.Perimeter = RectangleFormulas.GetPerimeter(rectangle.Width, rectangle.Length);
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
                if (rectangle.Length == null || rectangle.Length == 0)
                {
                    rectangle.Length = RectangleFormulas.GetLength(RectangleCalculationType.SideAndDiagonal, side, otherValue);
                }
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
                if (rectangle.Width == null || rectangle.Width == 0)
                {
                    rectangle.Width = RectangleFormulas.GetWidth(RectangleCalculationType.SideAndDiagonal, side, otherValue);
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion "PublicMethods"

    }
}

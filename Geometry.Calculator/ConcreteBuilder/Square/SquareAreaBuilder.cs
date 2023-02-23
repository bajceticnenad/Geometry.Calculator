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
    public class SquareAreaBuilder : ISquareBuilder
    {
        #region "PrivateFields"
        SquareProduct square = new SquareProduct();
        #endregion "PrivateFields"

        #region "PublicMethods"

        public SquareProduct GetSquare()
        {
            return square;
        }

        public void SetArea(double value)
        {
            try
            {
                square.Area = value;
            }
            catch
            {
                throw;
            }
        }

        public void SetDiagonal(double value)
        {
            try
            {
                if (square.Side == null || square.Side == 0)
                {
                    SetSide(value);
                }
                square.Diagonal = SquareFormulas.GetDiagonal(square.Side);
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
                if (square.Side == null || square.Side == 0)
                {
                    SetSide(value);
                }
                square.Perimeter = SquareFormulas.GetPerimeter(square.Side);
            }
            catch
            {
                throw;
            }
        }

        public void SetSide(double value)
        {
            try
            {
                if (value == null)
                {
                    throw new Exception("Value a can not be null!");
                }
                if (square.Side == null || square.Side == 0)
                {
                    square.Side = SquareFormulas.GetSide(SquareCalculationType.Area, value);
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

using Geometry.Calculator.Builder;
using Geometry.Calculator.Enums;
using Geometry.Calculator.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Calculator.ConcreteBuilder.Square
{
    public class SquareSideBuilder : ISquareBuilder
    {
        #region "PrivateFields"
        SquareProduct square = new SquareProduct();

        //private readonly double _side;
        #endregion "PrivateFields"

        #region "PublicConstructor"
        //public SquareSideBuilder(double side)
        //{
        //    _side = side;
        //}
        #endregion "PublicConstructor"

        #region "PublicMethods"

        public SquareProduct GetSquare()
        {
            return square;
        }

        public void SetArea(double value)
        {
            try
            {
                if (value == null)
                {
                    throw new Exception("Value a can not be null!");
                }
                square.Area = value * value;
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
                if (value == null)
                {
                    throw new Exception("Value a can not be null!");
                }
                square.Diagonal = Math.Round(value * Math.Sqrt(2), 4);
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
                if (value == null)
                {
                    throw new Exception("Value a can not be null!");
                }
                square.Perimeter = 4 * value;
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
                square.Side = 4 * value;
            }
            catch
            {
                throw;
            }
        }
        #endregion "PublicMethods"

    }
}

using Geometry.Calculator.Builder;
using Geometry.Calculator.Enums;
using Geometry.Calculator.Helper;
using Geometry.Calculator.Product;

namespace Geometry.Calculator.ConcreteBuilder.Square
{
    public class SquareDiagonalBuilder : ISquareBuilder
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
                if (square.Side == null || square.Side == 0)
                {
                    SetSide(value);
                }
                square.Area = SquareFormulas.GetArea(square.Side);
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
                square.Diagonal = Math.Round(value, 4);
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
                if (square.Side == null || square.Side == 0)
                {
                    square.Side = SquareFormulas.GetSide(SquareCalculationType.Diagonal, value);
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

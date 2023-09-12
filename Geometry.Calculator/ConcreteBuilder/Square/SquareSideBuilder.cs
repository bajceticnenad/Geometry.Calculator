using Geometry.Calculator.Builder;
using Geometry.Calculator.Helper;
using Geometry.Calculator.Product;

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
                square.Area = SquareFormulas.GetArea(value);
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
                square.Diagonal = SquareFormulas.GetDiagonal(value);
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
                square.Perimeter = SquareFormulas.GetPerimeter(value);
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
                square.Side = Math.Round(value, 4);
            }
            catch
            {
                throw;
            }
        }
        #endregion "PublicMethods"

    }
}

using Geometry.Calculator.Builder;
using Geometry.Calculator.Product;

namespace Geometry.Calculator.Creator
{
    public class SquareCreator
    {
        #region "PrivateFields"
        private ISquareBuilder _squareBuilder;
        private readonly double _value;
        #endregion "PrivateFields"

        #region "PublicConstructor"
        public SquareCreator(ISquareBuilder squareBuilder, double value)
        {
            _squareBuilder = squareBuilder;
            _value = value;
        }
        #endregion "PublicConstructor"

        #region "PublicMethods"
        public void CreateSquare()
        {
            _squareBuilder.SetArea(_value);
            _squareBuilder.SetDiagonal(_value);
            _squareBuilder.SetSide(_value);
            _squareBuilder.SetPerimeter(_value);
        }
        public SquareProduct GetSquare()
        {
            return _squareBuilder.GetSquare();
        }
        #endregion "PublicMethods"
    }
}

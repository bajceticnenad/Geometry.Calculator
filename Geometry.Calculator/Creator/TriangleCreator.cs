using Geometry.Calculator.Builder;
using Geometry.Calculator.Product;

namespace Geometry.Calculator.Creator
{
    public class TriangleCreatorWithOneInputParam
    {
        #region "PrivateFields"
        private ITriangleBuilder _triangleBuilder;
        private readonly double _value;
        #endregion "PrivateFields"

        #region "PublicConstructor"
        public TriangleCreatorWithOneInputParam(ITriangleBuilder triangleBuilder, double value)
        {
            _triangleBuilder = triangleBuilder;
            _value = value;
        }
        #endregion "PublicConstructor"

        #region "PublicMethods"
        public void CreateSquare()
        {
            _triangleBuilder.SetShorterLeg(_value);
            _triangleBuilder.SetLongerLeg(_value);
            _triangleBuilder.SetHypotenuse(_value);
            _triangleBuilder.SetArea(_value);
            _triangleBuilder.SetPerimeter(_value);
        }
        public TriangleProduct GetTriangle()
        {
            return _triangleBuilder.GetTriangle();
        }
        #endregion "PublicMethods"
    }
}

using Geometry.Calculator.Enums;

namespace Geometry.Calculator.Product.ConcreteProducts
{
    /// <summary>  
    /// Square - A 'ConcreteProduct' class  
    /// </summary>  
    class SquareShape : ShapeProduct
    {

        #region "PrivateFields"
        private readonly Shape _shape;
        private readonly double _a;
        #endregion "PrivateFields"

        #region "PublicConstructor"
        public SquareShape(double a)
        {
            _shape = Shape.Square;
            _a = a;
        }
        #endregion "PublicConstructor"

        #region "PublicProperties"
        public override Shape Shape
        {
            get { return _shape; }
        }
        #endregion "PublicProperties"

        #region "PublicMethods"
        public override double Area()
        {
            try
            {
                if (_a == null)
                {
                    throw new Exception("Value a can not be null!");
                }
                return _a * _a;
            }
            catch
            {
                throw;
            }
        }

        public override double Perimeter()
        {
            try
            {
                if (_a == null)
                {
                    throw new Exception("Value a can not be null!");
                }
                return 4 * _a;
            }
            catch
            {
                throw;
            }
        }

        public override double? Diagonal()
        {
            try
            {
                if (_a == null)
                {
                    throw new Exception("Value a can not be null!");
                }
                return Math.Round(_a * Math.Sqrt(2), 4);
            }
            catch
            {
                throw;
            }
        }
        #endregion "PublicMethods"

    }
}

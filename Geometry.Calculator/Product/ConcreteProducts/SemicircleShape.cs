using Geometry.Calculator.Enums;

namespace Geometry.Calculator.Product.ConcreteProducts
{
    /// <summary>  
    /// Semicircle - A 'ConcreteProduct' class  
    /// </summary>  
    class SemicircleShape : ShapeProduct
    {

        #region "PrivateFields"
        private readonly Shape _shape;
        private readonly double _r;
        #endregion "PrivateFields"

        #region "PublicConstructor"
        public SemicircleShape(double r)
        {
            _shape = Shape.Semicircle;
            _r = r;
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
                if (_r == null)
                {
                    throw new Exception("Value a can not be null!");
                }
                return Math.PI * Math.Pow(_r, 2) / 2;
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
                if (_r == null)
                {
                    throw new Exception("Value a can not be null!");
                }
                var d = Diametar();
                return Math.PI * _r + d ?? 0;
            }
            catch
            {
                throw;
            }
        }

        public override double? Diametar()
        {
            try
            {
                if (_r == null)
                {
                    throw new Exception("Value a can not be null!");
                }
                return 2 * _r;
            }
            catch
            {
                throw;
            }
        }
        #endregion "PublicMethods"

    }
}

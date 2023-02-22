using Geometry.Calculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Calculator.Product.ConcreteProducts
{
    /// <summary>  
    /// Rectangle - A 'ConcreteProduct' class  
    /// </summary>  
    class RectangleShape : ShapeProduct
    {
        #region "PrivateFields"
        private readonly Shape _shape;
        private readonly double _a;
        private readonly double _b;
        #endregion "PrivateFields"

        #region "PublicConstructor"
        public RectangleShape(double a, double b)
        {
            _shape = Shape.Rectangle;
            _a = a;
            _b = b;
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
                return _a * _b;
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
                return 2 * _a + 2 * _b;
            }
            catch
            {
                throw;
            }
        }

        //d = √(a² + b²)
        public override double? Diagonal()
        {
            try
            {
                if (_a == null)
                {
                    throw new Exception("Value a can not be null!");
                }
                return Math.Round(Math.Sqrt( Math.Pow(_a, 2) + Math.Pow(_b, 2) ), 4);
            }
            catch
            {
                throw;
            }
        }
        #endregion "PublicMethods"

    }
}

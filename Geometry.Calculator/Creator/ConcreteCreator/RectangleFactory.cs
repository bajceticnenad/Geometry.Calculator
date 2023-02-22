using Geometry.Calculator.Product;
using Geometry.Calculator.Product.ConcreteProducts;
using System.Drawing;

namespace Geometry.Calculator.Creator.ConcreteCreator
{
    /// <summary>  
    /// A 'ConcreteCreator' class  
    /// </summary>  
    class RectangleFactory : ShapeFactory
    {
        private double _a;
        private double _b;

        public RectangleFactory(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public override ShapeProduct GetGeometryShape()
        {
            try
            {
                return new RectangleShape(_a, _b);
            }
            catch
            {
                throw;
            }
        }
    }
}

using Geometry.Calculator.Product;
using Geometry.Calculator.Product.ConcreteProducts;
using System.Drawing;

namespace Geometry.Calculator.Creator.ConcreteCreator
{
    /// <summary>  
    /// A 'ConcreteCreator' class  
    /// </summary>  
    class CircleFactory : ShapeFactory
    {
        private double _r;

        public CircleFactory(double r)
        {
            _r = r;
        }

        public override ShapeProduct GetGeometryShape()
        {
            try
            {
                return new CircleShape(_r);
            }
            catch
            {
                throw;
            }
        }
    }
}

using Geometry.Calculator.Product;
using Geometry.Calculator.Product.ConcreteProducts;
using System.Drawing;

namespace Geometry.Calculator.Creator.ConcreteCreator
{
    /// <summary>  
    /// A 'ConcreteCreator' class  
    /// </summary>  
    class SemicircleFactory : ShapeFactory
    {
        private double _r;

        public SemicircleFactory(double r)
        {
            _r = r;
        }

        public override ShapeProduct GetGeometryShape()
        {
            try
            {
                return new SemicircleShape(_r);
            }
            catch
            {
                throw;
            }
        }
    }
}

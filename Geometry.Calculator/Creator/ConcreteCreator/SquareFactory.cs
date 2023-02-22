using Geometry.Calculator.Product;
using Geometry.Calculator.Product.ConcreteProducts;
using System.Drawing;

namespace Geometry.Calculator.Creator.ConcreteCreator
{
    /// <summary>  
    /// A 'ConcreteCreator' class  
    /// </summary>  
    class SquareFactory : ShapeFactory
    {
        private double _a;

        public SquareFactory(double a)
        {
            _a = a;
        }

        public override ShapeProduct GetGeometryShape()
        {
            try
            {
                return new SquareShape(_a);
            }
            catch
            {
                throw;
            }
        }
    }
}

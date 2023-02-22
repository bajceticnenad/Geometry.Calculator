using Geometry.Calculator.Product;

namespace Geometry.Calculator.Creator
{
    /// <summary>  
    /// The 'Creator' Abstract Class  
    /// </summary>  
    abstract class ShapeFactory
    {
        public abstract ShapeProduct GetGeometryShape();
    }
}

using Geometry.Calculator.Enums;

namespace Geometry.Calculator.Product
{
    /// <summary>  
    /// GeometryShape - The 'Product' Abstract Class  
    /// </summary>  
    public abstract class ShapeProduct
    {
        public abstract Shape Shape { get; }

        public abstract double Area();
        public abstract double Perimeter();
        public virtual double? Diagonal()
        {
            return null;
        }
        public virtual double? Diametar()
        {
            return null;
        }
    }
}

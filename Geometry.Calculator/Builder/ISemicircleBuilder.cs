using Geometry.Calculator.Product;

namespace Geometry.Calculator.Builder
{
    public interface ISemicircleBuilder
    {
        void SetRadius(double value);
        void SetArea(double value);
        void SetPerimeter(double value);
        void SetDiameter(double value);
        SemicircleProduct GetSemicircle();
    }
}

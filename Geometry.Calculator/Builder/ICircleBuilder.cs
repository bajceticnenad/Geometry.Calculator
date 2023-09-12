using Geometry.Calculator.Product;

namespace Geometry.Calculator.Builder
{
    public interface ICircleBuilder
    {
        void SetRadius(double value);
        void SetArea(double value);
        void SetCircumference(double value);
        void SetDiameter(double value);
        CircleProduct GetCircle();
    }
}

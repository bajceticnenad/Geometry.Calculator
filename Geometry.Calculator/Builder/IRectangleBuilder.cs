using Geometry.Calculator.Product;

namespace Geometry.Calculator.Builder
{
    public interface IRectangleBuilder
    {
        void SetLength(double side, double otherValue);
        void SetWidth(double side, double otherValue);
        void SetArea(double side, double otherValue);
        void SetPerimeter(double side, double otherValue);
        void SetDiagonal(double side, double otherValue);
        RectangleProduct GetRectangle();
    }
}

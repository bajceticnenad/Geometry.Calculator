using Geometry.Calculator.Product;

namespace Geometry.Calculator.Builder
{
    public interface ISquareBuilder
    {
        void SetSide(double value);
        void SetArea(double value);
        void SetPerimeter(double value);
        void SetDiagonal(double value);
        SquareProduct GetSquare();
    }
}

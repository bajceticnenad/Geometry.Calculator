using Geometry.Calculator.Product;

namespace Geometry.Calculator.Builder
{
    public interface ITriangleBuilder
    {
        void SetShorterLeg(double value);
        void SetLongerLeg(double value);
        void SetHypotenuse(double value);
        void SetArea(double value);
        void SetPerimeter(double value);
        void SetAlphaAngle(double value);
        void SetBetaAngle(double value);
        TriangleProduct GetTriangle();
    }
}

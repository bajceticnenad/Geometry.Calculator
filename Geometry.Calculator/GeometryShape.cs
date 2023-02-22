using Geometry.Calculator.Creator.ConcreteCreator;
using Geometry.Calculator.Product;

namespace Geometry.Calculator
{
    public static class GeometryShape
    {
        public static ShapeProduct GetSquare(double a)
        {
            return new SquareFactory(a).GetGeometryShape();
        }

        public static ShapeProduct GetRectangle(double a, double b)
        {
            return new RectangleFactory(a, b).GetGeometryShape();
        }

        public static ShapeProduct GetCircle(double r)
        {
            return new CircleFactory(r).GetGeometryShape();
        }

        public static ShapeProduct GetSemicircle(double r)
        {
            return new SemicircleFactory(r).GetGeometryShape();
        }
    }
}

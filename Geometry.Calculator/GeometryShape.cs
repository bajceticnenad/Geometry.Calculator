using Geometry.Calculator.ConcreteBuilder.Square;
using Geometry.Calculator.Creator;
using Geometry.Calculator.Enums;
using Geometry.Calculator.Product;
using Newtonsoft.Json.Linq;

namespace Geometry.Calculator
{
    public static class GeometryShape
    {
        public static SquareProduct GetSquare(SquareCalculationType squareCalculationType, double value)
        {
            switch (squareCalculationType)
            {
                case SquareCalculationType.Side:
                    var squareSideCreator = new SquareCreator(new SquareSideBuilder(), value);
                    squareSideCreator.CreateSquare();
                    return squareSideCreator.GetSquare();
                case SquareCalculationType.Area:
                    var squareAreaCreator = new SquareCreator(new SquareAreaBuilder(), value);
                    squareAreaCreator.CreateSquare();
                    return squareAreaCreator.GetSquare();
                case SquareCalculationType.Diagonal:
                    var squareDiagonalCreator = new SquareCreator(new SquareDiagonalBuilder(), value);
                    squareDiagonalCreator.CreateSquare();
                    return squareDiagonalCreator.GetSquare();
                case SquareCalculationType.Perimeter:
                    var squarePerimeterCreator = new SquareCreator(new SquarePerimeterBuilder(), value);
                    squarePerimeterCreator.CreateSquare();
                    return squarePerimeterCreator.GetSquare();
                default:
                    throw new Exception("Unknown Shape!");
            }
        }

        //public static ShapeProduct GetRectangle(double a, double b)
        //{
        //    return new RectangleFactory(a, b).GetGeometryShape();
        //}

        //public static ShapeProduct GetCircle(double r)
        //{
        //    return new CircleFactory(r).GetGeometryShape();
        //}

        //public static ShapeProduct GetSemicircle(double r)
        //{
        //    return new SemicircleFactory(r).GetGeometryShape();
        //}
    }
}

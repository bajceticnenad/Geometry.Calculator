using Geometry.Calculator.ConcreteBuilder.Rectangle;
using Geometry.Calculator.ConcreteBuilder.Square;
using Geometry.Calculator.Creator;
using Geometry.Calculator.Enums;
using Geometry.Calculator.Helper;
using Geometry.Calculator.Product;
using Newtonsoft.Json.Linq;

namespace Geometry.Calculator
{
    public static class GeometryShape
    {
        public static SquareProduct GetSquare(SquareCalculationType squareCalculationType, double value)
        {
            try
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
                        throw new Exception("Unknown Calculation Type!");
                }
            }
            catch
            {
                throw;
            }
        }

        public static RectangleProduct GetRectangle(RectangleCalculationType rectangleCalculationType, double side, double otherValue)
        {
            try
            {
                switch (rectangleCalculationType)
                {
                    case RectangleCalculationType.BothSides:
                        var rectangleBothSidesCreator = new RectangleCreator(new RectangleBothSidesBuilder(), side, otherValue);
                        rectangleBothSidesCreator.CreateRectangle();
                        return rectangleBothSidesCreator.GetRectangle();
                    case RectangleCalculationType.SideAndArea:
                        var rectangleSideAndAreaCreator = new RectangleCreator(new RectangleSideAndAreaBuilder(), side, otherValue);
                        rectangleSideAndAreaCreator.CreateRectangle();
                        return rectangleSideAndAreaCreator.GetRectangle();
                    case RectangleCalculationType.SideAndDiagonal:
                        var rectangleSideAndDiagonalCreator = new RectangleCreator(new RectangleSideAndDiagonalBuilder(), side, otherValue);
                        rectangleSideAndDiagonalCreator.CreateRectangle();
                        return rectangleSideAndDiagonalCreator.GetRectangle();
                    case RectangleCalculationType.SideAndPerimeter:
                        var rectangleSideAndPerimeterCreator = new RectangleCreator(new RectangleSideAndPerimeterBuilder(), side, otherValue);
                        rectangleSideAndPerimeterCreator.CreateRectangle();
                        return rectangleSideAndPerimeterCreator.GetRectangle();
                    default:
                        throw new Exception("Unknown Calculation Type!");
                }
            }
            catch
            {
                throw;
            }
        }

        public static CircleProduct GetCircle(CircleCalculationType circleCalculationType, double value)
        {
            try
            {
                switch (circleCalculationType)
                {
                    case CircleCalculationType.Radius:
                        var circleRadiusCreator = new CircleCreator(new CircleRadiusBuilder(), value);
                        circleRadiusCreator.CreateCircle();
                        return circleRadiusCreator.GetCircle();
                    case CircleCalculationType.Area:
                        var circleAreaCreator = new CircleCreator(new CircleAreaBuilder(), value);
                        circleAreaCreator.CreateCircle();
                        return circleAreaCreator.GetCircle();
                    case CircleCalculationType.Circumference:
                        var circleCircumferenceCreator = new CircleCreator(new CircleCircumferenceBuilder(), value);
                        circleCircumferenceCreator.CreateCircle();
                        return circleCircumferenceCreator.GetCircle();
                    case CircleCalculationType.Diameter:
                        var circleDiameterCreator = new CircleCreator(new CircleDiameterBuilder(), value);
                        circleDiameterCreator.CreateCircle();
                        return circleDiameterCreator.GetCircle();
                    default:
                        throw new Exception("Unknown Calculation Type!");
                }
            }
            catch
            {
                throw;
            }
        }

        //public static ShapeProduct GetSemicircle(double r)
        //{
        //    return new SemicircleFactory(r).GetGeometryShape();
        //}
    }
}

# Geometry.Calculator
#### Nuget (C# library) for Geometry shapes calculator: Area, Perimeter, Angles, Diagonal , Sides, etc...
- 2D shapes: Square, Rectangle, Triangle, Circle, Semicircle, Sector, Ellipse, Trapezoid, Parallelogram, Rhombus 
- 3D shapes: Cube, Pyramid, Sphere,Rectangular, Cylinder, Cone

## Example

```csharp
            //square Side
            var side = GeometryShape.GetSquare(Geometry.Calculator.Enums.SquareCalculationType.Side, 4);

            //square Area
            var area = GeometryShape.GetSquare(Geometry.Calculator.Enums.SquareCalculationType.Area, 16);
   
            //square Perimeter
            var perimeter = GeometryShape.GetSquare(Geometry.Calculator.Enums.SquareCalculationType.Perimeter, 16);

            //square Diagonal
            var diagonal = GeometryShape.GetSquare(Geometry.Calculator.Enums.SquareCalculationType.Diagonal, 5.6569);
            
            //Rectangle BothSides
            var side = GeometryShape.GetRectangle(Geometry.Calculator.Enums.RectangleCalculationType.BothSides, 4, 5);

            //Rectangle AreaAndSide
            var sideAndArea = GeometryShape.GetRectangle(Geometry.Calculator.Enums.RectangleCalculationType.SideAndArea, 4, 20);

            //Rectangle SideAndPerimeter
            var sideAndPerimeter = GeometryShape.GetRectangle(Geometry.Calculator.Enums.RectangleCalculationType.SideAndPerimeter, 4, 18);

            //Rectangle SideAndPerimeter
            var sideAndDiagonal = GeometryShape.GetRectangle(Geometry.Calculator.Enums.RectangleCalculationType.SideAndDiagonal, 4, 6.4031);
          
```

## Installation

` Install-Package Geometry.Calculator `

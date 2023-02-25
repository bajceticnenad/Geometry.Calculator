# Geometry.Calculator
Nuget (C# library) for Geometry shapes calculator: Area, Perimeter, Angles, Diagonal , Sides, etc...
### 2D shapes: Square, Rectangle, Triangle, Circle, Semicircle, Sector, Ellipse, Trapezoid, Parallelogram, Rhombus 
### 3D shapes: Cube, Pyramid, Sphere,Rectangular, Cylinder, Cone

## Example

```csharp
            //square Side
            var side = GeometryShape.GetSquare(Geometry.Calculator.Enums.SquareCalculationType.Side, 4);
            Console.WriteLine($"SquareCalculationType: {Geometry.Calculator.Enums.SquareCalculationType.Side}, Value={4}");
            Console.WriteLine($"Area: {side.Area}");
            Console.WriteLine($"Perimeter: {side.Perimeter}");
            Console.WriteLine($"Diagonal: {side.Diagonal}");
            Console.WriteLine($"Side: {side.Side}");
            Console.WriteLine($"***************");

            //square Area
            var area = GeometryShape.GetSquare(Geometry.Calculator.Enums.SquareCalculationType.Area, 16);
            Console.WriteLine($"SquareCalculationType: {Geometry.Calculator.Enums.SquareCalculationType.Area}, Value={16}");
            Console.WriteLine($"Area: {area.Area}");
            Console.WriteLine($"Perimeter: {area.Perimeter}");
            Console.WriteLine($"Diagonal: {area.Diagonal}");
            Console.WriteLine($"Side: {area.Side}");
            Console.WriteLine($"***************");

            //square Perimeter
            var perimeter = GeometryShape.GetSquare(Geometry.Calculator.Enums.SquareCalculationType.Perimeter, 16);
            Console.WriteLine($"SquareCalculationType: {Geometry.Calculator.Enums.SquareCalculationType.Perimeter}, Value={16}");
            Console.WriteLine($"Area: {perimeter.Area}");
            Console.WriteLine($"Perimeter: {perimeter.Perimeter}");
            Console.WriteLine($"Diagonal: {perimeter.Diagonal}");
            Console.WriteLine($"Side: {perimeter.Side}");
            Console.WriteLine($"***************");

            //square Side
            var diagonal = GeometryShape.GetSquare(Geometry.Calculator.Enums.SquareCalculationType.Diagonal, 5.6569);
            Console.WriteLine($"SquareCalculationType: {Geometry.Calculator.Enums.SquareCalculationType.Diagonal}, Value={5.6569}");
            Console.WriteLine($"Area: {diagonal.Area}");
            Console.WriteLine($"Perimeter: {diagonal.Perimeter}");
            Console.WriteLine($"Diagonal: {diagonal.Diagonal}");
            Console.WriteLine($"Side: {diagonal.Side}");
            Console.WriteLine($"***************");
            
            //Rectangle BothSides - test OK
            var side = GeometryShape.GetRectangle(Geometry.Calculator.Enums.RectangleCalculationType.BothSides, 4, 5);
            Console.WriteLine($"RectangleCalculationType: {Geometry.Calculator.Enums.RectangleCalculationType.BothSides}, Value1={4}, Value2={5}");
            Console.WriteLine($"Area: {side.Area}");
            Console.WriteLine($"Perimeter: {side.Perimeter}");
            Console.WriteLine($"Diagonal: {side.Diagonal}");
            Console.WriteLine($"Width: {side.Width}");
            Console.WriteLine($"Length: {side.Length}");
            Console.WriteLine($"***************");

            //Rectangle AreaAndSide - test OK
            var sideAndArea = GeometryShape.GetRectangle(Geometry.Calculator.Enums.RectangleCalculationType.SideAndArea, 4, 20);
            Console.WriteLine($"RectangleCalculationType: {Geometry.Calculator.Enums.RectangleCalculationType.SideAndArea}, Value1={4}, Value2={20}");
            Console.WriteLine($"Area: {sideAndArea.Area}");
            Console.WriteLine($"Perimeter: {sideAndArea.Perimeter}");
            Console.WriteLine($"Diagonal: {sideAndArea.Diagonal}");
            Console.WriteLine($"Width: {sideAndArea.Width}");
            Console.WriteLine($"Length: {sideAndArea.Length}");
            Console.WriteLine($"***************");

            //Rectangle SideAndPerimeter - test OK
            var sideAndPerimeter = GeometryShape.GetRectangle(Geometry.Calculator.Enums.RectangleCalculationType.SideAndPerimeter, 4, 18);
            Console.WriteLine($"RectangleCalculationType: {Geometry.Calculator.Enums.RectangleCalculationType.SideAndPerimeter}, Value1={4}, Value2={18}");
            Console.WriteLine($"Area: {sideAndPerimeter.Area}");
            Console.WriteLine($"Perimeter: {sideAndPerimeter.Perimeter}");
            Console.WriteLine($"Diagonal: {sideAndPerimeter.Diagonal}");
            Console.WriteLine($"Width: {sideAndPerimeter.Width}");
            Console.WriteLine($"Length: {sideAndPerimeter.Length}");
            Console.WriteLine($"***************");

            //Rectangle SideAndPerimeter - test 
            var sideAndDiagonal = GeometryShape.GetRectangle(Geometry.Calculator.Enums.RectangleCalculationType.SideAndDiagonal, 4, 6.4031);
            Console.WriteLine($"RectangleCalculationType: {Geometry.Calculator.Enums.RectangleCalculationType.SideAndDiagonal}, Value1={4}, Value2={6.4031}");
            Console.WriteLine($"Area: {sideAndDiagonal.Area}");
            Console.WriteLine($"Perimeter: {sideAndDiagonal.Perimeter}");
            Console.WriteLine($"Diagonal: {sideAndDiagonal.Diagonal}");
            Console.WriteLine($"Width: {sideAndDiagonal.Width}");
            Console.WriteLine($"Length: {sideAndDiagonal.Length}");
            Console.WriteLine($"***************");            
```

## Installation

` Install-Package Geometry.Calculator `

# ShapeSqr
### Usage example

```C# Circle circle = new Circle(5);
using ShapeSqr;
Circle circle = new Circle(5.0);
Triangle triangle = new Triangle(3.0, 4.0, 5.0);
double circleArea = circle.CalculateSquare();
double triangleArea = triangle.CalculateSquare();
Console.WriteLine(circleArea);
Console.WriteLine(triangleArea);
if (triangle.IsRightTriangle)
{
  Console.WriteLine("Треугольник прямоугольный");
}
else
{
 Console.WriteLine("Треугольник не прямоугольный");
} 
```

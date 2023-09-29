namespace ShapeSqr;

public abstract class Shape //Базовый класс фигуры, мы ведь хотим чтобы все было легко расширяемо.
{
    public abstract Double CalculateSquare();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть положителен");
        }

        Radius = radius;
    }

    public override double CalculateSquare()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Triangle : Shape
{
    public Double Side1 { get; set; }
    public Double Side2 { get; set; }
    public Double Side3 { get; set; }

    public bool IsRightTriangle // Прямоугольный ли треугольник
    {
        get
        {
            double[] sides = { Side1, Side2, Side3 };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2); // a^2+b^2=c^2 
        }
    }

    public Triangle(double side1, double side2, double side3)
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            throw new ArgumentException("стороны треугольника должны быть положительными числами");
        }

        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public override double CalculateSquare()
    {
        double halfPerimeter = (Side1 + Side2 + Side3) / 2;
        double area = Math.Sqrt(halfPerimeter * (halfPerimeter - Side1) * (halfPerimeter - Side2) *
                                (halfPerimeter - Side3));
        return area;
    }
}
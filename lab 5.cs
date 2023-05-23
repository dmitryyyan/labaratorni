using System;

class Triangle
{
    private Point point1;
    private Point point2;
    private Point point3;

    public Triangle(Point p1, Point p2, Point p3)
    {
        point1 = p1;
        point2 = p2;
        point3 = p3;
    }

    public void SetCoordinates(Point p1, Point p2, Point p3)
    {
        point1 = p1;
        point2 = p2;
        point3 = p3;
    }

    public void DisplayCoordinates()
    {
        Console.WriteLine($"Coordinates of Triangle:");
        Console.WriteLine($"Point 1: ({point1.X}, {point1.Y})");
        Console.WriteLine($"Point 2: ({point2.X}, {point2.Y})");
        Console.WriteLine($"Point 3: ({point3.X}, {point3.Y})");
    }

    public double CalculateArea()
    {
        double side1 = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        double side2 = Math.Sqrt(Math.Pow(point3.X - point2.X, 2) + Math.Pow(point3.Y - point2.Y, 2));
        double side3 = Math.Sqrt(Math.Pow(point1.X - point3.X, 2) + Math.Pow(point1.Y - point3.Y, 2));

        double semiPerimeter = (side1 + side2 + side3) / 2;
        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));

        return area;
    }
}

class Tetrahedron : Triangle
{
    private Point point4;

    public Tetrahedron(Point p1, Point p2, Point p3, Point p4) : base(p1, p2, p3)
    {
        point4 = p4;
    }

    public void SetCoordinates(Point p1, Point p2, Point p3, Point p4)
    {
        base.SetCoordinates(p1, p2, p3);
        point4 = p4;
    }

    public new void DisplayCoordinates()
    {
        base.DisplayCoordinates();
        Console.WriteLine($"Point 4: ({point4.X}, {point4.Y})");
    }

    public new double CalculateArea()
    {
        double baseArea = base.CalculateArea();
        double height = Math.Sqrt(Math.Pow(point4.X - point1.X, 2) + Math.Pow(point4.Y - point1.Y, 2));

        double volume = (baseArea * height) / 3;
        return volume;
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Triangle example
        Point p1 = new Point(0, 0);
        Point p2 = new Point(3, 0);
        Point p3 = new Point(0, 4);

        Triangle triangle = new Triangle(p1, p2, p3);

        triangle.DisplayCoordinates();
        double triangleArea = triangle.CalculateArea();
        Console.WriteLine($"Triangle Area: {triangleArea}");

        // Tetrahedron example
        Point p4 = new Point(0, 6);

        Tetrahedron tetrahedron = new Tetrahedron(p1, p2, p3, p4);

        tetrahedron.DisplayCoordinates();
        double tetrahedronVolume = tetrahedron.CalculateArea();
        Console.WriteLine($"Tetrahedron Volume: {tetrahedronVolume}");

        Console.ReadLine();
    }
}

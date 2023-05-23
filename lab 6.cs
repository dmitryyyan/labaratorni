using System;

class Triangle
{
    protected int side1;
    protected int side2;
    protected int side3;

    public Triangle(int s1, int s2, int s3)
    {
        side1 = s1;
        side2 = s2;
        side3 = s3;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("This is a triangle.");
        Console.WriteLine($"Side 1: {side1}");
        Console.WriteLine($"Side 2: {side2}");
        Console.WriteLine($"Side 3: {side3}");
    }
}

class Tetrahedron : Triangle
{
    private int side4;

    public Tetrahedron(int s1, int s2, int s3, int s4) : base(s1, s2, s3)
    {
        side4 = s4;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("This is a tetrahedron.");
        Console.WriteLine($"Side 1: {side1}");
        Console.WriteLine($"Side 2: {side2}");
        Console.WriteLine($"Side 3: {side3}");
        Console.WriteLine($"Side 4: {side4}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Tetrahedron tetrahedron = new Tetrahedron(2, 3, 4, 5);

        Triangle shape1 = triangle;
        Triangle shape2 = tetrahedron;

        shape1.DisplayInfo();
        Console.WriteLine();
        shape2.DisplayInfo();

        Console.ReadLine();
    }
}

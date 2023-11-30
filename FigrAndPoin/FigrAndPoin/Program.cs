using System.Drawing;

class Program
{
    public static void Main()
    {
        Point A = new Point(1, 2, "A");
        Point B = new Point(3, 4, "B");
        Point C = new Point(5, 6, "C");

        if (IsValidTriangle(A, B, C))
        {
            Figure triangle = new Figure("Triangle", new Point[] { A, B, C });
            triangle.CalculatePerimeter();
        }
        else
        {
            Console.WriteLine("Invalid triangle: Not enough or too many points.");
        }
    }

    public static bool IsValidTriangle(Point A, Point B, Point C)
    {
        return !(A == B || A == C || B == C);
    }
}
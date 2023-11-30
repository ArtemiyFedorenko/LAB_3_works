using System;

class Program
{
    static void Main()
    {
        double side1, side2;

        do
        {
            Console.WriteLine("Enter the length of side1: ");
        } while (!double.TryParse(Console.ReadLine(), out side1) || side1 <= 0);

        do
        {
            Console.WriteLine("Enter the length of side2: ");
        } while (!double.TryParse(Console.ReadLine(), out side2) || side2 <= 0);

        Rectangle myRectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Perimeter: {myRectangle.Perimeter}");
        Console.WriteLine($"Area: {myRectangle.Area}");
    }
}
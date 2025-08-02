using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("Enter the three sides of the triangle:");

        Console.Write("Side A: ");
        double a = GetSide();

        Console.Write("Side B: ");
        double b = GetSide();

        Console.Write("Side C: ");
        double c = GetSide();

        if (IsValidTriangle(a, b, c))
        {
            if (a == b && b == c)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
        else
        {
            Console.WriteLine("The entered sides do not form a valid triangle.");
        }
    }

    static double GetSide()
    {
        double side;
        while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
        {
            Console.Write("Invalid input. Enter a positive number: ");
        }
        return side;
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}

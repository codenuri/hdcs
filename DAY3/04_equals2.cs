using System;

// 107 page

class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = p1;

        Point p3 = new Point(1, 2);
        Point p4 = new Point(1, 2);

        // #1. == ¿¬»êÀÚ

        bool b1 = (p1 == p2);
        bool b2 = (p3 == p4);

        WriteLine($"{b1}");
        WriteLine($"{b2}");

    }
}

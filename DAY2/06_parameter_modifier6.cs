using System;

class Point
{
    public int x = 0;
    public int y = 0;
}

class Program
{
    public static void Foo(Point pt)
    {
        pt.x = 10; // !!
    }
    public static void Main()
    {
        Point p1 = new Point();
        Foo(p1);
    }
}
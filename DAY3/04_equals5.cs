using static System.Console;

// 107 page
/*
class Object
{
    public virtual bool Equals(Object   obj )
    {

    }
}
*/




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
        Point p2 = new Point(1, 2);

        WriteLine($"{p1 == p2}");

    }
}



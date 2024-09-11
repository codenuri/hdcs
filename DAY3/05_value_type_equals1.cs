using System;


struct Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
    public static void Main()
    {
        // Point 는 value 타입입니다.
        // => 아래 p1, p2 는 다른 객체입니다.
        Point p1 = new Point(1, 2);
        Point p2 = p1;

        // #1. == 연산자 
        bool b1 = (p1 == p2);

    }
}

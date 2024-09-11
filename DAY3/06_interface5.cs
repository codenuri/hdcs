using System;

class Point : ICloneable
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    public object Clone()
    {
        Point pt = new Point(x, y); // 자신과 동일한 객체 생성후
        return pt;                  // 반환
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = p1;

//      Point p3 = p1.Clone();       // error
        Point p3 = (Point)p1.Clone();// ok 인데, 불편합니다.

    }
}

// Animal a = Dog 객체
// Dog d    = a;  // ?error
// Dog d    = (Dog)a;  // ok
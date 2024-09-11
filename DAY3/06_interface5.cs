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

        Point p3 = p1.Clone(); // 만들어 봅시다.
    
    }
}

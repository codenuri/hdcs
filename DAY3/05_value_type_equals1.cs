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
        // Point �� value Ÿ���Դϴ�.
        // => �Ʒ� p1, p2 �� �ٸ� ��ü�Դϴ�.
        Point p1 = new Point(1, 2);
        Point p2 = p1;

        // #1. == ������ 
        bool b1 = (p1 == p2);

    }
}

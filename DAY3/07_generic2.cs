using System;

// Ŭ������ Generic ���� �Ҽ� �ֽ��ϴ�.

class Point<T>
{
    private T x = 0;
    private T y = 0;

    public Point(T a, T b) => (x, y) = (a, b);
}

class Program
{
    public static void Main()
    {
        Point<int> p1 = new Point<int>(0, 0);
        Point<double> p2 = new Point<double>(1.1, 2.2);
    }
}

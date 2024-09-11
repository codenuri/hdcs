using static System.Console;

// 사용자가 만든 타입에 CompareTo 를 제공하려면
// #1. IComparable 인터페이스를 구현하겠다고 표시 합니다.
// #2. CompareTo 를 구현합니다.

class Point : IComparable
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
        Point p2 = new Point(3, 4);

        bool b = p1.CompareTo(p2);
    }
}
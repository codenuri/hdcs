using static System.Console;

// ����ڰ� ���� Ÿ�Կ� CompareTo �� �����Ϸ���
// #1. IComparable �������̽��� �����ϰڴٰ� ǥ�� �մϴ�.
// #2. CompareTo �� �����մϴ�.

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
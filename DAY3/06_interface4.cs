using static System.Console;

// ����ڰ� ���� Ÿ�Կ� CompareTo �� �����Ϸ���
// #1. IComparable �������̽��� �����ϰڴٰ� ǥ�� �մϴ�.
// #2. CompareTo �� �����մϴ�.

class Point  : IComparable
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    public int CompareTo(object? obj)
    {
        Point other = (Point)obj;

        // �ڽ��� x,y �� ohter �� x,y �� ������ ���� ū�� ���ؼ� ��ȯ
        // �Ʒ� �ڵ�� x�� ���� ũ�� ��
        if (x > other.x) 
            return 1;
        else if ( x < other.x) 
            return -1;

        return 0;
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(3, 4);

        int ret = p1.CompareTo(p2);

        WriteLine($"{ret}");

        Foo(p1);
    }

    // �Ʒ� �޼ҵ�� COmpareTo �޼ҵ尡 �ִ� ��ü�� �ްڴٴ� �ǵ�.
    public static void Foo(IComparable obj)
    {

    }
}
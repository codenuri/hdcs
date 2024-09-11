using static System.Console;

// 107 page

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
        Point p2 = p1;

        Point p3 = new Point(1, 2);
        Point p4 = new Point(1, 2);

        // #1. == ������
        // => ������ ��ü���� ����.
        bool b1 = (p1 == p2);
        bool b2 = (p3 == p4);

        WriteLine($"{b1}"); // True
        WriteLine($"{b2}"); // False

        // #2. Object �� �����ϴ� Equals �����Լ� ���
        // => Object �� �⺻ ������ "������ ��ü" ���� ����!!
        // => �׷���, "virtual method" �̹Ƿ�, �⺻ ���� ���氡��.
        bool b3 = p1.Equals(p2);
        bool b4 = p3.Equals(p4);
    
        WriteLine($"{b3}"); // True
        WriteLine($"{b4}"); // False

    }
}

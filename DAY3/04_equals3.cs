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

    // Object obj = new Point(); // �� �ڵ�� ����������
    // int n = obj.x;      // �̷��� ������ �ȵ˴ϴ�.
    // int n = ((Point)obj.x)  �̷��� �ؾ� �մϴ�.
    public override bool Equals(object? obj)
    {
        // �Ʒ� �ڵ�� "���� ��ü" ���ΰ� �ƴ϶�
        // "��ü�� ����" ���� �����ϴ� �ڵ�!

        Point pt = (Point)obj;

        return x == pt.x && y == pt.y;
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = p1;

        Point p3 = new Point(1, 2);
        Point p4 = new Point(1, 2);

        bool b3 = p1.Equals(p2);
        bool b4 = p3.Equals(p4);

        WriteLine($"{b3}"); // True
        WriteLine($"{b4}"); // True

    }
}

// equality ���� ���
// 1. p1 == p2
// => ��ü�� �������� ����.

// 2. p1.Equals(p2) 
// => Object �⺻ ������ "��ü�� ����"���� ����
// => �Ļ� Ŭ���� �����ڰ� ���� ����.
// => ���� "��ü�� ����(��)�� �������� ����" �ϵ��� ����
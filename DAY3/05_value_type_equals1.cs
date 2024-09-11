using System;


struct Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    public static bool operator ==(Point a, Point b)
    {
        return a.x == b.x && a.y == b.y;
    }
    public static bool operator !=(Point a, Point b)
    {
        return !(a == b);
    }
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
        // => �⺻������ �������� ����. ������ ����
        // => ������ Point Ÿ�� �����ڰ� "������ �����Ƿ� ����" ����. 
        bool b1 = (p1 == p2);

        // #2. Equals() virtual method
        // => Object Equals �⺻ ���� : ������ ��ü�ΰ� ?
        // => ValueType �������� : ��ü�� ��ü �޸𸮰� �����Ѱ� ���� 
        // => ��� struct �� ValueType ���� ���� �Ļ���
        bool b2 = p1.Equals(p2); // �׷���, p1, p2 �� ���� ���� �ΰ� ����

        Console.WriteLine($"{b2}"); // True
    }
}
/*
class Object
{
    public virtual bool Equals(Object obj)
    {
        // �⺻ ������ "��ü�� �����Ѱ�"!!
    }
}

class ValueType : Object
{
    public override bool Equals(Object obj)
    {
        // ��ü�� �޸� ��ü�� ��Ʈ ������ ���ؼ�
        // �޸� ������ü�� �����Ѱ��� ����
    }
}
// C# ��Ģ : ��� ����ü(value_type) �� �ڵ����� ValueType ���� ���� �Ļ� �ȴ�.
struct Point // ValueType
{

}
*/
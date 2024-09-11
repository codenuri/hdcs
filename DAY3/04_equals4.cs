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

 
    public override bool Equals(object? obj)
    {
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

        // "p1, p2 ��ü�� ����" �� �������� �����Ϸ��� �մϴ�.
        // = > �ּ��� �ڵ带 ������ ���ô�.

        // ��� #1.
        bool b1 = p1.Equals(p2); // ??

        //-----------------------------
        // ��� #2.
        bool b2 = p1 == p2;

        if (b2 == false)
        {
            b2 = p1.Equals(p2);
        }
        //-----------------------------
        // ���#2 �� ����������� "object.Equals(p1, p2)" �Դϴ�.
        // => Object Ŭ������ static method
        bool b3 = object.Equals(p1, p2); // ��� #2�� ����


    }
}



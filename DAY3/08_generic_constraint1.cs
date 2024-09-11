using System;
using static System.Console;

class Program
{
    // �Ʒ� �ڵ�� ����!!
    // => ������ Ÿ�� T �ȿ� "CompareTo" �� �ִٴ� ������ ���� ������
    // => Max �ȿ����� object Ÿ������ �Ҽ� �ִ� �͸� ����.
    // => ������ "swap" ������ �޼ҵ� ȣ���ϴ� �ڵ尡 ����!!
    //    ����, = ���길!!
    /*
    public static T Max<T>(T a, T b)
    {
        a.ToString(); // �� �ڵ�� ����. 
                      // C#�� ��� Ÿ���� Object ���� �Ļ��Ǵµ�
                      // ToString()�� object �ȿ� �ִ�

        return a.CompareTo(b) < 0 ? b : a;            
    }
    */

    // �ذ�å : Generic Constraint ǥ�� - 128 page
    // => ������ �����ϴ� Ÿ�Ը� ���� �ްڴٴ� �ǹ�
    // => ����, {} �ȿ��� ���࿡ �´� ������ �����ϴ�.
    public static T Max<T>(T a, T b) where T : IComparable
    {
        return a.CompareTo(b) < 0 ? b : a;
    }

    public static void Main()
    { 
        int n1 = 10, n2 = 20;

        string s1 = "AA", s2 = "BB";

        int ret1 = Max(n1, n2);
        string ret2 = Max(s1, s2);

        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);

//      Point ret3 = Max(p1, p2); // error. IComparable�� ������ Ÿ���� �ƴ�
    }
}


class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);
}


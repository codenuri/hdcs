using System;

// Ŭ������ Generic ���� �Ҽ� �ֽ��ϴ�.

class Point<T>
{
//  private T x = 0;  // error. ������ Ÿ�� T�� 0���� �ʱ�ȭ �ɼ������ϴ�.
    private T x = default;  // �̷��� default ���
    private T y = default;  // T �� int, double �̸� 0
                            // reference type �̸� null
                            // 21 page ǥ ����

    public Point(T a, T b) => (x, y) = (a, b);
}

class Program
{
    public static void Main()
    {
        // Ŭ���� Generic �� �⺻������ Ÿ������ �����ؾ� �մϴ�.
        // => �Լ� Generic �� Ÿ�� ���� ���� ����

        Point<int> p1 = new Point<int>(0, 0);
        Point<double> p2 = new Point<double>(1.1, 2.2);

     
    }
}

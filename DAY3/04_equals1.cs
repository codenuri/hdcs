using System;

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
		// p1, p2 �� "���� ��ü" �� ����ŵ�ϴ�.
		// => ��ü�� ����
		Point p1 = new Point(1,2);
		Point p2 = p1;

		// p3, p4 �� "���� ��ü"�� �ƴ�����
		// => ���°� ����
		Point p3 = new Point(1,2);
		Point p4 = new Point(1,2);

		// ��ü���� ���α׷����� "equal" �� �̾߱��Ҷ�
		// => ���� ��ü���� ?
		// => ��ü�� ���°� �������� ? �� �� �����ϼ���.
	}
}

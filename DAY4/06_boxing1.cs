using static System.Console;

// 116p ~ 

// class  : reference type
// struct : value type

// object : class  �̹Ƿ� reference type �Դϴ�.

class Point 
{
	public int X{set; get;} = 0;
	public int Y{set; get;}	= 0;
	public Point(int a, int b) => (X, Y) = (a, b);
}

class Program
{
	public static void Main()
	{
		// �Ʒ� �ڵ��� �޸� �׸��� 116 page �Դϴ�.
		Point p1 = new Point(1, 1);
		object o = p1;

		Point p2 = (Point)o;
		p1.X = 2; 
		p1.Y = 2;

		// �� �ڵ忡�� p1, p2, o �� ��� ���� ��ü�� ����Ű�� �˴ϴ�.

		Console.WriteLine($"{p2.X}, {p2.Y}");
							// 2, 2
			
					

	}
}
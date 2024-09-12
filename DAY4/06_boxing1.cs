using static System.Console;

// 116p ~ 

// class  : reference type
// struct : value type

// object : class  이므로 reference type 입니다.

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
		// 아래 코드의 메모리 그림이 116 page 입니다.
		Point p1 = new Point(1, 1);
		object o = p1;

		Point p2 = (Point)o;
		p1.X = 2; 
		p1.Y = 2;

		// 위 코드에서 p1, p2, o 는 모두 동일 객체를 가리키게 됩니다.

		Console.WriteLine($"{p2.X}, {p2.Y}");
							// 2, 2
			
					

	}
}
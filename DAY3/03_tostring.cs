 using static System.Console;

// 106 page

 class Point 
 {
	private int x = 0;
	private int y = 0;

	/*
    public Point(int a, int b) 
	{
		//	x = a; 
		//	y = b;
		(x, y) = (a, b); // �� ������ ���� ����
	}
	*/

	// �Ʒ� �ڵ�� �ᱹ �� �ڵ�� �����մϴ�.
    public Point(int a, int b) => (x, y) = (a, b);
 }

 class Program 
 {
	public static void Main()
	{
		Point p = new Point(1, 2);
		
		string s = p.ToString();

		WriteLine( s );
	}
 }

using static System.Console;

class Program
{
	// Swap 를 만들어 봅시다.
	// => 인자를 R/W 모두 가능해야 합니다.
	public static void Swap( ref int a, ref int b )
	{
		int t = a;
		a = b;
		b = t;
	}
	public static void Main()
	{
		int x = 1;
		int y = 2;

		Swap(ref x, ref y);

		WriteLine($"{x}, {y}");
				//   2,   1
	}
}
using static System.Console;

class Program
{
	// 두정수의 합을 반환하고, 두정수의 차를 3번째 인자에 담아주고 싶다.
	public static int AddSub(int a, int b, ref int c)
	{
		c = a - b;
		return a + b;
	}

	public static void Main()
	{
//		int ret1 = 0;
		int ret1;

        int ret2 = AddSub(5, 3, ref ret1 );

		WriteLine($"{ret1}, {ret2}");
				
	}
}
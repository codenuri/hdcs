using static System.Console;

class Program
{
    // 두정수의 합을 반환하고, 두정수의 차를 3번째 인자에 담아주고 싶다.
//	public static int AddSub(int a, int b, ref int c)
    public static int AddSub(int a, int b, out int c)
    {
		c = a - b;
		return a + b;
	}
	public static void Main()
	{
//		int ret1 = 0;
		int ret1;

//      int ret2 = AddSub(5, 3, ref ret1 ); // error. ref 는 초기값이 있는 변수만 가능
        int ret2 = AddSub(5, 3, out ret1); // ok. 초기값이 없어도 가능

        WriteLine($"{ret1}, {ret2}");

        // out 을 사용시 아래 처럼 편리하게 할수 있습니다.
        // => 함수 호출 () 안에서 변수를 선언!!!
        int ret3 = AddSub(5, 3, out int c); // 변수를 만들면서 전달하는 것
    }
}

// ref : 함수 안에서 "R/W"모두 한다는 의도, R 을 위해서는 반드시 초기값 있는 변수만 가능
// out : 함수 안에서 "W"  만 한다는 의도, 초기값 없어도 가능.
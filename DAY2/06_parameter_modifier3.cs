using static System.Console;

class Program
{
	// #1. 인자에 대한 modifier 가 없는 경우.
	public static void no_modifier_parameter(int x)
	{
		// x 는 main 에서 보낸 인자의 복사본
		int n = x;	// ok. 복사본 x에 대한 R
		x = 0;		// ok. W
	}

	// #2. out parameter
	public static void out_parameter(out int x)
	{
//		int n = x;	// error. out 은 초기화 되지 않은 변수도 보낼수 있다.
		x = 0;		// ok. 
					// 그런데, 이코드가 없으면에러!!
					// out parameter 는 반드시 쓰는 코드가 있어야 한다.
	}

	// #3. ref parameter 
	// => 복사본 만들지 않고, R/W 모두 하겠다는것
	public static void ref_parameter(ref int x)
	{
		int n = x;	// ok
		x = 0;		// ok.

		// 위 코드가 모두 없어도 가능.
	}

	public static void Main()
	{
		int n1;
		int n2 = 0;

		out_parameter(out n1);  // ok
		out_parameter(out n2);  // ok
		
		ref_parameter(ref n1);  // error. 초기화 안된것은 전달 안됨
		ref_parameter(ref n2);  // ok

		out_parameter(out int n3); // out 은 변수를 만들면서도 전달 가능. 
									// ref 는 초기값이 필요하므로
									// 이런 표기법 지원 안함

	}
}
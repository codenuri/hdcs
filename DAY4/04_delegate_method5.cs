delegate void MyFunc(int arg);

// ?.invoke()

class Program
{
	public static void M1(int arg)    {}
	
	public static void Main()
	{
		MyFunc f = M1;

		f(10);			// 메소드 호출시 이렇게 해도 되고
		f.Invoke(10);   // 이렇게 해도 됩니다.

		// invoke 가 좋은 경우..!
		f = null;

//		f(10); // 예외 발생

		// 안전하게 하려면 아래 처럼하는데..
		if ( f != null)
		{
			f(10);
		}

		// 위코드는 아래 한줄이면 됩니다.
		f?.Invoke(10);
//		f?(10); // 이 표기법은 안됨..error

	}
}

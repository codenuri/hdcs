using static System.Console;

delegate void MyFunc(int arg);

class Test
{
    public static void SMethod(int arg) => WriteLine("Test.SMethod");
    public        void IMethod(int arg) => WriteLine("Test_Object.IMethod");
}

class Program
{
	public static void SMethod(int arg) => WriteLine("Program.SMethod");

	public static void Main()
	{	
		// 핵심 : 여러 메소드를 등록해서 사용가능합니다.
		//		  "multi cast"

		Test t = new Test();

		MyFunc f = Test.SMethod;

		f += t.IMethod;
		f += Program.SMethod;
			
	
		f(10); // 이순간 3개의 메소드가 차례대로(등록순으로) 호출됩니다.
	}
}

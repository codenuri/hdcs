using static System.Console;

delegate void MyFunc(int arg);

// 이전 소스 : 다른 클래스의 메소드 등록
// 이번 소스 : 같은 클래스의 메소드 등록

class Program
{
    public static void SMethod(int arg) { WriteLine("SMethod"); }

    public void IMethod(int arg) { WriteLine("IMethod"); }

    public static void Main()
    {
        MyFunc f1 = Program.SMethod;
        MyFunc f2 = SMethod;        // 같은 클래스 멤버이므로 클래스이름생략가능
//      MyFunc f3 = IMethod; // error. 객체가 있어야 한다.

        Program p = new Program();
        MyFunc f3 = p.IMethod;

        p.InstanceMethod();
    }

	public void InstanceMethod()
	{
        MyFunc f1 = IMethod; // ok      이코드는 아래 코드로 변경된것
        MyFunc f2 = this.IMethod; // ok. 

        MyFunc f3 = Program.SMethod; // ok
        MyFunc f4 = SMethod          // ok
    }
}
// 위 코드 복습할때
// Main 은 "static method"
// InstanceMethod 는 instance method 라는 점을 꼭 고려하고 생각해 보세요.  
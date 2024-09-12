using static System.Console;

// delegate 에 메소드를 등록하는 방법

delegate void MyFunc(int arg);

class Test
{
    public static void SMethod(int arg) { WriteLine("Test.SMethod"); }

    public void IMethod(int arg) { WriteLine("Test_Object.IMethod"); }
}

class Program
{
    public static void Main()
    {
        Test.SMethod(1); // static method 는 클래스이름으로 호출

        Test t = new Test();
        t.IMethod(1);    // instance method 는 객체가 필요

        MyFunc f1 = Test.SMethod; // static method는 클래스 이름으로 등록
        MyFunc f2 = t.IMethod;    // instance method 는 객체 이름으로 등록

        f1(10); // Test.SMethod(10)
        f2(10); // t.IMethod(10)
    }
}

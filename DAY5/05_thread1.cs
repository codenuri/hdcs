using static System.Console;

// 05_thread1.cs

class Program
{
    public static void F1() {  }
    public static void F2(object arg) { }
    public static void F3(int a, int b) { }

    public static void Main()
    {
        // #1. 스레드 생성하는 방법
        Thread t1 = new Thread(F1);
        t1.Start();

        Thread t2 = new Thread(F2);
        t2.Start("Hello");  // 인자가 한개 있는 경우. 

        // #2. 인자가 여러개라면 람다 표현식으로
        Thread t3 = new Thread( () => F3(1, 2) ); // new Thread(Foo) 의미
        t3.Start();
    }
    public void static Foo()
    {
        F3(1, 2);
    }
}
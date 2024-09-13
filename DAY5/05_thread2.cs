using static System.Console;

// thread pool 
class Program
{
    public static void F2(object arg) { }

    public static void Main()
    {
        // #1. 사용자가 스레드를 만드는 코드
        Thread t2 = new Thread(F2);
        t2.Start("Hello");

        // #2. 이미 생성되어 있는 Thread pool 에 있는 스레드에 작업 요청
        ThreadPool.QueueUserWorkItem(F2, "Hello");
    }

}
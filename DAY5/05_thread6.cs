using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{

    public static Task<int> SumAsync(int first, int last)
    {
        return Task.Run(() =>
        {
            int s = 0;
            for (int i = first; i <= last; i++)
            {
                s += i;
                Thread.Sleep(10);
            }
            return s;
        });
    }

    public static void Foo()
    {
        Task<int> t = SumAsync(1, 1000); 

        Console.WriteLine("Foo 계속실행");

//      int ret = t.Result;         // 이렇게 대기 하면
                                    // 스레드 종료(연산의 종료)를
                                    // 주스레드가 하게 됩니다.
//      Console.WriteLine($"결과 : {ret}");

        var waiter = t.GetAwaiter(); // 결과 대기 객체

        waiter.OnCompleted(Goo ); // 작업이 종료 되면
                                  // 또다른 스레드를 만들어서
                                  // Goo 호출
                                  // 작업의 대기를 주스레드가 하지 않음ㄴ.
    }
    public static void Goo()     {   Console.WriteLine("Goo");    }

    public static void Main()
    {
        // Main 은 무한루프를 돌면서 아주 중요한 작업을 한다고 가정해 보세요
        // => 절대 "중단" 되면 안됩니다.
        Foo();
        Console.WriteLine("Main 계속실행");

        Console.ReadLine();
        
    }

}
// git thread3.cs
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    public static int Sum(int first, int last)
    {
        int s = 0;
        for (int i = first; i <= last; i++)
        {
            s += i;
            Thread.Sleep(10);
        }
        return s;
    }

    public static void Main()
    {
        // Task 클래스
        // => 스레드를 생성하고 결과까지 얻을수 있도록 설계된 클래스
        // => Thread 클래스를 직접 사용하는 것 보다 편리하다.

        Task<int> t = Task.Run(() => Sum(1, 1000));

        Console.WriteLine("Main 계속실행");

        // 주스레드는 계속 실행하다가
        // 결과 필요하면 아래 처럼 얻으면 됩니다.
        int ret = t.Result; // 아직 연산이 안끝난경우는 대기.
    }

}
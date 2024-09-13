// git thread3.cs
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    // Sum : Sum 자체는 스레드로 동작하지 않습니다.
    //      사용자가 스레드를 만들어서 실행할수도 있고 아닐수도 있습니다.
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

    // SumAsync : 함수가 스스로 내부에서 스레드를 생성하는 것.
    //            사용자가 스레드를 만드는 것이 아니다.
    //            "비동기(async) 함수" 라고 합니다.
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
    public static void Main()
    {
        SumAsync(1, 2);

        Console.WriteLine("Main 계속실행");

//        int ret = t.Result; // 아직 연산이 안끝난경우는 대기.
//        Console.WriteLine($"결과 : {ret}");
    }

}
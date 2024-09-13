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
//      Sum(1, 1000);  // 메소드 종료를 대기 

        Thread t = new Thread(() => Sum(1, 1000));
        t.Start();  // 새로운 스레드가 실행하므로
                    // 주스레드는 계속 실행됨.
                        
                    // 그런데, Sum 의 결과를 얻을수가 없습니다.
                    // => 얻으려면 복잡한 코드를 직접 작성해야 한다.

        Console.WriteLine("Main 계속실행");




    }

}
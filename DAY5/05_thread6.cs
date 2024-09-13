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

        int ret = t.Result; 
        Console.WriteLine($"결과 : {ret}");
    }

    public static void Main()
    {
        // Main 은 무한루프를 돌면서 아주 중요한 작업을 한다고 가정해 보세요
        // => 절대 "중단" 되면 안됩니다.
        Foo();
        Console.WriteLine("Main 계속실행");
        
    }

}
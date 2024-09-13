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

    public static async void Foo()
    {
        //        Task<int> t = SumAsync(1, 1000);

        Console.WriteLine($"Foo #1 : {Thread.CurrentThread.ManagedThreadId}");

        int ret = await SumAsync(1, 1000);

        Console.WriteLine($"Foo #2 : {Thread.CurrentThread.ManagedThreadId}");
    }

    public static void Main()
    {
        Foo();
        Console.WriteLine("Main 계속실행");

        Console.ReadLine();

    }

}
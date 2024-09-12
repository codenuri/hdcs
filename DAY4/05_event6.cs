using System.Text;
using static System.Console;

// 아래 코드가 이미 C# 에 있습니다. 인자 16개짜리까지 지원
/*
delegate void Action();
delegate void Action<T>(T arg);
delegate void Action<T1, T2>(T1 arg1, T2 arg2);
*/

class Program
{
    public static int F3(double arg1, string arg2)
    {
        WriteLine("F2");
        return 0;
    }

    public static void Main()
    {
        ? f = F3;
    }
}
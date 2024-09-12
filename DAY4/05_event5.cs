using static System.Console;

delegate void Action();
delegate void Action<T>(T arg);
delegate void Action<T1, T2>(T1 arg1, T2 arg2);

class Program
{
    public static void F0()        => WriteLine("F0");
    public static void F1(int arg) => WriteLine("F1");
    public static void F2(int arg1, int arg2) => WriteLine("F2");

    public static void F3(double arg1, string arg2) => WriteLine("F2");

    public static void Main()
    {
        Action m1 = F0;
        Action<int> m2 = F1;
        Action<int, int> m3 = F2;
        
        ? m4 = F3;
    }
}
using static System.Console;

class Program
{
    public static void F1() {  }
    public static void F2(object arg) { }
    public static void F3(int a, int b) { }

    public static void Main()
    {
        Thread t1 = new Thread(F1);
        t1.Start();

    }
}
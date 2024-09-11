using static System.Console;

class Program
{
    public static void Foo(object) 
    {
        Console.WriteLine("Object")
    }

    public static void Main()
    {
        string s = "aa";
        Foo(s);
    }
}

using static System.Console;

class Program
{
    // Foo 가 2개 지만 
    // => s 전달시 명확히 string 타입이 있으므로 ok. 
    public static void Foo(object obj) 
    {
        Console.WriteLine("Object");
    }
    public static void Foo(string obj)
    {
        Console.WriteLine("string");
    }

    public static object Goo() { return "aa"; }
    public static string Goo() { return "aa";  }

    public static void Main()
    {
        string s = "aa";
        Foo(s);

        Goo(); // 2개의 Goo 는 인자는 동일하고 리턴 값만 다르므로
               // error 입니다. 함수 호출시 구별 안됨
    }
}

using static System.Console;

class Program
{
    public static bool Foo(int n) { return n % 2 == 0; }

    public static void Main()
    {
        int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // x.First(함수) : x의 모든 요소를 차례대로 함수에 보내서 
        //                처음으로 0을 반환하는 것을 찾고 싶다.

        int ret = x.First(Foo);

        Console.WriteLine(ret);
    }
}
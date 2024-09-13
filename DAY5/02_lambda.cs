using static System.Console;

class Program
{
    public static int Add(int a, int b) { return a + b; }

    public static void Main()
    {
        Func<int, int, int> f1 = Add;

        int ret = f1(1, 2); // Add(1,2)


        // 람다 표현식 
        // => 익명의 메소드를 만드는 기법
        Func<int, int, int> f2 = (int a, int b) => { return a + b; };
        Func<int, int, int> f3 = (int a, int b) => a + b; 

        int ret2 = f2(1, 2);
        int ret3 = f3(1, 2);
    }
}
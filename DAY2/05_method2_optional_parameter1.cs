using static System.Console;

class Program
{
    // C++ : default parameter
    // C#  : optional parameter
    public static void M1(int a, int b = 0, int c = 0)
	{
	 	WriteLine($"{a}, {b}, {c}");
	} 
    public static void Main()
    {
        M1(10, 20, 30); // 10, 20, 30
        M1(10, 20);     // 10, 20, 0
        M1(10);         // 10, 0,  0
    }

    // 주의!
    // => 마지막 인자 부터 차례대로만 가능.
    public static void M2(int a, int b = 0, int c = 0) { }  // ok
    public static void M3(int a = 0, int b, int c = 0) { }  // error
    public static void M4(int a, int b = 0, int c) { }      // error
}
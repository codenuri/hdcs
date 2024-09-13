// #1. DAY5 프로젝트를 다시 시작프로젝트로 
// 04_find.cs 추가 - git 에서 소스 복사하세요

using static System.Console;

class Program
{
    public static bool Foo(int n) { return n % 2 == 0; }

    public static void Main()
    {
        int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // x.First(함수) : x의 모든 요소를 차례대로 함수에 보내서 
        //                처음으로 true 을 반환하는 것을 찾고 싶다.

        int ret1 = x.First(Foo);
        int ret2 = x.First( (n) => n % 2 == 0 );  // 위와 동일
        int ret3 = x.FirstOrDefault((n) => n % 2 == 0);  // 위와 동일

        Console.WriteLine(ret1);

        object[] y = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int ret4 = y.First((n) => n % 2 == 0); // error. 요소가 object 라서
                                               // n % 2 는 안됨.
                                               // 해결책은 아래!
        int ret4 = y.Cast<int>().First((n) => n % 2 == 0);
    }
}
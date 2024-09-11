using static System.Console;

class Program
{
    public static void Main()
    {
        // 표준 타입은 == 사용해도 충분합니다.

        int n1 = 10;
        int n2 = 10;

        // int 
        // => struct 이므로 value type
        // => struct 는 기본적으로 == 연산 안됨
        // => 그런데, 아래 처럼 사용하게 하기 위해 "==" 연산자를 재정의 한것!

        if (n1 == n2) { }


    }
}
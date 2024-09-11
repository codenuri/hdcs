using static System.Console;

// 79 page
class Program
{
    public static void Main()
    {
        // 변수의 크기 비교 방법
        // #1. int 타입은 < 또는 > 사용 가능
        int n1 = 10;
        int n2 = 20;
        if (n1 < n2) { }
        if ( n1.CompareTo(n2) < 0) { }


        // #2. string 은 < 안됨
        // => CompareTo 사용하면 됩니다.
        string s1 = "AB";
        string s2 = "XY";

//      if (s1 < s2) { } // error
        if (s1.CompareTo(s2) < 0) { } // ok. a < b 의 의미  - 79p표참고

        // 핵심 
        // 1. C# 언어 사용시 < 연산이 안되는 타입이 있으면
        //    크기 비교를 위해서는 "CompareTo" 메소드를 찾아 보세요

        // 2. 그런데, C# 에서는 "CompareTo" 이름을 약속하기 위해서
        //    "IComparable" 인터페이스 제공

        IComparable c;
    }
}
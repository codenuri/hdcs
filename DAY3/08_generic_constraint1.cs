using System;
using static System.Console;

class Program
{
    // 아래 코드는 에러!!
    // => 임의의 타입 T 안에 "CompareTo" 가 있다는 보장이 없기 때문에
    // => Max 안에서는 object 타입으로 할수 있는 것만 가능.
    // => 이전의 "swap" 예제는 메소드 호출하는 코드가 없다!!
    //    단지, = 연산만!!
    /*
    public static T Max<T>(T a, T b)
    {
        a.ToString(); // 이 코드는 가능. 
                      // C#의 모든 타입은 Object 에서 파생되는데
                      // ToString()은 object 안에 있다

        return a.CompareTo(b) < 0 ? b : a;            
    }
    */

    // 해결책 : Generic Constraint 표기 - 128 page
    // => 제약을 만족하는 타입만 전달 받겠다는 의미
    // => 따라서, {} 안에서 제약에 맞는 동작은 가능하다.
    public static T Max<T>(T a, T b) where T : IComparable
    {
        return a.CompareTo(b) < 0 ? b : a;
    }

    public static void Main()
    { 
        int n1 = 10, n2 = 20;

        string s1 = "AA", s2 = "BB";

        int ret1 = Max(n1, n2);
        string ret2 = Max(s1, s2);

        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);

//      Point ret3 = Max(p1, p2); // error. IComparable을 구현한 타입이 아닙
    }
}


class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);
}


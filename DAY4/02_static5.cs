using System;

// 수학관련 함수를 라이브러리로 제공하고 싶다.
// => C# 9.0 이전에는 모든 메소드는 반드시 클래스 안에 있어야 했습니다.
// => 이런경우, 각 메소드를 호출하기 위해 아래 Math 객체를 만들게 할 필요 없습니다.
// => 그래서 모든 메소드를 Static 으로 하게 됩니다.

class Math
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Sub(int a, int b)
    {
        return a - b;
    }
}
class Program
{
    public static void Main()
    {
        int n = Math.Add(1, 2);
    }
}
using System;


struct Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    public static bool operator ==(Point a, Point b)
    {
        return a.x == b.x && a.y == b.y;
    }
    public static bool operator !=(Point a, Point b)
    {
        return !(a == b);
    }
}

class Program
{
    public static void Main()
    {
        // Point 는 value 타입입니다.
        // => 아래 p1, p2 는 다른 객체입니다.
        Point p1 = new Point(1, 2);
        Point p2 = p1;

        // #1. == 연산자 
        // => 기본적으로 제공하지 않음. 컴파일 에러
        // => 하지만 Point 타입 설계자가 "연산자 재정의로 제공" 가능. 
        bool b1 = (p1 == p2);

        // #2. Equals() virtual method
        // => Object Equals 기본 구현 : 동일한 객체인가 ?
        // => ValueType 구현변경 : 객체의 전체 메모리가 동일한가 조사 
        // => 모든 struct 는 ValueType 으로 부터 파생됨
        bool b2 = p1.Equals(p2); // 그래서, p1, p2 가 같은 상태 인가 조사

        Console.WriteLine($"{b2}"); // True
    }
}
/*
class Object
{
    public virtual bool Equals(Object obj)
    {
        // 기본 구현은 "객체가 동일한가"!!
    }
}

class ValueType : Object
{
    public override bool Equals(Object obj)
    {
        // 객체의 메모리 전체를 비트 단위로 비교해서
        // 메모리 내용자체가 동일한가로 구현
    }
}
// C# 규칙 : 모든 구조체(value_type) 은 자동으로 ValueType 으로 부터 파생 된다.
struct Point // ValueType
{

}
*/
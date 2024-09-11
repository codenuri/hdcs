using System;

// Clone() 이라는 메소드 이름을 "인터페이스로 약속" 하고 싶다.
/*
// C# 1.0 : Generic 문법이 없었습니다
// => 그래서 Clone() 메소드의 반환 타입을 object 로 할수 밖에 없었습니다
// => 그래서 Clone() 메소드 사용시 "interface5.cs" 처럼 캐스팅 필요
interface ICloneable
{
    object Clone();
}

// C#2.0 : Generic 문법이 도입됩니다.
// => 모든 인터페이스의 Generic 버전이 추가됩니다.
interface ICloneable<T>
{
    T Clone();
}
*/
class Point : ICloneable<Point>
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    public Point Clone()
    {
        Point pt = new Point(x, y);
        return pt;                 
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = p1;
 
        Point p3 = p1.Clone();

        IComparable c1;         // C# 1.0
        IComparable<Point> c2;  // C# 2.0
    }
}

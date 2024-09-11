using static System.Console;

// 107 page
/*
class Object
{
    public virtual bool Equals(Object   obj )
    {

    }
}
*/




class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    // Object obj = new Point(); // 이 코드는 가능하지만
    // int n = obj.x;      // 이렇게 접근은 안됩니다.
    // int n = ((Point)obj.x)  이렇게 해야 합니다.
    public override bool Equals(object? obj)
    {
        // 아래 코드는 "동일 객체" 여부가 아니라
        // "객체의 상태" 끼리 조사하는 코드!

        Point pt = (Point)obj;

        return x == pt.x && y == pt.y;
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = p1;

        Point p3 = new Point(1, 2);
        Point p4 = new Point(1, 2);

        bool b3 = p1.Equals(p2);
        bool b4 = p3.Equals(p4);

        WriteLine($"{b3}"); // True
        WriteLine($"{b4}"); // True

    }
}

// equality 조사 방법
// 1. p1 == p2
// => 객체가 동일한지 조사.

// 2. p1.Equals(p2) 
// => Object 기본 구현은 "객체가 동일"한지 조사
// => 파생 클래스 제작자가 변경 가능.
// => 보통 "객체의 상태(값)이 동일한지 조사" 하도록 변경
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

    // C# 은 사용자 정의 클래스에 대해서 +, -, == 등의 연산자를
    // 재정의 할수 있습니다.
    // => static method 로 만들게 됩니다.
    public static bool operator==(Point a, Point b)
    {
        return a.x == b.x && a.y == b.y;
    }
    public static bool operator !=(Point a, Point b)
    {
        return !(a== b);
    }
    // 참고 : == 를 만들때는 반드시 != 도 같이 제공해야 합니다.
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(1, 2);

        WriteLine($"{p1 == p2}");

        // == 연산자가 재정의된 상태에서 "객체의 동질성"을 조사하려면
        // 아래 처럼하면 됩니다.
        bool b = ((Object)p1) == p2;

        WriteLine($"{b}");

        // 아래 함수를 생각해 보세요. 
        bool b2 = ReferenceEquals(p1, p2);  
        WriteLine($"{b2}");

        // 아래의 ReferenceEquals() 의 원리로 만든것이
        // Object.ReferenceEquals() 입니다.
        bool b3 = Object.ReferenceEquals(p1, p2); // 항상 객체의 동질성조사
        WriteLine($"{b3}");
    }

    public static bool ReferenceEquals(Object a, Object b)
    {
        return a == b;
    }

}





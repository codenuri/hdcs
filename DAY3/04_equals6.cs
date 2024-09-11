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
    public static bool operator ==(Point a, Point b)
    {
        return a.x == b.x && a.y == b.y;
    }
    public static bool operator !=(Point a, Point b)
    {
        return !(a == b);
    }
    // 참고 : == 를 만들때는 반드시 != 도 같이 제공해야 합니다.
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(1, 2);
        
        // 객체 동질성 조사 정리 - 115 page 오른쪽 표에서.  
        //                          reference type 에 정리해 두세요

        bool b1 = object.ReferenceEquals(p1, p2); // 항상 객체가 동일한가 조사!

        bool b2 = (p1 == p2);   // 기본적으로 "객체가 동일한가" 조사
                                // 하지만 타입설계자가 "==" 연산자를 다시 만들어서
                                // 동작 변경가능.

        bool b3 = p1.Equals(p2); // 기본적으로 "객체가 동일한가" 조사
                                 // 하지만 virtual method 이므로
                                 // override 할수 있고, 자주 override 한다.
                                 // => 객체의 상태가 동일한가로 변경하는 경우가 많다.

        bool b4 = object.Equals(p1, p2);
                    // p1 == p2 로 먼저 조사후, false 라면 p1.Equals(p2) 로 조사
                    // "상태가 동일한가 조사에 많이 사용"

        // 권장 
        // 동일 객체 조사 : object.ReferenceEquals()
        // 객체 상태 조사 : object.Equals()
        // 그런데, int, string 등 기본 타입은 "==" 로 하세요
    }
}





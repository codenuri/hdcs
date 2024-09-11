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

 
    public override bool Equals(object? obj)
    {
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

        // "p1, p2 객체의 상태" 가 동일한지 조사하려고 합니다.
        // = > 최선의 코드를 생각해 봅시다.

        // 방법 #1.
        bool b1 = p1.Equals(p2); // ??

        //-----------------------------
        // 방법 #2.
        bool b2 = p1 == p2;

        if (b2 == false)
        {
            b2 = p1.Equals(p2);
        }
        //-----------------------------
        // 방법#2 로 만들어진것이 "object.Equals(p1, p2)" 입니다.
        // => Object 클래스의 static method
        bool b3 = object.Equals(p1, p2); // 방법 #2와 동일


    }
}



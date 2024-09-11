using static System.Console;

// 사용자가 만든 타입에 CompareTo 를 제공하려면
// #1. IComparable 인터페이스를 구현하겠다고 표시 합니다.
// #2. CompareTo 를 구현합니다.

class Point  : IComparable
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    public int CompareTo(object? obj)
    {
        Point other = (Point)obj;

        // 자신의 x,y 와 ohter 의 x,y 를 가지고 누가 큰지 비교해서 반환
        // 아래 코드는 x만 으로 크기 비교
        if (x > other.x) 
            return 1;
        else if ( x < other.x) 
            return -1;

        return 0;
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(3, 4);

        int ret = p1.CompareTo(p2);

        WriteLine($"{ret}");

        Foo(p1);
    }

    // 아래 메소드는 COmpareTo 메소드가 있는 객체만 받겠다는 의도.
    public static void Foo(IComparable obj)
    {

    }
}
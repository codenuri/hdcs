using static System.Console;

// 107 page

class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = p1;

        Point p3 = new Point(1, 2);
        Point p4 = new Point(1, 2);

        // #1. == 연산자
        // => 동일한 객체인지 조사.
        bool b1 = (p1 == p2);
        bool b2 = (p3 == p4);

        WriteLine($"{b1}"); // True
        WriteLine($"{b2}"); // False

        // #2. Object 가 제공하는 Equals 가상함수 사용
        // => Object 의 기본 구현은 "동일한 객체" 인지 조사!!
        // => 그런데, "virtual method" 이므로, 기본 구현 변경가능.
        bool b3 = p1.Equals(p2);
        bool b4 = p3.Equals(p4);
    
        WriteLine($"{b3}"); // True
        WriteLine($"{b4}"); // False

    }
}

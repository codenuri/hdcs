using static System.Console;

// 106 page
/*
class Object
{
    public virtual string ToString()
    {
        //....
        // 현재 객체의 타입을 조사해서
        // 타입을 문자열 반환하도록 기본 구현제공
    }
}
*/
class Point  // : Object
{
    private int x = 0;
    private int y = 0;

    public Point(int a, int b) => (x, y) = (a, b);

    public override string ToString()
    {
        // "0, 0" 형태의 문자열로 반환 
        string s = $"{x}, {y}";

        return s;
    }
}

class Program
{
    public static void Main()
    {
        Point p = new Point(1, 2);

        string s = p.ToString();

        WriteLine(s);
    }
}

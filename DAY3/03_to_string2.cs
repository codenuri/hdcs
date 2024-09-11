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

// ToString 메소드
// => 객체의 상태를 문자열로 반환하는 용도로 사용하기 위한 메소드

// => 기본 구현은 "클래스이름을 문자열" 로 반환

// => 일반적으로는 클래스 설계자가 override 해서 객체의 상태를 반환하도록
//    하는것이 좋다.
// => Point 사용자가 디버깅 하기 편리하게.. 
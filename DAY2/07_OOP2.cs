using static System.Console;

// 사각형이 필요 하면
// => int 변수 4개를 매번 사용하지 말고
// => "Rect" 라는 타입을 먼저 만들어라

class Rect
{
    public int x1 = 0;
    public int y1 = 0;
    public int x2 = 0;
    public int y2 = 0;

    public int GetArea() {  return (x2 - x1) * (y2-y1); }
};

class Program
{
    public static void Main()
    {
        // Rect 라는 타입이 있다면 사용자는 아래 처럼 사용하게 됩니다.
        Rect rc = new Rect();

        int n = rc.GetArea();
    }
}



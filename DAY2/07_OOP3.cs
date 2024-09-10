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
    // 생성자 : 클래스 이름과 동일한 함수
    //          반환 타입을 표기하지 않고,반환하지도 않는다.
    //          객체를 생성하면 자동으로 호출
    public Rect(int a, int b, int c, int d)
    {
        x1 = a;
        y1 = b;
        x2 = c;
        y2 = d;
    }
    public int GetArea() { return (x2 - x1) * (y2 - y1); }
};

class Program
{
    public static void Main()
    {
        Rect rc = new Rect(1, 1, 10, 10);

        int n = rc.GetArea();
    }
}



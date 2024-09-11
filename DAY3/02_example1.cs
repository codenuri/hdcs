using static System.Console;

// 파워 포인트 같은 프로그램을 만드는 것을 생각해 봅시다.

// #1. 모든 도형을 타입(클래스)로 설계 한다.

class Rect
{
//    private int w, y, w, h;  그리고 생성자로 초기화.  코드 생략

    public void Draw() { WriteLine("draw Rect"); }
}

class Circle
{
    public void Draw() { WriteLine("draw Circle"); }
}

class Program
{
    public static void Main()
    {
        while (true)
        {
            int cmd = int.Parse(Console.ReadLine());

            if (cmd == 1)
            {
                Rect rc = new Rect();
            }
            else if (cmd == 2)
            {
                Circle c = new Circle();
            }
        }
    }
}
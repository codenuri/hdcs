using static System.Console;

// 파워 포인트 같은 프로그램을 만드는 것을 생각해 봅시다.

// #1. 모든 도형을 타입(클래스)로 설계 한다.

// #2. 모든 도형은 공통의 특징이 있다(색상등...)
//     공통의 특징은 기반 클래스로 제공한다.!!
//     => 기반 클래스가 있다면 기반 클래스 타입으로 보관하는 경우
//        모든 종류의 도형을 한개의 배열에 보관 가능하다.

class Shape
{
    // 모든 도형의 공통의 특징을 이곳에서 제공.
    private int color = 0;
}
class Rect : Shape 
{
//    private int x, y, w, h;  그리고 생성자로 초기화.  코드 생략

    public void Draw() { WriteLine("draw Rect"); }
}

class Circle : Shape
{
    public void Draw() { WriteLine("draw Circle"); }
}

class Program
{   
    public static void Main()
    {
        // 만들어진 모든 도형을 보관하기 위한 배열
//      Rect[] arr = new Rect[10];    // Rect 객체만 보관 가능한 배열
        Shape[] arr = new Shape[10];  // 모든 도형(Shape)로 부터 파생된
                                      // 을 보관 가능한 배열!!!
                                      // upcasting 의 장점

        while (true)
        {
            string s = Console.ReadLine();
            int cmd = int.Parse( s );

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
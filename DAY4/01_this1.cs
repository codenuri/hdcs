using static System.Console;

class Point
{
    private int x = 0;
    private int y = 0;

    // 파이썬 : 객체의 참조를 개발자가 메소드 만들때 직접 코드 
    //         def Set(self, a, b)
    // C#/Java/C++ : 개발자는 아래 왼쪽 처럼 코드 작성. 
    //               컴파일러가 오른쪽 처럼 변경
    public void Set(int a, int b) // void Set(Point this, int a, int b)
    {
        x = a;                      // this.x = a;
        y = b;                      // this.y = b;

        // this : 현재 메소들 호출한 객체의 참조
    }
}
class Program
{
    public static void Main()
    {
        Point p1 = new Point();
        Point p2 = new Point();

        p1.Set(1, 2); // 컴파일러에 의해서 "Set(p1, 1, 2)" 처럼 변경
        p2.Set(3, 4); // Set(p2, 3, 4)

    }
}



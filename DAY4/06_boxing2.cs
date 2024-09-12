using static System.Console;


//class Point
struct Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int a, int b) => (X, Y) = (a, b);
}

class Program
{
    public static void Main()
    {
        // 아래 코드의 메모리 그림이 117 page
        Point p1 = new Point(1, 1);

        object o = p1; // 이순간 stack 에 있는 p1의
                       // 1. 복사본을  힙에 생성하고
                       // 2. o 는 힙에 있는 복사본을 가르키게 됩니다.
                       // => 이런 현상을 Boxing 이라고 합니다.
                        

        Point p2 = (Point)o; // 이순간
                        // 1. p2 는 스택에 만드는데
                        // 2. 힙에 있는 복사본으로 초기화
                        // => 이런 현상을 UnBoxing 이라고 합니다.
        
        p1.X = 2;
        p1.Y = 2;


        Console.WriteLine($"{p2.X}, {p2.Y}");
        // 1, 1



    }
}
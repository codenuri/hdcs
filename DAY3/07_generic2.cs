using System;

// 클래스도 Generic 으로 할수 있습니다.

class Point<T>
{
//  private T x = 0;  // error. 임의의 타입 T가 0으로 초기화 될수없습니다.
    private T x = default;  // 이럴때 default 사용
    private T y = default;  // T 가 int, double 이면 0
                            // reference type 이면 null
                            // 21 page 표 참고

    public Point(T a, T b) => (x, y) = (a, b);
}

class Program
{
    public static void Main()
    {
        // 클래스 Generic 은 기본적으로 타입인자 전달해야 합니다.
        // => 함수 Generic 은 타입 인자 생략 가능

        Point<int> p1 = new Point<int>(0, 0);
        Point<double> p2 = new Point<double>(1.1, 2.2);

     
    }
}

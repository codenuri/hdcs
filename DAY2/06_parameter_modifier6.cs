using System;

// Point : class 이므로 reference type 
class Point
{
    public int x = 0;
    public int y = 0;
}
class Program
{
    // reference type 을 인자로 받는 경우는
    // => ref 가 없어도
    // => 원본 객체를 수정할수 있습니다.
    // => "참조변수"에 대한 "복사본" 이므로 
    // => "ref" 를 표기해도 됩니다.
    public static void Foo(Point pt)
    {
        pt.x = 10; // !!
    }
    public static void Main()
    {
        Point p1 = new Point();
        Foo(p1);

        Console.WriteLine($"{p1.x}"); // 10
    }
}
// 51 page ~ 

// named argument
class Program
{
    public static void SetRect(int x,     int y, 
							   int width, int height) {}

    public static void Main()
    {
        // positional argument
        SetRect(10, 10, 30, 30);

        // named argument
        SetRect(x:10, y:10, width:30, height:30);

        SetRect( width: 30, height: 30, x: 10, y: 10); // 순서 변경가능

        // positional argument 와 named argument 를 동시에 사용가능.
        SetRect(10, 10, width: 30, height: 30);

        // 주의. named argument 뒤에는 positional 이 나올수 없습니다.
        // positional 을 먼저 사용하고, named 는 뒤쪽에
        SetRect(10, y:10, 30, height: 30); // error
    }
}

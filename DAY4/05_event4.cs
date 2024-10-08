using static System.Console;


delegate void HANDLER();
// class HANDLER {}

class Button
{
    public int   x; // 
    //     타입  변수이름

//  public HANDLER Click = null;        // +=, -=, = 모두 사용가능
//         타입    변수이름

    public event HANDLER Click = null;  // +=, -= 만 사용가능.
                                        // = 는 사용할수 없음.

    public void UserPressButton()
    {
        Click?.Invoke();
    }
}
class Program
{
    public static void F1() => WriteLine("F1");
    public static void F2() => WriteLine("F2");
    public static void F3() => WriteLine("F3");

    public static void Main()
    {
        Button btn1 = new Button();

        btn1.Click += F1;
        btn1.Click += F2;
//      btn1.Click = F3;  // error
        btn1.Click += F3;  // ok

        btn1.UserPressButton();
    }
}
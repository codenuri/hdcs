using static System.Console;


delegate void HANDLER();  

class Button
{
    public HANDLER Click = null;

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

        btn1.Click = F1;
        btn1.Click += F2;
//      btn1.Click += F3;

        btn1.Click = F3; // += 로 하려고 했는데, 실수로 = 를 사용했다
                        // 이전 등록된 메소드가 모두 reset 되었다!!
                        // 이런 실수를 막기위해서 나온 키워드가 "event"
                        // => 다음소스에서

        btn1.UserPressButton();
    }
}
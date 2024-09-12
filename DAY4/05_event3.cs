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
        btn1.Click += F3;

        btn1.UserPressButton();
    }
}
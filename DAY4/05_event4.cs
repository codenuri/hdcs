using static System.Console;


delegate void HANDLER();
// class HANDLER {}

class Button
{
    public int   x; // 
    //     Ÿ��  �����̸�

//  public HANDLER Click = null;        // +=, -=, = ��� ��밡��
//         Ÿ��    �����̸�

    public event HANDLER Click = null;  // +=, -= �� ��밡��.
                                        // = �� ����Ҽ� ����.

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
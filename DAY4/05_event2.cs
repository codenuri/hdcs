using static System.Console;


delegate void HANDLER();  // Ŭ����(Ÿ��)�� �����
// class HANDLER { }

class Button
{
    public HANDLER Click = null;

    public void UserPressButton()
    {
        Click?.Invoke();    // �Ʒ� �ڵ�� ����. 

//      if (Click != null )
//          Click();
    }
}

class Program
{
    public static void F1() => WriteLine("F1");
    public static void F2() => WriteLine("F2");

    public static void Main()
    {
        Button btn1 = new Button();
        Button btn2 = new Button();

        btn1.Click = F1;    // ��ư�� �������� ȣ��� �޼ҵ带 ���
        btn2.Click = F2;

        btn1.UserPressButton(); 	
        btn2.UserPressButton();
    }
}
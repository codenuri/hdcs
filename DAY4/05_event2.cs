using static System.Console;


delegate void HANDLER();  // 클래스(타입)을 만든것
// class HANDLER { }

class Button
{
    public HANDLER Click = null;

    public void UserPressButton()
    {
        Click?.Invoke();    // 아래 코드와 동일. 

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

        btn1.Click = F1;    // 버튼을 눌렀을때 호출될 메소드를 등록
        btn2.Click = F2;

        btn1.UserPressButton(); 	
        btn2.UserPressButton();
    }
}
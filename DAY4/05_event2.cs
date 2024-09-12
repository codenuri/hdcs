using static System.Console;

class Button
{
    public void UserPressButton()
    {

        WriteLine("To Do Something");
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

        btn1.Click = F1;    // 버튼을 눌렀을때 호출될 함수를 등록
        btn2.Click = F2;

        btn1.UserPressButton(); 	
        btn2.UserPressButton();
    }
}
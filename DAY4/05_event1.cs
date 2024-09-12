using static System.Console;

class Button
{
	public void UserPressButton()
	{
		// 여기서 직접 어떤 작업을 하면
		// 모든 버튼이 동일한 작업을 하게 됩니다.
		WriteLine("To Do Something"); 
	}
}

class Program
{
	public static void Main()
	{
		Button btn1 = new Button();
		Button btn2 = new Button();
	
		btn1.UserPressButton();	// 사용자 버튼을 눌렀다고 가정. 	
		btn2.UserPressButton();		
	}
}
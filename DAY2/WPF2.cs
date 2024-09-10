using System;
using System.Windows;
using System.Windows.Media;

// 객체지향 
// => 필요한 타입을 만들어서 사용하는 언어.
// => 개발자가 클래스를 만들기도 하지만
// => 이미 만들어서 제공되는 클래스가 분야별로 수천개!!!

// GUI 를 위한 클래스 라이브러리
// => winforms : 초창기. 
// => WPF      : 2010년경에 등장해서 많이 사용
// => UWP, WinUI3 : 최신.. 아직 많이 사용안함. WPF 와 거의 유사
// 
class WPF1
{
    [STAThread] // 프로그램에서 GUI를 만들때는 반드시 적어야 합니다
    public static void Main()
    {
        Window w = new Window();

        w.Title = "hello";
        w.Left = -800;  //100 으로하세요
        w.Top = 100;
        w.Width = 500;
        w.Background = new SolidColorBrush(Colors.Red);

        w.Show();

        //        MessageBox.Show("Hello, C#");

        // GUI 를 만든경우
        // "종료 하지말고 event 를 처리하기 위해
        // "event loop" 를 수행해야 합니다.
        Application app = new Application();
        app.Run();
    }
}
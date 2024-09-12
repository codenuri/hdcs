using System;
using System.Windows;

// step3. 메세지(이벤트) 루프 수행
// => 프로그램을 종료하지 말고, GUI 에서 발생하는 이벤트 처리

class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        Window w = new Window();
        w.Title = "Hello, WPF";
        w.Show();
                
//      app.MainWindow = w; // 예전에는 필요했는데, 
                            // 지금은 없어도 됩니다.

        app.Run();
    }
}
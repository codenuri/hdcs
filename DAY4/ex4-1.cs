using System;
using System.Windows;

// step4. 윈도우에서 발생하는 이벤트 처리 
// 방법 #1. delegate 등록

class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        Window w = new Window();

        w.MouseLeftButtonDown += W_MouseLeftButtonDown;


        w.Show();

        app.Run();
    }

    private static void W_MouseLeftButtonDown(object sender, 
                        System.Windows.Input.MouseButtonEventArgs e)
    {
        Window w = (Window)sender;

        Point pt = e.GetPosition(w);

        Console.WriteLine($"{pt.X}, {pt.Y}");
    }
}
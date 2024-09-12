using System;
using System.Windows;

// 4-1 : 윈도우 이벤트 처리를 Program 클래스의 메소드에서 하는 코드
// 4-2 : 윈도우 이벤트는 윈도우 클래스 메소드에서!!!

class MainWindow : Window
{
    public MainWindow()
    {
        this.MouseLeftButtonDown += this.W_MouseLeftButtonDown;
    }

    private void W_MouseLeftButtonDown(object sender,
                         System.Windows.Input.MouseButtonEventArgs e)
    {

        Window w = (Window)sender;
        Point pt = e.GetPosition(w);
        Console.WriteLine($"{pt.X}, {pt.Y}");
    }
}

class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        MainWindow w = new MainWindow();       

        w.Show();

        app.Run();
    }

 
}
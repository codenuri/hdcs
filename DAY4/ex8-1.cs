using System;
using System.Windows;
using System.Windows.Media;

// ex8-1. 다양한 Property
// => Window 클래스에는 다양한 속성(Property)가 있습니다.

class MainWindow : Window
{
    public MainWindow()
    {        
        Title = "Hello, WPF"; // this.Title = "Hello, WPF";
        Topmost = true;       // 최상위 윈도우
        Background = new SolidColorBrush(Colors.Green);
    }
}

class App : Application
{
    public App()
    {
    }

    [STAThread]
    public static void Main()
    {
        App app = new App();
        MainWindow w = new MainWindow();
        w.Show();
        app.Run();
    }
}

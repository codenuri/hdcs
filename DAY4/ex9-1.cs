using System;
using System.Windows;
using System.Windows.Controls;

// step9. Layout!!

class MainWindow : Window
{
    public MainWindow()
    {
        StackPanel sp = new StackPanel();

        // #1. MainWindow 의 Contents 는 StackPanel 이라는 Layout
        this.Content = sp;

        // #2. 자식 컨트롤은 모두 StackPanel(Layout)에 추가
        sp.Children.Add(new Button { Content = "btn1" });
        sp.Children.Add(new Button { Content = "btn2" });
        sp.Children.Add(new Button { Content = "btn3" });
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

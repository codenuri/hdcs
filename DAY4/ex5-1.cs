using System;
using System.Windows;

// step5-1. App 도 event 를 처리할수 있다.

class MainWindow : Window
{
    public MainWindow()
    {
    }
}

class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        app.Startup += App_Startup;

        MainWindow w = new MainWindow();

        w.Show();

        app.Run();
    }

    private static void App_Startup(object sender, StartupEventArgs e)
    {
        Console.WriteLine("프로그램시작시 해야할일수행");
    }
}
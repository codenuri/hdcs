using System;
using System.Windows;

// step5-2. App Event 는 App 클래스에서!!

class MainWindow : Window
{
    public MainWindow()
    {
    }
}

class App : Application
{
    public App()
    {
        this.Startup += App_Startup;
    }
    private void App_Startup(object sender, StartupEventArgs e)
    {
        Console.WriteLine("프로그램시작시 해야할일수행");
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
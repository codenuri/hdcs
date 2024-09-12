using System;
using System.Windows;
using System.Windows.Controls;

// step9. Grid Layout
// => 격자 모양의 Layout
// => 가장 많이 사용되지만, 약간 복잡한 편!!

class MainWindow : Window
{
    public MainWindow()
    {
        Grid grid = new Grid();

        this.Content = grid;

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

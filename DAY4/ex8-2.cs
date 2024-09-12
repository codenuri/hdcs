using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

// ex8-2. Contents 속성 - 중요
// => WPF 의 대부분의 GUI 는 한개의 객체를 표현(표시, display)할수 있다.

class MainWindow : Window
{
    public MainWindow()
    {
        // #1. 문자열 연결
        // this.Content = "Hello";

        // #2. 자식윈도우 버튼
        Button btn = new Button();

        this.Content = btn;
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

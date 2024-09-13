using System;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;

// WPF 프로그램의 기본 코드
// 1. 2개의 클래스 작성
// => Application 파생 클래스 : 프로그램의 시작/종료시 할일, event loop, Main method
// => Windows 파생 클래스     : GUI 윈도우를 만들기 위해

// 2. Project 파일 수정해야 합니다. 

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

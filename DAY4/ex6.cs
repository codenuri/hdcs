using System;
using System.Windows;

// step6. Main 함수를 별도의 클래스로 하지말고 App 클래스 안으로
// => 아래 코드가 WPF 를 사용하는 프로그램의 기본 코드
// => 2개의 클래스로 구성

// App : 프로그램의 시작, 종료시 해야 할일 작성, Event 루프 제공,
//       Main 함수도 포함

// MainWindow : UI(주된 윈도우) 제공.

// 이제 모든 WPF 프로그램은 아래 코드부터(복사해서) 작성

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

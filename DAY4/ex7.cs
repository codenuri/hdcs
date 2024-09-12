using System;
using System.Windows;

// step 7. 객체간의 참조 얻기

// 아래 WPF 프로그램은 크게 2개의 객체가 생성됩니다.
// App 객체, MainWindow 객체

// MainWindow 클래스에서 App 의 참조가 필요 하면
// => Application.Current
// => 보통 캐스팅해서 사용 : ((App)Application.Current).메소드이름()


class MainWindow : Window
{
    public void MainWindowFoo()
    {
        Console.WriteLine("MainWindow Foo");
    }
    public MainWindow()
    {
        this.MouseLeftButtonDown += MainWindow_MouseLeftButtonDown;

    }

    private void MainWindow_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        // App클래스의 Foo 호출해 보세요

        // #1. MainWindow 안에서 App 객체의 참조가 필요하면
        // Application.Current : Main 에서 만든 App 객체의 참조
        //                       그런데, Application 타입

        ((App)Application.Current).AppFoo();
    }
}

class App : Application
{
    public void AppFoo() 
    { 
        Console.WriteLine("AppFoo"); 

        // MainWindowFoo 호출!
        // 힌트 : ex3.cs 주석 참고
    }

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

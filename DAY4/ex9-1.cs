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
        // sp.Children : List 입니다. 따라서, Add 로 컨트롤 추가

        sp.Children.Add(new Button { Content = "btn1" });
        sp.Children.Add(new Button { Content = "btn2" });
        sp.Children.Add(new Button { Content = "btn3" });

        // #3. stack panel 은 자식들을 한줄로 배치
        // => 다양한 속성도 있습니다.
        sp.Orientation = Orientation.Horizontal;
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

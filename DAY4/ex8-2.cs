using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// ex8-2. Contents 속성 - 중요
// => WPF 의 대부분의 GUI 는 한개의 객체를 표현(표시, display)할수 있다.

class MainWindow : Window
{
    public MainWindow()
    {
        // #1. 문자열 연결
        // this.Content = "Hello";

        // #2. 자식윈도우 버튼
        /*
        Button btn = new Button();
        btn.Content = "확인";
        this.Content = btn;
        */
        // 위 3줄은 아래 한줄로 가능
        // => 객체 생성시 {} 하고, 속성을 바로 지정.
        // this.Content = new Button { Content = "확인" };

        // #3. 그림연결
        // => Contents 에 연결되려면 UIElement 라는 클래스로 부터 파생된
        //    클래스만 가능
        Uri uri = new Uri("D:\\totoro.jpeg");

        BitmapImage bitmap = new BitmapImage(uri);

        //this.Content = bitmap; // error

        Image img = new Image { Source = bitmap };

        this.Content = img;
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

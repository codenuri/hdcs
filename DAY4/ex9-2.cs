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

        // #1. Row, Col 갯수 지정
        // => grid.SetRolCount(3) 이 절대 아닙니다.
        // => 객체지향 입니다. 아래 코드가 2* 2로 설정
        grid.RowDefinitions.Add(new RowDefinition());
        grid.RowDefinitions.Add(new RowDefinition());
        grid.ColumnDefinitions.Add(new ColumnDefinition());
        grid.ColumnDefinitions.Add(new ColumnDefinition());

        // #2. 자식 컨트롤 생성
        Button btn1 = new Button { Content = "btn1" };
        Button btn2 = new Button { Content = "btn2" };

        // #3. 컨트롤이 어느 위치에 놓일지 지정
        // => 약간 특이한 방식 입니다. 
        // => Grid 의 static method 사용
        Grid.SetRow(btn1, 0);
        Grid.SetColumn(btn1, 0);

        Grid.SetRow(btn2, 1);
        Grid.SetColumn(btn2, 1);

        // #4. grid 의 자식 list 에 버튼 추가
        grid.Children.Add(btn1);
        grid.Children.Add(btn2);


        // 아래 코드 생각해 보세요
        StackPanel sp = new StackPanel();

        Grid.SetRow(sp, 0);
        Grid.SetColumn(sp, 1);

        grid.Children.Add(sp);

        sp.Children.Add(new Button { Content = "btn3" });
        sp.Children.Add(new Button { Content = "btn4" });
        sp.Children.Add(new Button { Content = "btn5" });

        // btn1, btn2 클릭시 화면에 로깅해 보세요 ( event(delegate) 로하면됩니다.)

        btn1.Click += Btn1_Click;
        btn2.Click += Btn2_Click;
    }

    private void Btn2_Click(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("button1 click");
    }

    private void Btn1_Click(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("button2 click");
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

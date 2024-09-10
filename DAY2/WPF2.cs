using System;
using System.Windows;  

class WPF1
{
    [STAThread] // 프로그램에서 GUI를 만들때는 반드시 적어야 합니다
    public static void Main()
    {
        Window w = new Window();

        w.Show();

        MessageBox.Show("Hello, C#");
    }
}
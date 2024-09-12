using System;
using System.Windows;

// step2. windows 만들기
// => System.Windows.Window  라는 클래스 사용

class Program
{
    public static void Main()
    {
        Window w = new Window();
        w.Title = "Hello, WPF";
        w.Show();

        MessageBox.Show("Hello, WPF");
    }
}
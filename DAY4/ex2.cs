using System;
using System.Windows;

// step2. windows 만들기
// => System.Windows.Window  라는 클래스 사용

// => Main 에서 GUI 를 만드는 경우는 반드시 [STAThread] 라고 표기
//    Single Thread Apartment

class Program
{
    [STAThread]
    public static void Main()
    {
        Window w = new Window();
        w.Title = "Hello, WPF";
        w.Left = -1000;

        w.Show();

        MessageBox.Show("Hello, WPF");
    }
}
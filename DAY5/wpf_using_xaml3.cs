using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;


class MainWindow : Window
{
    public void InitializeComponent()
    {

    }
    public MainWindow()
    {
        InitializeComponent();

        //....
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



        FileStream fs = new FileStream("../../../MyXaml3.xaml", FileMode.Open);

        Window w = (Window)XamlReader.Load(fs);

        fs.Dispose();




        w.Show();
        app.Run();
    }
}


// http://schemas.microsoft.com/winfx/2006/xaml/presentation
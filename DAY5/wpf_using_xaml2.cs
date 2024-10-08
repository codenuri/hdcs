﻿using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;


// #1. "MyXaml.xaml" 이라는 새로운 파일 추가 하세요
// => 빌드는 "없음" 으로 하세요


class MainWindow : Window
{
    // XAML 로 UI 를 만드는 함수
    public void InitializeComponent()
    {
        // 현재 디렉토리 : 실행파일이 있는 폴더. 
        // 프로젝트 폴더에 있는 파일에 접근하기 위한 경로는 아래 처럼
        FileStream fs = new FileStream("../../../MyXaml2.xaml", FileMode.Open);

        StackPanel sp = (StackPanel)XamlReader.Load(fs);

        fs.Dispose(); // 파일 즉시 닫기

        this.Content = sp;
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
        MainWindow w = new MainWindow();
        w.Show();
        app.Run();
    }
}


// http://schemas.microsoft.com/winfx/2006/xaml/presentation
// 교재 149 이후 WPF 내용있습니다. 4page

// 콘솔 프로젝트에서 "GUI" 라이브러리인 WPF 를 사용하려면
// 프로젝트 설정파일에서
// #1. <UseWPF>true</UseWPF>  추가
// #2. <TargetFramework>net8.0-windows</TargetFramework> 변경

// 콘솔창을 제거 하려면
// <OutputType>WinExe</OutputType>  => 콘솔없음
// <OutputType>Exe</OutputType>     => 콘솔있음

using System;
using System.Windows;   // 이안에 MessageBox 클래스 있습니다.

class WPF1
{
    public static void Main()
    {
        MessageBox.Show("Hello, C#");
    }
}
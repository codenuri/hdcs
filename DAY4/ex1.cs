// ex1.cs
using System;
using System.Windows;

// WPF 
// => Windows Presentable Framework
// => .net 기반(C#) GUI 라이브러리
// => WinForm 의 다음 버전(대체자)

// step1. 환경설정
// 1. 콘솔 프로젝트로 만들고
// 2. 프로젝트 파일에서 1개 항목 추가, 1개 항목 수정
// 	  추가할것 : <UseWPF>true</UseWPF> 
//    변경할것 : <TargetFramework>net8.0-windows</TargetFramework>

class Program
{
    public static void Main()
    {
        MessageBox.Show("Hello, WPF");
    }
}
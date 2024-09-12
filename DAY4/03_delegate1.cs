using System;
using static System.Console;

// delegate1.cs - 130p ~ 
// => 다른 언어에서 볼수 없는 C# 만의 특징
// => C/C++ 의 함수 포인터 개념을 C# 방식으로 만든것

// #1. delegate 란 : 메소드의 호출 정보를 보관했다가 나중에 호출 할수 있게 하는 타입

// #2. 만드는 법 정확히 알아 두세요.
// => 메소드의 선언만 복사한후에
// => 앞에 "delegate" 표기하고
// => 메소드 이름 위치를 "원하는 이름(타입명)"으로 변경

delegate void MyFunc(int arg);  // MyFunc 라는 타입을 만든것

class Program
{
	public static void Main()
	{
		// ? 에 맞는 타입을 생각해 보세요
		int    n = 10;
		double d = 3.4;
		string s = "abc";

        MyFunc f = Foo; // 함수 자체의 정보를 담는 타입이 필요
		f(10); // Foo(10)
	}

	public static void Foo(int arg)
	{
		WriteLine($"Foo : {arg}");
	}
}

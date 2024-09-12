using System;
using static System.Console;

// delegate1.cs - 130p ~ 
// => 다른 언어에서 볼수 없는 C# 만의 특징
// => C/C++ 의 함수 포인터 개념을 C# 방식으로 만든것

// delegate 의 원리  - 132 page

delegate void MyFunc(int arg);


// 위 코드를 가지고 컴파일러는 아래 클래스를 생성 합니다.
// => MulticastDelegate 로 부터 파생된 클래스는 사용자가 직접만들수 없습니다.
// => 컴파일러만이 생성 가능
/*
class MyFunc : MulticastDelegate
{
    // 리턴타입이 void 이고, 인자가 int 한개인
    // 메소드의 정보를 보관하기 위한 코드를 생성
    // 
}
*/





class Program
{
    public static void Main()
    {
        MyFunc f1 = new MyFunc(Foo); // 이 표기법이 정확한 표기법

        MyFunc f2 = Foo; // 이 표기법도 지원하는 것
                         // 일반적인 코딩 관례

        f2(10); 
    }

    public static void Foo(int arg)
    {
        WriteLine($"Foo : {arg}");
    }
}

using System.Text;
using static System.Console;

// 54 page ~ 　　

// 핵심 #1. value type 은 대입연산시 "복사본 생성" 합니다.
// int n1 = 10;
// int n2 = n1;



class Program
{
	// 인자 전달은 결국 "변수를 만들면서 초기화" 하는 것
	public static void Inc1(int x)
	{
		++x;	// 복사본 증가. 
	}

    public static void Inc2(ref int x)
    {
        ++x;   
    }

    public static void Main()
	{
		int a = 1, b = 1;

		Inc1(a);     // "int x = a", call by value, a 증가 안함
        Inc2(ref b); // b의 복사본을 만들지 말고, 참조(reference)로 받아달라

        WriteLine($"{a}");  // 1
        WriteLine($"{b}");  // 2

    }
}
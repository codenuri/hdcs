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

    // 핵심 : 인자를 받을때 ref 를 표기하면
    // => 호출시 에도 "ref" 필요 합니다. Inc2(ref b)
    // => 복사본을 만들지 말고, 참조(reference)로 받아 달라는 것
    // => 의도 : main 에서 만든 변수를 수정하겠다는것
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

        // C#1.0 ~ : ref 는 함수 인자로만 사용가능했습니다.
        // C#6.0 ~ : ref 를 지역변수에도 사용가능합니다.

        int n1 = 10;
        int n2 = n1; // 복사본 생성

        ref int n3 = ref n1; // ok. 6.0 부터 가능.

        n3 = 20; // n1 도 변경
        WriteLine($"{n1}"); // 20
    }
}
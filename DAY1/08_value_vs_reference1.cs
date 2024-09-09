using static System.Console;

// value type vs reference type 개념
// => C#, Java, Swift, Kotlin 등 거의 모든 객체지향언어의 공통의 특징
// => C++에는 없는 특징

// C/C++ : 메모리의 위치를 타입 사용자 결정합니다.

// C#/Java/Swfit/Kotlin : 타입의 설계자가 메모리 위치 결정

// struct 만든 타입: 변수(객체) 생성시 스택에 생성 - value type
// class  만든 타입: 변수(객체) 생성시 힙에 생성 - reference type


class CPoint
{
	private int x;
	private int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	private int x;
	private int y;
	public SPoint(int a, int b) { x = a; y = b;}	
}
class Program 
{
	public static void Main()
	{
		// 아래 2줄은 완전히 동일합니다.
		// => 그런데, 메모리 그림이 완전히 다릅니다.
		// => 27 page 완벽히 이해 하세요
		CPoint cp = new CPoint(0, 0);
		SPoint sp = new SPoint(0, 0);	
	}
}

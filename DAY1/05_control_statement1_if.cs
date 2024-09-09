using static System.Console;

// 모든 프로그램 언어의 기본
// 2개의 제어문 : if, switch
// 3개의 반복문 : for, while, do~while  

// C# 은 위내용에 "foreach" 가 추가. 

// if 문
// => C언어와 거의 동일

int score = 75;

if ( score > 70 ) 
{
	WriteLine("pass");	// 실행할 문장이 한줄이면 {} 생략가능
}
else if ( score == 70 )
{
	WriteLine("reexam");
}
else 
{
	WriteLine("fail");
}

// C와의 차이점 : 정수 변수 이름만 넣을수 없습니다.
if ( score ) { } // C언어는 가능하지만
				 //	C#에서는 error. 반드시 "score != 0" 로해야 한다.

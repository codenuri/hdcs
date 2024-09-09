using static System.Console;

// while
// => C와 거의 동일

int cnt = 0;
while( cnt < 10 )
{
	Write($"{cnt}, ");
	++cnt;
}
WriteLine(); // 개행만 하겠다(빈줄 출력)

cnt = 0;
while( true )	// 무한루프
{
	Write($"{cnt}, ");

	if ( ++cnt == 10)
		break;	// 루프 탈출
}

//while( cnt ) {} // C언어는 조건식으로 변수 이름만도 가능
//				   // C#은 안됨. error

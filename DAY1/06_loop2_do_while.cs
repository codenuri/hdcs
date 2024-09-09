using static System.Console;

// do-while
// => C와 거의 동일

int cnt = 0;

do
{
	Write($"{cnt}, ");
	++cnt;
}
while( cnt < 10 );

WriteLine();

cnt = 0;

do
{
	Write($"{cnt}, ");

	if ( ++cnt == 10)
		break;
} while( true );


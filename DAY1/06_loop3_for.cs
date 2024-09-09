using static System.Console;


// for
// => C客 芭狼 悼老

int[] x = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

for( int i = 0; i < 10; i++ )
{
	WriteLine($"{i} : {x[i]}");
}

int j = 0;

for( ; ; )	// 公茄 风橇(C客 悼老)
{
	WriteLine($"{j} : {x[j]}");

	if ( ++j == 10 )
		break;
}

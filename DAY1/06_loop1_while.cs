using static System.Console;

// while
// => C�� ���� ����

int cnt = 0;
while( cnt < 10 )
{
	Write($"{cnt}, ");
	++cnt;
}
WriteLine(); // ���ุ �ϰڴ�(���� ���)

cnt = 0;
while( true )	// ���ѷ���
{
	Write($"{cnt}, ");

	if ( ++cnt == 10)
		break;	// ���� Ż��
}

//while( cnt ) {} // C���� ���ǽ����� ���� �̸����� ����
//				   // C#�� �ȵ�. error

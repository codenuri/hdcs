using static System.Console;

// ��� ���α׷� ����� �⺻
// 2���� ��� : if, switch
// 3���� �ݺ��� : for, while, do~while  

// C# �� �����뿡 "foreach" �� �߰�. 

// if ��
// => C���� ���� ����

int score = 75;

if ( score > 70 ) 
{
	WriteLine("pass");	// ������ ������ �����̸� {} ��������
}
else if ( score == 70 )
{
	WriteLine("reexam");
}
else 
{
	WriteLine("fail");
}

// C���� ������ : ���� ���� �̸��� ������ �����ϴ�.
if ( score ) { } // C���� ����������
				 //	C#������ error. �ݵ�� "score != 0" ���ؾ� �Ѵ�.

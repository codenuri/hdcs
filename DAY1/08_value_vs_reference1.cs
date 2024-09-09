using static System.Console;

// value type vs reference type ����
// => C#, Java, Swift, Kotlin �� ���� ��� ��ü�������� ������ Ư¡
// => C++���� ���� Ư¡

// C/C++ : �޸��� ��ġ�� Ÿ�� ����� �����մϴ�.

// C#/Java/Swfit/Kotlin : Ÿ���� �����ڰ� �޸� ��ġ ����

// struct ���� Ÿ��: ����(��ü) ������ ���ÿ� ���� - value type
// class  ���� Ÿ��: ����(��ü) ������ ���� ���� - reference type


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
		// �Ʒ� 2���� ������ �����մϴ�.
		// => �׷���, �޸� �׸��� ������ �ٸ��ϴ�.
		// => 27 page �Ϻ��� ���� �ϼ���
		CPoint cp = new CPoint(0, 0);
		SPoint sp = new SPoint(0, 0);	
	}
}

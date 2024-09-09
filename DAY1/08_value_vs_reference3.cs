using static System.Console;

class CPoint
{
	public int x;
	public int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	public int x;
	public int y;
	public SPoint(int a, int b) { x = a; y = b; }	
}

class Program 
{
	public static void Main()
	{
		// 28 page ������ �׸�
		// #1. class( reference type)
		CPoint cp1; // reference �� ����. ��ü ���� �ȵ�
                    // 

        int a = cp1.x;	// error  ���� ��ü�� ����.
        cp1.x = 2;      // error


		// #2
		SPoint sp1; // value type �ε� new ������
                    // ������ ȣ��ȵ�. ��, �ʱ�ȭ �ȵ�

        int b = sp1.x;	// error. �ʱ�ȭ ���� ���� ����
        sp1.x = 2;		// ok
        int c = sp1.x;	// ok. ���ٿ��� �ʱ�ȭ ��. 


		// #3. �Ʒ� �ڵ�� ���ÿ� ����� �ʱ�ȭ���� �� �ڵ�
        SPoint sp2 = new SPoint(1, 1);
		
		int d = sp2.x;	// ok
		sp2.x = 2;		// ok

	}
}

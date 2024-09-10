using static System.Console;

class Program
{
	// #1. ���ڿ� ���� modifier �� ���� ���.
	public static void no_modifier_parameter(int x)
	{
		// x �� main ���� ���� ������ ���纻
		int n = x;	// ok. ���纻 x�� ���� R
		x = 0;		// ok. W
	}

	// #2. out parameter
	public static void out_parameter(out int x)
	{
//		int n = x;	// error. out �� �ʱ�ȭ ���� ���� ������ ������ �ִ�.
		x = 0;		// ok. 
					// �׷���, ���ڵ尡 �����鿡��!!
					// out parameter �� �ݵ�� ���� �ڵ尡 �־�� �Ѵ�.
	}

	// #3. ref parameter 
	// => ���纻 ������ �ʰ�, R/W ��� �ϰڴٴ°�
	public static void ref_parameter(ref int x)
	{
		int n = x;	// ok
		x = 0;		// ok.

		// �� �ڵ尡 ��� ��� ����.
	}

	public static void Main()
	{
		int n1;
		int n2 = 0;

		out_parameter(out n1);  // ok
		out_parameter(out n2);  // ok
		
		ref_parameter(ref n1);  // error. �ʱ�ȭ �ȵȰ��� ���� �ȵ�
		ref_parameter(ref n2);  // ok

		out_parameter(out int n3); // out �� ������ ����鼭�� ���� ����. 
									// ref �� �ʱⰪ�� �ʿ��ϹǷ�
									// �̷� ǥ��� ���� ����

	}
}
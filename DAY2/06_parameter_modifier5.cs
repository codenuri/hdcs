using static System.Console;

class Program
{
	public static void Main()
	{
        // int.Parse : ���ڷ� ���� ���ڿ��� "����" �����ؼ� ��ȯ
		// => ���ڸ� ������ ��ȯ�Ҽ� ������ "����"
        int n = int.Parse("Hello");  // ���� �߻�(����)

		// int.TryParse : ��ȯ���� bool
		//				  ����� out parameter��
		//				  ���н� ���ܰ� �ƴ� ��ȯ���� false

		bool b1 = int.TryParse("hello", out int ret1); // b1�� false
        bool b2 = int.TryParse("10", out int ret2); // b2 �� true
													// ret2 ���� 10

    }
}
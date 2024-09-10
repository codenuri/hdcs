using static System.Console;

class Program
{
    // �������� ���� ��ȯ�ϰ�, �������� ���� 3��° ���ڿ� ����ְ� �ʹ�.
//	public static int AddSub(int a, int b, ref int c)
    public static int AddSub(int a, int b, out int c)
    {
		c = a - b;
		return a + b;
	}
	public static void Main()
	{
//		int ret1 = 0;
		int ret1;

//      int ret2 = AddSub(5, 3, ref ret1 ); // error. ref �� �ʱⰪ�� �ִ� ������ ����
        int ret2 = AddSub(5, 3, out ret1); // ok. �ʱⰪ�� ��� ����

        WriteLine($"{ret1}, {ret2}");

        // out �� ���� �Ʒ� ó�� ���ϰ� �Ҽ� �ֽ��ϴ�.
        // => �Լ� ȣ�� () �ȿ��� ������ ����!!!
        int ret3 = AddSub(5, 3, out int c); // ������ ����鼭 �����ϴ� ��
    }
}

// ref : �Լ� �ȿ��� "R/W"��� �Ѵٴ� �ǵ�, R �� ���ؼ��� �ݵ�� �ʱⰪ �ִ� ������ ����
// out : �Լ� �ȿ��� "W"  �� �Ѵٴ� �ǵ�, �ʱⰪ ��� ����.
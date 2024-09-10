using System.Text;
using static System.Console;

// 54 page ~ ����

// �ٽ� #1. value type �� ���Կ���� "���纻 ����" �մϴ�.
// int n1 = 10;
// int n2 = n1;



class Program
{
	// ���� ������ �ᱹ "������ ����鼭 �ʱ�ȭ" �ϴ� ��
	public static void Inc1(int x)
	{
		++x;	// ���纻 ����. 
	}

    // �ٽ� : ���ڸ� ������ ref �� ǥ���ϸ�
    // => ȣ��� ���� "ref" �ʿ� �մϴ�. Inc2(ref b)
    // => ���纻�� ������ ����, ����(reference)�� �޾� �޶�� ��
    // => �ǵ� : main ���� ���� ������ �����ϰڴٴ°�
    public static void Inc2(ref int x)
    {
        ++x;   
    }

    public static void Main()
	{
		int a = 1, b = 1;

		Inc1(a);     // "int x = a", call by value, a ���� ����
        Inc2(ref b); // b�� ���纻�� ������ ����, ����(reference)�� �޾ƴ޶�

        WriteLine($"{a}");  // 1
        WriteLine($"{b}");  // 2

        // C#1.0 ~ : ref �� �Լ� ���ڷθ� ��밡���߽��ϴ�.
        // C#6.0 ~ : ref �� ������������ ��밡���մϴ�.

        int n1 = 10;
        int n2 = n1; // ���纻 ����

        ref int n3 = ref n1; // ok. 6.0 ���� ����.

        n3 = 20; // n1 �� ����
        WriteLine($"{n1}"); // 20
    }
}
using System;
using static System.Console;

// delegate1.cs - 130p ~ 
// => �ٸ� ���� ���� ���� C# ���� Ư¡
// => C/C++ �� �Լ� ������ ������ C# ������� �����

// #1. delegate �� : �޼ҵ��� ȣ�� ������ �����ߴٰ� ���߿� ȣ�� �Ҽ� �ְ� �ϴ� Ÿ��

// #2. ����� �� ��Ȯ�� �˾� �μ���.
// => �޼ҵ��� ���� �������Ŀ�
// => �տ� "delegate" ǥ���ϰ�
// => �޼ҵ� �̸� ��ġ�� "���ϴ� �̸�(Ÿ�Ը�)"���� ����

delegate void MyFunc(int arg);  // MyFunc ��� Ÿ���� �����

class Program
{
	public static void Main()
	{
		// ? �� �´� Ÿ���� ������ ������
		int    n = 10;
		double d = 3.4;
		string s = "abc";

        MyFunc f = Foo; // �Լ� ��ü�� ������ ��� Ÿ���� �ʿ�
		f(10); // Foo(10)
	}

	public static void Foo(int arg)
	{
		WriteLine($"Foo : {arg}");
	}
}

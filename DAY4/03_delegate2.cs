using System;
using static System.Console;

// delegate1.cs - 130p ~ 
// => �ٸ� ���� ���� ���� C# ���� Ư¡
// => C/C++ �� �Լ� ������ ������ C# ������� �����

// delegate �� ����  - 132 page

delegate void MyFunc(int arg);


// �� �ڵ带 ������ �����Ϸ��� �Ʒ� Ŭ������ ���� �մϴ�.
// => MulticastDelegate �� ���� �Ļ��� Ŭ������ ����ڰ� ��������� �����ϴ�.
// => �����Ϸ����� ���� ����
/*
class MyFunc : MulticastDelegate
{
    // ����Ÿ���� void �̰�, ���ڰ� int �Ѱ���
    // �޼ҵ��� ������ �����ϱ� ���� �ڵ带 ����
    // 
}
*/





class Program
{
    public static void Main()
    {
        MyFunc f1 = new MyFunc(Foo); // �� ǥ����� ��Ȯ�� ǥ���

        MyFunc f2 = Foo; // �� ǥ����� �����ϴ� ��
                         // �Ϲ����� �ڵ� ����

        f2(10); 
    }

    public static void Foo(int arg)
    {
        WriteLine($"Foo : {arg}");
    }
}

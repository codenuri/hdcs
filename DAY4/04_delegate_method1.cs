using static System.Console;

// delegate �� �޼ҵ带 ����ϴ� ���

delegate void MyFunc(int arg);

class Test
{
    public static void SMethod(int arg) { WriteLine("Test.SMethod"); }

    public void IMethod(int arg) { WriteLine("Test_Object.IMethod"); }
}

class Program
{
    public static void Main()
    {
        Test.SMethod(1); // static method �� Ŭ�����̸����� ȣ��

        Test t = new Test();
        t.IMethod(1);    // instance method �� ��ü�� �ʿ�

        MyFunc f1 = Test.SMethod; // static method�� Ŭ���� �̸����� ���
        MyFunc f2 = t.IMethod;    // instance method �� ��ü �̸����� ���

        f1(10); // Test.SMethod(10)
        f2(10); // t.IMethod(10)
    }
}

using static System.Console;

delegate void MyFunc(int arg);

// ���� �ҽ� : �ٸ� Ŭ������ �޼ҵ� ���
// �̹� �ҽ� : ���� Ŭ������ �޼ҵ� ���

class Program
{
    public static void SMethod(int arg) { WriteLine("SMethod"); }

    public void IMethod(int arg) { WriteLine("IMethod"); }

    public static void Main()
    {
        MyFunc f1 = Program.SMethod;
        MyFunc f2 = SMethod;        // ���� Ŭ���� ����̹Ƿ� Ŭ�����̸���������
//      MyFunc f3 = IMethod; // error. ��ü�� �־�� �Ѵ�.

        Program p = new Program();
        MyFunc f3 = p.IMethod;

        p.InstanceMethod();
    }

	public void InstanceMethod()
	{
        MyFunc f1 = IMethod; // ok      ���ڵ�� �Ʒ� �ڵ�� ����Ȱ�
        MyFunc f2 = this.IMethod; // ok. 

        MyFunc f3 = Program.SMethod; // ok
        MyFunc f4 = SMethod          // ok
    }
}
// �� �ڵ� �����Ҷ�
// Main �� "static method"
// InstanceMethod �� instance method ��� ���� �� ����ϰ� ������ ������.  
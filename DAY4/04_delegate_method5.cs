delegate void MyFunc(int arg);

// ?.invoke()

class Program
{
	public static void M1(int arg)    {}
	
	public static void Main()
	{
		MyFunc f = M1;

		f(10);			// �޼ҵ� ȣ��� �̷��� �ص� �ǰ�
		f.Invoke(10);   // �̷��� �ص� �˴ϴ�.

		// invoke �� ���� ���..!
		f = null;

//		f(10); // ���� �߻�

		// �����ϰ� �Ϸ��� �Ʒ� ó���ϴµ�..
		if ( f != null)
		{
			f(10);
		}

		// ���ڵ�� �Ʒ� �����̸� �˴ϴ�.
		f?.Invoke(10);
//		f?(10); // �� ǥ����� �ȵ�..error

	}
}

class Example1
{
    private int data1 = 0;
    private int data2 = 0;
    private int data3 = 0;
    private int data4 = 0;
    private int data5 = 0;

    // #1. property �� ����� �������� �ڵ�
    public int Data1
	{   
		get { return data1; }	
		set { data1 = value; }
    }

    // #2. "expression bodied" �� ���� - 04_expressionbodied.cs
    public int Data2 
	{
		get => data2;
		set => data2 = value;
    }

    // #3. getter �� �����
	public int Data3
	{   
		get => data3; 			
    }

    // #3. setter �� �����.
    public int Data4 
	{
        set => data4 = value; 	
    }

    // #5. public getter, private setter
    public int Data5 
	{
        get => data5;
        private set => data5 = value; // �޼ҵ� �������� ��밡��
    }

    public Example1()
    {
//		data5 = 10;
        Data5 = 10;	// ok
    }	
}

class Program
{
    public static void Main()
    {
        Example1 e1 = new();
        e1.Data3 = 20; // error. setter ����.

        e1.Data4 = 30; // ok
        int n = e1.Data4; // error
    }
}

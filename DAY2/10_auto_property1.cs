// �������� C# �ڵ�
// 1. ����Ÿ(�ʵ�)�� private �����
// 2. �ʵ� ������ "property" �� ����� ���� ���� �Դϴ�.

class Example
{
    private int data1 = 0;

    public int Data1
    {
        set => data1 = value;
        get => data1;
    }

    // �Ʒ� ������ �� �ڵ�� ������ �����մϴ�.
    // 1. �ʵ� �ڵ������ǰ�
    // 2. getter/setter �� �������� �ڵ�(�� �ڵ�)�� �ڵ�����

    // "auto implemented property" ��� �մϴ�.
    public int Data2 { get; set; } = 0;
}

class Program
{
    public static void Main()
    {
        Example e = new Example();
        e.Data1 = 10;
        e.Data2 = 10;
    }
}

class Person
{
    private string name;    
    private int age = 0;    

    public Person(string n, int a)  { (name, age) = (n, a);  }

    // �Ʒ� ���� �޼ҵ带 "setter/getter" ��� �θ��ϴ�.
    public void SetName(string n)   { name = n; }
    public string GetName()         { return name; }


    // C#���� "�ٸ� ��� ���� ����" property ��� ������ �ֽ��ϴ�.
    // => Setter/Getter �� ���� ����� ����
    // => ���鶧�� "�޼ҵ�� ����" �ϰ� ��������
    //    ����Ҷ��� "�ʵ� ó��" �����ϰ� �˴ϴ�.
    // �ᱹ, Setter/Getter �����ε�, ���ϰ� �����, ���ϰ� ���

    // ���� : ����Ÿ(�ʵ�)�̸��� "�ҹ���"�� 
    //        ������Ƽ �̸��� ù��° ���ڸ� "�빮��"�� 
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    public static void Main()
    {
        Person p1 = new Person("kim", 20);

        p1.SetName("lee");
        string s = p1.GetName();

        p1.Name = "park";
        s = p1.Name;
     
    }
}

// �ᱹ C# �� Ÿ��(Ŭ����)�ȿ���
class Car
{
    // 1. �ʵ�(����Ÿ), ��κ� private 
    // 2. �޼ҵ�. "����"�� ��Ÿ���� ��. Go(), Stop()�� 
    //    => ����Ҷ� () �ʿ�. c.Go()

    // 3. ������Ƽ(�Ӽ�), ����Ÿ ���ٽ� ���, Speed
    //    => () ����.  c.Speed
}
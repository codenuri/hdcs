// ���α׷����� "���" �� �����Ϸ���
// 1. Person Ŭ������ ���弼��
// 2. ����� ��Ÿ���� ����Ÿ�� private ���弼��. �ʵ� ��� �մϴ�
// 3. �����ڸ� ���� �ʵ带 �ʱ�ȭ �ϼ���
class Person
{
    private string name;    // �ʱⰪ�� ��� �ǰ�
    private int age = 0;    // �־ �˴ϴ�.

    public Person(string n, int a)
    {
        //       name = n;
        //       age = a;
        (name, age) = (n, a); // �̷��� �ϸ� ���ڵ带 ���ٷε� ����.
    }
    
    // �����ڴ� "���� ����(��ü)������ �ʱ�ȭ" �� �뵵 �Դϴ�.
    // �����Ŀ� �����ϱ� ���ؼ��� ������ �޼ҵ� ����
    public void SetName(string n)
    {
        name = n;
    }
}

class Program
{
    public static void Main()
    {
//      Person p1 = new Person(); // error. ���ڰ� 0���� ������ ����
        Person p1 = new Person("kim", 20);

        // new Person("kim", 20) : �Լ� ȣ��� �������� ����
        //                1. Person Ÿ���� ��ü�� �����(�޸� �Ҵ�)
        //                2. ������ �޼ҵ�(Person(string, int)) ȣ��

        p1.SetName("lee");
    }
}

using static System.Console;

class Animal
{
    public void Cry1() { WriteLine("1. Animal Cry1"); }
}
class Dog : Animal
{
    public new void Cry1() { WriteLine("2. Dog Cry1"); }
}
class Program
{
    public static void Main()
    {
        Animal a = new Animal();
        Dog d = new Dog();


        Animal a2 = d;

        if (������Է°� == 1) 
            a2 = a;

        a2.Cry1();  // ��� �Լ��� ȣ�� �ɱ�� ??
                    // ���� ��ü�� Dog �ε�, ���� Ÿ���� Animal.

        // C++/C# : Animal Cry1
        // Java/Swift/Python/Kotlin �� ��κ��� ��ü���� ��� : Dog Cry1
    }
}


// a2.Cry1() �� �ڵ带 � �Լ� ȣ��� ������ ���ΰ� ?
// => �Լ� ���ε�

// 1. static binding : ������ �ð��� �����Ϸ��� ��� �Լ��� ȣ������ ����
//                     �����Ϸ��� a2 ��ü�� Ÿ�Ը� �˼� �ְ�,
//                     ����Ű�� ��ü�� Ÿ���� �˼� ����. 
//                      (����ð��� ����Ű�� ���ü�� ����ɼ� �����Ƿ�, �� main ����)
//                     �׷���, �����Ϸ��� �Լ� ȣ���� �����ϸ� ���� Ÿ���� 
//                    "Animal Cry1" ���� ����
// �������� ������, ������.
// C++/C#

// 2. dynamic binding : ������ �ð����� a2 ����Ű�� �޸𸮿� � ������ ��ü�� �ִ���
//                      �����ϴ� ���� �ڵ带 ������ ����.
//                      ����ð��� �ش� ���� �ڵ带 �����ؼ� �޸� ������ ȣ�����
//                      ����Ű�� ���� Dog ��ü�� �־��ٸ�
//                      "Dog Cry1" ȣ�� 
// ����������, ������.
// Java, Python, Swift ���� ��κ��� ��ü���� ���
// C++/C# �� virtual function
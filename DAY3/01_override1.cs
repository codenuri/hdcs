using static System.Console;

// 72 page
class Animal           
{
    public void Cry1() { WriteLine("1. Animal Cry1");}
}
class Dog : Animal
{
    // method override : ��� Ŭ���� �޼ҵ带 �Ļ� Ŭ������
    //                   �ٽ� �����ϴ� ��
    public void Cry1() { WriteLine("2. Dog Cry1");}
}
class Program
{
    public static void Main()
    {
		Animal a = new Animal(); 
		Dog    d = new Dog();

        a.Cry1();   // 1. Animal Cry1
        d.Cry1();   // 2. Dog Cry1

        
	}
}




// #1. �⼮�� ������ �ּ���

// #2. github.com/codenuri/hdcs ����  DAY3.zip �����ø� �˴ϴ�.


// #3. DAY3.zip ���� Ǯ�� DAY3.sln ���� Ŭ���ϸ� visual studio ���� 
//     ���� �ֽ��ϴ�.
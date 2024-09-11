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

        a2.Cry1();  // 어느 함수가 호출 될까요 ??
                    // 실제 객체는 Dog 인데, 참조 타입은 Animal.


    }
}


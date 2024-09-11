using static System.Console;

class Animal
{
    public void Cry1() { WriteLine("1. Animal Cry1"); }

    public virtual void Cry2() { WriteLine("1. Animal Cry2"); }
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

        a2.Cry1();  
    }
}


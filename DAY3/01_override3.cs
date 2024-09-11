using static System.Console;

class Animal
{
    // non-virtual method : static binding 해달라
    //                      함수호출 결정할때 "reference 타입"으로 결정해 달라.
    //                      실제 메모리에 어떤 객체가 있는지 조사할 필요 없다
    //                      호출 속도가 빠르다.!
    public void Cry1() { WriteLine("1. Animal Cry1"); }

    // virtual method : dynamic binding 해달라.
    //                  reference type 으로 결정하지 말고, 가리키는 메모리의 객체를
    //                  조사해서 호출해 달라.
    //                  호출시 약간의 성능저하. 
    public virtual void Cry2() { WriteLine("1. Animal Cry2"); }
}

class Dog : Animal
{
    public new void Cry1() { WriteLine("2. Dog Cry1"); }
 
    // virtual method 를 override 할때는 "new" 가 아닌 override 키워드 사용
    public override void Cry2() { WriteLine("2. Dog Cry2"); }
}
class Program
{
    public static void Main()
    {
        Animal a = new Animal();
        Dog d = new Dog();

        Animal a2 = d;

        a2.Cry1();  // 1. Animal Cry1
        a2.Cry2();  // 2. Dog Cry2
    }
}

// Animal a = new Dog();
// a.Cry()  <== 이 부분이 어떤 함수를 호출하는가 ?

// java, swift, python : 무조건 Dog 의 Cry 호출

// C++/C#              : Cry 를 어떻게 만들었냐에 따라 달라짐
//                       virtual 이라면 : Dog Cry
//                       virtual 아니면 : Animal Cry

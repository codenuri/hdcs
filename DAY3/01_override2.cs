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

        if (사용자입력값 == 1) 
            a2 = a;

        a2.Cry1();  // 어느 함수가 호출 될까요 ??
                    // 실제 객체는 Dog 인데, 참조 타입은 Animal.

        // C++/C# : Animal Cry1
        // Java/Swift/Python/Kotlin 등 대부분의 객체지향 언어 : Dog Cry1
    }
}


// a2.Cry1() 의 코드를 어떤 함수 호출과 연결할 것인가 ?
// => 함수 바인딩

// 1. static binding : 컴파일 시간에 컴파일러가 어느 함수를 호출할지 결정
//                     컴파일러는 a2 자체의 타입만 알수 있고,
//                     가리키는 객체의 타입은 알수 없다. 
//                      (실행시간에 가리키는 대상체가 변경될수 있으므로, 위 main 참고)
//                     그래서, 컴파일러가 함수 호출을 결정하면 참조 타입인 
//                    "Animal Cry1" 으로 결정
// 논리적이지 않지만, 빠르다.
// C++/C#

// 2. dynamic binding : 컴파일 시간에는 a2 가리키는 메모리에 어떤 종류의 객체가 있는지
//                      조사하는 기계어 코드를 생성해 놓고.
//                      실행시간에 해당 기계어 코드를 실행해서 메모리 조사후 호출결정
//                      가리키는 곳에 Dog 객체가 있었다면
//                      "Dog Cry1" 호출 
// 논리적이지만, 느리다.
// Java, Python, Swift 등의 대부분의 객체지향 언어
// C++/C# 의 virtual function
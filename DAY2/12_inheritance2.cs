using System;

class Animal
{
    public int age;
}

class Dog : Animal
{
    public int color;
}

class Program
{
    public static void Main()
    {
        Dog d = new Dog();

        Dog    d1 = d; // ok.
        
//      string s1 = d; // error. C# 은 static type check 언어(타입에 엄격)
                       // python 은 ok. 파이선은 모든것을 가리킬수있다.
        
        // #1. 기반 클래스 타입으로 참조 변수로 "파생 클래스 객체"를 가리킬수있다
        // => upcating 이라고 합니다
        // => 이유는 "메모리 그림"을 생각하면 됩니다.
        Animal a1 = d; // 


        // #2. Animal 타입인 a1 으로는 Animal 로 부터 물려받은 멤버만 접근가능
        //     Dog 가 추가한 멤버는 접근 못함.
        a1.age = 10;    // ok
        a1.color = 20;  // error.

        // #3. a1 으로 Dog 가 추가한 고유 멤버 접근하려면 캐스팅해야 합니다.
        //     () 사용하면 됩니다.
        //     => 컴파일러에게 a1이 가리키는 곳이 Dog 라고 알려주는 것
        ((Dog)a1).color = 20; // ok

    }
}
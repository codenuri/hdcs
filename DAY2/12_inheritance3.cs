using System;

class Animal
{
    public int age = 0;
}

class Dog : Animal
{
    public int color = 0;
}

class Cat : Animal
{
    public int speed = 0;
}

class Program
{
    //  public static void NewYear(Dog a) // 이렇게 하면 Dog 객체만 인자로 받겠다는의도
    public static void NewYear(Animal a)  // Animal 객체 뿐 아니라 모든 파생 클래스
    {                                       // 객체도 받겠다는 의도
        ++(a.age);                          // 동종(동일 기반 클래스를 사용하는 타입)
                                            // 을 처리하는 메소드 만들기
//      a.color = 10; // error. 여기서 이렇게는 안됨니다.
    }

    public static void Main()
    {
        Dog d = new Dog();
        Cat c = new Cat();

        NewYear(d);
        NewYear(c);

    }
}
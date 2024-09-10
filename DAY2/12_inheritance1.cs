// 12_inheritance1.cs
using System;

// 상속 개념 ( 103 page)
// => 기존 클래스를 확장해서 새로운 클래스를 만드는 문법

class Animal
{
    public int age;
}
// 대부분의 객체지향 언어가 지원하느 문법인데,
// => 표기법이 다릅니다.

// C#     : class Dog : Animal
// Python : class Dog( Animal )
// C++    : class Dog : public Animal
// Java   : class Dog extends Animal

// 클래스 Diagram 그리는 법 (UML : Unified Modeling Language)
// => 기반 클래스 쪽으로 화살표

// 용어
// Animal : Base Class(기반),  Super Class, Parent Class
// Dog    : Derived Class(파생), Sub Class, Child Class

class Dog : Animal
{
    public int color;
}

class Program
{
    public static void Main()
    {
        Dog d = new Dog();
        d.

    }
}
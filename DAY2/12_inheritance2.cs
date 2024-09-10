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

        Dog    d1 = d; // ?
        string s1 = d; // ?
        Animal a1 = d; // ?

    }
}
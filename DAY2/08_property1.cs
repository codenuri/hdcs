// 82 page  property
// 핵심 #1. private vs public
// 핵심 #2. setter & getter

class Person1
{
    public int age;
}

// 캡슐화
// 타입을 만들때
// => 상태를 나타내는 데이타(필드) 를 private 에 놓아서 외부의 잘못된 사용으로 부터
//    객체의 상태가 불안해지는 것을 막는다.

// => 객체의 상태는 잘정의된 메소드를 통해서만 변경될수 있다.

// => 아래 코드는 사람의 나이는 0< age < 150 사이만 설정될수 있다.


class Person2
{
    private int age; // private: 멤버가 아닌 외부에서 직접 접근할수 없다.
                     // 멤버 메소드를 통해서만 접근 가능

    public void SetAge(int a) // public : 프로그램의 모든 곳에서 접근 가능
    {
        if ( a > 0 && a < 150 )
            age = a;
    }
}

class Program
{
    public static void Main()
    {
        Person1 p2 = new Person2();
//      p2.age = -5; // error
        p2.SetAge(-5); // ok. 하지만, 잘못된 값이므로 실제 적용 되지는 않음.



        Person1 p1 = new Person1();
        
		p1.age = 10;
        p1.age = -5; // 실수로, 현실세계에 존재 할수 없는 객체를 만들었다!!
    }
}

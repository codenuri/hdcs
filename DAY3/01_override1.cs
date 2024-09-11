using static System.Console;

// 72 page
class Animal           
{
    public void Cry1() { WriteLine("1. Animal Cry1");}
}
class Dog : Animal
{
    // method override : 기반 클래스 메소드를 파생 클래스가
    //                   다시 구현하는 것
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




// #1. 출석부 서명해 주세요

// #2. github.com/codenuri/hdcs 에서  DAY3.zip 받으시면 됩니다.


// #3. DAY3.zip 압축 풀고 DAY3.sln 더블 클릭하면 visual studio 에서 
//     열수 있습니다.
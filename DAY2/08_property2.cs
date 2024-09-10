// 프로그램에서 "사람" 을 관리하려면
// 1. Person 클래스를 만드세요
// 2. 사람을 나타내는 데이타를 private 만드세요. 필드 라고 합니다
// 3. 생성자를 만들어서 필드를 초기화 하세요
class Person
{
    private string name;    // 초기값은 없어도 되고
    private int age = 0;    // 있어도 됩니다.

    public Person(string n, int a)
    {
        //       name = n;
        //       age = a;
        (name, age) = (n, a); // 이렇게 하면 위코드를 한줄로도 가능.
    }
    
    // 생성자는 "최초 변수(객체)생성시 초기화" 의 용도 입니다.
    // 생성후에 변경하기 위해서는 별도의 메소드 제공
    public void SetName(string n)
    {
        name = n;
    }
}

class Program
{
    public static void Main()
    {
//      Person p1 = new Person(); // error. 인자가 0개인 생성자 없음
        Person p1 = new Person("kim", 20);

        // new Person("kim", 20) : 함수 호출로 생각하지 말고
        //                1. Person 타입의 객체를 만들고(메모리 할당)
        //                2. 생성자 메소드(Person(string, int)) 호출

        p1.SetName("lee");
    }
}

using static System.Console;

class People
{
    private string name;
    private int age;

    // this 활용 #1. 인자가 아닌 필드 임을 명확히 하고 싶을때
    public void SetAge(int age)
    {
//      age = age; // 인자 age = 인자 age; 이므로 잘못된 코드
        this.age = age;
    }

    // this 활용 #2. this 를 반환하는 메소드.!
    public People SetName(string name)
    {
        name = name;
        return this;
    }
}

class Program
{
    public static void Main()
    {
        People p = new People();

        p.SetName("kim").SetAge(20);

    }
}

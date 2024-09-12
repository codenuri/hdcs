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
    // => 메소드 호출을 연속적으로 할수 있습니다.
    // => Java 에서 아주 널리사용. Java 진영에서는 "빌더"라는 이름을 가진 기법 
    // => C# 은 이렇게 하지 않고, 주로, Property 사용
    public People SetName(string name)
    {
        this.name = name;
        return this;
    }
}

class Program
{
    public static void Main()
    {
        People p = new People();

        p.SetName("kim").SetAge(20); // java style

        // C# 은 아래 처럼(지금은 속성 안만들었으므로 에러)
//      p.Name = "kim";
//      p.Age = 20;

    }
}

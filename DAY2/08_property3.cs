class Person
{
    private string name;    
    private int age = 0;    

    public Person(string n, int a)  { (name, age) = (n, a);  }

    // 아래 같은 메소드를 "setter/getter" 라고 부릅니다.
    public void SetName(string n)   { name = n; }
    public string GetName()         { return name; }


    // C#에는 "다른 언어 에는 없는" property 라는 문법이 있습니다.
    // => Setter/Getter 를 쉽게 만드는 문법
    // => 만들때는 "메소드와 유사" 하게 만들지만
    //    사용할때는 "필드 처럼" 접근하게 됩니다.
    // 결국, Setter/Getter 개념인데, 편리하게 만들고, 편리하게 사용

    // 관례 : 데이타(필드)이름은 "소문자"로 
    //        프라퍼티 이름은 첫번째 문자를 "대문자"로 
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    public static void Main()
    {
        Person p1 = new Person("kim", 20);

        p1.SetName("lee");
        string s = p1.GetName();

        p1.Name = "park";
        s = p1.Name;
     
    }
}

// 결국 C# 의 타입(클래스)안에는
class Car
{
    // 1. 필드(데이타), 대부분 private 
    // 2. 메소드. "동작"을 나타내는 것. Go(), Stop()등 
    //    => 사용할때 () 필요. c.Go()

    // 3. 프라퍼티(속성), 데이타 접근시 사용, Speed
    //    => () 없음.  c.Speed
}
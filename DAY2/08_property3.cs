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

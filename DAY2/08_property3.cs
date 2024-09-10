class Person
{
    private string name;    
    private int age = 0;    

    public Person(string n, int a)  { (name, age) = (n, a);  }

    public void SetName(string n)   { name = n; }
    public string GetName()         { return name; }
}

class Program
{
    public static void Main()
    {
        Person p1 = new Person("kim", 20);

        p1.SetName("lee");
        string s = p1.GetName();
    }
}

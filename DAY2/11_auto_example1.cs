class Person
{
	// public 필드로 하면 항상 R/W 가능.
	//	public string Name;
	//	public string Address;

	// auto implemented property 로 하면
	// get, set 을 한개만 지원 가능
	public string Name { get; } = 0;
    public string Address { get; set; } = 0;

    public Person(string name, string address)
	{
		Name = name;			// ok.
								// get 만 있어도, 생성자에서 초기화는 가능. 
		Address = address;
	}	
}
class Program 
{
	public static void Main()
	{
		Person p = new Person("lee", "pusan");

		p.name    = "kim";	// error
		p.address = "seoul";// ok. 
	}
}
// property를 만드는 2가지 방법
// 1. 필드를 직접 만들고, set, get 을 직접 구현하는 방법
// => set 에서 "값의 유효성"등을 확인 하고 싶을때

// 2. auto implemented 문법 사용
// => 전형적인 구현이 필요 할때
// => 필드까지 자동생성
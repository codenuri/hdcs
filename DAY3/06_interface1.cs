using static System.Console;

// 75 page

class Camera
{
	public void Take() { WriteLine("take picture"); }
}

class HDCamera
{
    public void Take() { WriteLine("take HD picture"); }
}


class People
{
	// overloading : 인자의 갯수나 타입이 다르면 같은 이름의 함수를
	//				 여러개 만들수 있다.
	public void UseCamera(Camera c) { c.Take(); }
    public void UseCamera(HDCamera c) { c.Take(); }
}

class Program 
{
	public static void Main()
	{
		People p = new People();

		Camera c = new Camera();

		p.UseCamera(c);


        HDCamera hc = new HDCamera();

        p.UseCamera(hc); // ??
    }
}

using static System.Console;

// class 의 virtual method : 파생 클래스가 반드시 구현해야 하는 것은 아니다
//                          재정의 하지 않으면 기본 구현 제공

// interface : method 이름만 약속하는 것. 구현할수 없음.
//             파생클래스에게 반드시 만들라고 지시하는 것

interface ICamera
{
    void Take();
}

class People
{
    public void UseCamera(ICamera c) { c.Take(); }
}


class Camera : ICamera
{
    public void Take() { WriteLine("take picture"); }
}

class HDCamera : ICamera
{
    public void Take() { WriteLine("take HD picture"); }
}

class UHDCamera : ICamera
{

}

class Program
{
    public static void Main()
    {
        People p = new People();
        Camera c = new Camera();

        p.UseCamera(c);


        HDCamera hc = new HDCamera();

        p.UseCamera(hc);
    }
}


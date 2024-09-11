using static System.Console;


// 카메라를 바로 만들지 말고!!!

// 카메라와 카메라 사용자 사이에 지켜야 하는 규칙을 먼저 만들자

// 규칙 : 모든 카메라는 아래 클래스로 부터 파생되어야 한다.
class CameraBase
{
    virtual void Take() { WriteLine("CameraBase Take"); }
}

// 카메라 사용자는 "구체적인 제품명 대신에"
// 규칙의 이름만 사용해야 합니다.
class People
{
    public void UseCamera(CameraBase c) { c.Take(); }
}


class Camera : CameraBase
{
    public override void Take() { WriteLine("take picture"); }
}

class HDCamera : CameraBase
{
    public override void Take() { WriteLine("take HD picture"); }
}

class UHDCamera : CameraBase
{
    // 현재 상태에서는 반드시 Take 를 만들어야 하는 것은 아니다.
    // Take 가 virtual 이므로!!
    // 만들지 않으면 CameraBase 로 부터 상속 받아서
    // 기본 구현을 사용할수 있다.

    // 규칙에서 반드시 만들라고 시킬수는 없을까 ??
    // 즉, 함수 이름만 약속, 구현은 제공하지 말고!!!
    // => interface 문법.
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


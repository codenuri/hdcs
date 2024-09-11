using static System.Console;

// class 의 virtual method : 파생 클래스가 반드시 구현해야 하는 것은 아니다
//                          재정의 하지 않으면 기본 구현 제공

// interface : method 이름만 약속하는 것. 구현할수 없음.
//             파생클래스에게 반드시 만들라고 지시하는 것


// 규칙 : "모든 카메라는 아래 클래스로 부터 파생되어야 한다." 라고 표현하지 말고
//        "모든 카메라는 아래 인터페이스를 구현 해야 한다" 라고 표현합니다.
//        => 단, 문법은 "상속" 문법 처럼 : 으로 표기
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
    public void Take() { WriteLine("take UHD picture"); }
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

        UHDCamera uhc = new UHDCamera();

        p.UseCamera(uhc);
    }
}

// 78page 용어

// 강한 결합(tightly coupling)
// => 하나의 클래스가 다른 클래스 사용시 "클래스 이름"을 직접 사용
// => UseCamera(HDCamera) 처럼 제품 이름 직접 사용
// => 교체 불가능한 경직된 디자인


// 약한 결합(loosely coupling)
// => 하나의 클래스가 다른 클래스 사용시 "규칙의 이를(인터페이스)"을
//    사용해서 접근
// => UseCamera(ICamera) 처럼 제품 이름 직접 사용 안함.
// => 교체 가능한 유연한 디자인
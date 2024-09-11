using static System.Console;


// ī�޶� �ٷ� ������ ����!!!

// ī�޶�� ī�޶� ����� ���̿� ���Ѿ� �ϴ� ��Ģ�� ���� ������

// ��Ģ : ��� ī�޶�� �Ʒ� Ŭ������ ���� �Ļ��Ǿ�� �Ѵ�.
class CameraBase
{
    virtual void Take() { WriteLine("CameraBase Take"); }
}

// ī�޶� ����ڴ� "��ü���� ��ǰ�� ��ſ�"
// ��Ģ�� �̸��� ����ؾ� �մϴ�.
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


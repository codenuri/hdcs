using static System.Console;


// ī�޶� �ٷ� ������ ����!!!

// ī�޶�� ī�޶� ����� ���̿� ���Ѿ� �ϴ� ��Ģ�� ���� ������

// ��Ģ : ��� ī�޶�� �Ʒ� Ŭ������ ���� �Ļ��Ǿ�� �Ѵ�.
class CameraBase
{
    virtual void Take() { WriteLine("CameraBase Take"); }
}







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

        p.UseCamera(hc); 
    }
}


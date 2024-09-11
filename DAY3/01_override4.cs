using static System.Console;

class Base
{
    public void M1() { }
    public void M2() { }
    public virtual void M3() { WriteLine("Base M3"); }
    public virtual void M4() { WriteLine("Base M4"); }
}
class Derived : Base
{
    // #1. virtual �� �ƴ� �޼ҵ带 ������(override) �Ҷ��� "new" Ű���� ���
    public new void M1() { }        // ok
//  public override void M2() {}    // error

    // #2. virtual method �� override �Ҷ���
    //     "new" �� �ƴ� "override" �� ��Ģ. 
    //     �׷���, "new" �� ����(�̷��� ����ϴ� ���� ���� ������ ���������δ� ����)
    public override void M3() { WriteLine("Derived M3"); }
    public new void M4() { WriteLine("Derived M4"); }
            // => ��� Ŭ���� M4 �� �ٽø���� �ǵ��� �ƴ϶�
            // => ������ �ٸ� �ǹ̷� ����� �ٴ� ���ε�.
            // => �������� �̷��� ����ϴ� ���� ����.
            // => ���� �̷��� �������� "override" �ϼ��� 
}
class Program
{
    public static void Main()
    {
        Base bd = new Derived();
        bd.M3();    // Derived M3()
        bd.M4();    // Base M4()
    }
}
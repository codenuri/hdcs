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
    // #1. virtual 이 아닌 메소드를 재정의(override) 할때는 "new" 키워드 사용
    public new void M1() { }        // ok
//  public override void M2() {}    // error

    // #2. virtual method 를 override 할때는
    //     "new" 가 아닌 "override" 가 원칙. 
    //     그런데, "new" 도 가능(이렇게 사용하는 경우는 거의 없지만 문법적으로는 가능)
    public override void M3() { WriteLine("Derived M3"); }
    public new void M4() { WriteLine("Derived M4"); }
            // => 기반 클래스 M4 를 다시만드는 의도가 아니라
            // => 완전히 다른 의미로 만드는 다는 것인데.
            // => 실전에서 이렇게 사용하는 경우는 없음.
            // => 절대 이렇게 하지말고 "override" 하세요 
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
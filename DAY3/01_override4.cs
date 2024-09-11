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
    public new void M1() { } 
    public override void M2() {} 

    public new void M3() { WriteLine("Derived M3"); }
    public override void M4() { WriteLine("Derived M4"); }
}
class Program
{
    public static void Main()
    {
        Base bd = new Derived();
        bd.M3(); 
        bd.M4();
    }
}
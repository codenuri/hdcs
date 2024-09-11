using static System.Console;

// 핵심
// #1. 모든 파생 클래스의 공통의 특징은 기반 클래스에도 있어야 한다.
//       (디자인 원칙)
//       모든 도형이 "Draw" 가 있다면, 기반 클래스인 Shape 에도 있어야 한다.

// #2. 기반 클래스 메소드중에서 파생 클래스가 다시 만들게(override)하는 것은
//     virtual 로 만들어야 한다.
//     => 재정의 할때 "override" 붙여야 함

class Shape
{
    private int color = 0;

    // 아래 메소드는 virtual 할까요 ? non-virtual 로 할까요 ?
    // => 파생 클래스가 override 할 필요 없다.
    // => non-virtual!!
    public void SetColor(int c) { color = c; }

    // 면적을 구하는 함수
    // => 도형의 면적을 구하는 방법은 모든 도형이 다릅니다.
    // => 파생 클래스가 override 해야 합니다.
    // => 따라서, virtual 
    public virtual int GetArea() { return 0; }



    public virtual void Draw() { WriteLine("draw Shape"); }
}

class Rect : Shape
{
    public override void Draw() { WriteLine("draw Rect"); }
}

class Circle : Shape
{
    public override void Draw() { WriteLine("draw Circle"); }
}

class Program
{
    public static void Main()
    {
        List<Shape> st = new List<Shape>();


        while (true)
        {
            string s = Console.ReadLine();
            int cmd = int.Parse(s);

            if (cmd == 1)
            {
                st.Add(new Rect());
            }
            else if (cmd == 2)
            {
                st.Add(new Circle());
            }
            else if (cmd == 9)
            {
                foreach (var e in st)
                {

                    e.Draw(); 
                }
            }
        }
    }
}


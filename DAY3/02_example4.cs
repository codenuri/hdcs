using static System.Console;

// 핵심 : 모든 파생 클래스의 공통의 특징은 기반 클래스에도 있어야 한다.
//       (디자인 원칙)
//       모든 도형이 "Draw" 가 있다면, 기반 클래스인 Shape 에도 있어야 한다.

class Shape
{
    private int color = 0;

    public void Draw() { WriteLine("draw Shape"); }
}

class Rect : Shape
{
    public void Draw() { WriteLine("draw Rect"); }
}

class Circle : Shape
{
    public void Draw() { WriteLine("draw Circle"); }
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


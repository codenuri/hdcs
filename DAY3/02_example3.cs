using static System.Console;

class Shape
{
    private int color = 0;
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
            else if ( cmd == 9)
            {
                // 만들어진 모든 도형을 그리기(Draw 호출)
                foreach( var e in st )
                {
                    e.Draw();
                }                    
            }
        }
    }
}
// 위 코드는 왜 ?? 에러 일까요 ?
// 해결책은 뭘까요 ?


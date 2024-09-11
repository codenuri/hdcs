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
        //      Shape[] arr = new Shape[10]; // 배열. 크기가 고정되어 있다

        List<Shape> st = new List<Shape>(); // List, 크기가 자동증가.
                                            // python list 와 동일


        while (true)
        {
            string s = Console.ReadLine();
            int cmd = int.Parse(s);

            if (cmd == 1)
            {
//                Rect rc = new Rect();
//                st.Add(rc);

                st.Add(new Rect()); // 위 2줄은 결국 이렇게 해도 됩니다.
            }
            else if (cmd == 2)
            {
                st.Add(new Circle());
            }
        }
    }
}
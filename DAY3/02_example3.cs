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
                    // st는 List<Shape> 이므로
                    // 현재 e 는 Shape 타입.
                    e.Draw(); // 이 부분이 에러. 
                              // Shape 에는 Draw 가 없기 때문에 에러!!

                   //((Rect)e).Draw(); // 이렇게 하면 에러가 아니지만  
                                      // e가 가리키는 것은 Rect 가 아닌 Circle 일수도
                                      // 있다.. 실행시 오류!!!
                                      
                    // 해결책이 중요!! -> 다음소스에서!!
                }                    
            }
        }
    }
}
// 위 코드는 왜 ?? 에러 일까요 ?
// 해결책은 뭘까요 ?


using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

class Program
{

    public static async void Foo()
    {

        FileStream fs = new FileStream("a.txt", FileMode.Create);

        
            byte[] buff = new byte[1024 * 1024 * 1000]; // 1G
                
            // fs.Write(buff, 0, buff.Length); // 동기

            await fs.WriteAsync(buff);

            Console.WriteLine("WriteAsync Finish");

    }

    public static void Main()
    {
        Foo();
        Console.WriteLine("Main 계속실행");

        Console.ReadLine();

    }

}
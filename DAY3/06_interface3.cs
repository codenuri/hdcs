using System.Text;
using static System.Console;

class Program
{
    public static void Main()
    {
        // string�� ���� Ÿ��
        string s1 = "abcd";
        string s2 = s1; // s1, s2 �� ���� ��ü�� ����Ŵ.

        string s3 = s1.Clone(); // s1�� ������ �ٸ� ��ü�� ������ �޶�.


        // StringBuilder �� ���� Ÿ��
        StringBuilder sb1 = new StringBuilder("abcd");
        StringBuilder sb2 = sb1; // sb1, sb2 ���� ��ü
        StringBuilder sb3 = sb1.Clone();

        // C# ���� "���纻 ��ü" �� �ʿ� �ϸ�
        // => Clone() �޼ҵ� ȣ���ϸ� �˴ϴ�.
        // => �׷���,!!!! "�޼ҵ� �̸�" �� ���� ���� �����ϱ� ����
        // => �������̽��� ���.(IClonable)

        IClonable c;
    }
}

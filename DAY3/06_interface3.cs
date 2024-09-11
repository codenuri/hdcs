using System.Text;
using static System.Console;

class Program
{
    public static void Main()
    {
        // string�� ���� Ÿ��
        string s1 = "abcd";
        string s2 = s1; // s1, s2 �� ���� ��ü�� ����Ŵ.

        string s3 = (string)s1.Clone(); // s1�� ������ �ٸ� ��ü�� ������ �޶�.


        // �迭 �� ���� Ÿ��
        int[] x = { 1, 2, 3 };
        int[] y = (int[])(x.Clone());


        // C# ���� "���纻 ��ü" �� �ʿ� �ϸ�
        // => Clone() �޼ҵ� ȣ���ϸ� �˴ϴ�.
        // => �׷���,!!!! "�޼ҵ� �̸�" �� ���� ���� �����ϱ� ����
        // => �������̽��� ���.(ICloneable)

        ICloneable c;
    }
}

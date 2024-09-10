class Program
{
    public static void M1(int a, int b) { }

    // ���ڷ� �迭�� ����ϸ� �������ڷ� ���� ���� �մϴ�.
    public static void M2(int[] arr) { }

    // params : ������ ������ �������� �ްڴ�...
    // => ��Ȯ�� �ǹ̴� 
    // => �迭�� ���ڸ� �ްڴ�..
    // => �׷��� M3(1,2,3) ������ ����� �޶�.
    public static void M3(params int[] arr) { }

    public static void Main()
    {
        M1(1, 2);

        M2( new int[] { 1, 2, 3 } ); // ok
        M2( new [] { 1, 2, 3 });     // ok

        M2( 1, 2, 3 ); // error

        M3(1, 2, 3); // ok
                     // 1) 1, 2, 3 �� �ڵ带 �����Ϸ��� "new int[]{1,2,3}" ���� ����

        M3(1, 2, 3, 4, 5); // "new int[]{1,2,3,4,5}"
    }

    // ���� ����
    // 1. params ���� �迭���ڷ� ������, �ڿ� �ٸ� ���� ����������
    // 2. params ���ڴ� �׻� �������� �־�� �մϴ�.
    //  public static void M4(int[] ar, int n) { }		     // ok	
    //  public static void M5(params int[] ar, int n) { }	 // error
    //  public static void M6(int n, params int[] ar) { }	 // ok

    // M4 �� �ݵ�� �迭���·� �����Ƿ� �򰥸��� �ʽ��ϴ�.
    // M4( new int[]{1,2,3}, 4);
    // M5( 1,2,3,4); // error
    // M6(1,2,3,4);

}

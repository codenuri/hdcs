using static System.Console;

// �Ʒ� �ڵ� �׸��� "29page"

// int : value type

int n1 = 10;
int n2 = n1; // n1, n2 �� �ٸ� �޸�

n1 = 20;     // n1�� ����

WriteLine($"{n1} {n2}"); // 20, 10

// �迭 : reference type
// ��, swift �� �迭�� value_type

int[] x1 = {1, 2, 3};
int[] x2 = x1;

x1[0] = 20;
WriteLine($"{x1[0]} {x2[0]}"); //???


// string : reference type �Դϴ�.
string s1 = "AB"; 
string s2 = s1;

s1 = "XY"; // s1 = new string("XY");

WriteLine($"{s1} {s2}");  // "XY", "AB"



// string ���� ������ ����
string s3 = "AB"; // string s3 = new string("AB")

s3 = "XY";        // ���� �ִ� ��ü�� ���� �����ϴ°��� �ƴ϶�!!
                  // s3 = new string("XY");  ���� �����

// ����� ���ο� ��ü�� ����� ǥ���̰�, ����� ���� �����ϴ� �ڵ��ΰ��� ?
// => string �� �����ϼ���!

using static System.Console;

int  a1 = 10;
int? n1 = 10;

// #1. int ��  int? �� ȣȯ(����)
// => �׻� int? �� "int+bool" ���� �����ϼ���

int? n2 = a1; // ok
//int  a2 = n1; // error. n1 �� nullable �̹Ƿ� ���� ������ �ִ�

// #2. nullable Ÿ�Կ��� �� ������
int a3 = n1.Value;


Console.WriteLine(a3);




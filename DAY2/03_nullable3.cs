using static System.Console;

int  a1 = 10;
int? n1 = 10;

// #1. int ��  int? �� ȣȯ(����)
// => �׻� int? �� "int+bool" ���� �����ϼ���

int? n2 = a1; // ok
              //int  a2 = n1; // error. n1 �� nullable �̹Ƿ� ���� ������ �ִ�


// #2. nullable Ÿ�Կ��� �� ������
//n1 = null;

//int a3 = n1.Value;                // n1 �� null �̸� ���� �߻�
//int a3 = n1.GetValueOrDefault();  // n1 �� null �̸� ����Ʈ��
                                    // int �� ����Ʈ ���� 0
//int a3 = n1.GetValueOrDefault(3);  // n1 �� null �̸� 3 ��ȯ 

int a3 = n1 ?? 3; // ���� ����
                  // n1 != null �̸� n1.Value
                  // n1 == null �̸� 3;

Console.WriteLine(a3);




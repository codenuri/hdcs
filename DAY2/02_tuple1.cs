using static System.Console;
// 35 page

// #1. variable, array, tuple
int n1 = 0;                 // �Ϲ� ���� : ���� �Ѱ��� ����

int[] a1 = { 1, 2, 3 };     // �迭 : ���� Ÿ���� ������ ����

(int, double, char) t1 = (3, 4.5, 'A'); // Ʃ�� : ���� Ÿ���� ������ ����

// #2. tuple ����� ��
//ValueTuple<int, double, char> t2 = new ValueTuple<int, double, char>(3, 4.5, 'A');
                        // => �� ǥ���� ��Ȯ�� ǥ���������
                        // => �����ϱ� ������ �Ʒ� ���� ǥ��� ���

// (int, double, char) : Ÿ��
// t2                   : �����̸�
(int, double, char) t2 = (3, 4.5, 'A');

using System;

/*
// #1. ��� ����
(int,   double,   char)   t1 = (1, 3.4, 'A');   // ��ҿ� �̸��� ���� tuple
(int a, double b, char c) t2 = (1, 3.4, 'A');   // ��ҿ� �̸��� �ִ� tuple

int n1 = t1.Item1;
int n2 = t2.a;


// #2. deconstruction
(int, int, int) t3 = (1, 2, 3);

int x, y, z;
(x, y, z) = t3; // t3�� ������ x, y, z �� ���
                // x = t3.Item1
                // y = t3.Item2
                // z = t3.Item3
// �� �ڵ�� �Ʒ� ó�� �ص� �˴ϴ�.
(int x1, int y1, int z1) = t3;

*/
// #3. �Ʒ� �ڵ常 �� �����ϼ��� - 35page
(int x1, int y1, int z1) t4 = (1, 2, 3); // tuple ����
                                         // x1, y1, z1 �� 
                                         // tuple �� ����� �̸�
int k = t4.x1;

(int x2, int y2, int z2) = t4;  // tuple ����
// ���ڵ�� �Ʒ� �ǹ� - 3���� ���� ����
//int x2 = t4.Item1;
//int y2 = t4.Item2;
//int z2 = t4.Item3;

int k1 = x1; // error
int k2 = x2; // ok



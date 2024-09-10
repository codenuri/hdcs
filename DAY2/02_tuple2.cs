using System;

/*
// #1. 요소 접근
(int,   double,   char)   t1 = (1, 3.4, 'A');   // 요소에 이름이 없는 tuple
(int a, double b, char c) t2 = (1, 3.4, 'A');   // 요소에 이름이 있는 tuple

int n1 = t1.Item1;
int n2 = t2.a;


// #2. deconstruction
(int, int, int) t3 = (1, 2, 3);

int x, y, z;
(x, y, z) = t3; // t3의 내용을 x, y, z 에 담기
                // x = t3.Item1
                // y = t3.Item2
                // z = t3.Item3
// 위 코드는 아래 처럼 해도 됩니다.
(int x1, int y1, int z1) = t3;

*/
// #3. 아래 코드만 잘 구별하세요 - 35page
(int x1, int y1, int z1) t4 = (1, 2, 3); // tuple 생성
                                         // x1, y1, z1 은 
                                         // tuple 의 요소의 이름
int k = t4.x1;

(int x2, int y2, int z2) = t4;  // tuple 분해
// 위코드는 아래 의미 - 3개의 변수 선언
//int x2 = t4.Item1;
//int y2 = t4.Item2;
//int z2 = t4.Item3;

int k1 = x1; // error
int k2 = x2; // ok



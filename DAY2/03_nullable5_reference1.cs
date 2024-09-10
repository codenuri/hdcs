string s1 = "hello";
string s2 = null;

// #1. null �� ���� ��ü�� �޼ҵ峪 �Ӽ��� �����ϴ� ���� ����(���� �߻�)
var ret1 = s1.Length; // ok
var ret2 = s2.Length; // runtime error. ���� �߻�


// #2. value type �� null �� �������/���� ���� �����մϴ�.
int  n1 = 10;       // null �� �ɼ� ���� Ÿ��
int? n2 = null;     // null �� �ɼ� �ִ� Ÿ��


// #3. reference type �� �׻� null �� �����մϴ�.
// => �����Ҽ� �־��ٸ� ���� ������ ?
// => �׷��� C# 9.0 ���� nullable reference ���� ����
string s3 = null;
string? s4 = null; // C# 9.0 



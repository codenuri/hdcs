// ? ������

//string s1 = "abcd";
string s1 = null;

//string s2 = s1.ToUpper(); // ���� �߻�
                            // null ��ü�� ���ؼ� �޼ҵ� ȣ�� �ȵ˴ϴ�.


string s2;

// �����ϰ� �Ϸ��� �Ʒ� ó�� �մϴ�.
if ( s1 != null)
{
    s2 = s1.ToUpper();
}

// �Ʒ� ������ ���� �����մϴ�.
s2 = s1?.ToUpper(); // s1 != null �̸�  s2 = s1.ToUpper()
                    // s1 == null �̸�  s2 = null

// ?? �� ? ����
// ?? : null �̸� ����Ʈ�� ����ϰڴ�
// ?  : null �̸� �޼ҵ� ȣ�� ���ϰڴ�. �׸��� null ��ȯ

int? n = null;
string s = null;

int a = n ?? 3;
string s2 = s?.ToUpper(); 
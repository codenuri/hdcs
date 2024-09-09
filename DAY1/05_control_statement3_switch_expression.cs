int n = 1;

string s1 = "";

// switch ���� ����ؼ�
// n == 0 �̸� s1 = "sun"
// n == 1 �̸� s1 = "mon"
// n == 2 �̸� s1 = "tue"
// �׿ܿ��� s1 �� "unknown" �̶�� �־� ������ ( C�� �����մϴ�.)

switch( n )
{
    case 0:  s1 = "sun"; break;
    case 1:  s1 = "mon"; break;
    case 2:  s1 = "tue"; break;
    default: s1 = "unknown"; break;
}

// �Ʒ� �ڵ尡 ���� ������ ������ �ǹ� �Դϴ�.
// => switch expression
string s2 = n switch 
            {
                0 => "sun",
                1 => "mon",
                2 => "tue",
                _ => "unknown",  // �����Ҽ� ����. �ݵ�� �ʿ�
             };

Console.WriteLine($"{s1}, {s2}");

// 1��° switch : string s1 �� ���� ����� ���
// 2��° switch : string s2 �� ����鼭 �ʱ�ȭ. 
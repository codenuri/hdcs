using static System.Console;

int[] x = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

for (int i = 0; i < 10; i++)
{
    WriteLine($"{x[i]}");
}

// 위 for 문은 아래 foreach 로 할수도 있습니다.
// 파이썬 : for(e in x)
//foreach(int e in x)
foreach (var e in x)
{
    WriteLine($"{e}");
}



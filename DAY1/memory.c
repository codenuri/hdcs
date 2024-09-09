// memory.c - 26page ~

// 메모리에 대해서
// => 아래 코드는 C 코드 입니다.

// 1. 할당된 메모리는 반드시 해지 되어야 합니다.
// => 메모리 크기에 제한이 있으므로 무한정 할당될수 없습니다.
// => 메모리 할당/해지 방식에 따라 2개의 메모리가 있습니다.(stack, heap)

// stack : 지역변수가 놓이는것, 순차적으로 자동으로 할당 해지.
//		   파괴되는 규칙도 정해져 있습니다. 크기 1MB
//		   할당과 해지가 아주 빠르다.

// heap : 사용자가 원할때 할당/해지 할수 있다. C언어 malloc
//		  자유 기억공간
//		  하나의 함수에서 할당한 메모리를 해지하지 않으면 다른 함수에서도 사용가능
//        아주 자유로운 공간
//		  크기가 아주 큽니다. (자동 증가)
//		  단점 : 할당속도가 느립니다.

void foo()
{
	int n1 = 10;
	int n2 = 20;
	int n3 = 20;

}	// <= n3, n2, n1 순으로 차례대로 파괴
	// <= n3 보다 n2 가 먼저 파괴 될수 없습니다.
	// <= main 으로 돌아가서도 n1 을 사용하게 할 방법은 없습니다.


int* goo()
{
	int* p1 = new int[10];
	int* p2 = new int[20];

	delete[] p1; // 언제라도 원할때 지울수 있습니다.

	return p2; // 지역변수인 p2는 파괴되지만
				// 힙할당된메모리(80바이트는 파괴 안됨)
}

int main()
{
	foo();
	int* p3 = goo();
	p3[0] = 0; // goo 가 할당한 메모리를 main 사용
}
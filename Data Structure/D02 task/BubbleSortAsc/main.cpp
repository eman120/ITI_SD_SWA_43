#include <iostream>

using namespace std;



void SWAP (int* x , int* y)
{
    int temp = *x;
    *x= *y;
    *y = temp;
}

void BubbleSortAsc (int* arra , int Size)
{
    bool Sorted;
    for (int i = 0 ; i < Size ; i++)
    {
        Sorted = true;
        for (int j = 0 ; j < Size - i -1 ; j++)
        {
            if (arra [j] > arra [j+1])
            {
                SWAP(&arra [j] , &arra [j+1]);
                Sorted = false;
            }
        }
        if(Sorted) return ;
    }
}

// Function to print an array
void printArray(int *arr, int Size) {
  for (int i = 0; i < Size; i++) {
    cout << arr[i] << " ";
  }
  cout << endl;
}

int main()
{
    int data[] = {9, 5, 1, 4, 3};
    int Size = sizeof(data) / sizeof(data[0]); /// 20/4 = 5
    BubbleSortAsc(data, Size);
    cout << "Sorted array in ascending order:\n";
    printArray(data, Size);
    return 0;
}

#include <iostream>

using namespace std;

int IndexOfMinValue ( int *arra , int StartIndex , int EndIndex)
{
    int Index = StartIndex;
    for (int i = StartIndex+1 ; i < EndIndex ; i++)
    {
        if (arra [i ] < arra [Index])
        {
            Index = i;
        }
    }
    return Index;
}

void SWAP (int* x , int* y)
{
    int temp = *x;
    *x= *y;
    *y = temp;
}

void SelectionSort (int* arr , int Size)
{
    int Index;
    for (int i = 0 ; i < Size ; i++)
    {
        Index = IndexOfMinValue(arr , i , Size) ;
        SWAP(&arr[i] , &arr[Index]);
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
    SelectionSort(data, Size);
    cout << "Sorted array in ascending order:\n";
    printArray(data, Size);
    return 0;
}

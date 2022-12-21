#include <iostream>

using namespace std;

void mergeFun(int* Arr, int LFirst , int LLast , int RFirst , int RLast)
{
    int *TempArr = new int [sizeof(Arr)];
    int Index = LFirst;
    int SaveFirst = LFirst;

    while ((LFirst <= LLast) && (RFirst <= RLast))
    {
        if (Arr[LFirst] < Arr[RFirst])
        {
            TempArr[Index++] = Arr[LFirst++];
        }
        else
        {
            TempArr[Index++] = Arr[RFirst++];
        }
    }
    while (LFirst <= LLast)
    {
            TempArr[Index++] = Arr[LFirst++];
    }
    while (RFirst <= RLast)
    {
            TempArr[Index++] = Arr[RFirst++];
    }

    for (int i =SaveFirst ; i <= RLast ; i++)
    {
        Arr[i] = TempArr[i];
    }
}

void mergeSort(int* Arr , int First , int Last)
{
    if (First < Last) ///Divide
    {
        int middle = (First + Last)/2;
        mergeSort(Arr , First , middle); ///left
        mergeSort(Arr , middle+1 , Last); ///right
        mergeFun(Arr, First , middle , middle+1 , Last);
    }
}

void printArray(int *arr, int Size) {
  for (int i = 0; i < Size; i++) {
    cout << arr[i] << " ";
  }
  cout << endl;
}

int main()
{
    int data[] = {9, 5, 1, 4, 3 , 7 , 6 ,2};
    int Size = sizeof(data) / sizeof(data[0]); /// 20/4 = 5
    mergeSort(data, 0 ,Size-1);
    cout << "Sorted array in ascending order:\n";
    printArray(data, Size);
    return 0;
}

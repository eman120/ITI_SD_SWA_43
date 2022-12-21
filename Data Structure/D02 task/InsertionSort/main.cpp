// Insertion sort in C++

#include <iostream>
using namespace std;

// Function to print an array
void printArray(int *arr, int Size) {
  for (int i = 0; i < Size; i++) {
    cout << arr[i] << " ";
  }
  cout << endl;
}

void insertionSort(int *arr, int Size) {
    int key , j;
  for (int i = 1 ; i <Size ; i++)
  {
        key = arr[i];
        j =  i-1;
        while (key < arr[j] && j >= 0)
        {
            arr[j+1] = arr[j];
            j--;
        }
        arr[j + 1] = key;
  }
}

// Driver code
int main() {
  int data[] = {9, 5, 1, 4, 3};
  int Size = sizeof(data) / sizeof(data[0]); /// 20/4 = 5
  insertionSort(data, Size);
  cout << "Sorted array in ascending order:\n";
  printArray(data, Size);
}

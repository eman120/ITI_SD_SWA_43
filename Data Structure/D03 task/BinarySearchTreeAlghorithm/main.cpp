#include <iostream>

using namespace std;

int BinarySearch(int *Arr , int Low , int High , int Value)
{
    cout<<"BSearch" <<endl;
    int Mid = (Low + High)/2;
    if (Low <= High){
        if (Value == Arr[Mid])
        {
            return Mid;
        }
        else if (Value < Arr[Mid]) ///Go Left
        {
            return BinarySearch(Arr , Low , Mid-1 , Value);
        }
        else ///GoRight
        {
            return BinarySearch(Arr , Mid+1 , High , Value);
        }
    }
    return -1;
}

int BinarySearch(int *Arr , int Size , int Value)
{
    cout<<"BSearch 2 " <<endl;
    int Low = 0 , High = Size -1 ;
    while (Low <= High){
        int Mid = (Low + High)/2;
        if(Arr[Mid] == Value)
        {
            return Mid;
        }
        else if (Value < Arr[Mid]) ///Go Left
        {
            High = Mid-1 ;
        }
        else ///GoRight
        {
            Low = Mid+1;
        }
    }
    return -1;
}

int main()
{
    int Arr[8] = {1 , 3 , 4 , 5 , 8 , 12 , 20 , 23};

    cout << "Recursive : " << endl;
    cout << "-----------------" << endl;
    cout << BinarySearch(Arr, 0 , 7 , 1) << endl;
    cout << BinarySearch(Arr, 0 , 7 , 5) << endl;
    cout << BinarySearch(Arr, 0 , 7 , 20) << endl;
    cout << BinarySearch(Arr, 0 , 7 , 9) << endl;

    cout << endl;
    cout << "===================" << endl;
    cout << endl;

    cout << "Iterative : " << endl;
    cout << "------------------" << endl;
    cout << BinarySearch(Arr, 8 , 1) << endl;
    cout << BinarySearch(Arr, 8 , 5) << endl;
    cout << BinarySearch(Arr, 8 , 20) << endl;
    cout << BinarySearch(Arr, 8 , 9) << endl;
    return 0;
}

#include <iostream>

using namespace std;

class intArray
{
    int *Arr , Size;
public:
    intArray(int s=5)
    {
        Size = s;
        Arr = new int[Size];
    }
    intArray(const intArray &A)
    {
        Size = A.Size;
        Arr = new int[Size];
        for (int i =0 ; i <Size ; i++)
        {
            Arr[i] = A.Arr[i];
        }
    }
    ~intArray()
    {
        for (int i=0 ; i <Size ; i++)
        {
            Arr[i]=-1;
        }
        delete[] Arr;
    }
    void setSize (int s)
    {
        Size = s;
    }
    int getSize ()
    {
        return Size;
    }
    void setValue (int index , int value)
    {
        if ((index >= 0) && (index < Size))
            Arr[index] = value;
    }
    int getValue (int index)
    {
        if((index >=0) && (index < Size))
            return Arr[index];
    }
    int& operator[] (int index)
    {
        if ((index >= 0) && (index<Size))
            return Arr[index];
    }
    intArray &operator= (const intArray &A)
    {
        delete[] Arr;
        Size = A.Size;
        Arr = new int[Size];
        for (int i =0 ; i <Size ; i++)
        {
            Arr[i] = A.Arr[i];
        }
        return *this;
    }
    intArray operator+ (const intArray &A)
    {
        intArray R;
        R.Size = Size ;
        R.Arr = new int[Size];
        for (int i =0 ; i <Size ; i++)
        {
            R.Arr[i] =Arr[i] + A.Arr[i];
        }
        return R;
    }
};
int main()
{
    intArray arr1(3) , arr2 (3) , arr3 (3);
    //for(int i=0 ; i <arr1.getSize() ; i++)
    arr1.setValue(0,3);
    arr1.setValue(1,4);
    arr1.setValue(2,5);
    cout <<"arr1[] : " <<endl;
    for(int i=0 ; i <arr1.getSize() ; i++)
        cout << arr1[i]<< endl;
    cout << endl;

    cout <<"arr1.getValue() : "<< endl;
    for(int i=0 ; i <arr1.getSize() ; i++)
        cout << arr1.getValue(i)<< endl;
    cout << endl;

    cout <<"arr2 : "<< endl;
    for(int i=0 ; i <arr1.getSize() ; i++)
    {
        arr2[i] = 3*i;
        cout << arr2[i]<< endl;
    }

    cout <<"arr1 + arr2 : "<< endl;
    arr3 = arr1 + arr2;
    for(int i=0 ; i <arr3.getSize() ; i++)
    {
        cout << arr3[i]<< endl;
    }

    cout <<"arr2 = arr1 : "<< endl;
    arr3 = arr1;
    for(int i=0 ; i <arr3.getSize() ; i++)
    {
        cout << arr3[i]<< endl;
    }

    return 0;
}

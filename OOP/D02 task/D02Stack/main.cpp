#include <iostream>

using namespace std;

class MyStack
{
    int *Stk;
    int Tos ;
    int Size;
public:
    MyStack(int L)
    {
        cout <<"Stack Ctor \n";
        Size = L;
        Tos = 0;
        Stk = new int[Size];
    }

    ~MyStack()
    {
        cout<<"Destructor \n";
        delete [] Stk;
    }


    bool IsFull()
    {
        return (Tos == Size);
    }

    bool IsEmpty ()
    {
        return (Tos == 0);
    }


    void Push (int n)
    {
        if  (!IsFull())///(IsFull() == false)
            Stk[Tos++] = n;
        else
            cout <<"Stack is Full \n";
    }

    int Pop()
    {
        if (!IsEmpty())
            return Stk[--Tos];
        else
        {
            cout <<"Stack is Empty \n";
            return -1;
        }
    }

    int Peek()
    {
        if (!IsEmpty())
            return Stk[Tos-1];
        else
        {
            cout <<"Stack is Empty \n";
            return -1;
        }
    }

    void printStack()
    {
        int i;
        cout << "Stack :";
        for(i =0 ; i< Tos ; i++)
        {
            cout<< Stk[i]<<" ";
        }
        if (IsEmpty())
        {
            cout<<"stack is Empty";
        }
        cout<< endl;
    }
};


int main()
{
    MyStack S1(5);

    S1.printStack();

    S1.Push(7);
    S1.printStack();
    cout << endl;

    S1.Push(8);
    S1.Push(9);
    S1.printStack();
    cout << endl;

    S1.Push(13);
    S1.Push(14);
    S1.printStack();

    ///not added
    S1.Push(15);
    cout <<"pop element : "<< S1.Pop()<< endl;

    S1.Push(16);
    cout << "peek element : "<< S1.Peek()<< endl;

    S1.printStack();

    return 0;
}

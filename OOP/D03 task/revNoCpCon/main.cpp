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
        cout <<"================"<<endl;
        cout <<"Stack Ctor : "<<this<<endl;
        Size = L;
        Tos = 0;
        Stk = new int[Size];
    }

    ~MyStack()
    {
        cout <<"================"<<endl;
        cout<<"Destructor : "<<this<<endl;

        for (int i =0 ; i <Tos ; i++)
        {
            Stk[i]=-1;
        }
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
            cout <<"================"<<endl;
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
friend void viewContent (MyStack S);

    MyStack Reverse()
    {
        MyStack Re(Size);
        Re.Tos = Tos ;
        //cout <<"================R"<<endl;
        for(int j=0 ; j <Tos ; j++)
        {
            Re.Stk[j] = Stk[Tos - 1-j];
        }
        return Re;
    }
};

void viewContent (MyStack S)
{
    cout <<"================"<<endl;
    cout<<"viewContent : ";
    for(int i=0 ; i<S.Tos ; i++)
    {
        cout<<S.Stk[i]<<",";
    }
    cout<<endl;
}
int main()
{
    MyStack S1(5);

    //S1.printStack();

    S1.Push(7);
    S1.Push(8);
    S1.Push(9);
    S1.Push(10);

    viewContent(S1);
    cout <<"pop element : "<< S1.Pop()<< endl;

    S1.printStack();
    //cout <<"Reverse element : "<<endl;
    //S1.Reverse();
    //S1.printStack();
    cout <<"Reverse element : "<< S1.Reverse().Peek()<< endl;

    return 0;
}

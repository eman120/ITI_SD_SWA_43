#include <iostream>

using namespace std;

class MyStack
{
    int *Stk;
    int Tos ;
    int Size;
public:
    MyStack(int L =6)
    {
        //cout <<"================"<<endl;
        //cout <<"Stack Ctor : "<<this<<endl;
        Size = L;
        Tos = 0;
        Stk = new int[Size];
    }

    ~MyStack()
    {
        //cout <<"================"<<endl;
        //cout<<"Destructor : "<<this<<endl;

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
        cout <<"================"<<endl;
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
        cout <<"================"<<endl;
        if (!IsEmpty())
            return Stk[Tos-1];
        else
        {
            cout <<"Stack is Empty \n";
            return -1;
        }
    }

    MyStack (MyStack &oldS)  ///copy Ctor
    {

        Tos = oldS.Tos;
        Size = oldS.Size;
        Stk = new int[Size];
        for(int i=0 ; i<Tos ; i++)
        {
            Stk[i]= oldS.Stk[i];
        }
        //cout <<"================"<<endl;
        //cout << "Copy Ctor : "<<this<<endl;
    }

    int& operator[] (int index)
    {
        if ((index >= 0) && (index<Size))
            return Stk[index];
    }
    MyStack &operator= (const MyStack &A)
    {
        delete[] Stk;
        Size = A.Size;
        Tos = A.Tos;
        Stk = new int[Size];
        for (int i =0 ; i <Size ; i++)
        {
            Stk[i] = A.Stk[i];
        }
        return *this;
    }
    MyStack operator + (const MyStack &A)
    {
        //int S = Size + A.Size ;
        MyStack R(Size + A.Size);
        R.Size = Size + A.Size;
        R.Tos = 0;
        R.Stk = new int[R.Size];
        for (int i =0 ; i <Size ; i++)
        {
            R.Stk[R.Tos++] = Stk[i];
        }
        for (int i =0; i<A.Size ; i++)
        {
             R.Stk[R.Tos++]  = A.Stk[i];
        }
        return R;
    }

    void printStack()
    {
        int i;
        cout <<"================"<<endl;
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
    MyStack S1(4) , S2 (4) , S3;

    S1.printStack();

    S1.Push(1);
    S1.Push(2);
    S1.Push(3);
    S1.Push(4);

    //viewContent(S1);
    S1.printStack();
    //cout <<"pop element : "<< S1.Pop()<< endl;

    //S1.printStack();
    //cout <<"Reverse element : "<<endl;
    //S1.Reverse();
    //S1.printStack();
    //cout <<"Reverse element : "<< S1.Reverse().Peek()<< endl;

    S2.Push(5);
    S2.Push(6);
    S2.Push(7);
    S2.Push(8);
    S2.printStack();
    cout <<"================" <<endl;

    cout <<"S1 + S2 : " <<endl;
    S3 = S1 + S2;
    S3.printStack();

    S2 = S1;
    cout<<"S2 = S1 : "<<endl;
    //viewContent(S2);
    S2.printStack();
    //cout<<<<endl;


    return 0;
}

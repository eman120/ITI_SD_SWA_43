#include <iostream>

using namespace std;

template <class MyType> ///Declare MyType as Type Parameter

class MyStack
{
    MyType *Stk;
    int Tos ;
    int Size;
    static int SNum; //private
public:
    MyStack(int L =6)
    {
        Size = L;
        Tos = 0;
        Stk = new MyType[Size];
        SNum++;
    }

    ~MyStack()
    {
        for (int i =0 ; i <Tos ; i++)
        {
            Stk[i]=-1;
        }
        delete [] Stk;
        SNum--;
    }


    bool IsFull()
    {
        return (Tos == Size);
    }

    bool IsEmpty ()
    {
        return (Tos == 0);
    }


    void Push (MyType n)
    {
        if  (!IsFull())///(IsFull() == false)
            Stk[Tos++] = n;
        else
            cout <<"Stack is Full \n";
    }

    MyType Pop()
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
        Stk = new MyType[Size];
        for(int i=0 ; i<Tos ; i++)
        {
            Stk[i]= oldS.Stk[i];
        }
        SNum++;
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
        Stk = new MyType[Size];
        for (int i =0 ; i <Size ; i++)
        {
            Stk[i] = A.Stk[i];
        }
        return *this;
    }
    MyStack operator + (const MyStack &A)
    {
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

    void viewContent ();

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

    static void DemoFun (MyStack &S)
    {
        MyStack R(4);
        R.Tos++; ///valid
        S.Size = 15; ///valid
    }
    static int GetSNum () ///function depends on object state
    {
        ///Tos++ ; Size--; static function is lacking this pointer,
        /// can't Access Directly Object Attributes
        return SNum;
    }
};

///end scope of class MyType

template <class T>
int MyStack<T>::SNum = 0; ///for initializing private or public static members
///end scope of class MyType

template <class MyType>
void MyStack<MyType>::viewContent ()
{
    cout <<"================"<<endl;
    cout<<"viewContent : ";
    for(int i=0 ; i<Tos ; i++)
    {
        cout<<Stk[i]<<",";
    }
    cout<<endl;
}
///end scope of class MyType

int main()
{
    cout<< "MyStack<int> Object Numbers = "<<
     MyStack<int>::GetSNum () <<endl; //for private

    MyStack<char> cStk(10);
    cout<< "MyStack<char> Object Numbers = "<<
    MyStack<char>::GetSNum () <<endl;
    cStk.Push('s');
    cStk.printStack();

    MyStack<int> S1(5) , S2;

    S1.printStack();

    S1.Push(7);
    S1.Push(8);
    S1.Push(9);
    S1.viewContent();
    cout << endl;

    cout<< "MyStack<int> Object Numbers = "<<
     MyStack<int>::GetSNum () <<endl; //for private

    MyStack<int> *Ptr;
    Ptr = new MyStack<int>(8);

    cout<< "MyStack<int> Object Numbers = "<<
     MyStack<int>::GetSNum () <<endl; //for private

    delete Ptr;

    cout<< "MyStack<int> Object Numbers = "<<
     MyStack<int>::GetSNum () <<endl; //for private


    return 0;
}

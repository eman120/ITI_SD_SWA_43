#include <iostream>

using namespace std;

template <class MyType> ///Declare MyType as Type Parameter

class MyQueue
{
    MyType *que;
    int tail;
    int Size;



public:
    MyQueue()
    {
        que= new MyType [Size];
        tail=0;
        Size=5;
    }
    MyQueue(int s)
    {
        que= new MyType [Size];
        tail=0;
        Size=s;
    }

    bool IsFull()
    {
        return tail==Size;
    }

    bool IsEmpty()
    {
        return tail==0;
    }

    void Eneque(MyType num)
    {
        if (!IsFull())
        {
            que[tail++]=num;
        }
        else
        {
             cout<< "Queue is full" <<endl;
        }

    }
    MyType Deneque()
    {
        if(!IsEmpty())
        {
            MyType current = que[0];
            for(int i=0;i<=tail;i++)
            {
                que[i]=que[i+1];
            }
            tail--;
            return current;
        }
        else
        {
             cout<< "Queue is Empty" <<endl;
             return -1;
        }
    }
    ~MyQueue()
    {
        delete[]que;
    }
  void peek()
  {
      if (!IsEmpty())
      {
      cout<<que[tail-1]<<endl;

      }
      else
      {
          cout <<"the Queue is empty"<<endl;

      }
  }
  void printQueue()
    {
        int i = 0;
        cout << "Queue :";
        for(i =0 ; i< tail ; i++)
        {
            cout<< que[i]<<" ";
        }
        if (IsEmpty())
        {
            cout<<"Queue is Empty";
        }
        cout<< endl;
    }
};


int main()
{
    MyQueue<int> q1;

    q1.printQueue();

    q1.Eneque(5);
    q1.printQueue();
    cout << endl;

    q1.Eneque(8);
    q1.Eneque(9);
    q1.printQueue();
    cout << endl;

    q1.Eneque(13);
    q1.Eneque(14);
    q1.printQueue();

    ///not added
    q1.Eneque(15);
    cout <<"Deneque element : "<< q1.Deneque()<< endl;
    q1.printQueue();

    q1.Eneque(16);

    cout << "peek element : ";
    q1.peek();
    cout<<endl;

    q1.printQueue();

    MyQueue<char> q2;
    q2.Eneque('h');
    q2.printQueue();
    cout << endl;

    return 0;
}

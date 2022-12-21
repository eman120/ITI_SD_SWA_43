#include <iostream>

using namespace std;

class MyQueue
{
  private:
      int *que;
      int head;
      int tail;
      int size;
      int number;

  public:
    MyQueue (int s = 5)
    {
        size = s;
        head =0;
        tail = 0;
        number = 0;
        que = new int(size);
    }
    ~MyQueue ()
    {
        delete [] que;
    }
    bool IsFull()
    {
        return number==size;
    }

    bool IsEmpty()
    {
        return number==0;
    }
    void Enqueue(int num)
    {
        if(!IsFull())
        {
            que[tail]=num;
            tail = ++tail %size;
            number ++;
        }
        else{
            cout<< "Queue is full" <<endl;
        }
    }
    int Dequeue ()
    {
        if(!IsEmpty())
        {
            int current = que[head];
            head = ++head %size;
            number--;
            return current;
        }
        else{
            cout<< "Queue is Empty" <<endl;
            return -1;
        }
    }

    void peek()
    {
        if (!IsEmpty())
        {
            if (tail==0)
            {
                cout<<que[size-1]<<endl;
            }
            else if (IsEmpty())
            {
                cout<<"the queue is empty"<<endl;
            }
        }
        else{cout<<que[tail-1]<<endl;}

    }

    void printQueue()
    {
        int temp = head;
        int i;
        cout << "Queue :";
        for(i =0 ; i< number ; i++)
        {
            cout<< que[temp++ %size]<<" ";
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

    MyQueue q1(5);

    q1.printQueue();

    q1.Enqueue(5);
    q1.printQueue();
    cout << endl;

    q1.Enqueue(8);
    q1.Enqueue(9);
    q1.printQueue();
    cout << endl;

    q1.Enqueue(11);
    q1.Enqueue(14);
    q1.printQueue();
    cout<< endl;

    ///not added
    q1.Enqueue(15);
    cout <<"Dequeue element : "<< q1.Dequeue()<< endl;
    q1.printQueue();

    cout << "peek element : ";
    q1.peek();
    cout<< endl;

    q1.printQueue();

    return 0;
}

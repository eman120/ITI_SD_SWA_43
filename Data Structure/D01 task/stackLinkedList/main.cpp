#include <iostream>
#define Null 0
using namespace std;

class Node
{
public:
  int Data;
  Node* pNext;
  Node* pPrev;
};


class MyStack
{
public:
    Node* pStart = Null;
    Node* pLast = Null;
    int Tos ;
    int Size;

    ///newNode Method
    Node* NewNode(int D)
    {
        Node *pNew = new Node();
        if(pNew==NULL) exit(0);
        pNew -> Data = D;
        pNew->pNext = Null;
        pNew->pPrev = Null;
        return pNew;
    }

    ///push Method
    void Push (int data)
    {
        Node *pNew = NewNode(data);
        if  (pStart == Null)
        {
            pLast = pNew;
            pStart = pNew;
        }
        else
        {
            pLast->pNext = pNew;
            pNew->pPrev = pLast;
            pLast = pNew;
        }
    }

    int Pop()
    {
        if (pStart == Null)
        {
            cout <<"Stack is Empty \n";
            return -1;
        }
        else if(pStart==pLast)
        {
            int current = pStart->Data  ;
            free(pStart);
            return current;
        }
        else
        {
            int current = pLast->Data  ;
            pLast->pPrev->pNext = NULL;
            pLast = pLast->pPrev;
            return current;
        }
    }

    int Peek()
    {
        if (pStart == Null)
        {
            cout <<"Stack is Empty \n";
            return -1;
        }
        else
        {
        return pLast->Data;
        }
    }

    void printStack()
    {
        Node *pDisply = pStart;
        cout << "Stack :";
        while(pDisply != Null)
        {
            cout<<pDisply->Data<<"  ";
            pDisply = pDisply->pNext;
        }
        cout<< endl;
    }
    bool isfull(){return false;}
    bool isempty(){return pStart==NULL;}
};


int main()
{
    MyStack S1;

    S1.printStack();

    S1.Push(7);
    S1.printStack();
    cout << endl;

    S1.Push(13);
    S1.Push(14);
    S1.printStack();

    ///not added
    S1.Push(15);
    S1.printStack();
    cout <<"pop element : "<< S1.Pop()<< endl;

    S1.Push(16);
    S1.printStack();
    cout << "peek element : "<< S1.Peek()<< endl;

    S1.printStack();

    return 0;
}

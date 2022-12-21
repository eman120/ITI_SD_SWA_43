#include <iostream>
#define Null 0

using namespace std;
struct Employee
{
    int ID, Age;
    string Name;
    double Salary; //Deduct = tax
};

class Node
{
public:
    struct Employee Data;
    Node* pNext;
    Node* pPrev;
};

class MyQueue
{
public:
    Node* pStart = Null;
    Node* pLast = Null;
    int tail;
    int size;

    Node* NewNode(int D , int A , string G , int S )
    {
        Node *pNew = new Node();
        if(pNew==NULL) exit(0);
        pNew -> Data.ID = D;
        pNew -> Data.Age = A;
        pNew -> Data.Name = G;
        pNew -> Data.Salary = S;
        pNew->pNext = Null;
        pNew->pPrev = Null;
        return pNew;
    }


    void Eneque(int D , int A , string G , int S )
    {
        Node *pNew = NewNode(D , A ,  G , S );
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
    struct Employee Deneque()
    {
        /*
        if (pStart == Null)
        {
            cout <<"Queue is Empty \n";
            return Null;
        }
        else */if(pStart==pLast)
        {
            struct Employee current = pStart->Data  ;
            free(pStart);
            return current;
        }
        else
        {
            struct Employee current = pStart->Data ;
            pStart->pNext->pPrev=NULL;
            pStart=pStart->pNext;
            return current;
        }
    }
    struct Employee peek()
    {
        if (!(IsEmpty()))
        {
            return pStart->Data;
        }
        /*
        else
        {
            cout <<"Queue is Empty \n";
            return -1;
        }*/
    }
    void printQueue()
    {
        Node *pDisply = pStart;
        cout << "Queue :\n";
        while(pDisply != Null)
        {
            cout<<pDisply->Data.ID<<"  ";
            cout<<pDisply->Data.Name<<"  ";
            cout<<pDisply->Data.Age<<"  ";
            cout<<pDisply->Data.Salary<<"  ";
            pDisply = pDisply->pNext;
            cout<< endl;
        }
        cout<< endl;

        if (IsEmpty())
        {
            cout<<"Queue is Empty"<< endl;
        }

    }

    bool isfull()
    {
        return false;
    }
    bool IsEmpty()
    {
        return pStart==NULL;
    }
};


int main()
{

    MyQueue q1;

    q1.printQueue();

    q1.Eneque(5 , 25 , "Em" , 4000);
    q1.printQueue();
    cout << endl;

    q1.Eneque(8 , 28 , "En" , 5000);
    q1.Eneque(9 , 29 , "EA" , 5500);
    q1.printQueue();
    cout << endl;

    q1.Eneque(3 , 33 , "Hi" , 6000);
    q1.Eneque(4 , 34 , "Bye" , 7000);
    q1.printQueue();

    ///not added
    q1.Eneque(1 , 35 , "Hi5" , 6600);
    q1.printQueue();
    struct Employee emp = q1.Deneque();
    cout <<"Deneque Employee is : \n"<< emp.ID << ", ";
    cout << "Name: "<<emp.Name << ", ";
    cout << "Age: "<<emp.Age <<", ";
    cout <<"Salary: " << emp.Salary << endl;
    q1.printQueue();

    q1.Eneque(16 , 36 , "Bye6" , 7700);

    struct Employee empPeek = q1.peek();
    cout << "peek element : \n"<< empPeek.ID << ", ";
    cout << "Name: "<<empPeek.Name << ", ";
    cout << "Age: "<<empPeek.Age <<", ";
    cout <<"Salary: " << empPeek.Salary << endl;
    cout<<endl;

    q1.printQueue();

    return 0;
}

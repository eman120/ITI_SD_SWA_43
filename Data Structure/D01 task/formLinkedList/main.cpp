#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include<windows.h>
#define NormalPen 0x0b
#define HighLightPen 0xb0
#define Enter 0x0D
#define ESC 27
#define Delete 127
#include <iostream>

#define Null 0
#define size 10
#define itemsNumber 5
#define itemLength 20


using namespace std;

///Highlight Menu with 10 employees.

void gotoxy( int column, int line )
  {
  COORD coord;
  coord.X = column;
  coord.Y = line;
  SetConsoleCursorPosition(
    GetStdHandle( STD_OUTPUT_HANDLE ),
    coord
    );
  }

  void textattr (int i)
{
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);
}

struct Employee
{
    int ID, Age , Num;
    char Gender ,Name[100] , Address[200];
    double Salary, OverTime, Deduct; //Deduct = tax
};

//struct Employee emp;

class Node
{
public:
  Employee Data;
  Node* pNext;
  Node* pPrev;
};
Node* pStart;
Node* pLast;

int i;
char line[11];
char* LineEditor (int lineSize ,int xPos , int yPos , char sChar , char eChar)
{
    int xPosOld = xPos, lPos = xPos , ExitFlag =0;
    char *pCurrent , *pEnd;
    char c ;
    int limit = lineSize;

    pEnd = &line[0];
    pCurrent = &line[0];
    gotoxy(xPos, yPos);
    do{
        c = getch();

         switch (c)
        {
            case Enter:
                *pEnd='\0';
                return line;
            break;

            case ESC :
                ExitFlag = 1;
            break;

            case -32:
                c = _getch(); ///get second byte from buffer
                switch(c)
                {
                    case 77: //right
                        if(pCurrent< &line[limit])
                        {
                            pCurrent++;
                            gotoxy(++xPosOld, yPos);
                        }
                        break;
                    case 75: //left
                        if(pCurrent > &line[0])
                        {
                            pCurrent--;
                            gotoxy(--xPosOld, yPos);
                        }
                        break;
                    case 71 : //Home
                        pCurrent = &line[0];
                        gotoxy(xPos, yPos);
                        xPosOld = xPos;
                    break;
                    case 79 : //End
                        pCurrent = pEnd;
                        gotoxy(lPos, yPos);
                        xPosOld = lPos;
                    break;
                }

            break;
            default:
                if (c >= sChar && c <= eChar && pEnd!= &line[limit])
                {
                    *pCurrent= c;

                    if (pCurrent == pEnd)
                    {
                        lPos++;
                        pEnd++;
                    }
                    printf("%c",*pCurrent);
                    xPosOld++;
                    pCurrent++;
                }

            break;
        }

    }while(!ExitFlag);//c!=Enter);

    ///if ESC is pressed
    textattr(NormalPen);
    system("cls");
    exit(0);
}

class linkedList
{
    Node* pStart;
    Node* pLast;
};

Node* searchList(int key)
{
    struct Node* pSearch = pStart;
    while(pSearch != Null)
    {
        if(pSearch -> Data.Num == key)
        {
            break;
        }
        pSearch = pSearch->pNext;
    }
    return pSearch;
}


///Print Form Screen
void printScreen (int choice)
{
    int current =0 , ExitFlag =0;
    char Form[8][10] = {"ID" ,"Name" ,"Salary", "Tax" , "Address", "Age", "Gender", "OverTime"} , ch;

    printf("Employee #%i : " , choice);
    printf("\n");
    for(i =0 ; i <5 ; i++)
    {
        gotoxy(5,5+(3*i));
        printf("%s : " , Form[i]);
    }
    //_flushall();
    for(i =0; i <5 ; i++)
    {
        gotoxy(40,5+(3*i));
        if ( i < 3)
            printf("%s : " , Form[i+5]);
        else
            printf("\n");
    }
    gotoxy(15,5);
   // ch = _getch();

}

Node* NewNode(int D)
{
    Node* pNew = new Node();
    if (pNew == Null)
    {
        exit(0);
    }

    ///ID
    for (i =0 ; i <=10 ; i++)
    {
        gotoxy(14+i,5);
        printf(" ");
        textattr(HighLightPen);
    }
    pNew->Data.Num = D;
    pNew->Data.ID = atoi(LineEditor(2 ,15,5 , 48 , 57));

    ///Name
    for (i =0 ; i <=10 ; i++)
    {
        gotoxy(14+i,5+(3*1));
        printf(" ");
        textattr(HighLightPen);
    }
    strcpy(pNew->Data.Name , LineEditor(10 ,15,5+(3*1) , 97 , 122));

    ///Salary
    for (i =0 ; i <=10 ; i++)
    {
        gotoxy(14+i,5+(3*2));
        printf(" ");
        textattr(HighLightPen);
    }
    pNew->Data.Salary = atoi(LineEditor(5, 15,5+(3*2) , 48 , 57));

    ///Deduct
    for (i =0 ; i <=10 ; i++)
    {
        gotoxy(14+i,5+(3*3));
        printf(" ");
        textattr(HighLightPen);
    }
    pNew->Data.Deduct = atoi(LineEditor(5, 15,5+(3*3) , 48 , 57));

    ///Address
    for (i =0 ; i <=10 ; i++)
    {
        gotoxy(14+i,5+(3*4));
        printf(" ");
        textattr(HighLightPen);
    }
    strcpy(pNew->Data.Address , LineEditor(10, 15,5+(3*4) ,97 , 122));

    ///Age
    for (i =0 ; i <=10 ; i++)
    {
        gotoxy(50+i,5);
        printf(" ");
        textattr(HighLightPen);
    }
    pNew->Data.Age = atoi(LineEditor(2 ,50,5 , 48 , 57));

    ///Gender
    for (i =0 ; i <=10 ; i++)
    {
        gotoxy(50+i,5+(3*1));
        printf(" ");
        textattr(HighLightPen);
    }
    pNew->Data.Gender = *LineEditor(1 ,50 ,5+(3*1) ,97 , 122);

    ///OverTime
    for (i =0 ; i <=10 ; i++)
    {
        gotoxy(50+i,5+(3*2));
        printf(" ");
        textattr(HighLightPen);
    }
    pNew->Data.OverTime = atoi(LineEditor(5 ,50 , 5+(3*2), 48 , 57));

    pNew->pNext = Null;
    pNew->pPrev = Null;
    return pNew;
}

void ADDNode(int key)
{
    struct Node* pNew = NewNode(key);
    if (pLast == Null)
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


///Print Employee INFO
void Display(int choice)
{
    Node* pDisplay = searchList(choice);
    if(pDisplay == Null)
    {
        printf("not found");
    }
    else
    {
        printf("Employee %i INFO ::\n" , choice);
        printf("------------------\n");
        printf("Employee ID : %i\n" , pDisplay->Data.ID);
        printf("Employee Name : %s\n" , pDisplay->Data.Name);
        printf("Employee Gender : %c\n" , pDisplay->Data.Gender);
        printf("Employee Age : %i\n" , pDisplay->Data.Age);
        printf("Employee Address : %s\n" , pDisplay->Data.Address);
        printf("Employee Salary : %lf\n" ,pDisplay->Data.Salary + pDisplay->Data.OverTime - pDisplay->Data.Deduct);
        printf("===================\n");
    }
}

///display all employees
void DisplayAll ()
{
    //int choice = 0;
    Node* pDisplay = pStart;
    while(pDisplay != Null)
    {
        //pDisplay = searchList(choice);
        printf("Employee %i INFO ::\n" , pDisplay->Data.Num);
        printf("------------------\n");
        printf("Employee ID : %i\n" , pDisplay->Data.ID);
        printf("Employee Name : %s\n" , pDisplay->Data.Name);
        printf("Employee Gender : %c\n" , pDisplay->Data.Gender);
        printf("Employee Age : %i\n" , pDisplay->Data.Age);
        printf("Employee Address : %s\n" , pDisplay->Data.Address);
        printf("Employee Salary : %lf\n" ,pDisplay->Data.Salary + pDisplay->Data.OverTime - pDisplay->Data.Deduct);
        printf("=================\n");
        pDisplay = pDisplay->pNext;
        //choice++;
    }
    if (pStart == Null)
    {
        printf("There are no Employees");
    }
}


void DeleteByID(int key){
    char ch;
   Node*pdelete = searchList(key);
   if(pdelete == NULL){
        printf("not found!!\n");
   }
   else {
        if(pStart==pLast) pStart=pLast=NULL;
        else if(pStart==pdelete){
            pStart=pStart->pNext;
            pStart->pPrev=NULL;
        }
        else if(pLast==pdelete){
            pLast=pLast->pPrev;
            pLast->pNext=NULL;
        }
        else{
            pdelete->pPrev->pNext=pdelete->pNext;
            pdelete->pNext->pPrev=pdelete->pPrev;
        }
    }
    if (ch != Enter)
    {
    printf("Employee #%i is Deleted" , key );
    free (pdelete);
    }
}
/*
void insertNode(int N){
    struct Node * pnew = NewNode(N);
    if(pStart==NULL){
        pStart=pLast=pnew;
    }
    else{
        struct Node* psearch = pStart;
        while(psearch!=NULL && (psearch->Data.ID <= pnew->Data.ID)){
            psearch = psearch ->pNext;
            if(psearch==NULL){
                pLast->pNext =pnew;
                pnew->pPrev=pLast;
                pLast=pnew;
            }
            else if(psearch=pStart){
                pStart->pPrev=pnew;
                pnew->pNext=pStart;
                pStart=pnew;
            }
            else{
                printf("Bla Bla ..\n");
                pnew->pPrev =psearch->pPrev;
                pnew->pNext=psearch;
                psearch->pPrev->pNext=pnew;
                psearch->pPrev=pnew;

            }
        }
    }
}
*/
///Delete Employee By ID
/*
void DeleteByID (int choice)
{
    system("cls");
    char ch;

    while(EmpArr[choice-1].ID == 0)
    {
        printf("Employee #%i not Found \nEnter another Index : " , choice );
        ch = _getch();
        if (ch == ESC)
        {
            break;
        }
        scanf("%i" , &choice);
    }
    if (ch != ESC)
    {
    printf("Employee #%i is Deleted" , choice );
    EmpArr[choice-1].ID = 0;
    }

}

///Delete Employee By Name
void DeleteByName (char choice [])
{
    system("cls");
    int n, deleteFlag =0 , ExitFlag =0;
    char ch;

    do
    {
        for(n =0 ; n< size; n++)
        {
            if (strcmp(EmpArr[n].Name ,choice)==0 && EmpArr[n].ID != 0)
            {
                printf("Employee %s is Deleted" , choice );
                EmpArr[n].ID = 0;
                strcpy(EmpArr[n].Name , "");
                deleteFlag = 1;
                break;
            }
        }
       if(!deleteFlag)
        {
            printf("Employee %s not Found \nEnter another Name : " , choice );
            ch = _getch();
            if (ch == ESC)
            {
                break;
            }
            gets(choice);
            _flushall();
        }
    }while(!deleteFlag );
}
*/
int main()
{
    char Menu[itemsNumber][itemLength] = {"New", "Display By ID", "Display All" ,"Delete By ID" , "Exit"} , ch, nameUser[100];
    int current =0 , ExitFlag =0 , index;

    do
    {
        textattr(NormalPen);
        system("cls");

    for(i =0 ; i <itemsNumber ; i++)
    {
        if (current == i)
            textattr(HighLightPen);
        else
            textattr(NormalPen);
        gotoxy(15,5+(3*i));
        printf("%s" , Menu[i]);
    }
    ch = _getch();
    switch(ch)
    {
    case Enter:
        switch(current)
        {
        case 0: ///New
            system("cls");
            printf("Enter Index : ");
            scanf("%i" , &index);
            system("cls");
            printScreen(index);
            ADDNode(index);
            _getch();
            break;
            /*
        case 1: ///Insert By ID
            system("cls");
            printf("Enter Index : ");
            scanf("%i" , &index);
            system("cls");
            printScreen(index);
            insertNode(index);
            _getch();
            break;
            */
        case 1: ///Display By ID
            system("cls");
            printf("Enter Index : ");
            scanf("%i" , &index);
            Display(index);
            _getch();
            break;
        case 2: ///Display
            system("cls");
            DisplayAll();
            _getch();
            break;
        case 3: ///Delete By ID
            system("cls");
            printf("Enter Index : ");
            scanf("%i" , &index);
            DeleteByID (index);
            _getch();
            break;
        case 4: ///Exit
            ExitFlag =1;
            break;
        }
        break;
    case ESC:
        ExitFlag =1;
        break;
    case -32: //0xFFFFFFE0 //extended key
        ch = _getch(); ///get second byte from buffer
        switch(ch)
        {
        case 72: //UP
            current--;
            if(current <0) current =5;
            break;
        case 80: //Down
            current++;
            if(current >5) current =0;
            break;
        case 71: //Home
            current=0;
            break;
        case 79: //End
            current=5;
            break;
        }
        break;
        }
    }while(!ExitFlag); //ExitFlag=0 (false)


    //_getch();


    return 0;
}

#include <iostream>

using namespace std;

class Demo
{
public :
    int MyFun ( int X , char *Str ) {}
    int MyFun ( char * Str , int X) {} ///valid
    int MyFun ( int X , int Y) {}
    int MyFun ( int X) {}

};

class Complex
{
    int Real , Img;

public:
    static int countCtor;
    static int countDctor;

    Complex(int R ,int I)
    {
        cout <<"================"<<endl;
        cout << "Parameterized Ctor \n"<<this<<endl;
        countCtor++;
        Real = R ; Img = I;
        cout << "Ctor count is \n"<<countCtor<<endl;
    }
    Complex (int n)
    {
        cout <<"================"<<endl;
        cout << "Parameterized Ctor \n"<<this<<endl;
        Real = Img = n;
        countCtor++;
        cout << "Ctor count is \n"<<countCtor<<endl;
    }
    Complex ()  ///Parameterless Ctor
    {
        cout <<"================"<<endl;
        cout << "Parameterless Ctor \n"<<this<<endl;
        Real = Img = 0;
        countCtor++;
        cout << "Ctor count is \n"<<countCtor<<endl;
    }

    ~Complex()
    {
        cout <<"================"<<endl;
        cout <<"Destructor \n"<<this<<endl;
        countDctor++;
        cout <<"Destructor count is  \n"<<countDctor<<endl;
    }


    int GetReal () { return Real;}
    int GetImg () { return Img;}

    void SetReal ( int R)
    {
        Real = R;
    }

    void SetImg ( int I) { Img = I;}

    void Print()
    {
        cout <<Real <<"+" ;
        cout<<Img << "i"<<endl;
    }

    Complex Sum (Complex C)
    {
        Complex Result ;

        Result.Real = Real + C.Real;
        Result.Img = Img + C.Img;

        return Result;
    }
};

int Complex :: countCtor=0;
int Complex:: countDctor=0;

Complex Sub ( Complex L , Complex R)
{
    Complex Result ;

    Result.SetReal( L.GetReal() - R.GetReal());
    Result.SetImg(L.GetImg() - R.GetImg());

    return Result;
}

int main()
{
    Complex C1 (1,2) , C2 (5),C3;

    C3 = C1.Sum(C2);
    //C3.Print();
    C3 = Sub (C1 , C2);

    return 0;
}

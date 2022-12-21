#include <iostream>
#include <conio.h>
#include <string>
#include <cstring>
#include <sstream>
///complex with copy constructor by value
//output 5 constructors and 5 destructor

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
    //static int countCtor;
    //static int countDctor;

    Complex(int R ,int I)
    {
        //cout <<"================"<<endl;
        //cout << "Parameterized Ctor \n"<<this<<endl;
        //countCtor++;
        Real = R ; Img = I;
        //cout << "Ctor count is \n"<<countCtor<<endl;
    }
    Complex (int n)
    {
        //cout <<"================"<<endl;
        //cout << "Parameterized Ctor \n"<<this<<endl;
        Real = Img = n;
        //countCtor++;
        //cout << "Ctor count is \n"<<countCtor<<endl;
    }
    Complex ()  ///Parameterless Ctor
    {
        //cout <<"================"<<endl;
        //cout << "Parameterless Ctor \n"<<this<<endl;
        Real = Img = 0;
        //countCtor++;
        //cout << "Ctor count is \n"<<countCtor<<endl;
    }

///won't work without &
///It won't compile
    Complex (const Complex &oldC)  ///copy Ctor
    {
        //cout <<"================"<<endl;
        //cout << "copy Ctor \n"<<this<<endl;
        Real = oldC.Real;
        Img = oldC.Img;
        //countCtor++;
        //cout << "Ctor count is \n"<<countCtor<<endl;
    }

    ~Complex()
    {
        //cout <<"================"<<endl;
        //cout <<"Destructor \n"<<this<<endl;
        //countDctor++;
        //cout <<"Destructor count is  \n"<<countDctor<<endl;
    }


    int GetReal () const{ return Real;}
    int GetImg ()const { return Img;}

    void SetReal ( int R)
    {
        Real = R;
    }

    void SetImg ( int I) { Img = I;}

    void Print ()
    {
        if(Real == 0)
        {
            //cout <<Real << sign ;
            if (Img > 0)
            {
                cout << Img << "i" <<endl;
            }
            else if (Img < 0)
            {
                cout << '-' << -1*Img << "i" <<endl;
            }
            else
            {
                cout << 0 <<endl;
            }
        }
        else if(Img == 0)
        {
            cout <<Real<<endl;
        }
        else
        {
            cout <<Real;
            if (Img > 0)
            {
                cout << '+' <<Img << "i" <<endl;
            }
            else if (Img < 0)
            {
                cout << '-' << -1*Img << "i" <<endl;
            }
            else
            {
                cout << 0 <<endl;
            }
        }

    }

    Complex Sum (Complex C)
    {
        Complex Result ;

        Result.Real = Real + C.Real;
        Result.Img = Img + C.Img;

        return Result;
    }

    ///operator+///
    ///C3 = C1 + C2
    Complex operator+ (const Complex &C)
    {
        Complex Result (Real + C.Real, Img + C.Img);
        return Result;
    }
    ///C3 = C1 + 7
    Complex operator+ (int R)
    {
        Complex Result (Real + R, Img);
        return Result;
    }

    ///C3 = (C1 += C2)
   Complex &operator+= (const Complex &C)
    {
        Real += C.Real;
        Img += C.Img;
        return *this;
    }
    Complex &operator+= (int R)
    {
        Real += R;
        return *this;
    }

    //=======================
    ///operator-///
    ///C3 = C1 - C2
    Complex operator- (const Complex &C)
    {
        Complex Result (Real - C.Real, Img - C.Img);
        return Result;
    }
    ///C3 = C1 - 7
    Complex operator- (int R)
    {
        Complex Result (Real - R, Img);
        return Result;
    }

    ///C3 = (C1 -= C2)
    Complex &operator-= (const Complex &C)
    {
        Real -= C.Real;
        Img -= C.Img;
        return *this;
    }
    ///C3 = (C1 -= 7)
    Complex &operator-= (int R)
    {
        Real -= R;
        return *this;
    }
    ///C3 = (--C1)
    Complex &operator-- ()
    {
        Real --;
        return *this;
    }
    ///C3 = (C1--)
    Complex &operator-- (int)
    {
        Complex Temp (*this);
        Real --;
        return Temp;
    }
    ///C1 == C2
    bool operator== (const Complex &C)
    {
        return ((C.Real == Real) && (C.Img == Img));
    }
    ///C1 != C2
    bool operator!= (const Complex &C)
    {
        return ((C.Real != Real) && (C.Img != Img));
    }
    ///C1 > C2
    bool operator> (const Complex &C)
    {
        if (C.Real !=0 || Real !=0)
            return (Real > C.Real);
        else
            return (Img > C.Img);
    }
    ///C1 >= C2
    bool operator>= (const Complex &C)
    {
        if (C.Real !=0 && Real !=0)
            return (Real > C.Real) || (C.Real == Real);
        else
            return (Img > C.Img) || (C.Img == Img);
    }
    ///C1 < C2
    bool operator< (const Complex &C)
    {
        if (C.Real !=0 || Real !=0)
            return (Real < C.Real);
        else
            return (Img < C.Img);
    }
    ///C1 <= C2
    bool operator<= (const Complex &C)
    {
        if (C.Real !=0 && Real !=0)
            return (Real < C.Real) || (C.Real == Real);
        else
            return (Img < C.Img) || (C.Img == Img);
    }

    operator int ()
    {
        return Real;
    }
    operator char* ()
    {
        char* ch = new char[6];
        stringstream y ;
        y <<Real;
        y <<'+';
        y <<Img;
        y <<'i';
        string s = y.str();
        strcpy(ch , s.c_str());

        return ch;
    }

    //Explicit casting to array of char
    /*
    operator char*(){
        char *arr;
        arr = new char[10];
        string R,I;
        R = to_string(Real);
        I = to_string(Img);
        string result;
        result+= R;
        result+= '+';
        result+= I;
        result+= 'i';
        strcpy(arr,result.c_str());

        return arr;
    }
    */
};

///C3 = 7 + C1
Complex operator+ (int R ,const Complex &C)
{
    Complex Result (R + C.GetReal(),C.GetImg());
    return Result;
}
///C3 = 7 - C1
Complex operator- (int R ,const Complex &C)
{
    Complex Result (R - C.GetReal(),C.GetImg());
    return Result;
}
///C3 = (7 -=C1)
/*
Complex operator-= (int R ,const Complex &C)
{
    Complex Result (R - C.GetReal(),C.GetImg());
    return Result;
}
*/
int& operator-= (int &R ,const Complex &C)
{
    R =  R - C.GetReal();
    return R;
}


int main()
{
    //ctrl + shift + c => comment
    //ctrl + shift + x => no comment
    /// EQ :
    //Complex C1 (19,6) , C2 (5,3),C3;
    /// Not EQ :
    Complex C1 (15,6) , C2 (5,3),C3;
    int x = 7;
    char* ch;

    //C3.Print();

    /*
    cout <<"+ Operator ================"<<endl;
    C3.Print();
    C3 = C1 + C2;
    C3.Print();
    C3 = C1 + 7;
    C3.Print();
    //C3 = 7 + C1;
    C3.Print();
    C3 = (C1 += C2);
    C1.Print();
    cout <<"C1 += 7 : ";
    C3 = (C1 += 7);
    C1.Print();
    cout<<endl;
    */

    cout <<"- Operator ================"<<endl;
    cout <<"C1 : ";
    C1.Print();
    cout<<endl;
    cout <<"C2 : ";
    C2.Print();
    cout<<endl;
    cout <<"C3 : ";
    C3.Print();
    cout<<endl;
    cout <<"C3 = C1 - C2 : ";
    C3 = C1 - C2;
    C3.Print();
    cout<<endl;
    cout <<"================"<<endl;
    cout <<"C3 = C1 - 7 : ";
    C3 = C1 - 7;
    C3.Print();
    cout<<endl;
    cout <<"================"<<endl;
    cout <<"C3 = 7 - C1 : ";
    C3 = 7 - C1;
    C3.Print();
    cout<<endl;
    cout <<"================"<<endl;
    cout <<"C1 -= C2 : ";
    C1 -= C2;
    C1.Print();
    cout<<endl;
    cout <<"================"<<endl;
    cout <<"C1 -= 7 : ";
    C1 -= 7;
    C1.Print();
    cout<<endl;
    cout <<"================"<<endl;
    /*
    cout <<"7 -= C1 : ";
    C3 =( 7 -= C1);
    C3.Print();
    cout <<endl;
*/
    cout <<"7 -= C1 : ";
    x -= C1;
    cout<< x<<endl;

    cout <<"================"<<endl;
    cout <<"--C1 : "<<endl;
    cout <<"C3 : ";
    C3 = --C1;
    C3.Print();
    cout <<"C1 : ";
    C1.Print();
    cout<<endl;
    cout <<"================"<<endl;
    cout <<"C1-- : "<<endl;
    cout <<"C3 : ";
    C3 = C1--;
    C3.Print();
    cout <<"C1 : ";
    C1.Print();
    cout<<endl;
    cout <<"================"<<endl;
    cout <<"C1 : ";
    C1.Print();
    cout<<endl;
    cout <<"C2 : ";
    C2.Print();
    cout<<endl;
    cout <<"C1 == C2 : ";
    if (C1 == C2)
        cout<<"EQ"<<endl;
    else
        cout<<"Not EQ"<<endl;

    cout <<"C1 != C2 : ";
    if (!(C1 != C2))
        cout<<"Not EQ"<<endl;
    else
        cout<<"EQ"<<endl;

    cout <<"C1 > C2 : ";
    if (C1 > C2)
        cout<<"True"<<endl;
    else
        cout<<"False"<<endl;

    cout <<"C1 >= C2 : ";
    if (C1 >= C2)
        cout<<"True"<<endl;
    else
        cout<<"False"<<endl;

    cout <<"C1 < C2 : ";
    if (C1 < C2)
        cout<<"True"<<endl;
    else
        cout<<"False"<<endl;

    cout <<"C1 <= C2 : ";
    if (C1 <= C2)
        cout<<"True"<<endl;
    else
        cout<<"False"<<endl;
    cout <<"================"<<endl;
    cout <<"(int)C1 : ";
    x = (int)C1;
    cout<<x<<endl;
    cout <<"================"<<endl;
    cout <<"(char*)C1 : ";
    ch = (char*)C1;
    cout<<ch<<endl;

    //Explicit casting to char*
    /*
    char* ch ;
    ch = (char*)c2;
    cout<<ch;
    */

    /*
    stringstream y ;
    y <<x;
    string s = y.str();
    cout << s;
    */
    return 0;
}

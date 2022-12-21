#include <iostream>

using namespace std;

class Base
{
    int X;
protected:
    int Y;
public:
    int Z;
    Base()
    {
        X = Y = Z =0;
    }
    Base (int _x , int _y , int _z)
    {
        X = _x ;
        Y = _y;
        Z = _z;
    }
    void SetX(int _x)
    {
        X = _x;
    }
    int GetX ()
    {
        return X;
    }
    void SetY(int _y)
    {
        Y = _y;
    }
    int GetY ()
    {
        return Y;
    }
    void SetZ(int _Z)
    {
        Z = _Z;
    }
    int GetZ ()
    {
        return Z;
    }

    int funSum()
    {
        return X + Y + Z;
    }
};

class Derived: public Base
{
    int A;
protected:
    int B;
public:
    int C;
    Derived()
    {
        A = B = C = 0;
    }
    Derived(int _x , int _y , int _z ,int _A , int _B , int _C)
    :Base(_x , _y , _z)
    {
        A = _A;
        B = _B;
        C = _C;
    }

    void SetX(int _a)
    {
        A = _a;
    }
    int GetA ()
    {
        return A;
    }
    void SetB(int _b)
    {
        B = _b;
    }
    int GetB ()
    {
        return B;
    }
    void SetC(int _c)
    {
        C = _c;
    }
    int GetC ()
    {
        return C;
    }

    int funSum()
    {
        return GetX() + Y + Z + A + B + C;
    }
};

class Derived02: public Derived
{
    int K;
protected:
    int L;
public:
    int M;
    Derived02()
    {
        K = L = M =0;
    }
    Derived02(int _x , int _y , int _z ,int _A , int _B , int _C , int _K , int _L , int _M)
    :Derived(_x , _y , _z , _A , _B , _C)
    {
        K = _K;
        L = _L;
        M = _M;
    }

    void SetK(int _k)
    {
        K = _k;
    }
    int GetK ()
    {
        return K;
    }
    void SetL(int _l)
    {
        L= _l;
    }
    int GetL ()
    {
        return L;
    }
    void SetM(int _m)
    {
        M = _m;
    }
    int GetM ()
    {
        return M;
    }

    int funSum()
    {
        return GetX() + Y + Z + GetA() + B + C + K + L + M;
    }
};

int main()
{
    Base B;
   // B.X = B.Y = B.Z = 1;
    //cout <<"B.funSum() : "<<B.funSum () <<endl;


    //Derived D(1,2,3,5,6,7);
    Derived D;
    D.X = D.Y = D.Z = D.A =D.B = D.C = 2;
    //cout <<"D.funSum() : "<<D.funSum () <<endl;

    //Derived02 D02(1,2,3,5,6,7,8,9,10);
    Derived02 D02;
    D02.X = D02.Y = D02.Z = D02.A =D02.B = D02.C = D02.K= D02.L =D02.M =3;
    //cout <<"D02.funSum() : "<<D02.funSum () <<endl;

    return 0;
}

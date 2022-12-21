#include <iostream>

using namespace std;

class GeoShape
{
protected:
    int Dim1 , Dim2;
public:
    GeoShape(int  d1=0 , int d2 =0 )
    {
        Dim1 = d1 ;
        Dim2 = d2;
        //cout<<"GeoShape Ctor \n";
    }
    ~GeoShape ()
    {
        //cout<<"GeoShape destructor \n";
    }
    int GetDim1(){return Dim1;}
    int GetDim2(){return Dim2;}
    void SetDim1 (int D){Dim1 = D;}
    void SetDim2 (int D){Dim2 = D;}
};

class Rect : public GeoShape
{
public:
    Rect (int W , int H) :GeoShape(W,H)
    {
        //cout<<"Rect Ctor \n";
    }
    ~Rect()
    {
        //cout<<"Rect Dest \n";
    }
    int CArea () {return Dim1 * Dim2;}
};

class Square : protected Rect
{
public:
    Square (int L) :Rect(L ,L)
    {
        //cout<<"Square Ctor \n";
    }
    ~Square()
    {
        //cout<<"Square Dest \n";
    }

    ///new Functions
    void SetDim(int d)
    {
        Dim1 = Dim2 = d;
    }
    int SetDim()
    {
        return Dim1;
    }

    ///override protected Rect::setDim1 with public Square::setDim1
    void SetDim1 (int D)
    {
        Dim1 = Dim2 = D;
    }
    void SetDim2 (int D)
    {
        Dim1 = Dim2 = D;
    }

    int CArea()
    {
        return Rect::CArea();
    }
};

class Circle : public GeoShape
{
public:
    Circle (int R) :GeoShape(R , R)
    {
        //cout<<"Circle Ctor \n";
    }
    ~Circle()
    {
        //cout<<"Circle Dest \n";
    }
    double CArea ()
    {
        return 3.14 * Dim1 * Dim2;
    }

    ///overridding
    ///Hide GeoShape implementation with new Function
    void SetDim1(int d)
    {
        Dim1 = Dim2 = d;
    }
    void SetDim2(int d)
    {
        Dim1 = Dim2 = d;
    }
};

class Triangle : public GeoShape
{
public:
    Triangle (int d1 , int d2) :GeoShape(d1 , d2)
    {
        //cout<<"Triangle Ctor \n";
    }
    ~Triangle()
    {
       // cout<<"Triangle Dest \n";
    }
    double CArea () {return 0.5 * Dim1 * Dim2;}
};

double sumAreas(Rect *RArr , int RNum, Circle *CArr , int CNum , Square *SArr , int SNum , Triangle *TArr , int TNum)
{
    double sumArea =0;
    for (int i=0 ; i <RNum ; i++)
    {
        sumArea += RArr[i].CArea();
    }

    for (int i=0 ; i <CNum ; i++)
    {
        sumArea += CArr[i].CArea();
    }

    for (int i=0 ; i <SNum ; i++)
    {
        sumArea += SArr[i].CArea();
    }

    for (int i=0 ; i <TNum ; i++)
    {
        sumArea += TArr[i].CArea();
    }
    return sumArea;
}

int main()
{

    Rect R1(10 , 15);
    R1.SetDim1(11);
    R1.SetDim2(16);
    Rect R2(10 , 15);
    cout <<"R1.CArea() : "<< R1.CArea() << endl;
    cout <<"R2.CArea() : "<< R2.CArea() << endl;

    Square S1 (20);
    Square S2 (20);
    S2.SetDim1(40);
    S2.SetDim2(40);
    cout <<"S1.CArea() : "<< S1.CArea() << endl;
    cout <<"S2.CArea() : "<< S2.CArea() << endl;

    Triangle T1 (25 , 30);
    Triangle T2 (25 , 30);
    cout <<"T1.CArea() : "<< T1.CArea() << endl;
    cout <<"T2.CArea() : "<< T2.CArea() << endl;

    Circle C1(35);
    Circle C2(35);
    C2.SetDim1(50);
    C2.SetDim2(60);
    cout <<"C1.CArea() : "<< C1.CArea() << endl;
    cout <<"C2.CArea() : "<< C2.CArea() << endl;

    Rect RArr[2] ={
        R1,
        R2
    };

    Circle CArr[2] ={
        C1,
        C2
    };

    Square SArr[2] ={
        S1,
        S2
    };

    Triangle TArr[2] ={
        T1,
        T2
    };

    cout<<"sumAreas : "<<sumAreas(RArr , 2,CArr ,2,SArr ,2,TArr, 2);

    return 0;
}

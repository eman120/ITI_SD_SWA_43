#include <iostream>
#include <graphics.h>
/*
#include <windows.h>
#include <conio.h>
*/
//-lbgi -lgdi32 -lcomdlg32 -luuid -loleaut32 -lole32


using namespace std;

class ShapeColor
{
    int Color;
public:
    ShapeColor(int _color = 0)
    {
        Color = _color;
        setcolor(Color);
    }
    void setShapeColor(int _color)
    {
        Color = _color;
    }
    int getShapeColor()
    {
        return Color;
    }
};

class Point
{
    int X,Y;

public:
    Point()
    {
        X = Y = 0;
    }
    Point(int _X , int _Y)
    {
        X = _X;
        Y = _Y;
    }
    ~Point()
    {
        //cout<<"Point Destructor \n";
    }
    int GetX (){return X;}
    int GetY (){return Y;}

    void SetX (int _X){X = _X;}
    void SetY (int _Y){Y = _Y;}

    void show()
    {
        cout<<"("<<X <<","<<Y <<")\n";
    }
};

class Rect :public ShapeColor
{
    //UL : Upper Left
    //LR : Lower Right
    Point UL; ///composition
    Point LR;
public:
    Rect()
     {
         //int Color = 0;
         //cout << "Rect Parameterless Ctor \n";
     }
    Rect(int X1 , int Y1 , int X2 , int Y2 , int C)
    :UL(X1,Y1),LR(X2,Y2),ShapeColor(C)
    {
        //Color = C;
    }

    ~Rect()
    {
        //cout <<"Rect Destructor \n";
    }
    void Draw ()
    {
        //setcolor(Color);
        //setfillstyle(1 , 5);
        rectangle(UL.GetX(), UL.GetY() , LR.GetX(),LR.GetY());
    }
};

class Line :public ShapeColor
{
    Point UL; ///composition
    Point LR;
    //int Color;
public:
    Line()
     {
         //int Color = 0;
         //cout << "Line Parameterless Ctor \n";
     }
    Line(int X1 , int Y1  , int X2 , int Y2 , int C)
    :UL(X1,Y1),LR(X2,Y2),ShapeColor(C)
    {
        //Color = C;
        //cout <<"Line Ctor02 \n";
    }

    ~Line()
    {
        //cout <<"Line Destructor \n";
    }
    void Draw ()
    {
        ///Built in Function from Graphics.h
        //setcolor(Color);
        line(UL.GetX(), UL.GetY() , LR.GetX(),LR.GetY() );
    }

};

class Triangle :public ShapeColor
{
    Point right; ///composition
    Point left;
    Point bottom;
    //int Color;
public:
    Triangle()
     {
         //int Color = 0;
         //cout << "Triangle Parameterless Ctor \n";
     }
    Triangle(int X1 , int Y1 , int X2 , int Y2 , int X3 , int Y3, int C)
    :right(X1,Y1),left(X2,Y2),bottom(X3,Y3),ShapeColor(C)
    {
        //Color = C;
    }

    void Draw ()
    {
        ///Built in Function from Graphics.h
        //setcolor(Color);
        //setfillstyle(1,Color);
        line(left.GetX(), left.GetY(), right.GetX(), right.GetY());
        line(right.GetX(), right.GetY(), bottom.GetX(), bottom.GetY());
        line(left.GetX(), left.GetY() ,bottom.GetX(), bottom.GetY());
    }
};

class Circle :public ShapeColor
{
    Point center; ///composition
    //int Color;
    int radius;
public:
    Circle()
    {
        //Color = 2;
        radius = 0;
    }
    Circle(int X1 , int Y1  , int R, int C)
    :center(X1,Y1),ShapeColor(C)
    {
        //Color = C;
        radius = R;
    }

    void Draw ()
    {
        //setcolor(Color);
        circle(center.GetX(), center.GetY(), radius);
    }

};

class Pic
{
    Rect* pRect;
    Circle* pCir;
    Triangle* pTri;
    Line* pLine;

    int RNum;
    int CNum;
    int TNum;
    int LNum;
public:
    Pic()
    {
        RNum = 0 ; pRect = NULL;
        CNum = 0 ; pCir = NULL;
        TNum = 0 ; pTri = NULL;
        LNum = 0 ; pLine = NULL;
        //cout<<"Pic Ctor01 \n";
    }
    Pic ( Rect* rArr , int R , Circle* cArr , int C , Triangle* tArr , int T ,Line* lArr , int L )
    {
        pRect = rArr;
        RNum = R;
        pCir = cArr;
        CNum = C;
        pTri = tArr;
        TNum = T;
        pLine = lArr;
        LNum = L;

        cout<<"Pic Ctor02 \n";
    }
    ~Pic() {
        //cout <<"Pic Destructor \n";
    }
    void SetRect ( Rect* rArr , int R)
    {
        pRect = rArr;
        RNum = R;
    }

    void SetCir ( Circle* cArr , int C)
    {
        pCir = cArr;
        CNum = C;
    }

    void SetLine ( Line* lArr , int L)
    {
        pLine = lArr;
        LNum = L;
    }

    void SetTri ( Triangle* tArr , int T)
    {
        pTri = tArr;
        TNum = T;
    }


    void Paint()
    {
        for ( int i=0 ; i < RNum; i++)
            pRect[i].Draw();
        for ( int i=0 ; i < TNum; i++)
            pTri[i].Draw();
        for ( int i=0 ; i < LNum; i++)
            pLine[i].Draw();
        for ( int i=0 ; i < CNum; i++)
            pCir[i].Draw();

    }
};


int main()
{
    initgraph();
    Pic P;
    Rect *rArr ;
    Circle *cArr ;
    Triangle *tArr;
    Line *lArr;

    rArr = new Rect[1];
    rArr[0] = Rect(146 , 268 , 274  ,352  ,7);

    tArr = new Triangle[1];
    tArr[0] = Triangle(170 , 300 , 160  ,320 ,180 , 320 ,5);

    cArr = new Circle[2];
    cArr[1] = Circle(207 , 60, 70 ,7);
    cArr[0] = Circle(207 , 176, 110 ,7);

    lArr = new Line[4];
    lArr[0] = Line(182 , 268 , 182  ,208  ,5);
    lArr[1] = Line(230 , 268 , 230  ,208  ,5);
    lArr[2] = Line(152  ,173 , 173  ,60  ,5);
    lArr[3] = Line(262 , 173 , 238  ,60  ,5);


    P.SetRect(rArr , 1);
    P.SetLine(lArr , 4);
    P.SetTri(tArr , 1);
    P.SetCir(cArr , 2 );

    P.Paint();

    int k;
    cin>>k;

    return 0;
}

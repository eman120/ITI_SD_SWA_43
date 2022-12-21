#include <iostream>
#include <graphics.h>
/*
#include <windows.h>
#include <conio.h>
*/
//-lbgi -lgdi32 -lcomdlg32 -luuid -loleaut32 -lole32


using namespace std;
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

class Rect
{
    //UL : Upper Left
    //LR : Lower Right
    Point UL; ///composition
    Point LR;
    int Color;
public:
    Rect()
    {
        Color = 5;
    }
    Rect(int X1 , int Y1 , int X2 , int Y2 , int C)
    :UL(X1,Y1),LR(X2,Y2)
    {
        Color = C;
    }

    ~Rect()
    {
        //cout <<"Rect Destructor \n";
    }
    void Draw ()
    {
        setcolor(Color);
        //setfillstyle(1 , 5);
        rectangle(UL.GetX(), UL.GetY() , LR.GetX(),LR.GetY());
    }
};

class Line
{
    Point UL; ///composition
    Point LR;
    int Color;
public:
    Line()
    {
        Color = 2;
    }
    Line(int X1 , int Y1  , int X2 , int Y2 , int C)
    :UL(X1,Y1),LR(X2,Y2)
    {
        Color = C;
        //cout <<"Line Ctor02 \n";
    }

    ~Line()
    {
        //cout <<"Line Destructor \n";
    }
    void Draw ()
    {
        ///Built in Function from Graphics.h
        setcolor(Color);
        line(UL.GetX(), UL.GetY() , LR.GetX(),LR.GetY() );
    }

};

class Triangle
{
    Point right; ///composition
    Point left;
    Point bottom;
    int Color;
public:
    Triangle()
    {
        Color = 2;
    }
    Triangle(int X1 , int Y1 , int X2 , int Y2 , int X3 , int Y3, int C)
    :right(X1,Y1),left(X2,Y2),bottom(X3,Y3)
    {
        Color = C;
    }

    void Draw ()
    {
        ///Built in Function from Graphics.h
        setcolor(Color);
        //setfillstyle(1,Color);
        line(left.GetX(), left.GetY(), right.GetX(), right.GetY());
        line(right.GetX(), right.GetY(), bottom.GetX(), bottom.GetY());
        line(left.GetX(), left.GetY() ,bottom.GetX(), bottom.GetY());
    }
};
class Circle
{
    Point center; ///composition
    int Color;
    int radius;
public:
    Circle()
    {
        Color = 2;
        radius = 0;
    }
    Circle(int X1 , int Y1  , int R, int C)
    :center(X1,Y1),Color(C)
    {
        Color = C;
        radius = R;
    }

    void Draw ()
    {
        ///Built in Function from Graphics.h
        setcolor(Color);
        //setfillstyle(1,Color);
        circle(center.GetX(), center.GetY(), radius);
    }

};
int main()
{
    //Rect R01;
    initgraph();
    system("color 7D"); ///7:white(background) ,F:Purple (pen)
    Rect R01(146 , 268 , 274  ,352  ,7);
    R01.Draw();

    Triangle T01(170 , 300 , 160  ,320 ,180 , 320 ,5);
    T01.Draw();

    Line L01(182 , 268 , 182  ,208  ,5);
    L01.Draw();
    Line L02(230 , 268 , 230  ,208  ,5);
    L02.Draw();

    Circle C01(207 , 176, 110 ,7);
    C01.Draw();


    Line L03(152  ,173 , 173  ,60  ,5);
    L03.Draw();
    Line L04(262 , 173 , 238  ,60  ,5);
    L04.Draw();

    Circle C02(207 , 60, 70 ,7);
    C02.Draw();

    int k;
    cin>>k;

    /*
    initgraph();
    setcolor(2);
    circle(200,200,100); ///circle (int x, int y, int radius)
    rectangle(50 , 50 , 200  ,100 ); ///rectangle (int UL.X1 , int Y1 , int X2 , int Y2)
    line(140, 140, 350, 100); //line(int X1 , int Y1 , int X2 , int Y2);
    int k;
    cin>> k;
    */

    return 0;
}

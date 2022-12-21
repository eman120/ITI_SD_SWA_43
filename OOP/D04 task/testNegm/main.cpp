#include <iostream>
#include <graphics.h>

using namespace std;

class Point
{
    int x, y;
public:
    Point(int c1 = 0, int c2 = 0)
    {
        x = c1;
        y = c2;
    }
    int getX()
    {
        return x;
    }
    int getY()
    {
        return y;
    }
    void setX(int c)
    {
        x = c;
    }
    void setY(int c)
    {
        y = c;
    }
    void show()
    {
        cout << x << "," << y << endl;
    }
};

class MyRectangle
{
    Point ul, lr;
    int color;
public:
    MyRectangle(int p1x, int p1y, int p2x, int p2y, int clr):
    ul(p1x, p1y), lr(p2x, p2y)
    {
        color = clr;
    }

    void draw()
    {
        setcolor(color);
        rectangle(ul.getX(), ul.getY(), lr.getX(), lr.getY());
    }
};

class Line
{
    Point p1, p2;
    int color;
public:
    Line(int p1x, int p1y, int p2x, int p2y, int clr):
        p1(p1x, p1y), p2(p2x, p2y)
    {
        color = clr;
    }

    void draw()
    {
        setcolor(color);
        line(p1.getX(), p1.getY(), p2.getX(), p2.getY());
    }
};

class Triangle
{
    Point p1, p2, p3;
    int color;
public:
    Triangle(int p1x, int p1y, int p2x, int p2y, int p3x, int p3y, int clr):
        p1(p1x, p1y), p2(p2x, p2y), p3(p3x, p3y)
    {
        color = clr;
    }

    void draw()
    {
        setcolor(color);
        line(p2.getX(), p2.getY(), p3.getX(), p3.getY());
        line(p1.getX(), p1.getY(), p3.getX(), p3.getY());
        line(p2.getX(), p2.getY(), p1.getX(), p1.getY());
    }
};

class Circle
{
    Point center;
    int radius, color;
public:
    Circle(int centerX, int centerY, int _radius, int clr):
        center(centerX, centerY),radius(_radius)
    {
        radius = _radius;
        color = clr;
    }

    void draw()
    {
        setcolor(color);
        circle(center.getX(), center.getY(), radius);
    }
};

int main()
{
    initgraph();
    MyRectangle base (146 , 268 , 274  ,352  ,10);
    base.draw();

    Triangle button (170 , 300 , 160  ,320 ,180 , 320 ,10);
    button.draw();

    Line column1 (182 , 268 , 182  ,208  ,10);
    column1.draw();

    Line column2 (230 , 268 , 230  ,208  ,10);
    column2.draw();

    Circle lCircle (207 , 176, 110 ,10);
    lCircle.draw();

    Circle uCircle (207 , 60, 70 ,10);
    uCircle.draw();

    Line uLine1 (152  ,173 , 173  ,60  ,10);
    uLine1.draw();

    Line uLine2 (262 , 173 , 238  ,60  ,10);
    uLine2.draw();

    int k;
    cin>>k;
    return 0;
}

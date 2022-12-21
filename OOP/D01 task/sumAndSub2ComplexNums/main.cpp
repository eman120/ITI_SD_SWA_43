#include <iostream>

using namespace std;

class Complex
{//private:
    int Real;
    int Img;
public:
    void SetReal(int R) { Real = R;}
    void SetImg (int I) { Img = I;}

    int GetReal () { return Real;}
    int GetImg () { return Img;}

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
        Complex N;
        //N.SetReal(Real + C.Real);
        //N.SetReal(GetReal() + C.GetReal());
        //N.SetReal(this->GetReal() + C.GetReal());
        //N.SetImg(Img + C.Img);
        N.Real = Real + C.Real;
        N.Img = Img + C.Img;
        return N;
    }
};

Complex Sub (Complex L , Complex R)
{
    ///Complete Body
    Complex C;
    C.SetReal(L.GetReal() - R.GetReal());
    C.SetImg(L.GetImg() - R.GetImg());
    return C;
}


int main()
{
    Complex C1 , C2 ,C3 , C4 , C5 , C6 , C7;

    C1.SetReal(3);
    C1.SetImg(4);

    C2.SetReal(1);
    C2.SetImg(2);

    C3.SetReal(1);
    C3.SetImg(-2);

    C4.SetReal(4);
    C4.SetImg(0);

    C5.SetReal(0);
    C5.SetImg(3);

    C6.SetReal(0);
    C6.SetImg(0);

    cout << "First Complex" << endl;
    C1.Print();
    cout << "Second Complex" << endl;
    C2.Print();
    cout << "Third Complex" << endl;
    C3.Print();
    cout << "Third Complex" << endl;
    C4.Print();
    cout << "Fifth Complex" << endl;
    C5.Print();
    cout << "Sixth Complex" << endl;
    C6.Print();

    cout << "===========" << endl;

    C7 = C1.Sum(C2); ///Member Function
    cout << "Sum Two Complex" << endl;
    C7.Print();
    C7 = Sub(C1 , C2);
    cout << "Sub Two Complex" << endl;
    C7.Print();

    return 0;
}

using static ConsoleApp1.Point3D;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString());
            //Console.WriteLine(P);
            string str = (string)P;
            Console.WriteLine(str);

            //int x = 0 , y= 0 , z =0;
            Point3D P1, P2;
            Console.WriteLine("Enter Point 1 coordinates : ");
            P1 = new Point3D();
            
            Console.WriteLine("Enter Point 2 coordinates : ");
            P2 = new Point3D();
            //P2 = new Point3D(x, y, z);

            if(P1 == P2)
            {
                Console.WriteLine("P1 == P2 : True" );
            }
            else
            {
                Console.WriteLine("P1 == P2 : False");
            }

            if (P1.Equals(P2))
            {
                Console.WriteLine("P1.Equals(P2) : True");
            }
            else
            {
                Console.WriteLine("P1.Equals(P2) : False");
            }
        }
    }
}
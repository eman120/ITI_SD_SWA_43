namespace Duration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine("D1 :" + D1.ToString());

            Duration D2 = new Duration(3600);

            Console.WriteLine("D2 :" + D2.ToString());

            Duration D3 = new Duration(7800);

            Console.WriteLine("D3 :" + D3.ToString());

            Duration D4 = new Duration(666);

            Console.WriteLine("D4 :" + D4.ToString());

            Duration sum = D1 + D2;
            Console.WriteLine("Dsum(D1+D2) :" + sum);

            Duration sumint = D1 + 7800;
            Console.WriteLine("D1 + 7800 :" + sumint);

            Duration sumintRev = 666 + D1;
            Console.WriteLine("666 + D1 :" + sumintRev);

            Duration d = D1++;
            Console.WriteLine("D = D1++ :" + d);

            Duration Dminus = --D2;
            Console.WriteLine("D1 = --D2 :" + Dminus);

            D4 = -D4;
            Console.WriteLine("D4 = -D4 " + D4);

            D1 = new Duration(1, 10, 15);
            D2 = new Duration(3600);


            if (D1 >= D2)
                Console.WriteLine("D1 >= D2");
            if (D1 <= D2)
                Console.WriteLine("D1 <= D2");

            if (D1)
                Console.WriteLine("D1 : is not null");



            D2 = new Duration(3600 * 23);
            DateTime obj = (DateTime)D2;
            Console.WriteLine(obj);
        }
    }
}
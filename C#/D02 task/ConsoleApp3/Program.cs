using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            var watch = new Stopwatch();
            watch.Start();

            int numb = 99999999;

            //Console.WriteLine($"1 is counted {countOneString(numb)} times and prog time is {watch.ElapsedMilliseconds}");
            //Console.WriteLine($"1 is counted {countOneDigit(numb)} times and prog time is {watch.ElapsedMilliseconds}");
            Console.WriteLine($"1 is counted {countOneDigitFaster(numb)} times and prog time is {watch.ElapsedMilliseconds}");

            //Console.WriteLine(countOneString(numb));
            //Console.WriteLine(watch.ElapsedTicks.ToString());
            //Console.WriteLine(watch.ElapsedMilliseconds);

        }

        static int countOneString(int num)
        {
            Console.WriteLine("Case 1 :");
            int counter = 0;
            string str = "";
            for (int i = 0; i < num; i++)
            {
                str = i.ToString();
                counter += str.Split('1').Length -1;
            }
            return counter;
        }

        static int countOneDigit(int num)
        {
            Console.WriteLine("Case 2 :");
            int current = 1;

            int counter = 0;
            for (int i = 1; i < num; i++)
            {
                current = i;
                while(current != 0)
                {
                    counter += current % 10 == 1 ? 1 : 0;
                    current /= 10;
                }
            }
            return counter;
        }

        //third faster way
        static int countOneDigitFaster(int num)
        {
            Console.WriteLine("Case 3 :");

            int counter = 0;
            int digits = 0;
            while (num > 0)
            {
                num = num / 10;
                digits++;
            }
            //Console.WriteLine(digits);
            counter = (digits == 0) ? 1 : digits * (int)Math.Pow(10 , digits - 1) ;
            return counter;
        }
    }
}
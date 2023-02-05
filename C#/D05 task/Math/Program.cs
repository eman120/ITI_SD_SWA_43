namespace MathOPerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double res;

            int x = 1, y = 0;

            Console.WriteLine($"Add {x} , {y} : {MathS.Add(x, y)}");
            Console.WriteLine($"Subtract {x} , {y} : {MathS.Subtract(x, y)}");
            Console.WriteLine($"Multiply {x} , {y} : {MathS.Multiply(x, y)}");

            if( MathS.Divide(x, y, out res))
            {
                Console.WriteLine($"Divide {x} , {y} : {res}");
            }
            else
            {
                Console.WriteLine("Divide {x} , {y} is invalid");
            }
        }
    }
}
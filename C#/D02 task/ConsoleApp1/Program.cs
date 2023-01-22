namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write a program find the longest distance between Two equal cells.
            //int[] Arr = new int [11]{ 7, 0, 0,0, 5 , 6 , 7 ,0 , 7 ,5 , 3 };

            Console.WriteLine("Please Enter the size of the Array");
            int ArrSize = int.Parse(Console.ReadLine());
            int[] Arr= new int[ArrSize];

            for (int i = 0; i < ArrSize; i++)
            {
                Console.WriteLine($"Enter value ({i+1}) ");
                Arr[i] = int.Parse(Console.ReadLine());
            }

            getLongestDistance(Arr);
        }

        static void getLongestDistance(int[] Arr)
        {
            int max = 0;
            int count = 0;
            int num = 0;
            int numTwin = 0;
            int first = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr.Length; j++)
                {
                    if (Arr[i] == Arr[j])
                    {
                        numTwin = j;
                        count = numTwin - i;
                        if (count > max)
                        {
                            num = i;
                            max = count;
                            //first = i;
                        }
                    }
                }
            }
            Console.WriteLine("===========================");
            Console.WriteLine($"The longest distance in array = {max - 1} is between the ({num + 1}) element and the ({numTwin + 1}) element");
        }
    }
}
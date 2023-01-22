namespace ConsoleApp2
{
    internal class Program
    {
        //Given a list of space separated words, reverse the order of the words.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string you want to be reversed");
            string str = Console.ReadLine();

            reverseString(str);
        }

        static void reverseString(string s)
        {
            string [] strArr = s.Split(' ');
            //string strReverse = "";
            //for(int i = strArr.Length - 1 ; i >= 0; i--)
            //{
            //    strReverse += strArr[i];
            //}
            Array.Reverse(strArr);
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.Write(strArr[i] + " ");
            }
        }
    }
}
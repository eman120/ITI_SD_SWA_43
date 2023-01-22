namespace refByVal_refByRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 5 };
            System.Console.WriteLine("Inside Main, before calling the method, the first element is: {0}", arr[0]);

            System.Console.WriteLine("=========================================");

            //Pass a reference type by value
            ChangeValue(arr);
            System.Console.WriteLine("Inside Main, after calling the method, the first element is: {0}", arr[0]);

            System.Console.WriteLine("=========================================");

            //Pass a reference type by reference
            ChangeRef(ref arr);
            System.Console.WriteLine("Inside Main, after calling the method, the first element is: {0}", arr[0]);

        }

        //Pass a reference type by value
        static void ChangeValue(int[] pArray)
        {
            pArray[0] = 888;  // This change affects the original element.
            pArray = new int[5] { -3, -1, -2, -3, -4 };   // This change is local.
            System.Console.WriteLine("Inside the method, the first element is: {0}", pArray[0]);
        }
        /* Output:
            Inside Main, before calling the method, the first element is: 1
            Inside the method, the first element is: -3
            Inside Main, after calling the method, the first element is: 888
        */

        ///Pass a reference type by reference
        static void ChangeRef(ref int[] pArray)
        {
            // Both of the following changes will affect the original variables:
            pArray[0] = 888;
            pArray = new int[5] { -3, -1, -2, -3, -4 };
            System.Console.WriteLine("Inside the method, the first element is: {0}", pArray[0]);
        }
        /* Output:
            Inside Main, before calling the method, the first element is: 1
            Inside the method, the first element is: -3
            Inside Main, after calling the method, the first element is: -3
        */
    }
}
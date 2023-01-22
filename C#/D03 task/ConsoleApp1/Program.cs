using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sl = String.Empty;
            string gender = String.Empty;
            string date = String.Empty;

            Console.WriteLine("Please enter the number of employees");
            Console.WriteLine("================================");

            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("================================");

            Employee[] empArr = new Employee[size];

            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine("Please enter the data of employee " + (i + 1));
                Console.WriteLine("================================");
                //ID
                Console.WriteLine("Enter Employee ID : ");
                empArr[i].setID(int.Parse(Console.ReadLine()));

                //security Level
                Console.WriteLine("Enter Employee Secutity Level (guest/Developer/secretary/DBA/officer) : ");
                sl=Console.ReadLine();
                empArr[i].setSecutityLevel((privilege)Enum.Parse(typeof(privilege),sl));

                //salary
                Console.WriteLine("Enter Employee salary : ");
                empArr[i].setSalary(int.Parse(Console.ReadLine()));

                //gender
                do
                {
                    Console.WriteLine("Enter Employee gender (M / F) only : ");
                    gender = Console.ReadLine();
                } while (gender != "F" && gender != "M");
                empArr[i].setGender((Gender)Enum.Parse(typeof(Gender), gender));

                //hire date
                Console.WriteLine("Enter Employee hire date (dd/mm/yyyy) : ");
                date = Console.ReadLine();
                string[] dateArr = date.Split("/");
                empArr[i].setDate(int.Parse(dateArr[0]) , int.Parse(dateArr[1]) , int.Parse(dateArr[2]));


                Console.WriteLine("================================");
                //empArr[i] = new Employee();
            }

            Console.WriteLine("Press D to display all employees");
            if (Console.ReadKey().Key == ConsoleKey.D)
            {
                Console.Clear();
                displayEmployees(empArr);
            }

            ////All Employees
            //for (int i = 0; i < empArr.Length; i++)
            //{
            //    Console.Clear();
            //    Console.WriteLine(empArr[i].ToString());
            //    Console.WriteLine("================================");
            //}


        }
        public static void displayEmployees(Employee[] empArr)
        {
            //All Employees
            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine(empArr[i].ToString());
                Console.WriteLine("================================");
            }
        }

        //public static void Hold()
        //{
        //    Console.WriteLine("Press d to return");
        //    while (Console.ReadKey().Key != ConsoleKey.D) ;
        //}

    }
}
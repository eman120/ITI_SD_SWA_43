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

            #region enter the number of employees
            Console.WriteLine("Please enter the number of employees");
            Console.WriteLine("================================");

           // Employee[] empArr;
            //int size = int.Parse(Console.ReadLine());
            if (int.TryParse(Console.ReadLine(), out int size))
            {
                //empArr[i].ID = id;
                //empArr = new Employee[size];
            }
            else
            {
                Console.WriteLine("Employees number should be a number");
                return;
            }
            Console.WriteLine("================================");
            #endregion

            #region employee data
            Employee[] empArr = new Employee[size];

            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine("Please enter the data of employee " + (i + 1));
                Console.WriteLine("================================");

                #region id
                //ID
                Console.WriteLine("Enter Employee ID : ");
                //empArr[i].ID =int.Parse(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    empArr[i].ID = id;
                }
                else
                {
                    Console.WriteLine("Employee id should be a number");
                    return;
                }
                #endregion

                #region name
                //Name
                Console.WriteLine("Enter Employee Name : ");
                empArr[i].Name = Console.ReadLine();
                #endregion

                #region security level
                //security Level
                Console.WriteLine("Enter Employee Secutity Level (guest/Developer/secretary/DBA/officer) : ");
                sl=Console.ReadLine();
                //empArr[i].SecutityLevel = (privilege)Enum.Parse(typeof(privilege),sl);
                if (Enum.TryParse(sl, true, out privilege p)) //true : ignore case
                {
                    empArr[i].SecutityLevel = p;
                }
                else
                {
                    Console.WriteLine("invalid!!!!! \nThe SecutityLevel should be (guest/Developer/secretary/DBA/officer) only");
                    return;
                }
                #endregion

                #region salary
                //salary
                Console.WriteLine("Enter Employee salary : ");
                //empArr[i].Salary = int.Parse(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out int salary))
                {
                    empArr[i].Salary = salary;
                }
                else
                {
                    Console.WriteLine("The salary should be a number");
                    return;
                }
                #endregion

                #region gender
                //gender
                do
                {
                    Console.WriteLine("Enter Employee gender (M / F) only : ");
                    gender = Console.ReadLine();
                } while (gender != "F" && gender != "M");
                empArr[i].Gender = (Gender)Enum.Parse(typeof(Gender), gender);
                #endregion

                #region hire date
                //hire date
                Console.WriteLine("Enter Employee hire date (dd/mm/yyyy) : ");
                date = Console.ReadLine();
                string[] dateArr = date.Split("/");
                //empArr[i].Date ( int.Parse(dateArr[0]) , int.Parse(dateArr[1]) , int.Parse(dateArr[2]));
                if ((int.TryParse(dateArr[0], out int day))&& (int.TryParse(dateArr[1], out int month)) && (int.TryParse(dateArr[2], out int year)))
                {
                    empArr[i].Date(day, month,year);
                }
                else
                {
                    Console.WriteLine("Hire date should be a number");
                    return;
                }
                #endregion

                Console.WriteLine("================================");
            }

            //EmployeeSearch ES = new EmployeeSearch(,empArr);

            #endregion

            #region search employee
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("you can Search with : \n1-Name. 2-HireDate. 3-ID.");
            Console.WriteLine("Choose : 1 , 2 ,or 3");
            //int srch = int.Parse(Console.ReadLine()); //tyr parse//
            if (int.TryParse(Console.ReadLine(), out int srch))
            {
                //student.Id = srch;
            }
            else
            {
                Console.WriteLine("This choice should be a number");
                return;
            }

            Console.WriteLine("================================");

            EmployeeSearch empS = new EmployeeSearch(empArr);
            switch (srch)
            {
                case 1:
                    Console.WriteLine("Enter Employee Name : ");
                    string name = Console.ReadLine();
                    Console.WriteLine(empS[name]);
                    break;
                case 2:
                    Console.WriteLine("Enter Employee date(dd/mm/yyyy) : ");
                    //HireDate da = Console.ReadLine();
                    string da = Console.ReadLine();
                    string[] daArr = da.Split("/");
                    if ((int.TryParse(daArr[0], out int day)) && (int.TryParse(daArr[1], out int month)) && (int.TryParse(daArr[2], out int year)))
                    {
                        Console.WriteLine(empS[day, month, year]);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hire date should be a number");
                        return;
                    }
                case 3:
                    Console.WriteLine("Enter Employee id : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine(empS[id]);
                    break;

            }
            #endregion

        }

    }
}
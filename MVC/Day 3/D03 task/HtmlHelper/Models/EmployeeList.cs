using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HtmlHelper.Models
{
    public class EmployeeList
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee(){Id = 1 , Name ="Mohammed" ,Age = 20},
            new Employee(){Id = 2 , Name ="Ahmed" ,Age = 21},
            new Employee(){Id = 3 , Name ="Esraa" ,Age = 22},
            new Employee(){Id = 4 , Name ="Eman" ,Age = 23},
        };
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public List<Employee> Staff { set; get; } = new List<Employee>();
        public void AddStaff(Employee E)
        {
            if(Staff?.Contains(E) == false)
            {
                Staff.Add(E);
                E.EmployeeLayOff += RemoveStaff;
            }
            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveStaff(object sender,
        EmployeeLayOffEventArgs e)
        {
            if(sender is Employee emp)
            {
                Console.WriteLine($"Employee {emp.EmployeeID} is removed from department staff for {e.Cause}");
                Staff?.Remove(emp);
                emp.EmployeeLayOff -= this.RemoveStaff;
            }
        }
    }
}

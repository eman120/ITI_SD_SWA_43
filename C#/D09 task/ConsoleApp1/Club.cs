using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members { get; set; } = new List<Employee>();
        public void AddMember(Employee E)
        {
            if (Members?.Contains(E) == false)
            {
                Members.Add(E);
                E.EmployeeLayOff += RemoveMember;
            }
            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveMember
        (object sender, EmployeeLayOffEventArgs e)
        {
            if(sender is Employee employee && sender != null)
            {
                if(e.Cause == LayOffCause.exceedVacationLimit)
                {
                    Console.WriteLine($"Employee {employee.EmployeeID} is removed from club members for {e.Cause}");
                    Members.Remove(employee);
                    employee.EmployeeLayOff -= this.RemoveMember;
                }
            }
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
        }
    }
}


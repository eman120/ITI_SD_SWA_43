using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SalesPerson : Employee
    {
        public SalesPerson()//int id, DateTime birthdate, int vacationstock , int achievedTarget)
            //:base ( id,  birthdate ,  vacationstock)
        {
            //AchievedTarget = achievedTarget;
        }
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int target)
        {
            if (AchievedTarget < target)
            {
                LayOffCause Cause = LayOffCause.Notargat;
                OnEmployeeLayOff(new EmployeeLayOffEventArgs(Cause));
                return false;

            }
            return true;
        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.Notargat)
                base.OnEmployeeLayOff(e);
        }
    }
}

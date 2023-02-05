using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BoardMember : Employee
    {
        public BoardMember()//int id, DateTime birthdate, int vacationstock)
            //: base(id, birthdate, vacationstock)
        {
        }
        public void Resign()
        {
            LayOffCause Cause = LayOffCause.Resign;
            OnEmployeeLayOff(new EmployeeLayOffEventArgs(Cause));
        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.Resign)
                base.OnEmployeeLayOff(e);
        }
    }
}

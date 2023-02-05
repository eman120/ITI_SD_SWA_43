using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        //public Employee(int id , DateTime birthdate , int vacationstock ) 
        //{
        //    EmployeeID= id;
        //    BirthDate= birthdate;
        //    VacationStock= vacationstock;
        //}
        public event
        EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff
        (EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke (this, e);
            //throw new NotImplementedException();
        }

        DateTime birthDate;

        public int EmployeeID { get; set; }
        public DateTime BirthDate
        {
        
            get { return birthDate; }
            set { birthDate = value;  }
        }
        public int VacationStock
        {
            get;
            set;
        }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            double vocation = (To - From).TotalDays;
            if(vocation < VacationStock)
            {
                VacationStock -= (int)vocation;
                return true;
            }
            else
            {
                LayOffCause Cause = LayOffCause.exceedVacationLimit;
                OnEmployeeLayOff(new EmployeeLayOffEventArgs (Cause));
                return false;
            }
        }
        public void EndOfYearOperation()
        {
            DateTime date= DateTime.Now;
            if (date.Year - BirthDate.Year > 60)
            {
                LayOffCause Cause = LayOffCause.Retired;
                OnEmployeeLayOff(new EmployeeLayOffEventArgs(Cause));
            }
        }
    }
    public enum LayOffCause
    { 
        Retired , exceedVacationLimit , Resign, Notargat
    }
    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }
        public EmployeeLayOffEventArgs(LayOffCause cause)
        {
            Cause = cause;  
        }
    }
}

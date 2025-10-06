using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        public int EmployeeID { get; set; }
        public DateTime BirthDate { set; get; }
        public int VacationStock { get; set; }
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            if (To < From)
            {
                Console.WriteLine($"Invalid date range: '{To}' is before '{From}'");
                return false;
            }
            int requestedDays = (To - From).Days + 1;
            if(requestedDays <=0 || From < DateTime.Today)
            {
                Console.WriteLine("Invalid date range");
                return false;
            }
            Console.WriteLine($"Employee {EmployeeID} requested {requestedDays} days. Remaining stock = {VacationStock}");
            if (requestedDays > VacationStock)
            {
                return false;
            }
            VacationStock -= requestedDays;
            return true;
        }
        public void EndOfYearOperation()
        {
            if(DateTime.Now.Year - BirthDate.Year >= 60 && !( this is BoardMember ))
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.AgeExceeded});
            }
            else if (VacationStock <0 && !(this is SalesPerson))
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.VacationStockNegative });
            }
        }
    }
}

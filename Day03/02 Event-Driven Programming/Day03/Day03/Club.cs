using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }

        List<Employee> Members;
        public Club()
        {
            Members = new List<Employee>();
        }
        public void AddMember(Employee E)
        {
            Members.Add(E);
            E.EmployeeLayOff += RemoveMember;
            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            Employee? employee = sender as Employee;
            if (employee != null && Members.Contains(employee))
            {
                if (e.Cause == LayOffCause.AgeExceeded && DateTime.Now.Year - employee.BirthDate.Year > 60)
                {
                    Console.WriteLine($"Employee {employee.EmployeeID} not removed from Club {ClubName} due to {e.Cause}");
                    return;
                }
                if (e.Cause == LayOffCause.VacationStockNegative && employee.VacationStock < 0)
                {
                    Members.Remove(employee);
                    Console.WriteLine($"Employee {employee.EmployeeID} removed from Club {ClubName} due to {e.Cause}");
                    employee.EmployeeLayOff -= RemoveMember;
                }
            }
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
        }
        public void ShowMembers()
        {
            Console.WriteLine("Club Members: " + string.Join(", ", Members.Select(e => e.EmployeeID)));
        }
    }
}

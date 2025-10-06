using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public Department()
        {
            Staff = new List<Employee>();
        }

        List<Employee> Staff;
        public void AddStaff(Employee E)
        {
            Staff.Add(E);
            E.EmployeeLayOff += RemoveStaff;
            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveStaff(object sender,EmployeeLayOffEventArgs e)
        {
            Employee? employee = sender as Employee;
            if (employee != null && Staff.Contains(employee))
            {
                Staff.Remove(employee);
                Console.WriteLine($"Employee {employee.EmployeeID} removed from Dept {DeptName} due to {e.Cause}");
                employee.EmployeeLayOff -= RemoveStaff;
            }
        }
        public void ShowStaff()
        {
            Console.WriteLine("Department Staff: " + string.Join(", ", Staff.Select(e => e.EmployeeID)));
        }
    }
}

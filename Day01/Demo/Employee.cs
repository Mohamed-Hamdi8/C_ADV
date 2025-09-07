using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class EmployeeEqualityComparerById : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Id == y?.Id;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Id);
        }
    }
    class EmployeeEqualityComparerByName : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Name == y?.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }
    class EmployeeEqualityComparerBySalary : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Salary == y?.Salary;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Salary);
        }
    }
    class NewEmployeeComparerById : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return (x?.Id.CompareTo(y?.Id??0)) ?? (y is null ? 0 : -1);
        }
    }
    class NewEmployeeComparerByName : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return (x?.Name?.CompareTo(y?.Name)) ?? (y is null ? 0 : -1);
        }
    }
    internal class Employee :IEquatable<Employee> //,IComparable<Employee>
    {
        #region Property
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }
        #endregion

        #region Constructor
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        #endregion

        #region Method
        public override string ToString() => $"Id : {Id},\t Name : {Name},\t Salary : {Salary} ";
        
        ///public override bool Equals(object? obj)
        ///{
        ///    //Employee? other = (Employee?)obj; //Explicit Casting
        ///    //                                  //UnSafe Casting --> May Throw Exception
        ///
        ///
        ///    //1. is operator
        ///    //if (obj is Employee other)
        ///    //{
        ///    //    return (this.Id.Equals(other.Id)) && ((this.Name?.Equals(other.Name)) ?? (other.Name == null ? true : false)) && (this.Salary.Equals(other.Salary));
        ///    //}
        ///    //return false;
        ///
        ///
        ///    //2. as operator
        ///    Employee? other = obj as Employee;
        ///    if (other == null) return false;
        ///    return (this.Id.Equals(other.Id)) && ((this.Name?.Equals(other.Name)) ?? (other.Name == null ? true : false)) && (this.Salary.Equals(other.Salary));
        ///}
        ///
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);

            ///int HashValue = 5;
            ///HashValue = (HashValue * 7) ^ Id.GetHashCode();
            ///HashValue = (HashValue * 7) ^ Name?.GetHashCode()??0;
            ///HashValue = (HashValue * 7) ^ Salary.GetHashCode();
            ///return HashValue;

            //return Id.GetHashCode() ^ Name?.GetHashCode()?? 0 ^ Salary.GetHashCode();
            //return Id.GetHashCode() + Name?.GetHashCode()?? 0 + Salary.GetHashCode();
        }
        public bool Equals(Employee? other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id))&&((this.Name?.Equals(other.Name))??(other.Name == null? true : false))&&(this.Salary.Equals(other.Salary));

        }

        public int CompareTo(Employee? other)
        {
            return this.Salary.CompareTo(other?.Salary??1);
        }
        #endregion
    }
}

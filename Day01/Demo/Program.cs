namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Genric SWAP - EX01
            ///int A = 5, B = 10;
            ///Console.WriteLine($"A : {A}\nB : {B}");
            ///Helper.SWAP<int>(ref A, ref B);
            ///Console.WriteLine($"A : {A}\nB : {B}");

            ///double A = 5.3, B = 1.2;
            ///Console.WriteLine($"A : {A}\nB : {B}");
            ///Helper.SWAP<double>(ref A, ref B);
            ///Console.WriteLine($"A : {A}\nB : {B}");

            ///Point P1 = new Point(5,10);
            ///Point P2 = new Point(20,30);
            ///Console.WriteLine($"P1 : {P1}\nP2 : {P2}");
            ///Helper.SWAP<Point>(ref P1, ref P2);
            ///Console.WriteLine($"P1 : {P1}\nP2 : {P2}");

            ///string name01 = "Ali";
            ///string name02 = "Ola";
            ///Console.WriteLine($"Name01 : {name01}\nName02 : {name02}");
            ///Helper.SWAP( ref name01,ref  name02 );
            ///Console.WriteLine($"Name01 : {name01}\nName02 : {name02}"); 
            #endregion

            #region Genirc Linear Search - EX01
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //Console.WriteLine(Helper.LinearSearch<int>(Numbers, 9)); 
            #endregion

            #region Equality (== ,Equals) && GetHashCode
            //Employee emp01 = new Employee(1001, "Mohamed", 20_000);
            //Employee emp02 = new Employee(1001, "Mohamed", 20_000);

            //Console.WriteLine(emp01.GetHashCode());
            //Console.WriteLine(emp02.GetHashCode());

            ////if(emp01 == emp02)
            //if(emp01.Equals(emp02))
            //    Console.WriteLine("Equals");
            //else
            //    Console.WriteLine("!Equals"); 
            #endregion

            #region Linear Search - EX02 [Using IEquatable<>]
            //Employee[] employees =
            //{
            //    new Employee(1001, "Mohamed", 20_000),
            //    new Employee(1002, "Ahmed", 10_000),
            //    new Employee(1003, "Ali", 18_000),
            //    new Employee(1004, "Alaa", 15_000)
            //};


            //int index = Helper.LinearSearch<Employee>(employees, new Employee(10035, "Ali", 18_000), new EmployeeEqualityComparerById());
            //Console.WriteLine(index); 
            #endregion

            #region Linear Search - EX03 [Using Delegate(Func<>)]
            //Employee[] employees =
            //{
            //    new Employee(1001, "Mohamed", 20_000),
            //    new Employee(1002, "Ahmed", 10_000),
            //    new Employee(1003, "Ali", 18_000),
            //    new Employee(1004, "Alaa", 15_000)
            //};


            //int index = Helper.LinearSearch<Employee>(employees,
            //    new Employee(10035, "Alii", 18_000),
            //    //delegate (Employee X, Employee Y) { return (X.Salary == Y.Salary); }
            //    (X, Y) => X.Salary == Y.Salary
            //    );
            //Console.WriteLine(index);
            #endregion

            #region Bubble Sort - EX01
            //int[] Numbers = { 3, 5, 7, 2, 4, 9, 8 };
            //Helper.BubbleSort(Numbers);

            //foreach (var number in Numbers)
            //    Console.WriteLine(number);

            //Employee[] employees =
            //{
            //    new Employee(1001, "Mohamed", 20_000),
            //    new Employee(1002, "Ahmed", 10_000),
            //    new Employee(1003, "Ali", 18_000),
            //    new Employee(1004, "Alaa", 15_000)
            //};
            //Helper.BubbleSort(employees);

            //foreach (var employee in employees)
            //    Console.WriteLine(employee); 
            #endregion

            #region Bubble Sort - EX02
            //Employee[] employees =
            //{
            //    new Employee(1001, "Mohamed", 20_000),
            //    new Employee(1002, "Ahmed", 10_000),
            //    new Employee(1003, "Ali", 18_000),
            //    new Employee(1004, "Alaa", 15_000)
            //};
            //Helper.BubbleSort(employees, new NewEmployeeComparerByName());

            //foreach (var employee in employees)
            //    Console.WriteLine(employee);
            #endregion

            #region Bubble Sort - EX03
            //Employee[] employees =
            //{
            //    new Employee(1001, "Mohamed", 20_000),
            //    new Employee(1002, "Ahmed", 10_000),
            //    new Employee(1003, "Ali", 18_000),
            //    new Employee(1004, "Alaa", 15_000)
            //};
            //Helper.BubbleSort(employees,
            //    (X,Y)=> X.Name?.CompareTo(Y.Name)==1);

            //foreach (var employee in employees)
            //    Console.WriteLine(employee); 
            #endregion

        }
    }
}

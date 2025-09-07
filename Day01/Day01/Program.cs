

using System.Collections;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //Range<int> intRange = new Range<int>(10, 50);
            //Console.WriteLine(intRange);  // Range: [10, 50]
            //Console.WriteLine(intRange.IsInRange(33)); //True
            //Console.WriteLine(intRange.IsInRange(70)); //False
            //Console.WriteLine(intRange.Length()); //40

            //Range<double> doubleRange = new Range<double>(5.5, 10.2);
            //Console.WriteLine(doubleRange);                // Range: [5.5, 10.2]
            //Console.WriteLine(doubleRange.IsInRange(7.1)); // True
            //Console.WriteLine(doubleRange.Length()); // 4.7 
            #endregion

            #region 2

            ///string[] Arr = { "medo", "darsh", "7amosa", "mero", "os" };
            ///Helper.Reverse<string>(ref Arr);
            ///foreach (var i in Arr)
            ///{
            ///    Console.WriteLine(i);
            ///}

            ///Employee[] employees =
            ///{
            ///    new Employee(1001, "Mohamed"),
            ///    new Employee(1003, "Ahmed"),
            ///    new Employee(1002, "Ali"),
            ///    new Employee(1004, "Alaa")
            ///};
            ///Helper.Reverse<Employee>(ref employees);
            ///foreach (Employee employee in employees)
            ///{
            ///    Console.WriteLine(employee);
            ///}

            ///ArrayList list = new ArrayList() 
            ///{
            ///    new Employee(1001, "Mohamed"),
            ///    new Employee(1003, "Ahmed"),
            ///    new Employee(1002, "Ali"),
            ///    new Employee(1004, "Alaa")
            ///};
            ///Helper.Reverse(list);
            ///foreach (Employee e in list)
            ///{
            ///    Console.WriteLine(e);
            ///}

            ///List<Employee> list = new List<Employee>() {
            ///    new Employee(1001, "Mohamed"),
            ///    new Employee(1003, "Ahmed"),
            ///    new Employee(1002, "Ali"),
            ///    new Employee(1004, "Alaa")
            ///};
            ///Helper.Reverse<Employee>(list);
            ///foreach (var i in list)
            ///{
            ///    Console.WriteLine(i);
            ///}

            #endregion

            #region 3

            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //int[] evenNumbers = Helper<int>.ArrayOfEvenNumbers(numbers);
            //foreach (int number in evenNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,7,5,3,1,2};
            //List<int> ListOfEvenNumber = Helper.ListOfEvenNumbers(list);
            //foreach (var number in ListOfEvenNumber)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region 4
            // FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(3);
            // fixedSizeList.Add(1);
            // fixedSizeList.Add(2);
            // fixedSizeList.Add(3);
            // //fixedSizeList.Add(4); //throw Exception : Out Of Range
            // Console.WriteLine(fixedSizeList[2]); // 3
            //// Console.WriteLine(fixedSizeList[3]); //throw Exception : Invalid indices 
            #endregion

            #region 5 {Without Using Dictionary} I don't know her yet
            //string name = "leetcode";
            //Console.WriteLine(Helper.IndexOfFirstNonRepeatedCharacter(name)); 
            #endregion
        }
    }
}

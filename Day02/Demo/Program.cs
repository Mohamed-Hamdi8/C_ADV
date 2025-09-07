using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non-Genric Collections - ArrrayList 

            ///ArrayList Numbers = new ArrayList();
            ///
            ///Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            ///
            ///Numbers.Add(1);
            ///Numbers.Add(2);
            ///Numbers.AddRange(new int[] { 3, 4 });
            ///
            ///Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            ///
            ///Numbers.Add(5);
            ///
            ///Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            ///
            ///Numbers.TrimToSize(); //Free | Delete | Deallocate Unused Bytes = 12;
            ///Console.WriteLine("***** After Triming ******");
            ///
            ///Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");

            ///ArrayList Numbers = new ArrayList(9) { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ///ArrayList Numbers02 = new ArrayList(Numbers);
            ///
            ///Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            ///Console.WriteLine($"Count = {Numbers02.Count} , Capacity = {Numbers02.Capacity}");

            ///ArrayList Numbers = new ArrayList(5) { 1,2,3,4,5};
            ///
            /// //Numbers[5] = 100; //Error
            ///
            ///Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            ///
            ///if(Numbers.Capacity <21)
            ///    Numbers.Capacity = 21;
            ///
            ///for (int i = 6;i<= 21;i++)
            ///{
            ///    Numbers.Add(i);
            ///}
            ///
            ///Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");

            ///ArrayList Numbers = new ArrayList(5);
            ///Numbers.Add(1); //Casting From int[ValueType] to object[ReferenceType] --> Boxing 
            ///Numbers.Add(2); //Casting From int[ValueType] to object[ReferenceType] --> Boxing 
            ///Numbers.Add(3); //Casting From int[ValueType] to object[ReferenceType] --> Boxing 
            ///Numbers.Add(4); //Casting From int[ValueType] to object[ReferenceType] --> Boxing 
            ///Numbers.Add("Hamada"); //Compiler Can't Enforce Type Safety
            ///
            ///SumOfArrayList(Numbers); //System.InvalidCastException on line 56

            #endregion

            #region Genric Collections - List

            ///List<int> Numbers = new List<int>(); 
            ///
            ///Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            ///
            ///Numbers.Add(1);
            ///Numbers.Add(2);
            ///Numbers.AddRange([3,4]);
            ///
            ///Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            ///
            ///Numbers.Add(5);
            ///Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            ///
            ///Numbers.TrimExcess(); //Free | Delete | Deallocate Unused Bytes = 12;
            ///Console.WriteLine("***** After Triming ******");
            ///Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");

            ///List<int> Numbers = new List<int>(5) { 1,2,3,4};
            ///
            ///Numbers[0] = 100;
            /// //Numbers[4] = 5;//Error
            ///for (int i = 0; i < Numbers.Count; i++)
            ///    Console.WriteLine(Numbers[i]);
            ///
            ///foreach (int i in Numbers)
            ///    Console.WriteLine(i);

            ///List<int> Numbers = new List<int>(5) { 1,2,3,4,5};
            ///
            ///Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            ///
            ///Numbers.EnsureCapacity(21);
            ///for(int i =6; i<=21;i++)
            ///{
            ///    Numbers.Add(i);
            ///}
            ///
            ///Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");

            ///List<int> Numbers = new List<int>(5);
            ///Numbers.Add(1);
            ///Numbers.Add(2);
            ///Numbers.Add(3);
            ///Numbers.Add(4);
            ///
            ///int result = SumOfList(Numbers);
            ///Console.WriteLine($"Result = {result}");
            #endregion

            #region List Method
            ///List<int> Numbers = new List<int>(5) { 1, 3, 4, 5 ,6};

            ///Numbers.Insert(0, 100);
            ///Numbers.InsertRange(1, [101,102,103,104,105]);
            ///foreach (int item in Numbers)
            ///{
            ///    Console.WriteLine(item);
            ///}

            ///IReadOnlyList<int> ReadOnlyNumbers = Numbers.AsReadOnly();
            ///ReadOnlyNumbers[0] = 100; //Error
            ///foreach (int item in ReadOnlyNumbers)
            ///{
            ///    Console.WriteLine(item);
            ///}

            ///int index = Numbers.BinarySearch(5); //4
            ///index = Numbers.BinarySearch(10);   //-6
            ///index = Numbers.BinarySearch(2);    //-2
            ///Console.WriteLine(index);

            ///Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            ///Numbers.Clear();
            ///Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");

            /// //long[] Arr= Numbers.ConvertAll<long>(delegate(int N) { N += 100; return N; }).ToArray();
            /// //List<long> Arr = Numbers.ConvertAll<long>( N=> {N += 100; return N; });
            ///List<long> Arr = Numbers.Select<int,long>( N=>N).ToList(); //Best Practise
            ///foreach (int item in Arr)
            ///{
            ///    Console.WriteLine(item);
            ///}

            ///int[] Arr = new int[10];
            ///Numbers.CopyTo(Arr);
            ///Numbers.CopyTo(Arr,5);
            ///foreach (int item in Arr)
            ///{
            ///    Console.WriteLine(item);
            ///}

            ///int FirstEvenNumber = Numbers.Find(N => N%2==0); 
            ///int FirstEvenNumberIndex = Numbers.FindIndex(N => N % 2 == 0);
            ///int LastEvenNumber = Numbers.FindLast(N => N%2==0);
            ///int LastEvenNumberIndex = Numbers.FindLastIndex(N => N % 2 == 0);
            ///Console.WriteLine($"First Even Number --> {FirstEvenNumber} At Index : {FirstEvenNumberIndex} ");
            ///Console.WriteLine($"Last Even Number --> {LastEvenNumber} At Index : {LastEvenNumberIndex}");
            ///
            ///List<int> EvenNumbers = Numbers.FindAll(N => N % 2 == 0);
            ///foreach(int i in EvenNumbers)
            ///    Console.WriteLine(i);

            ///Console.WriteLine($"List Have All Even Numbers ?   {Numbers.TrueForAll(N => N % 2 == 0)}");
            ///Console.WriteLine($"List Have Even Numbers ?   {Numbers.Exists(N => N % 2 == 0)}");

            ///Numbers.ForEach(N => { N += 100; Console.WriteLine(N); });
            ///Console.WriteLine("********* Numbers Will No Effect *********");
            ///foreach (int item in Numbers)
            ///{
            ///    Console.WriteLine(item);
            ///}

            ///List<int> Numbers02 = Numbers.GetRange(0, 3);
            ///foreach (int item in Numbers02)
            ///    Console.WriteLine(item);
            ///Console.WriteLine("===========================");
            ///List<int> Numbers03 = Numbers.Slice(0, 3);
            ///foreach (int item in Numbers03)
            ///    Console.WriteLine(item);

            ///int index = Numbers.IndexOf(5); //3
            ///index = Numbers.IndexOf(5,2);//3
            ///index = Numbers.IndexOf(5,1,2);//-1
            ///index = Numbers.LastIndexOf(5); //3
            ///index = Numbers.LastIndexOf(5,2); //-1
            ///Console.WriteLine(index);

            ///Numbers.RemoveAll(N => N % 2 == 0);
            ///foreach (int n in Numbers)
            ///{
            ///    Console.WriteLine(n);
            ///}

            ///List<Employee> employees = new List<Employee>()
            ///{
            ///    new Employee(10,"Ahmed",30_000),
            ///    new Employee(20,"Ali",40_000),
            ///    new Employee(30,"Ola",20_000),
            ///    new Employee(40,"Alaa",10_000),
            ///};
            ///employees.Sort(new EmployeeNameComparer());
            ///int index = employees.BinarySearch(new Employee() { Id = 30} );
            ///index = employees.BinarySearch(new Employee() { Name = "Ola" },new EmployeeNameComparer());
            ///index = employees.BinarySearch(1, 3, new Employee() { Name = "Ola" }, new EmployeeNameComparer());
            ///Console.WriteLine($"Index = {index}");
            #endregion

            #region Genric Collections - Stack

            /// Stack<int> stack = new Stack<int>();
            /// 
            /// stack.Push(1);
            /// stack.Push(2);
            /// stack.Push(3);
            /// 
            /// //Console.WriteLine(stack.TryPop(out int Value01)); //T--> 3
            /// //Console.WriteLine(stack.TryPop(out int Value02)); //T--> 2
            /// //Console.WriteLine(stack.TryPop(out int Value03)); //T--> 1
            /// //Console.WriteLine(stack.TryPop(out int Value04)); //F--> 0
            /// 
            /// Console.WriteLine(stack.TryPeek(out int value)); //T
            /// Console.WriteLine(value); //3
            /// 
            /// 
            /// //foreach (int item in stack)
            /// //    Console.WriteLine(item); 

            #endregion

            #region Genric Collections - Queue

            /// Queue<int> queue = new Queue<int>();
            /// 
            /// queue.Enqueue(1);
            /// queue.Enqueue(2);
            /// queue.Enqueue(3);
            /// 
            /// Console.WriteLine(queue.TryDequeue(out int Value01)); //T--> 1
            /// Console.WriteLine(queue.TryDequeue(out int Value02)); //T--> 2
            /// Console.WriteLine(queue.TryDequeue(out int Value03)); //T--> 3
            /// Console.WriteLine(queue.TryDequeue(out int Value04)); //F--> 0
            /// 
            /// //foreach (int i in queue)
            /// //    Console.WriteLine(i);
            
            #endregion
        }
        public static int SumOfArrayList(ArrayList Numbers)
        {
            int sum = 0;
            if(Numbers is not null)
            {
                for (int i = 0; i < Numbers.Count; i++)
                {
                    sum += (int?)Numbers[i]??0; //Casting From object[ReferenceType] To int[ValueType] --> UnBoxing
                                                //Unsafe Casting
                }
            }
            return sum;
        }
        public static int SumOfList(List<int> Numbers)
        {
            int sum = 0;
            if(Numbers?.Count>0)
            {
                for (int i = 0; i < Numbers.Count; i++)
                {
                    sum += Numbers[i];
                }
            }
            return sum;
        }
    }
}

namespace Demo
{
    // Step 0.  Delegate Declaration
    public delegate int CustomFunc(string arg01);
    /// NEW Delegate (Class), The Reference from this Delegate Can Refer To a Function or More [Pointer To Function].
    /// These Functions Can Be Class Member [Static] , Or Object Member [Non-Static].
    /// These Functions Must Have The Same Signature Of The Delegate : int(string).

    public delegate bool CustomPredicate<T>(T arg01);
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Delegate is a C# Language Feature [C# 2.0 ]
            /// Has 2 Usage:
            /// 1. Functional Programming
            /// 2. Event-Driven Programming        

            #region Delegate EX01
            /// // Step 1.  Declare Delegate Reference
            /// CustomFunc func;
            /// 
            /// // Step 2.  Initialize The Delegate Reference [Pointer To Functions]
            /// //func = new CustomFunc(StringFunctions.GetCountOfUpperCaseChars);
            /// func = StringFunctions.GetCountOfUpperCaseChars; // "Syntax Sugar"
            /// 
            /// func += StringFunctions.GetCountOfLowerCaseChars;
            /// 
            /// func -= StringFunctions.GetCountOfUpperCaseChars; 
            /// 
            /// 
            /// // Step 3. Use The Delegate Reference
            /// int result = func.Invoke("Mohamed Hamdi");
            /// //result = func("Mohamed Hamdi"); // "Syntax Sugar"
            /// Console.WriteLine(result); 
            #endregion

            #region Delegate EX02

            ///int[] Numbers = [3, 4, 1, 5, 2, 0, 6, 9, 8, 7];
            ///d
            ///CustomFunc<int, int, bool> func = ComparsionType.CompareLes;
            ///SortingAlgorithm.BubbleSort<int>(Numbers, func);
            ///
            ///foreach (int i in Numbers) 
            ///    Console.WriteLine(i); 

            ///string[] Names = ["Mohamed", "Ahmed ", "Ali", "Alaa", "Fathy", "Hamdi", "Ziad"];
            ///
            ///CustomFunc<string, string, bool> func = ComparsionType.CompareGrt;
            ///
            ///SortingAlgorithm.BubbleSort<string>(Names, func);
            ///
            ///foreach (string item in Names)
            ///{
            ///    Console.WriteLine(item);
            ///}

            #endregion

            #region Delegate EX03
            //List<int> Numbers = Enumerable.Range(0, 101).ToList();

            #region Find Even Numbers

            ///List<int> EvenNumbers = FindElements(Numbers,ConditionFunction.IsEven);
            ///
            ///foreach (int num in EvenNumbers)
            ///    Console.Write($"{num} ");
            ///Console.WriteLine();

            #endregion

            //Console.WriteLine("*******************************");

            #region Find Odd Numbers

            ///List<int> OddNumbers = FindElements(Numbers, ConditionFunction.IsOdd);
            ///
            ///foreach (int num in OddNumbers)
            ///    Console.Write($"{num} ");
            ///Console.WriteLine();

            #endregion

            //Console.WriteLine("*******************************");

            #region Find Numbers Devieded By 7

            ///List<int> DiviededBySeven = FindElements(Numbers, ConditionFunction.IsDiviededBySeven);
            ///
            ///foreach (int num in DiviededBySeven)
            ///    Console.Write($"{num} ");
            ///Console.WriteLine();

            #endregion

            //Console.WriteLine("*******************************");

            #region Find Names Length More Than 4

            ///List<string> Names = new List<string>() { "Mohamed", "Ali", "Fares", "Ola", "Maram", "Noha" };
            ///
            ///List<string> NamesWithLengthMoreThan04 = FindElements(Names, ConditionFunction.IsMoreThan04Chars);
            ///
            ///foreach (string item in NamesWithLengthMoreThan04)
            ///{
            ///    Console.WriteLine(item);
            ///}

            #endregion

            #endregion

            #region Built-in Delegates [Predicate , Func , Action]

            //Predicate<int> predicate = DoSomeCode.Test;
            //predicate.Invoke(10);
            //predicate(10); //"Syntax Sugar"

            //Func<int, string> func = DoSomeCode.Cast;
            //func.Invoke(100);


            //Action action01 = DoSomeCode.Print;
            //action01.Invoke();


            //Action<string> action02 = DoSomeCode.Print;
            //action02.Invoke("Mohamed Hamdi"); 

            #endregion

            #region Anonymous Function VS Lambda Expression
            // Anonymous Function: C# 2.0 Feature (.NET Framework 2.0 [2005] )
            ///Predicate<int> predicate = delegate (int x) { return x > 0; };
            ///predicate.Invoke(10);
            ///predicate(10); //"Syntax Sugar"

            ///Func<int, string> func = delegate(int x) { return x.ToString(); };
            ///func.Invoke(100);

            ///Action action01 = delegate() { Console.WriteLine("Hello") ; };
            ///action01.Invoke();

            ///Action<string> action02 = delegate(string name) { Console.WriteLine($"Hello {name}"); };
            ///action02.Invoke("Mohamed Hamdi");

            // Lambda Expression: C# 3.0 Feature (.NET Framework 3.5 [2007] )
            //[ => ] Called as 'FatArrow' and read as 'GoesTo'
            ///Predicate<int> predicate =  x =>  x > 0; 
            ///predicate.Invoke(10);
            ///predicate(10); //"Syntax Sugar"

            ///Func<int, string> func =  x=> x.ToString(); 
            ///func.Invoke(100);

            ///Action action01 = () =>  Console.WriteLine("Hello");
            ///action01.Invoke();

            ///Action<string> action02 =  name=> Console.WriteLine($"Hello {name}");
            ///action02.Invoke("Mohamed Hamdi"); 
            #endregion

            #region NEW Feature in Delegate Using 'var' KeyWord

            /// // var keyword -> Implicitly Typed Local Variable   [C# 2.0]
            /// 
            /// var predicate = (int N) => N > 0;
            /// // Predicate<int>
            /// predicate.Invoke(10);
            /// predicate(10);
            /// 
            /// var func = (int Number) => Number.ToString();
            /// // Func<int, string>
            /// func.Invoke(10);
            /// func(10);
            /// 
            /// var action = (string Name) => Console.WriteLine($"Hello {Name}");
            /// // Action<string>
            /// action.Invoke("Ahmed");
            /// action("Ahmed"); 

            #endregion

            #region Method In List That Take Function As Parameter

            //List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            //List<int> OddNumbers = FindElements(Numbers ,ConditionFunction.IsOdd);
            //List<int> OddNumbers = FindElements(Numbers, delegate (int n) { return n % 2 != 0; });
            //List<int> OddNumbers = FindElements(Numbers, n=> n % 2 != 0);

            //Console.WriteLine($"All Element On List Is Odd : {OddNumbers.TrueForAll(X=>X%2!=0)}");
            //Console.WriteLine();

            //Numbers.ForEach(x => 
            //{ 
            //    x += 10;
            //    Console.WriteLine(x);
            //}
            //); 

            //foreach (int item in OddNumbers)
            //{
            //    Console.WriteLine(item);
            //} 

            #endregion

            #region Function Returns Function - FP Feature
            //var action = DelegateDoAction(); 
            //action("Ahmed");              
            //action("Sara");

            //var doubler = MakeMultiplier(2);  
            //var tripler = MakeMultiplier(3);

            //Console.WriteLine(doubler(5));  // 10
            //Console.WriteLine(tripler(5));  // 15 
            #endregion

        }
        public static List<T> FindElements<T>(List<T> element, CustomPredicate<T> customPredicate)
        {
            List<T> result = new List<T>();
            if (element?.Count > 0 && customPredicate is not null)
            {
                foreach (var item in element)
                {
                    if (customPredicate.Invoke(item))
                        result.Add(item);
                }
            }
            return result;
        }
        public static Action<string> DelegateDoAction()
        {
            return name => Console.WriteLine($"Hello {name}");
        }
        public static Func<int, int> MakeMultiplier(int factor)
        {
            return x => x * factor;
        }
    }

    class StringFunctions
    {
        public static int GetCountOfUpperCaseChars(string name)
        {
            Console.WriteLine("GetCountOfUpperCaseChars");

            int count = 0;
            if (name is not null)
            {
                for (int i = 0; i < name.Length; i++)
                    if (char.IsUpper(name[i]))
                        count++;
            }
            return count;
        }
        public static int GetCountOfLowerCaseChars(string name)
        {
            Console.WriteLine("GetCountOfLowerCaseChars");

            int count = 0;
            if (name is not null)
            {
                for (int i = 0; i < name.Length; i++)
                    if (char.IsLower(name[i]))
                        count++;
            }
            return count;
        }
    }

    class ConditionFunction
    {
        public static bool IsOdd(int x) => x % 2 != 0;
        public static bool IsEven(int x) => x % 2 == 0;
        public static bool IsDiviededBySeven(int x) => x % 7 == 0;
        public static bool IsMoreThan04Chars(string text) => text.Length > 4;
    }

    class DoSomeCode
    {
        public static bool Test(int x) => x > 0;
        public static string Cast(int x) => x.ToString();
        public static void Print() => Console.WriteLine("Hello");
        public static void Print(string Name) => Console.WriteLine($"Hello {Name}");
    }
}

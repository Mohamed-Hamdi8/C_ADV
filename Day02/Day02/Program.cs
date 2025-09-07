using Demo;
using System.Collections;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1

            //Console.Write("Enter Size Of Array : ");
            //int Size = int.Parse(Console.ReadLine());
            //Console.Write("Enter Number Of Queries : ");
            //int NoOfQueries = int.Parse(Console.ReadLine());

            //int[] Arr = new int[Size];
            //for(int i = 0; i < Arr.Length; i++)
            //{
            //    Console.Write($"Enter Element {i+1} : ");
            //    Arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            //int Query;
            //for(int i = 0;i < NoOfQueries; i++)
            //{
            //    int count = 0;
            //    Console.Write($"Enter Query {i+1} : ");
            //    Query = int.Parse(Console.ReadLine());
            //    for (int j = 0; j < Arr.Length; j++)
            //    {
            //        if (Query < Arr[j])
            //            count++;
            //    }
            //    Console.WriteLine($"The Number Of Element That Greater Than Query{i+1} = {count} ");
            //    Console.WriteLine();
            //}

            #endregion

            #region 2
            //Console.Write("Enter Size Of Array : ");
            //int Size = int.Parse(Console.ReadLine());
            //int[] Arr = new int[Size];
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.Write($"Enter Element {i + 1} : ");
            //    Arr[i] = int.Parse(Console.ReadLine());
            //}
            //int First = 0, Last = Arr.Length - 1;
            //bool flag = true;
            //while (First < Last)
            //{

            //    if (Arr[First] == Arr[Last])
            //    {
            //        First++;
            //        Last--;
            //    }
            //    else
            //    {
            //        flag = false;
            //        break;
            //    }
            //}
            //string Result = flag? "Numbers Are Palindrome" : "Numbers Are Not Palindrome";
            //Console.WriteLine(Result);
            #endregion

            #region 3
            //Queue<int > queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);


            //foreach (int item in queue)
            //    Console.WriteLine(item);
            //Console.WriteLine("********** After Reserved **********");
            //Helper.ReversedQueue(ref queue);
            //foreach (int item in queue)
            //    Console.WriteLine(item);
            #endregion

            #region 4
            //string Text = "[()]{}";
            //Console.WriteLine(Helper.IsBalanced(Text));
            #endregion

            #region 5
            //int[] arr = { 1, 2, 3, 2, 4, 1, 5, 3 };
            //int[] NewArr = Helper.RemoveDublicateElement(arr);
            //foreach (int i in NewArr)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 6
            //ArrayList arrayList = new ArrayList() { 1,2,3,4,5,6,78, "hhad"};
            //Console.WriteLine($"Count = {arrayList.Count}\t Capcity = {arrayList.Capacity}");
            //Helper.RemoveOddNumbers(ref arrayList);
            //foreach (var i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine($"Count = {arrayList.Count}\t Capcity = {arrayList.Capacity}");
            #endregion

            #region 7
            //Queue queue = new Queue(3);
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);
            //foreach (var item in queue) 
            //    Console.WriteLine(item);
            #endregion

            #region 8
            //int[] Arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            //Stack<int> Stack = Helper.PushInt(Arr);
            //string Statues = Helper.SearchInStack(Stack, 1);
            //Console.WriteLine(Statues);
            #endregion

            #region 9
            //int[] arr01 = [1, 2, 3, 4, 4];
            //int[] arr02 = [10, 4, 4];
            //int[] shared = Helper.FindSharedBetweenTwoArray(arr01, arr02);
            //foreach (int i in shared)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 10
            //List<int> ints = [1, 2, 3, 7, 5];
            //List<int> list = Helper.SubListTargetSum(ints, 10);
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region 11
            //Queue<int> ints = new Queue<int>();
            //ints.Enqueue(1);
            //ints.Enqueue(2);
            //ints.Enqueue(3);
            //ints.Enqueue(4);
            //ints.Enqueue(5);
            //Helper.ReverseFirstKElements(ints, 4);
            //foreach (int item in ints)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question From Me
            //Queue<int> ints = new Queue<int>();
            //ints.Enqueue(10);
            //ints.Enqueue(2);
            //ints.Enqueue(19);
            //ints.Enqueue(4);
            //ints.Enqueue(5);
            //Queue<int> NewQueue = Helper.ReverseQueueUpToValue(ints, 19);
            //foreach (int i in NewQueue)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion
        }

    }
}

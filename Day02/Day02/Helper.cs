using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper
    {
        public static void ReversedQueue<T>(ref Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();
            foreach (T item in queue)
                stack.Push(item);
            queue.Clear();
            foreach (T item in stack)
                queue.Enqueue(item);
        }
        public static bool IsBalanced(string text)
        {
            Stack<char> stack = new Stack<char>();
            char open;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '[' || text[i] == '{' || text[i] == '(')
                    stack.Push(text[i]);
                else if (text[i] == ']' || text[i] == '}' || text[i] == ')')
                {
                    if (stack.Count == 0)
                        return false;

                    open = stack.Pop();


                    if ((text[i] == ']' && open != '[') || (text[i] == '}' && open != '{') || (text[i] == ')' && open != '('))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
        public static T[] RemoveDublicateElement<T>(T[] Arr)
        {
            T[] temp = new T[Arr.Length];
            int newSize = 0;
            if (Arr is not null)
                for (int i = 0; i < Arr.Length; i++)
                {
                    bool isDuplicate = false;


                    for (int j = 0; j < newSize; j++)
                    {
                        if (Arr[i].Equals(temp[j]))
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (!isDuplicate)
                    {
                        temp[newSize] = Arr[i];
                        newSize++;
                    }
                }


            T[] result = new T[newSize];
            for (int i = 0; i < newSize; i++)
            {
                result[i] = temp[i];
            }

            return result;
        }
        public static void RemoveOddNumbers(ref ArrayList Arr)
        {
            for (int i = Arr.Count - 1; i > 0; i--)
            {
                if ((Arr[i]) is int num)
                {
                    if (num % 2 != 0)
                    {
                        Arr.RemoveAt(i);
                    }
                }
            }
            Arr.TrimToSize();
        }
        public static Stack<int> PushInt(int[] Array)
        {
            Stack<int> NewStack = new Stack<int>();
            foreach (int item in Array)
            {
                NewStack.Push(item);
            }
            return NewStack;
        }
        public static string SearchInStack(Stack<int> stack, int num)
        {
            int count = 0;
            foreach (int item in stack)
            {
                count++;
                if (item == num)
                    return $"Target was found successfully and the count = {count}";
            }
            return "Target was not found";
        }
        public static int[] FindSharedBetweenTwoArray(int[] arr01, int[] arr02)
        {
            int[] temp = new int[arr01.Length];
            int newsize = 0;
            for (int i = 0; i < arr01.Length; i++)
            {
                for (int j = 0; j < arr02.Length; j++)
                {
                    if (arr01[i] == arr02[j])
                    {
                        temp[newsize] = arr01[i];
                        newsize++;

                        arr02[j] = int.MinValue;
                        break;
                    }

                }
            }
            int[] Shared = new int[newsize];
            for (int i = 0; i < newsize; i++)
            {
                Shared[i] = temp[i];
            }
            return Shared;
        }
        public static int[] FindShared(int[] arr01, int[] arr02)
        {
            List<int> temp = new List<int>(arr02);
            List<int> res = new List<int>();

            foreach (int item in arr01)
            {
                if (temp.Contains(item))
                {
                    temp.Remove(item);
                    res.Add(item);
                }
            }

            return res.ToArray();
        }
        public static List<int> SubListTargetSum(List<int> arr, int sum)
        {
            List<int> newlist = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                int result = 0;
                for (int j = i; j < arr.Count; j++)
                {
                    result += arr[j];
                    newlist.Add(arr[j]);
                    if (result == sum)
                        return newlist;

                }
                newlist.Clear();
            }
            return newlist;
        }
        public static void ReverseFirstKElements(Queue<int> queue, int k)
        {
            Stack<int> stack = new Stack<int>();    
            for(int i = 0; i<k ;i++)
            {
                stack.Push(queue.Dequeue());
            }
            foreach (int item in stack)
            {
                queue.Enqueue(item);
            }
            int remaning = queue.Count - k;
            for(int i = 0;i<remaning;i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }


        public static Queue<int> ReverseQueueUpToValue(Queue<int> queue, int val)
        {
            Queue<int> NewQueue = new Queue<int>();
            if (queue.Contains(val))
            {
                Stack<int> stack = new Stack<int>();
                int temp = 0;
                int i = 0;
                while (i < queue.Count)
                {
                    temp = queue.Dequeue();
                    stack.Push(temp);
                    if (temp == val)
                    {
                        break;
                    }
                }
                foreach (int item in stack)
                {
                    NewQueue.Enqueue(item);
                }
                foreach (int item in queue)
                {
                    NewQueue.Enqueue(item);
                }
            }
            return NewQueue;
        }
    }
}

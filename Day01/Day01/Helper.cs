using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal static class Helper
    {
        public static void Reverse<T>(ref T[] Arr)
        {
            int first = 0, last = Arr.Length - 1;
            while (first < last)
            {
                SWAP(ref Arr[first], ref Arr[last]);
                first++;
                last--;
            }
            //OR
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    SWAP(ref Arr[first], ref Arr[last]);
            //    first++;
            //    last--;
            //    if (first == last ||first > last) break;
            //}
        }
        public static void Reverse(ArrayList Arr)
        {
            int first = 0, last = Arr.Count - 1;
            while (first < last)
            {
                object Temp = Arr[first]!;
                Arr[first] = Arr[last];
                Arr[last] = Temp;
                first++;
                last--;
            }
        }
        public static void Reverse<T>(List<T> Arr)
        {
            int first = 0, last = Arr.Count - 1;
            while (first < last)
            {
                T Temp = Arr[first];
                Arr[first] = Arr[last];
                Arr[last] = Temp;
                first++;
                last--;
            }
        }

        public static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        public static int[] ArrayOfEvenNumbers(int[] Arr)
        {
            int count = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] % 2 == 0)
                    count++;
            }

            int[] evens = new int[count];
            int index = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] % 2 == 0)
                {
                    evens[index] = Arr[i];
                    index++;
                }
            }

            return evens;
        }
        public static List<int> ListOfEvenNumbers(List<int> Arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < Arr.Count; i++)
            {
                if (Arr[i] % 2 == 0)
                {
                    list.Add(Arr[i]);
                }
            }
            return list;
        }

        public static int IndexOfFirstNonRepeatedCharacter(string Text)
        {
            for (int i = 0; i < Text.Length; i++)
            {
                int count = 0;
                for (int j = 0 ; j < Text.Length; j++)
                {
                    if (i != j && Text[i] == Text[j])
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                    return i;
            }
            return -1;
        }
    }
}

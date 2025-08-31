using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper
    {
        #region Genric Methods
        public static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        public static int LinearSearch<T>(T[] Arr, T Value)
        {
            if (Arr?.Length > 0 && Value is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Value.Equals(Arr[i]))
                        return i;
                }
            }
            return -1;
        }
        public static int LinearSearch<T>(T[] Arr, T Value, IEqualityComparer<T> equality)
        {
            if (Arr?.Length > 0 && Value is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (equality.Equals(Arr[i], Value)) return i;
                }
            }
            return -1;
        }
        public static int LinearSearch<T>(T[] Arr, T Value, Func<T, T, bool> equals)
        {
            if (Arr?.Length > 0 && Value is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (equals(Value, Arr[i]))
                        return i;
                }
            }
            return -1;
        }

        public static void BubbleSort<T>(T[] Arr) where T : IComparable<T>
        {
            if (Arr is null || Arr.Length == 0)
                return;

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr.Length - 1 - i; j++)
                {
                    if (Arr[j].CompareTo(Arr[j + 1]) == 1)
                        //if (Arr[j].CompareTo(Arr[j + 1]) == -1 ) //Desc
                        SWAP(ref Arr[j], ref Arr[j + 1]);
                }

            }
        }
        public static void BubbleSort<T>(T[] Arr, IComparer<T> comparer) 
        {
            if (Arr is null || Arr.Length == 0)
                return;

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr.Length - 1 - i; j++)
                {
                    if (comparer.Compare(Arr[j], Arr[j + 1]) == 1)
                        //if (Arr[j].CompareTo(Arr[j + 1]) == -1 ) //Desc
                        SWAP(ref Arr[j], ref Arr[j + 1]);
                }

            }
        }

        public static void BubbleSort<T>(T[] Arr, Func<T,T,bool> comparer)
        {
            if (Arr is null || Arr.Length == 0)
                return;

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr.Length - 1 - i; j++)
                {
                    if (comparer(Arr[j], Arr[j + 1]))
                        //if (Arr[j].CompareTo(Arr[j + 1]) == -1 ) //Desc
                        SWAP(ref Arr[j], ref Arr[j + 1]);
                }

            }
        }
        #endregion

        #region Not OverLoading it's 3bth ):
        //public static void SWAP(ref int X, ref int Y)
        //{
        //    Console.WriteLine("======SWAP======");
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //public static void SWAP(ref double X, ref double Y)
        //{
        //    Console.WriteLine("======SWAP======");
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //public static void SWAP(ref Point X, ref Point Y)
        //{
        //    Console.WriteLine("======SWAP======");
        //    Point Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        #endregion


    }
}

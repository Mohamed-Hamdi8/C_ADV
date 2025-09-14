using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate TResult CustomFunc<in T1,in T2, out TResult>(T1 arg01 , T2 arg02);
    internal class SortingAlgorithm
    {
        public static void BubbleSort<T>(T[] arr,CustomFunc<T,T,bool> func)
        {
            if (arr is not null && func is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length -1 - i ; j++)
                    {
                        if (func.Invoke(arr[j], arr[j + 1]))
                            Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        private static void Swap<T>(ref T x,ref T y )
        {
            T temp = x;
            x = y;
            y = temp;
        }
        
    }
    class ComparsionType
    {
        public static bool CompareGrt(int x, int y) => x>y; //ASC
        public static bool CompareGrt(string x, string y) => x.CompareTo(y) ==1 ; //ASC
        public static bool CompareLes(int x, int y) => x<y; //Desc
        public static bool CompareLes(string x, string y) => x.CompareTo(y) == -1 ; //Desc
    }
}

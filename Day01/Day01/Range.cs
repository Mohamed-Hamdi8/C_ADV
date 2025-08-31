using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class Range<T> where T : struct,IComparable<T>
    {
        public T Minimum { get; set; }
        public T Maximum { get; set; }
        public Range(T MinVal , T MaxVal) 
        {
            Minimum = MinVal;
            Maximum = MaxVal;
        }

        public  bool IsInRange(T Value) 
        {
            return Value.CompareTo(Minimum) >= 0 && Value.CompareTo(Maximum) <= 0;
        }
        public dynamic Length() => (dynamic)Maximum - (dynamic)Minimum;
        public override string ToString()
        {
            return $"Range: [{Minimum}, {Maximum}]";
        }
    }
}

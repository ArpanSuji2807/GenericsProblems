using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class FindMax
    {
        public string FindMaxStringElement(string first,string second,string third)
        {
            int first_Length = first.Length;
            int second_Length = second.Length;
            int third_Length = third.Length;
            if (first_Length.CompareTo(second_Length) > 0 && first_Length.CompareTo(third_Length) > 0)
            {
                Console.WriteLine("First Element is Greater: " +first);
                return first;
            }
            if (second_Length.CompareTo(first_Length) > 0 && second_Length.CompareTo(third_Length) > 0)
            {
                Console.WriteLine("Second Element is Greater: "+second);
                return second;
            }
            else
            {
                Console.Write("Third Element is Greater: "+third);
                return third;
            }
        }
    }
}

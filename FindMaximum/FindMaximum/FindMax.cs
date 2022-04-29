using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class FindMax<T> where T : IComparable
    {
        public T first, second, third;
        public FindMax(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public  T FindMaxElement()
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First Element is Greater: \n" + first);
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second Element is Greater: " + second);
                return second;
            }
            else
            {
                Console.Write("Third Element is Greater: " + third);
                return third;
            }
        }
    }
}

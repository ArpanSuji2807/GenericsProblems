using System;
using FindMaximum;
class program
{
    public static void Main(string[] args)
    {
        FindMax<int> max = new FindMax<int>(1,2,3);
        max.FindMaxElement();
        FindMax<float> max1 = new FindMax<float>(20.5f,33.2f,16.8f);
        max1.FindMaxElement();
        FindMax<string> max2 = new FindMax<string>("Apple","Banana","Peach");
        max2.FindMaxElement();
    }
}
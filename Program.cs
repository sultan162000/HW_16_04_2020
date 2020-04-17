using System;
using Arrays;

namespace HW_16_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ar = {"1,2,3,4,5,6,7","S","REX","PP"};
            System.Console.WriteLine(ArrayHelper.Push(ref ar,"EXW"));
            foreach (var item in ar)
            {
                System.Console.WriteLine(item);
            }
        }
    }
    
}

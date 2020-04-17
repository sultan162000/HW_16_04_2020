using System;
using Arrays;

namespace HW_16_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ar = {"A","B","C","D","E"};
            ArrayHelper.Pop(ref ar);
            foreach (var item in ar)
            {
                System.Console.Write(item+"  ");
            }
            System.Console.WriteLine();


            int[] arr = {1,2,3,4,5,6,7};
            System.Console.WriteLine(ArrayHelper.Push(ref arr, 8));
            foreach (var item in arr)
            {
                System.Console.Write(item+"  ");
            }
            System.Console.WriteLine();



            double[] d = {4.4, 3.65, 77.1, 29.98, 84.13, 55.5};
            System.Console.WriteLine(ArrayHelper.Shift(ref d));
            foreach (var item in d)
            {
                System.Console.Write(item+"  ");
            }
            System.Console.WriteLine();


            string[] test = {"B","C","D","E","F"};
            ArrayHelper.UnShift(ref test,"A");
            foreach (var item in test)
            {
                System.Console.Write(item+"  ");
            }
            System.Console.WriteLine();


            int[] tes1 = {1,2,3,4,5,6,7,8,9};
            int[] newTest = ArrayHelper.Slice(tes1,beginIndex:2, endIndex: -2);

            foreach (var item in newTest)
            {
                System.Console.Write(item+"  ");
            }




        }
    }
    
}

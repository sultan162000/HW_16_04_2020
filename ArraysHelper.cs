using System;

namespace Arrays
{
    public static class ArrayHelper
    {
        public static T Pop<T>(ref T[] ar){
            T ob = ar[ar.Length-1];
            T[] newArr = new T[ar.Length-1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i]=ar[i];
            }
            ar = newArr;
            return ob;

        }
    }
}
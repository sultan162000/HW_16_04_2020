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
        public static int Push<T>(ref T[] arr, T ob){
            int sizeArr = arr.Length+1;
            T[] newArr = new T[sizeArr];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i]=arr[i];
            }
            newArr[sizeArr-1] = ob;
            arr = newArr;

            return sizeArr;
        }

        public static T Shift<T>(ref T[] arr){
            T ob = arr[0];
            T[] newArr = new T[arr.Length-1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i]=arr[i+1];
            }

            arr = newArr;

            return ob;
        }
    }
}
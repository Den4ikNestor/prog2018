using System;

namespace Program
{
    public class Algorithm
    {
        static Random rnd = new Random(DateTime.Now.Millisecond);

        public int[] GenerateArray(int length)
        {
            var array = new int[length];
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(0, 666);
            return array;
        }

        int[] QuickSort(int[] array, int start, int end)
        {
            if (end == start) return array;
            var pivot = array[end];
            var storeIndex = start;
            for (int i = start; i <= end - 1; i++)
                if (array[i] <= pivot)
                {
                    var t = array[i];
                    array[i] = array[storeIndex];
                    array[storeIndex] = t;
                    storeIndex++;
                }

            var n = array[storeIndex];
            array[storeIndex] = array[end];
            array[end] = n;
            if (storeIndex > start) QuickSort(array, start, storeIndex - 1);
            if (storeIndex < end) QuickSort(array, storeIndex + 1, end);
            return array;
        }

        public int[] QuickSort(int[] array)
        {
            if (array.Length <= 0) return null;
            return QuickSort(array, 0, array.Length - 1);
        }

        public static void Main(string[] args)
        {
            //////////////////////////////////
        }
    }
}

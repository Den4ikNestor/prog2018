using System;

namespace Program
{
    public class Search
    {
        public static void Main(string[] args)
        {
            TesFiveNumbers();
            TestEmptyArray();
            TestHugeArray();
            TestNegativeNumbers();
            TestNonExistentElement();
            TestRepeatingNumbers();
            Console.ReadKey();
        }

        public static int BinarySearch(int[] array, int element)
        {
            if (array == null) return -1;
            var leftBoard = 0;
            var rightBoard = array.Length - 1;
            while (rightBoard > leftBoard)
            {
                var middle = (rightBoard + leftBoard) / 2;
                if (element <= array[middle])
                    rightBoard = middle;
                else leftBoard = middle + 1;
            }
            if (array[rightBoard] == element)
                return rightBoard;
            return -1;
        }

        private static void TesFiveNumbers()
        {
            //Тестирование поиска одного из пяти чисел
            int[] array = new[] { -5, -4, 0, 4, 5 };
            if (BinarySearch(array, -4) != 1)
                Console.WriteLine("! Поиск не нашёл число 4 среди чисел {-5, -4, 0, 4, 5}");
            else
                Console.WriteLine("Поиск среди пяти чисел работает корректно");
        }

        private static void TestNegativeNumbers()
        {
            //Тестирование поиска в отрицательных числах
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -3) != 2)
                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");
        }

        private static void TestNonExistentElement()
        {
            //Тестирование поиска отсутствующего элемента
            int[] array = new[] { -5, -4, -3, -2 };
            if (BinarySearch(array, -1) >= 0)
                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск отсутствующего элемента работает корректно");
        }

        private static void TestRepeatingNumbers()
        {
            //Тестирование поиска элемента, повторяющегося несколько раз
            int[] array = new[] { -5, -5, 0, 0, 5, 5, 5};
            if (BinarySearch(array, 5) != 4)
                Console.WriteLine("! Поиск не нашёл число 5 среди чисел { -5, -5, 0, 0, 5, 5, 5}, либо индекс элемента неверен");
            else
                Console.WriteLine("Поиск среди элементов, повторяющихся несколько раз, работает корректно");
        }

        private static void TestEmptyArray()
        {
            //Тестирование поиска в пустом массиве
            int[] array = null;
            if (BinarySearch(array, 10) != -1)
                Console.WriteLine("! Поиск нашёл число -1 среди пустого массива");
            else
                Console.WriteLine("Поиск среди пустого массива работает корректно"); //100001
        }

        private static void TestHugeArray()
        {
            //Тестирование поиска элемента в массиве из 100001 элементов
            int[] array = new int[100001];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 100;
            }
            array[0] = 2;
            if (BinarySearch(array, 2) != 0)
                Console.WriteLine("! Поиск не нашёл число 2 среди 100001-элементного массива, либо индекс элемента неверен");
            else
                Console.WriteLine("Поиск среди массива из 100001 элементов работает корректно");
        }
    }
}
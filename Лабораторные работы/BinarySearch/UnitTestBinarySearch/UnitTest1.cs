using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;

namespace UnitTestBinarySearch
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesFiveNumbers()
        {
            //Тестирование поиска одного из пяти чисел
            Binary binary = new Binary();
            int[] array = new[] { -5, -4, 0, 4, 5 };
            if (binary.BinarySearch(array, -4) != 1)
                Console.WriteLine("! Поиск не нашёл число 4 среди чисел {-5, -4, 0, 4, 5}");
            else
                Console.WriteLine("Поиск среди пяти чисел работает корректно");
        }

        [TestMethod]
        public void TestNegativeNumbers()
        {
            //Тестирование поиска в отрицательных числах
            Binary binary = new Binary();
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (binary.BinarySearch(negativeNumbers, -3) != 2)
                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");
        }

        [TestMethod]
        public void TestNonExistentElement()
        {
            //Тестирование поиска отсутствующего элемента
            Binary binary = new Binary();
            int[] array = new[] { -5, -4, -3, -2 };
            if (binary.BinarySearch(array, -1) >= 0)
                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск отсутствующего элемента работает корректно");
        }

        [TestMethod]
        public void TestRepeatingNumbers()
        {
            //Тестирование поиска элемента, повторяющегося несколько раз
            Binary binary = new Binary();
            int[] array = new[] { -5, -5, 0, 0, 5, 5, 5 };
            if (binary.BinarySearch(array, 5) != 4)
                Console.WriteLine("! Поиск не нашёл число 5 среди чисел { -5, -5, 0, 0, 5, 5, 5}, либо индекс элемента неверен");
            else
                Console.WriteLine("Поиск среди элементов, повторяющихся несколько раз, работает корректно");
        }

        [TestMethod]
        public void TestEmptyArray()
        {
            //Тестирование поиска в пустом массиве
            Binary binary = new Binary();
            int[] array = null;
            if (binary.BinarySearch(array, 10) != -1)
                Console.WriteLine("! Поиск нашёл число -1 среди пустого массива");
            else
                Console.WriteLine("Поиск среди пустого массива работает корректно"); //100001
        }

        [TestMethod]
        public void TestHugeArray()
        {
            //Тестирование поиска элемента в массиве из 100001 элементов
            Binary binary = new Binary();
            int[] array = new int[100001];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 100;
            }
            array[0] = 2;
            if (binary.BinarySearch(array, 2) != 0)
                Console.WriteLine("! Поиск не нашёл число 2 среди 100001-элементного массива, либо индекс элемента неверен");
            else
                Console.WriteLine("Поиск среди массива из 100001 элементов работает корректно");
        }
    }
}

using System;
using Program;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestQuickSort
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThreeElements()
        {
            Algorithm algo = new Algorithm();
            var array = algo.GenerateArray(3);
            algo.QuickSort(array);
            if (array[0] < array[1] && array[1] < array[2]) return;
            else throw new Exception();
        }

        [TestMethod]
        public void TestTheSameElements()
        {
            Algorithm algo = new Algorithm();
            var array = algo.GenerateArray(100);
            algo.QuickSort(array);
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1]) continue;
                else throw new Exception();
            }
        }

        [TestMethod]
        public void TestTenPairs()
        {
            Algorithm algo = new Algorithm();
            var array = algo.GenerateArray(1000);
            algo.QuickSort(array);

            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 10; i++)
            {
                var index = rnd.Next(0, 999);
                if (array[index] <= array[index + 1]) continue;
                else throw new Exception();
            }
        }

        [TestMethod]
        public void TestEmptyArray()
        {
            Algorithm algo = new Algorithm();
            var array = algo.GenerateArray(0);
            array = algo.QuickSort(array);
            if (array != null) throw new Exception();
        }

        [TestMethod]
        public void TestHugeArray()
        {
            Algorithm algo = new Algorithm();
            var array = algo.GenerateArray(1500000); //150к 411ms // 1.5m 45 s    15m program interrupts my tests - weak laptop :((
            algo.QuickSort(array);
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1]) continue;
                else throw new Exception();
            }
        }
    }
}

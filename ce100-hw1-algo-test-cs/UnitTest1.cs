using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw1_algo_lib_cs;

namespace ce100_hw1_algo_test_cs
{
    [TestClass]
    public class InsertionSort
    {
        [TestMethod]
        public void GoodCase()
        {
            Class1 Class1= new Class1();
            int[] arrinsert = { 14, 13, 16, 4, 7 };
            int result = Class1.InsertionSort(arrinsert);
            int[] arrinsert1 = { 14, 13, 16, 4, 7 };
            int expected = Class1.InsertionSort(arrinsert1);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void BadCase()
        {
            Class1 Class1 = new Class1();
            int[] arrinsert = { 14, 13, 16, 4, 7 };
            int result = Class1.InsertionSort(arrinsert);
            int[] arrinsert1 = { 3, 18, 22, 13, 5 };
            int expected = Class1.InsertionSort(arrinsert1);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            Class1 Class1 = new Class1();
            int[] arrinsert = { 14, 13, 16, 4, 7 };
            int result = Class1.InsertionSort(arrinsert);
            int[] arrinsert1 = { 4, 7, 24, 10, 16 };
            int expected = Class1.InsertionSort(arrinsert1);
            Assert.AreNotSame(expected, result);
        }
    }
    [TestClass]
    public class SelectionSort  
    {
        [TestMethod]
        public void GoodCase()
        {
            Class1 Class1 = new Class1();
            int[] n1 = { 61, 35, 16, 18, 15 };
            int result = Class1.SelectionSort(n1);
            int[] n2 = { 61, 35, 16, 22, 11 };
            int expected = Class1.SelectionSort(n2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void BadCase()
        {
            Class1 Class1 = new Class1();
            int[] n1 = { 61, 35, 16, 18, 15 };
            int result = Class1.SelectionSort(n1);
            int[] n2 = { 62, 27, 17, 21, 15 };
            int expected = Class1.SelectionSort(n2);
            Assert.AreNotSame(expected, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            Class1 Class1 = new Class1();
            int[] n1 = { 61, 35, 16, 18, 15 };
            int result = Class1.SelectionSort(n1);
            int[] n2 = { 61, 35, 16, 18, 15 };
            int expected = Class1.SelectionSort(n2);
            Assert.AreNotSame(expected, result);
        }
    }
    [TestClass]
    public class RecersiveMergeSort 
    {
        [TestMethod]
        public void GoodCase()
        {
            int[] n1 = new int[] { -3, 34, -673391, 7812, -456, 12, 61483 };
            int result = Class1.MergeSort(n1, 0, n1.Length - 1);
            int[] n2 = new int[] { -3, 34, -673391, 7812, -456, 12, 61483 };
            int expected = Class1.MergeSort(n1, 0, n1.Length - 1);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void BadCase()
        {
            int[] n1 = new int[] { -3, 34, -673391, 7812, -456, 12, 61483 };
            int result = Class1.MergeSort(n1, 0, n1.Length - 1);
            int[] n2 = new int[] { -3, 34, -673391, 7812, -456, 12, 61483 };
            int expected = Class1.MergeSort(n1, 0, n1.Length - 1);
            Assert.AreNotSame(expected, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            int[] n1 = new int[] { -3, 34, -673391, 7812, -456, 12, 61483 };
            int result = Class1.MergeSort(n1, 0, n1.Length - 1);
            int[] n2 = new int[] { -4, -34, -365961, 4685, -814, 28506, 348965 };
            int expected = Class1.MergeSort(n1, 0, n1.Length - 1);
            Assert.AreNotSame(expected, result);
        }
    }
    [TestClass]
    public class NaivepowerTest
    {
        [TestMethod]
        public void GoodCase()
        {
            int x = -2;
            int n = 10;
            long result = Class1.NaivePower(x, n);
            Assert.AreEqual(1024, result);
        }
        [TestMethod]
        public void BadCase()
        {
            int x = 3;
            int n = 3;
            long result = Class1.NaivePower(x, n);
            Assert.AreNotEqual(81, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            int x = 4;
            int n = 5;
            long result = Class1.NaivePower(x, n);
            Assert.AreNotSame(96, result);
        }
    }
    [TestClass]
    public class RecursivePowerTest
    {
        [TestMethod]
        public void GoodCase()
        {
            Class1 Class1 = new Class1();
            int n = 5;
            int p = 2;
            long res;
            res = Class1.RecursivePower(n, p);
            Assert.AreEqual(25, res);
        }
        [TestMethod]
        public void BadCase()
        {
            Class1 Class1 = new Class1();
            int n = 6;
            int p = 1;
            long res;
            res = Class1.RecursivePower(n, p);
            Assert.AreNotEqual(36, res);
        }
        [TestMethod]
        public void UglyCase()
        {
            Class1 Class1 = new Class1();
            int n = 5;
            int p = 2;
            long res;
            res = Class1.RecursivePower(n, p);
            Assert.AreNotSame(50, res);
        }
    } 
    [TestClass]
    public class IterativBinaryTest
    {
        [TestMethod]
        public void GoodCase()
        {
            Class1 Class1 = new Class1();
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;
            int result2 = Class1.IterativeBinarySearch(arr, x);
            Assert.AreEqual(3, result2);
        }
        [TestMethod]
        public void BadCase()
        {
            Class1 Class1 = new Class1();
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;
            int result2 = Class1.IterativeBinarySearch(arr, x);
            Assert.AreNotEqual(5, result2);
        }
        [TestMethod]
        public void UglyCase()
        {
            Class1 Class1 = new Class1();
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;
            int result2 = Class1.IterativeBinarySearch(arr, x);
            Assert.AreNotSame(4, result2);
        }
    }  
    [TestClass]
    public class RecursiveBinaryTest
    {
        [TestMethod]
        public void GoodCase()
        {
            Class1 Class1 = new Class1();
            int[] arr1 = { 2, 3, 4, 10, 40 };
            int n1 = arr1.Length;
            int x1 = 40;
            int result1 = Class1.RecursiveBinarySearch(arr1, 0, n1 - 1, x1);
            Assert.AreEqual(4, result1);
        }
        [TestMethod]
        public void BadCase()
        {
            Class1 Class1 = new Class1();
            int[] arr1 = { 2, 3, 4, 10, 40 };
            int n1 = arr1.Length;
            int x1 = 40;
            int result1 = Class1.RecursiveBinarySearch(arr1, 0, n1 - 1, x1);
            Assert.AreNotEqual(2, result1);
        }
        [TestMethod]
        public void UglyCase()
        {
            Class1 Class1 = new Class1();
            int[] arr1 = { 2, 3, 4, 10, 40 };
            int n1 = arr1.Length;
            int x1 = 40;
            int result1 = Class1.RecursiveBinarySearch(arr1, 0, n1 - 1, x1);
            Assert.AreNotSame(6, result1);
        }
    }  
}






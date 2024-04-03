using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSorting.Sorting;

namespace TestSorting
{
    [TestClass]
    //Tests for selection sort
    public class SelectionSortTests
    {
        readonly SelectionSort sort = new();

        [TestMethod]
        public void UnitTest1()
        {
            int[] data = [5, 82, 8, 12, 1, 3];
            int[] sortedData = [1, 3, 5, 8, 12, 82];

            data = sort.SortMethod(data);
            
            Assert.IsTrue(CheckSort(data,sortedData));
        }

        [TestMethod]
        public void UnitTest2()
        {
            int[] data = [5];
            int[] sortedData = [5];

            data = sort.SortMethod(data);

            Assert.IsTrue(CheckSort(data, sortedData));
        }

        [TestMethod]
        public void UnitTest3()
        {
            int[] data = [11, 12, 15];
            int[] sortedData = [11, 12, 15];

            data = sort.SortMethod(data);

            Assert.IsTrue(CheckSort(data, sortedData));
        }

        [TestMethod]
        public void UnitTest4()
        {
            int[] data = [1, 2, 3, 5, 7, 4, 8, 9, 10, 6];
            int[] sortedData = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            data = sort.SortMethod(data);

            Assert.IsTrue(CheckSort(data, sortedData));
        }

        [TestMethod]
        public void UnitTest5()
        {
            int[] data = [-1, 5, -20, 2];
            int[] sortedData = [-20, -1, 2, 5];

            data = sort.SortMethod(data);

            Assert.IsTrue(CheckSort(data, sortedData));
        }

        public bool CheckSort(int[] dataToCheck, int[] happyData)
        {
            return dataToCheck.SequenceEqual(happyData);
        }
    }

    [TestClass]
    //Tests for insertion sort
    public class InsertionSortTests
    {
        readonly InsertionSort sort = new();

        [TestMethod]
        public void UnitTest1()
        {
            int[] data = [5, 82, 8, 12, 1, 3];
            int[] sortedData = [1, 3, 5, 8, 12, 82];

            data = sort.SortMethod(data);

            Assert.IsTrue(CheckSort(data, sortedData));
        }

        [TestMethod]
        public void UnitTest2()
        {
            int[] data = [5];
            int[] sortedData = [5];

            data = sort.SortMethod(data);

            Assert.IsTrue(CheckSort(data, sortedData));
        }

        [TestMethod]
        public void UnitTest3()
        {
            int[] data = [11, 12, 15];
            int[] sortedData = [11, 12, 15];

            data = sort.SortMethod(data);

            Assert.IsTrue(CheckSort(data, sortedData));
        }

        [TestMethod]
        public void UnitTest4()
        {
            int[] data = [1, 2, 3, 5, 7, 4, 8, 9, 10, 6];
            int[] sortedData = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            data = sort.SortMethod(data);

            Assert.IsTrue(CheckSort(data, sortedData));
        }

        [TestMethod]
        public void UnitTest5()
        {
            int[] data = [-1, 5, -20, 2];
            int[] sortedData = [-20, -1, 2, 5];

            data = sort.SortMethod(data);

            Assert.IsTrue(CheckSort(data, sortedData));
        }

        public bool CheckSort(int[] dataToCheck, int[] happyData)
        {
            return dataToCheck.SequenceEqual(happyData);
        }
    }
}

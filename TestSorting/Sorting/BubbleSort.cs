using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestSorting.Sorting
{
    [TestClass]
    public class BubbleSort
    {
        /*SUDO:
            
            while 
            
         */

        UnitData sortingTest = new();
        int numbersSwapped = 0, iterations = 0;

        [TestMethod]
        public void SortMethod()
        {
            //TODO: Make sorting algorithm
            do
            {
                numbersSwapped = 0;
                iterations++;

                if (sortingTest == null) Assert.Inconclusive();

                for (int i = 0; i < sortingTest.data.Length - iterations; i++)
                {
                    int num1 = sortingTest.data[i];
                    int num2 = sortingTest.data[i + 1];
                    if (sortingTest.data[i] > sortingTest.data[i + 1])
                    {
                        sortingTest.data[i] = num2;
                        sortingTest.data[i + 1] = num1;
                        numbersSwapped++;
                    }
                }
            }
            while(numbersSwapped > 0);

            Console.WriteLine(sortingTest.data.ToString());
            Assert.AreEqual(sortingTest.CheckSort(), true);

        }
    }
}
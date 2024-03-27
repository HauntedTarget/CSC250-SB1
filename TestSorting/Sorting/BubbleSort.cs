using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using Assert = NUnit.Framework.Assert;

namespace TestSorting.Sorting
{
    [TestClass]
    public class BubbleSort
    {
        UnitData sortingTest = new();
        int numbersSwapped = 0;

        [TestMethod]
        public void SortMethod()
        {
            //TODO: Make sorting algorithm
            do
            {
                numbersSwapped = 0;

                if (sortingTest == null) Assert.Inconclusive();

                for (int i = 0; i < sortingTest.data.Length - 1; i++)
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
        }
    }
}
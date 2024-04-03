using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestSorting.Sorting
{
    public class BubbleSort
    {
        int numbersSwapped = 0, iterations = 0;

        public int[] SortMethod(int[] unsortedArray)
        {
            //TODO: Make sorting algorithm
            do
            {
                numbersSwapped = 0;
                iterations++;

                if (unsortedArray == null) Assert.Inconclusive();

                for (int i = 0; i < unsortedArray.Length - iterations; i++)
                {
                    int num1 = unsortedArray[i];
                    int num2 = unsortedArray[i + 1];
                    if (unsortedArray[i] > unsortedArray[i + 1])
                    {
                        unsortedArray[i] = num2;
                        unsortedArray[i + 1] = num1;
                        numbersSwapped++;
                    }
                }
            }
            while(numbersSwapped > 0);

            Console.WriteLine(unsortedArray.ToString());

            return unsortedArray;
        }
    }
}